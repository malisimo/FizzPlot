open System
open FPlot.HighCharts.Plot

[<EntryPoint>]
let main argv =

    let (~~) = float

    let n = 6
    let rand = Random()

    let data1 = [ for i in 0..n -> (0.1 * ~~i, 1.0 + rand.NextDouble() + ~~i) ]
    plot data1

    // Update the title
    title "data1"

    // Update the axis titles
    xlabel "x"
    ylabel "y"

    fig.series.[0].name.Set "Mike"

    printfn "Any key to update data..."
    Console.ReadKey() |> ignore

    // Change the data in current series 
    let data2 = [ for i in 0..n -> (0.1 * ~~i, 5.0 + rand.NextDouble() + ~~i) ]
    plot data2 |> ignore

    // Update the title again
    title "data2"

    // Update the axis titles again
    xlabel "x2"
    ylabel "y2"

    // #### KILL
    // Remember to clean up when finished!
    printfn "Any key to kill server..."
    Console.ReadKey() |> ignore
    kill()    
    printfn "Killed"
    
    0 // return an integer exit code
