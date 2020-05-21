open System
open System.Diagnostics
open FPlot
open System.Threading

let (~~) = float

let mutable serverProc:Process option = None

[<EntryPoint>]
let main _ =
    let n = 20
    let rand = Random()

    let data1 = [ for i in 0..n ->(0.1 * ~~i, 1.0 + rand.NextDouble() + ~~i) ]
    Plot.plot data1 |> ignore

    //Thread.Sleep(4000)
    Console.ReadKey() |> ignore
    printfn "Updating data..."

    let data2 = [ for i in 0..n ->(0.1 * ~~i, 5.0 + rand.NextDouble() + ~~i) ]
    Plot.plot data2 |> ignore

    //Thread.Sleep(4000)
    Console.ReadKey() |> ignore
    printfn "Updating data..."

    let data3 = [ for i in 0..n ->(0.1 * ~~i, 1.0 + rand.NextDouble() + 2.0 * ~~i) ]
    Plot.plot data3 |> ignore

    //Thread.Sleep(4000)
    Console.ReadKey() |> ignore
    printfn "Quitting..."
    
    Plot.killConnection()

    0 // return an integer exit code
