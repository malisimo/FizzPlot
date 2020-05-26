namespace FPlot

module internal Server =
    open System
    open System.IO
    open System.Diagnostics
    open System.Threading
    open System.Text
    open System.Net
    open System.Net.Http

    let serverAddress = "https://localhost:5001"
    let mutable serverProc:Process option = None

    let private asyncSend wait json = async {
        try
            use clientHandler = new HttpClientHandler()
            clientHandler.ServerCertificateCustomValidationCallback <- (fun sender cert chain sslPolicyErrors -> true)

            use client = new HttpClient(clientHandler)
            let content =  new StringContent(json, Encoding.UTF8, "application/json")

            let! resp = client.PostAsync(sprintf "%s/message" serverAddress, content) |> Async.AwaitTask
            printfn "Response code %s sending to server" (string resp.StatusCode)
            
            match resp.StatusCode with
            | HttpStatusCode.OK ->
                printfn "Posted to server OK"
                if wait then
                    let! content = resp.Content.ReadAsStringAsync() |> Async.AwaitTask
                    printfn "Got response: %s" content
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
        asyncSend false json |> Async.RunSynchronously

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


module HighCharts =
    open System.Diagnostics
    open StringUtils
    open Server

    let mutable serverProc:Process option = None

    let kill() =
        killServer()

    let plot (data:(float * float) seq) =

        // Add a new series to chart, creating one if needed
        let jsonTemplate = "{\"Operation\":\"add\",\"target\":null,\"Json\":\"{\\\"name\\\":\\\"Series_1\\\",\\\"data\\\":[%%DATA%%]}\"}"

        let json =
            jsonTemplate
            |> strRep "%%DATA%%" (data |> Seq.map (fun (x,y) -> sprintf "[%f,%f]" x y) |> strJoin)
        
        // Start server if not already running
        checkServer (Some json)

        send json

    let title str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":0,\"Json\":\"{\\\"title\\\":{\\\"text\\\":\\\"%%TITLE%%\\\"}}\"}"

        let json =
            jsonTemplate
            |> strRep "%%TITLE%%" str

        send json

    let xlabel str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":0,\"Json\":\"{\\\"xAxis\\\":{\\\"title\\\":{\\\"text\\\":\\\"%%TITLE%%\\\"}}}\"}"

        let json =
            jsonTemplate
            |> strRep "%%TITLE%%" str

        send json

    let ylabel str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":0,\"Json\":\"{\\\"yAxis\\\":{\\\"title\\\":{\\\"text\\\":\\\"%%TITLE%%\\\"}}}\"}"

        let json =
            jsonTemplate
            |> strRep "%%TITLE%%" str

        send json
 