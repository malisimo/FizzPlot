open System
open FSharp.Data
open FizzPlot.HighCharts.Plot

type Cases = JsonProvider<"""[{"country": "UA", "last_update": "2020-01-01T05:34:38", "cases": 1, "deaths": 1, "recovered": 1}]""">

let startDate = DateTime(2020,3,21,0,0,0)
let countries =
    [
        "Holland","NL"
        "China","CN"
        "Chile","CL"
    ] |> dict

let url = "https://covid19-api.org/api/timeline/"

let getCases (country:string) =
    Cases.Load(url + country)
    |> Array.map (fun p -> (p.LastUpdate.Subtract(startDate).TotalDays,float p.Cases))


[<EntryPoint>]
let main argv =

    // Get data and plot it as xy tuples
    plot (getCases countries.["Holland"])
    fig.series.[0].name.Set "Holland"

    printfn "Any key to update properties..."
    Console.ReadKey() |> ignore

    // Update the axis titles
    xlabel "Days since outbreak"
    ylabel "Confirmed cases"

    // Update plot title and other axis properties
    title "Total number of cases over time"
    fig.xAxis.[0].labels.format.Set "{value}d"
    fig.xAxis.[0].labels.rotation.Set 45

    printfn "Any key to add a second plot..."
    Console.ReadKey() |> ignore

    plot (getCases countries.["China"])
    fig.series.[1].name.Set "China"

    printfn "Any key to add a third plot..."
    Console.ReadKey() |> ignore

    plot (getCases countries.["Chile"])
    fig.series.[2].name.Set "Chile"

    printfn "Any key to add change line display..."
    Console.ReadKey() |> ignore

    // Update series display properties
    fig.series.[1].color.Set "#E6C"
    fig.series.[2].color.Set "#6EC"
    fig.series.[1].marker.enabled.Set true
    fig.series.[1].marker.enabledThreshold.Set 1
    fig.series.[2].lineWidth.Set 12

    printfn "Any key to change theme and size..."
    Console.ReadKey() |> ignore

    // Set theme to 'gray' and resize plot
    setTheme "gray"
    setWidth 500
    setHeight 700

    printfn "Any key to save image..."
    Console.ReadKey() |> ignore

    // Render current plot to PNG
    save "./img.png"

    // #### KILL
    // Remember to clean up when finished!
    printfn "Any key to kill server..."
    Console.ReadKey() |> ignore
    kill()    
    printfn "Killed"
    
    0 // return an integer exit code
