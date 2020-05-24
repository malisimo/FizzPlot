#r "../FPlot/bin/Debug/netstandard2.0/FPlot.dll"

open System
open FPlot

let (~~) = float

let n = 20
let rand = Random()

let data1 = [ for i in 0..n ->(0.1 * ~~i, 1.0 + rand.NextDouble() + ~~i) ]
Plot.plot data1 |> ignore

let data2 = [ for i in 0..n ->(0.1 * ~~i, 5.0 + rand.NextDouble() + ~~i) ]
Plot.plot data2 |> ignore
