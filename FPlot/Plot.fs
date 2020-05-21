namespace FPlot

module Plot =
    open System
    open System.IO
    open System.Diagnostics
    open System.Net.Http

    let mutable serverProc:Process option = None

    let killConnection() =
        match serverProc with
        | Some(proc) ->
            if proc.HasExited |> not then
                printfn "Killing server process"
                proc.Kill()
        | None ->
            ()

    let private startServer() =
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
        let res = proc.Start()
        printfn "Running server process..."

        proc.EnableRaisingEvents <- true
        proc.Exited.AddHandler(new EventHandler(fun _ _ ->
            printfn "Server process exited!"
            serverProc <- None))

        AppDomain.CurrentDomain.DomainUnload.AddHandler(new EventHandler(fun s e -> killConnection()))
        AppDomain.CurrentDomain.ProcessExit.AddHandler(new EventHandler(fun s e -> killConnection()))
        AppDomain.CurrentDomain.UnhandledException.AddHandler(new UnhandledExceptionEventHandler(fun s e -> killConnection()))

        proc

    let private checkServer() =
        match serverProc with
        | Some(proc) ->
            if proc.HasExited then
                serverProc <- Some (startServer())
        | None ->
            serverProc <- Some (startServer())

    let private send (json:string) = async {
        let clientHandler = new HttpClientHandler()
        clientHandler.ServerCertificateCustomValidationCallback <- (fun  sender  cert  chain  sslPolicyErrors -> true);

        let client = new HttpClient(clientHandler)
        let content =  new StringContent(json, Text.Encoding.UTF8, "application/json")

        printfn "Sending %s to server" json
        let! resp = client.PostAsync("http://localhost:5000/message", content) |> Async.AwaitTask
        return resp.StatusCode
    }

    let strRep (str:string) (strFrom:string) (strTo:string) =
        str.Replace(strFrom, strTo)

    let strJoin (strs:string seq) =
        String.Join(",", strs)

    let plot (data:(float * float) seq) =
        checkServer()

        let jsonTemplate = "{\"Text\":\"{\\\"title\\\":{\\\"text\\\":\\\"FPlot.plot\\\"},\\\"series\\\":[{\\\"name\\\":\\\"Series_1\\\",\\\"data\\\":[%%DATA%%]}]}\"}"

        let json =
            data
            |> Seq.map (fun (x,y) -> sprintf "%f,%f" x y)
            |> strJoin
            |> strRep jsonTemplate "%%DATA%%" 

        send json |> Async.RunSynchronously
 