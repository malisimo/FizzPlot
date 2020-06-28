namespace FPlot.HighCharts

module internal Server =
    open System
    open System.IO
    open System.Diagnostics
    open System.Threading
    open System.Text
    open System.Net
    open System.Net.Http

    let serverAddress = "http://localhost:5000"
    let mutable serverProc:Process option = None

    let asyncSend wait json = async {
        try
            printfn "-=- Sending %s to server..." json
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

    let send json =
        asyncSend false json |> Async.RunSynchronously |> ignore

    let add target json =
        let msg = sprintf "{\"Operation\":\"add\",\"target\":%i,\"Json\":\"%s\"}" target json
        send msg

    let update target json =
        let msg = sprintf "{\"Operation\":\"update\",\"target\":%i,\"Json\":\"%s\"}" target json
        send msg

    let killServer() =
        match serverProc with
        | Some(proc) ->
            if proc.HasExited |> not then
                printfn "Killing server process"
                proc.Kill()
        | None ->
            ()

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

    let private startServer (initData:string option) =
        let workDir = "FPlot.Server"
        let binDir = "bin/Debug/netcoreapp2.2/"
        let server = Path.Combine(binDir,"FPlot.Server.dll")

        printfn "Running server from %s" (Path.GetFullPath(Path.Combine(workDir,server)))

        let psi = ProcessStartInfo()    
        psi.FileName <- "dotnet"
        psi.Arguments <- server
        psi.UseShellExecute <- false
        psi.RedirectStandardOutput <- false
        psi.RedirectStandardError <- false
        psi.CreateNoWindow <- false
        psi.WorkingDirectory <- workDir

        let proc = new Process()
        proc.StartInfo <- psi

        proc.Start() |> ignore
        printfn "Running server process..."

        proc.EnableRaisingEvents <- true
        proc.Exited.AddHandler(new EventHandler(fun _ _ ->
            printfn "Server process exited!"
            serverProc <- None))
        
        waitForProcessStart 0 proc

        Process.Start("cmd", sprintf "/C start %s" "http://localhost:5000") |> ignore

        proc

    let checkServer initData =
        match serverProc with
        | Some(proc) ->
            if proc.HasExited then
                serverProc <- Some (startServer initData)
        | None ->
            serverProc <- Some (startServer initData)

            
