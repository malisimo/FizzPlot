namespace FizzPlot
open System.IO
open Microsoft.Extensions.Hosting

module Middleware =
    open System
    open System.Text
    open System.Threading
    open System.Threading.Tasks
    open System.Collections.Concurrent
    open System.Net.WebSockets
    open Microsoft.AspNetCore.Http
    open Microsoft.Extensions.Caching.Memory    
    open Giraffe.Core
    open Giraffe.Tasks

    let mutable sockets = list<WebSocket>.Empty
    let private receivedMessages = new ConcurrentQueue<string>()

    let private addSocket sockets socket = socket :: sockets

    let private removeSocket sockets socket =
        sockets
        |> List.choose (fun s -> if s <> socket then Some s else None)
    
    type private ReceiveMessageResult = 
        | Message of string
        | Closed of (WebSocketCloseStatus*string)
        | Failure of Exception
    
    let rec private receiveMessage (socket:WebSocket) (buffer:ArraySegment<byte>) (cancelToken:CancellationToken) =
        task {
            try
                use ms = new MemoryStream()
                Console.WriteLine("Awaiting message from socket...")
                let! resp = socket.ReceiveAsync(buffer, cancelToken)
                Console.WriteLine(sprintf "Received %i bytes from socket" resp.Count)

                if resp.Count > 0 then
                    do! ms.WriteAsync(buffer.Array, buffer.Offset, resp.Count)

                if not resp.EndOfMessage then
                    return! receiveMessage socket buffer cancelToken
                else
                    if resp.MessageType = WebSocketMessageType.Close then
                        Console.WriteLine(sprintf "Stopping socket receive: %A" (resp.CloseStatus.GetValueOrDefault()))
                        if resp.CloseStatus.HasValue then
                            return Closed (resp.CloseStatus.Value, resp.CloseStatusDescription)
                        else
                            return Closed (WebSocketCloseStatus.Empty, resp.CloseStatusDescription)
                    else
                        Console.WriteLine(sprintf "Finished receiving socket message (%i bytes in total)" ms.Length)
                        ms.Seek(0L, SeekOrigin.Begin) |> ignore
                        use sr = new StreamReader(ms, Encoding.UTF8)
                        let! str = sr.ReadToEndAsync()
                        return Message str
            with ex ->
                return Failure ex
        }

    let private receiveMessageLoop socket (context:HttpContext) (cancelToken:CancellationToken) =
        async {
            let buffer =
                Array.create (1024 * 64) 0uy
                |> fun arr -> new ArraySegment<byte>(arr)

            Console.WriteLine("Starting socket receive loop")

            let rec receiveLoop socket buffer =
                async {
                    let! resp = receiveMessage socket buffer cancelToken |> Async.AwaitTask

                    match resp with
                    | Message(msg) ->
                        Console.WriteLine(sprintf "Received message from socket (%i chars)" msg.Length)
                        receivedMessages.Enqueue(msg)
                        Console.WriteLine(sprintf "Stored message in queue (%i count)" receivedMessages.Count)
                        return! receiveLoop socket buffer
                    | Closed(closeStatus) ->
                        Console.WriteLine(sprintf "Socket close event - stopping socket receive: (%A,%s)" (fst closeStatus) (snd closeStatus))
                        return closeStatus
                    | Failure(ex) ->
                        Console.WriteLine(sprintf "Failed socket receive: %s" ex.Message)
                        return (WebSocketCloseStatus.InternalServerError, ex.Message)
                }

            let! closeStatus,closeStatusDesc = receiveLoop socket buffer            
            if socket.State = WebSocketState.Open then
                Console.WriteLine("Closing socket...")
                do! socket.CloseAsync(closeStatus, closeStatusDesc, cancelToken) |> Async.AwaitTask
                Console.WriteLine("...closed socket")
        }


    let private sendMessage =
        fun (socket:WebSocket) (message:string) ->
            task {
                let buffer = Encoding.UTF8.GetBytes(message)
                let segment = new ArraySegment<byte>(buffer)

                if socket.State = WebSocketState.Open then
                    do! socket.SendAsync(segment, WebSocketMessageType.Text, true, CancellationToken.None)
                else
                    sockets <- removeSocket sockets socket
            }
    
    let sendMessageToSockets =
        fun message ->
            task {
                printfn "Sending msg to %i sockets" sockets.Length
                for socket in sockets do
                    try
                        do! sendMessage socket message
                    with
                        | _ -> sockets <- removeSocket sockets socket
            }
    
    let tryGetReceivedMessage() =        
        Console.WriteLine(sprintf "Trying to find message from socket in queue (%i count)" receivedMessages.Count)
        match receivedMessages.TryDequeue() with
        | (true,msg) -> Some(msg)
        | (false,_) -> None
    
    type WebSocketMiddleware (next : RequestDelegate, lifetime : IApplicationLifetime) =
        member __.Invoke(ctx : HttpContext) =
            async {
                if ctx.Request.Path = PathString("/ws") then
                    match ctx.WebSockets.IsWebSocketRequest with
                    | true ->
                        let! webSocket = ctx.WebSockets.AcceptWebSocketAsync() |> Async.AwaitTask
                        sockets <- addSocket sockets webSocket
                        Console.WriteLine(sprintf "Accepted new socket with status %A (%i total)" webSocket.CloseStatusDescription sockets.Length)
                        
                        let cache = ctx.GetService<IMemoryCache>()

                        match cache.Get "initChartData" |> Option.ofObj |> Option.map string with
                        | Some(d) ->
                            Console.WriteLine("Sending cached initial chart data to socket")
                            do! sendMessage webSocket d |> Async.AwaitTask
                        | None ->
                            Console.WriteLine("No cached initial chart data availble")
                            ()
                        
                        do! receiveMessageLoop webSocket ctx lifetime.ApplicationStopping
                    | false ->
                        ctx.Response.StatusCode <- 400
                else
                    next.Invoke(ctx) |> ignore
            } |> Async.StartAsTask :> Task