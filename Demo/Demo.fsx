// FPlot Interactive Demo
// ======================
//
// Send chunks to FSI using 'Alt-Enter'.
// Include FPlot reference first:
#r "../FPlot/bin/Debug/netstandard2.0/FPlot.dll"

// #### SCATTER PLOTS

open System
open FPlot.HighCharts.Plot

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

fig.series.[0].name.Set "First"
fig.legend.backgroundColor.Set "rgba(220,180,20,0.4)"
fig.tooltip.padding.Set 12
fig.colors.[0].Set "#F123A2"
fig.plotOptions.line.lineWidth.Set 8
fig.legend.navigation.Set {| activeColor="#A2412F"; inactiveColor="#6A6A6A" |}
fig.legend.layout.Set "horizontal"
fig.xAxis.[0].title.text.Set "lsjdjwm"
fig.xAxis.[0].gridLineWidth.Set 4

fig.series.[0].name.Set "NewSeriesName"
fig.series.[0].lineWidth.Set 4

// Change the data in current series 
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
