// FizzPlot Interactive Demo
// ======================
//
// Send chunks to FSI using 'Alt-Enter'.
// Include FizzPlot reference first:
#r "../FizzPlot/bin/Debug/netstandard2.0/FizzPlot.dll"

// #### SCATTER PLOTS

open System
open FizzPlot.HighCharts.Plot

let (~~) = float

let n = 6
let rand = Random()

let data1 = [ for i in 0..n -> (0.1 * ~~i, 1.0 + rand.NextDouble() + ~~i) ]
plot data1

save ".\\img.png"

// Update the title
title "data1"

// Update the axis titles
xlabel "x"
ylabel "y"

setWidth 1200
setHeight 500

setTheme "gray"

fig.series.[0].name.Set "First"
fig.legend.backgroundColor.Set "rgba(220,180,20,0.4)"
fig.colors.[0].Set "#F123A2"
fig.xAxis.[0].title.text.Set "lsjdjwm"
fig.xAxis.[0].gridLineWidth.Set 1

fig.series.[0].name.Set "NewSeriesName"
fig.series.[0].lineWidth.Set 2

fig.yAxis.[0]._type.Set "logarithmic"
fig.xAxis.[0].min.Set 0.1
fig.xAxis.[0].max.Set 0.2
fig.yAxis.[0].min.Set 2.4
fig.yAxis.[0].max.Set 3.2

// Add another series 
let data2 = [ for i in 0..n -> (0.1 * ~~i, 5.0 + rand.NextDouble() + ~~i) ]
plot data2 |> ignore
fig.series.[1].name.Set "Second"

// Update the title again
title "data2"

// Update the axis titles again
xlabel "x2"
ylabel "y2"

// #### KILL
// Remember to clean up when finished!

kill()
