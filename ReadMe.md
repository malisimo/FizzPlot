# FPlot

Plotting library for .Net, with live updates.
Version: 0.0.1a

Author: Matt Jones
License: MIT

# Getting Started

Uses the dotnet CLI ([install here](https://docs.microsoft.com/en-us/dotnet/core/install/sdk)).

In the root folder, open a terminal and type:

```
dotnet run --project Demo/Demo.fsproj
```

Then navigate to https://localhost:5001/ in your browser.

# API Reference

## Basic Usage

From a .Net application, add the package reference, and generate a chart like so:

```
open FPlot.HighCharts

let xy = [(0.0,2.2),(1.0,1.4),(2.0,0.8)]

plot xy
title "X vs Y"
xlabel "X"
ylabel "Y"
```

This will start the local server and generate the chart which can be viewed in any tab of the browser (all tabs show the same set of plots).

Refer to the [Demo.fsx](./Demo/Demo.fsx) script for additional examples.

## Advanced Usage

To obtain the current figure object state as JSON, you can query this using ```chart.get`` like this:

```
getFig 0
|> printfn "Figure object: %s"
```

You can set any figure property using dot notation to access the underlying javascript object, with the static ```fig``` object as reference, and dot notation:

```
setFig 0 fig.xAxis.title.text "\"My X\""
```

# FSI Interative

Since the updates are live, FPlot is particularly suited to use in an interactive setting where you make an initial plot with the data, and then make subsequent tweaks to the visuals until happy with the results.
