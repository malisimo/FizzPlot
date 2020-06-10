namespace FPlot.HighCharts

module Plot =
    open System.Diagnostics
    open FPlot.StringUtils
    open FPlot.Common
    open Server
    open Figure

    let fig = Figure()
    let mutable serverProc:Process option = None

    let kill() =
        killServer()

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

        let jsonTemplate = "{\"Operation\":\"update\",\"target\":0,\"Json\":\"{\\\"title\\\":{\\\"text\\\":\\\"##TITLE##\\\"}}\"}"

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

    let setFig (fig:int) (target:IFigureElement) (value:string) =
        let targetJson = target.GetJson().Replace("##VALUE##",value)

        let jsonTemplate = sprintf "{\"Operation\":\"update\",\"target\":%i,\"Json\":\"##JSON##\"}" fig

        let json =
            jsonTemplate
            |> strRep "##JSON##" (targetJson.Replace("\"","\\\""))

        send json |> ignore
