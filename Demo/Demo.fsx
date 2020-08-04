// FizzPlot Interactive Demo
// =========================
//
// Send chunks to FSI using 'Alt-Enter'.
// Include FizzPlot reference first:
#r "../FizzPlot/bin/Release/netstandard2.0/FizzPlot.dll"

open FizzPlot.HighCharts.Plot

// Plot some data (xy tuples)
let data1 = [
    for t in 0.0 .. 0.01 .. 1. ->
    (t, 1.0 + t + sin (2. * t) * cos (30. * (t - 30. * cos (1. * t)))) ]
plot data1

// Update the title
title "Chirp"

// Update the axis titles
xlabel "Time (s)"
ylabel "Voltage (V)"

// Set the figure dimensions
setWidth 1200
setHeight 500

// Add another line
let data2 = [
    for t in 0.0 .. 0.001 .. 1. ->
    (t, 1.0 + t + sin (2. * t)) ]
plot data2

// Update series properties
fig.series.[0].name.Set "Chirp Signal"
fig.series.[0].color.Set "#AAFF22"
fig.series.[0].marker.enabledThreshold.Set 4
fig.series.[0].marker.fillColor.Set "#CCC"

fig.series.[1].name.Set "Envelope"
fig.series.[1].lineWidth.Set 4
fig.series.[1].marker.enabled.Set false

// Update axis properties (range, type)
fig.xAxis.[0].min.Set 0.1
fig.xAxis.[0].max.Set 0.5
fig.yAxis.[0]._type.Set "logarithmic"
fig.yAxis.[0].endOnTick.Set false
fig.yAxis.[0].max.Set 2.4

// Set the theme to gray
setTheme "gray" // dark, gray, default

// Save image to PNG
save ".\\img.png"

// Some styling changes
fig.chart.plotBackgroundColor.Set "#222"
fig.chart.plotBorderColor.Set "#FFF"
fig.chart.plotBorderWidth.Set 1
fig.title.style.fontFamily.Set "Courier New"
fig.title.style.fontSize.Set "8px"
fig.title.style.color.Set "#BBB"

// Legend
fig.legend.layout.Set "horizontal"
fig.legend.align.Set "left"
fig.legend.backgroundColor.Set "#000"
fig.legend.enabled.Set false

// Ticks
fig.xAxis.[0].tickColor.Set "#555"
fig.xAxis.[0].tickLength.Set 6
fig.xAxis.[0].tickInterval.Set 0.1
fig.xAxis.[0].labels.rotation.Set 90
fig.xAxis.[0].labels.format.Set "{value} m"

fig.xAxis.[0].gridLineWidth.Set 2
fig.xAxis.[0].gridLineColor.Set "#A77"

// Remove the first series
remove 0

// Add another series
let rand = System.Random(2387)
let data3 = [ for t in 0.0 .. 0.01 .. 1. -> (t, 2.0 * t + 1.0 + 0.3 * rand.NextDouble()) ]
plot data3 |> ignore

fig.series.[1].name.Set "Random"

// Update the title again
title "Sound absorption"

// Update the axis titles again
xlabel "Partition separation"
ylabel "Absorption"

// #### KILL
// Remember to clean up when finished!

kill()
