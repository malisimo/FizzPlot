namespace FizzPlot.HighCharts

module Plot =
    open System.IO
    open FizzPlot.StringUtils
    open Server
    open Figure

    let fig = Figure(None)
    let mutable currentChartIndex = 0

    /// Terminate server instance
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


    /// Plot sequence of xy value pairs
    let plot (data:(float * float) seq) =

        // Add a new series to chart, creating one if needed
        let jsonTemplate = "{\"Operation\":\"add\",\"chartIndex\":##CHART##,\"target\":\"\",\"Json\":\"{\\\"name\\\":\\\"Series_1\\\",\\\"data\\\":[##DATA##]}\"}"

        let json =
            jsonTemplate
            |> strRep "##DATA##" (data |> Seq.map (fun (x,y) -> sprintf "[%f,%f]" x y) |> strJoin)
            |> strRep "##CHART##" (string currentChartIndex)
        
        // Start server if not already running
        checkServer (Some json)

        send json

    let remove (i:int) =
        // Remove an existing series from chart, based on index
        let jsonTemplate = "{\"Operation\":\"remove\",\"chartIndex\":##CHART##,\"target\":\"series\",\"Json\":\"{\\\"id\\\":##INDEX##}\"}"

        let json =
            jsonTemplate
            |> strRep "##INDEX##" (sprintf "%i" i)
            |> strRep "##CHART##" (string currentChartIndex)
        
        // Start server if not already running
        checkServer (Some json)

        send json


    /// Set chart title
    let title str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"chartIndex\":##CHART##,\"target\":\"title.text\",\"Json\":\"\\\"##TITLE##\\\"\"}"

        let json =
            jsonTemplate
            |> strRep "##TITLE##" str
            |> strRep "##CHART##" (string currentChartIndex)

        send json

    /// Set X axis label
    let xlabel str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"chartIndex\":##CHART##,\"target\":\"xAxis[0].title.text\",\"Json\":\"\\\"##LABEL##\\\"\"}"

        let json =
            jsonTemplate
            |> strRep "##LABEL##" str
            |> strRep "##CHART##" (string currentChartIndex)

        send json

    /// Set Y axis label
    let ylabel str =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"update\",\"chartIndex\":##CHART##,\"target\":\"yAxis[0].title.text\",\"Json\":\"\\\"##LABEL##\\\"\"}"

        let json =
            jsonTemplate
            |> strRep "##LABEL##" str
            |> strRep "##CHART##" (string currentChartIndex)

        send json

    /// Set figure width, in pixels
    let setWidth (px:int) =
        let jsonTemplate = "{\"Operation\":\"update\",\"chartIndex\":##CHART##,\"target\":\"chart.width\",\"Json\":\"##VALUE##\"}"

        let json =
            jsonTemplate
            |> strRep "##VALUE##" (string px)
            |> strRep "##CHART##" (string currentChartIndex)

        send json

    /// Set figure height, in pixels
    let setHeight (px:int) =
        let jsonTemplate = "{\"Operation\":\"update\",\"chartIndex\":##CHART##,\"target\":\"chart.height\",\"Json\":\"##VALUE##\"}"

        let json =
            jsonTemplate
            |> strRep "##VALUE##" (string px)
            |> strRep "##CHART##" (string currentChartIndex)

        send json

    /// Set figure width, in pixels
    let setTheme (theme:string) =
        let jsonTemplate = "{\"Operation\":\"theme\",\"chartIndex\":##CHART##,\"target\":\"\",\"Json\":\"\\\"##THEME##\\\"\"}"

        let json =
            jsonTemplate
            |> strRep "##THEME##" theme
            |> strRep "##CHART##" (string currentChartIndex)

        send json
 
    /// Get current figure properties
    let getProps() =
        checkServer None

        let jsonTemplate = "{\"Operation\":\"fetch\",\"chartIndex\":##CHART##,\"target\":\"\",\"Json\":\"\"}"

        let json =
            jsonTemplate
            |> strRep "##CHART##" (string currentChartIndex)

        let statusCode,resp =
            asyncSend true json |> Async.RunSynchronously
        
        printfn "Fetched: %A (%A)" resp statusCode
        resp

    /// Set current figure properties
    let setProps (value:string) =
        let jsonTemplate = "{\"Operation\":\"restore\",\"chartIndex\":##CHART##,\"target\":\"\",\"Json\":\"##JSON##\"}"

        let json =
            jsonTemplate
            |> strRep "##JSON##" (value.Replace("\"","\\\""))
            |> strRep "##CHART##" (string currentChartIndex)

        send json

    /// Set current figure
    let setFig (fig:int) =
        currentChartIndex <- fig

    /// Render current figure to PNG file
    let save filename =
        getProps()
        |> render
        |> Option.iter (store filename)
