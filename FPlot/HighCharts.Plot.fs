namespace FPlot.HighCharts

module Plot =
    open System.IO
    open System.Diagnostics
    open FPlot.StringUtils
    open Server
    open Figure

    let fig = Figure(None)
    let mutable serverProc:Process option = None

    let kill() =
        killServer()

    let private store (filename:string) (stream:Stream) = 
        let numBytes = int stream.Length

        if numBytes <= 0 then
            ()
        else
            if Directory.Exists (Path.GetDirectoryName filename) |> not then
                Directory.CreateDirectory (Path.GetDirectoryName filename) |> ignore

            let buffer = Array.replicate (int stream.Length) 0uy
            stream.Position <- 0L
            stream.Read(buffer, 0, numBytes) |> ignore
            File.WriteAllBytes(filename, buffer)


    let plot (data:(float * float) seq) =

        // Add a new series to chart, creating one if needed
        let jsonTemplate = "{\"Operation\":\"add\",\"target\":null,\"Json\":\"{\\\"name\\\":\\\"Series_1\\\",\\\"data\\\":[##DATA##]}\"}"

        let json =
            jsonTemplate
            |> strRep "##DATA##" (data |> Seq.map (fun (x,y) -> sprintf "[%f,%f]" x y) |> strJoin)
        
        // Start server if not already running
        checkServer (Some json)

        send json

    let title str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":\"title.text\",\"Json\":\"\"##TITLE##\"\"}"

        let json =
            jsonTemplate
            |> strRep "##TITLE##" str

        send json

    let xlabel str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":0,\"Json\":\"{\\\"xAxis\\\":{\\\"title\\\":{\\\"text\\\":\\\"##LABEL##\\\"}}}\"}"

        let json =
            jsonTemplate
            |> strRep "##LABEL##" str

        send json

    let ylabel str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":0,\"Json\":\"{\\\"yAxis\\\":{\\\"title\\\":{\\\"text\\\":\\\"##LABEL##\\\"}}}\"}"

        let json =
            jsonTemplate
            |> strRep "##LABEL##" str

        send json
 
    let getFig (i:int) =
        let statusCode,resp =
            asyncSend true (sprintf "{\"Operation\":\"fetch\",\"target\":%i,\"Json\":\"\"}" i) |> Async.RunSynchronously
        
        printfn "Fetched: %A (%A)" resp statusCode
        resp

    let setFig (fig:int) (value:string) =
        // let jsonTemplate = sprintf "{\"Operation\":\"restore\",\"target\":%i,\"Json\":\"##JSON##\"}" fig

        // let json =
        //     jsonTemplate
        //     |> strRep "##JSON##" (value.Replace("\"","\\\""))

        // send json |> ignore
        ()        

    let save filename =
        getFig 0
        |> render
        |> Option.iter (store filename)
