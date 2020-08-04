namespace FizzPlot.HighCharts
open System.Reflection

module internal Server =
    open System
    open System.IO
    open System.Diagnostics
    open System.Threading
    open System.Text
    open System.Net
    open System.Net.Http
    open FizzPlot.StringUtils

    let serverAddress = "http://localhost:2387"
    let mutable serverProc:Process option = None

    /// Send JSON message asynchronously, and optionally retrieve response
    let asyncSend wait json = async {
        try
            use clientHandler = new HttpClientHandler()
            clientHandler.ServerCertificateCustomValidationCallback <- (fun sender cert chain sslPolicyErrors -> true)

            use client = new HttpClient(clientHandler)
            client.Timeout <- TimeSpan.FromSeconds(3.)

            let content =  new StringContent(json, Encoding.UTF8, "application/json")

            let! resp =
                if wait then
                    client.GetAsync(sprintf "%s/fetch" serverAddress) |> Async.AwaitTask
                else
                    client.PostAsync(sprintf "%s/message" serverAddress, content) |> Async.AwaitTask
        
            printfn "Response code %s sending to server" (string resp.StatusCode)
            
            match resp.StatusCode with
            | HttpStatusCode.OK ->
                printfn "Request to server OK"
                if wait then
                    let! content = resp.Content.ReadAsStringAsync() |> Async.AwaitTask
                    printfn "Got %i chars in response: %s (%s)" content.Length content (resp.ToString())
                    return (resp.StatusCode,content)
                else
                    return (resp.StatusCode,"")
            | _ ->
                printfn "Failed posting to server: %s" (string resp.StatusCode)
                return (resp.StatusCode,"")
        with ex ->
            printfn "Exception posting to server: %s" (string ex)
            return (HttpStatusCode.InternalServerError,"")
    }

    let asyncRender json = async {
        try
            use clientHandler = new HttpClientHandler()
            clientHandler.ServerCertificateCustomValidationCallback <- (fun sender cert chain sslPolicyErrors -> true)

            use client = new HttpClient(clientHandler)
            client.Timeout <- TimeSpan.FromSeconds(3.)

            let jsonTemplate = "{
                \"infile\":##JSON##,
                \"scale\":false,
                \"constr\":\"Chart\",
                \"callback\":\"\",
                \"styledMode\":false,
                \"type\":\"image/png\",
                \"asyncRendering\":false,
                \"async\":false,
                \"resources\":\"\"
            }"

            let contentStr = strRep "##JSON##" json jsonTemplate
            use content = new StringContent(contentStr, Encoding.UTF8, "application/json")

            let! resp = client.PostAsync("http://export.highcharts.com/", content) |> Async.AwaitTask        
            printfn "Response code %s sending to server" (string resp.StatusCode)
            
            match resp.StatusCode with
            | HttpStatusCode.OK ->
                printfn "Request to server OK"
                let! content = resp.Content.ReadAsStreamAsync() |> Async.AwaitTask
                printfn "Got %i bytes in response: (%s)" content.Length (resp.ToString())
                return (resp.StatusCode,Some content)
            | _ ->
                printfn "Failed posting to server: %s" (string resp.StatusCode)
                return (resp.StatusCode,None)
        with ex ->
            printfn "Exception posting to server: %s" (string ex)
            return (HttpStatusCode.InternalServerError,None)
    }

    /// Send JSON message synchronously
    let send json =
        asyncSend false json |> Async.RunSynchronously |> ignore

    /// Add series to existing chart
    let add chartIndex target json =
        let msg = sprintf "{\"operation\":\"add\",\"chartIndex\":%i,\"target\":\"%s\",\"json\":\"%s\"}" chartIndex target json
        send msg

    /// Update a single chart property
    let update chartIndex (target:string) json =
        let targetTrimmed =
            if target.StartsWith("Figure.") then
                target.Substring(7)
            else
                target

        let msg = sprintf "{\"operation\":\"update\",\"chartIndex\":%i,\"target\":\"%s\",\"json\":\"%s\"}" chartIndex targetTrimmed json
        send msg

    /// Render chart to PNG
    let render json =
        let resp,stream = asyncRender json |> Async.RunSynchronously
        if resp = HttpStatusCode.OK then
            stream
        else
            None

    /// Terminate this server instance
    let killServer() =
        match serverProc with
        | Some(proc) ->
            if proc.HasExited |> not then
                printfn "Killing server process"
                proc.Kill()
        | None ->
            ()

    /// Utility to pause until server has started
    let rec waitForProcessStart i (proc:Process) = 
        if i >= 20 then
            () 
        else          
            try
                let time = proc.StartTime
                ()
            with
            | _ ->
                Thread.Sleep(100)
                waitForProcessStart (i+1) proc

    let private getAssemblyDir() =
        Assembly.GetExecutingAssembly()
        |> Option.ofObj
        |> Option.map (fun a -> Uri a.CodeBase)
        |> Option.map (fun uri -> uri.AbsolutePath)
        |> Option.map (Uri.UnescapeDataString >> Path.GetFullPath >> Path.GetDirectoryName)
        |> Option.defaultValue Environment.CurrentDirectory


    /// Start server instance
    let private startServer (initData:string option) =
        let workDir = Environment.CurrentDirectory
        let binDir = getAssemblyDir()
        let server = Path.Combine(binDir,"FizzPlot.Server.dll")

        printfn "Running server from %s" server

        let psi = ProcessStartInfo()
        psi.FileName <- "dotnet"
        psi.Arguments <- server
        psi.UseShellExecute <- false
        psi.RedirectStandardOutput <- false
        psi.RedirectStandardError <- false
        psi.CreateNoWindow <- false
        psi.WorkingDirectory <- binDir

        let proc = new Process()
        proc.StartInfo <- psi

        proc.Start() |> ignore
        printfn "Running server process..."

        proc.EnableRaisingEvents <- true
        proc.Exited.AddHandler(new EventHandler(fun _ _ ->
            printfn "Server process exited!"
            serverProc <- None))

        waitForProcessStart 0 proc

        Process.Start("cmd", sprintf "/C start %s" "http://localhost:2387") |> ignore
        
        proc

    /// Start server if not already started
    let checkServer initData =
        match serverProc with
        | Some(proc) ->
            if proc.HasExited then
                serverProc <- Some (startServer initData)
        | None ->
            serverProc <- Some (startServer initData)

            
