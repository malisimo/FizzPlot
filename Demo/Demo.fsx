// FizzPlot Interactive Demo
// =========================
//
// Send chunks to FSI using 'Alt-Enter'.
// Include FizzPlot reference first:
#r "../FizzPlot/bin/Release/netstandard2.0/FizzPlot.dll"

// #### SCATTER PLOTS

open FizzPlot.HighCharts.Plot

let data1 = [
    for t in 0.0 .. 0.001 .. 1. ->
    (t,t + sin (2. * t) * cos (50. * (t - 30. * cos (1. * t)))) ]
plot data1

save ".\\img.png"

// Update the title
title "data1"

// Update the axis titles
xlabel "x"
ylabel "y"

setWidth 1200
setHeight 500

setTheme "gray" // gray, default

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
fig.yAxis.[0].min.Set 0.1
fig.yAxis.[0].max.Set 3.2

// Add another series
let rand = System.Random(2387)
let data2 = [ for t in 0.0 .. 0.01 .. 1. -> (t, 0.2 + rand.NextDouble() + t) ]
plot data2 |> ignore
fig.series.[1].name.Set "Second"

// Remove the first series
remove 0

// Update the title again
title "data2"

// Update the axis titles again
xlabel "x2"
ylabel "y2"

// #### KILL
// Remember to clean up when finished!

kill()
