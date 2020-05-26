namespace FPlot
open Microsoft.Extensions.Caching.Memory

module Middleware =
    open System
    open System.Text
    open System.Threading
    open System.Threading.Tasks
    open System.Net.WebSockets
    open Microsoft.AspNetCore.Http
    
    open Giraffe.Core
    open Giraffe.Tasks

    let mutable sockets = list<WebSocket>.Empty

    let private addSocket sockets socket = socket :: sockets

    let private removeSocket sockets socket =
        sockets
        |> List.choose (fun s -> if s <> socket then Some s else None)

    let private sendMessage =
        fun (socket : WebSocket) (message : string) ->
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

    let private echo (context:HttpContext) (webSocket:WebSocket) = async {
        let buffer = Array.init (1024 * 4) (fun _ -> 0uy)
        let! result = webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None) |> Async.AwaitTask
    
        let rec echoMsg (result:WebSocketReceiveResult) = async {
            Console.WriteLine(sprintf "Received %A from socket %s" result.CloseStatusDescription (webSocket.State.ToString()))
            if result.MessageType = WebSocketMessageType.Close then
                Console.WriteLine(sprintf "Stopping socket receive: %A" (result.CloseStatus.GetValueOrDefault()))
                return result
            elif result.CloseStatus.HasValue then
                return result
            else
                do! webSocket.SendAsync(new ArraySegment<byte>(buffer, 0, result.Count), result.MessageType, result.EndOfMessage, CancellationToken.None) |> Async.AwaitTask
                let! newResult = webSocket.ReceiveAsync(new ArraySegment<byte>(buffer), CancellationToken.None) |> Async.AwaitTask
                return! echoMsg newResult
        }

        let! newResult = echoMsg result
        Console.WriteLine("Closing socket...")
        do! webSocket.CloseAsync(newResult.CloseStatus.Value, newResult.CloseStatusDescription, CancellationToken.None) |> Async.AwaitTask
        Console.WriteLine("...closed socket")
    }
    
    type WebSocketMiddleware(next : RequestDelegate) =
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
                        
                        do! echo ctx webSocket
                    | false ->
                        ctx.Response.StatusCode <- 400
                else
                    next.Invoke(ctx) |> ignore
            } |> Async.StartAsTask :> Task