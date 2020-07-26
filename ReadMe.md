# FizzPlot

Plotting library for .Net, with live updates.
Version: 0.0.1-pre1

Author: Matt Jones
License: MIT

## What it is

This is a specially designed wrapper around the HighCharts and Plotly (coming!) JS charting libraries to allow you to generate beautiful line charts from .Net applications. The API is designed to be particularly friendly used from within a FSI (FSharp Interactive) window.

> Please note: Commercial use of HighCharts requires a [license](https://shop.highsoft.com/).

# Getting Started

Uses the dotnet CLI ([install here](https://docs.microsoft.com/en-us/dotnet/core/install/sdk)).

In the root folder of the repo, open a terminal and type:

```
dotnet run --project Demo/Demo.fsproj
```

This will open your browser and navigate to http://localhost:2387/ to show your plot.

# API Reference

## Basic Usage

From a .Net application, add the package reference, and generate a chart like so:

```
open FizzPlot.HighCharts.Plot

let xy = [(0.0,2.2),(1.0,1.4),(2.0,0.8)]

plot xy
title "X vs Y"
xlabel "X"
ylabel "Y"
```

This will start the local server and generate the chart which can be viewed in any tab of the browser (all tabs show the same set of plots).

Refer to the [Demo.fsx](./Demo/Demo.fsx) script for additional examples.

## Advanced Usage

To access more chart-specific options (e.g. series formatting, tooltips and lgend properties) you need to use the ```fig``` object, which exposes all available options:

```
fig.tooltip.padding.Set 12
fig.title.text.Set "Hello"
```

You will get intellisense on all available objects when pressing the ```.``` after fig, and each successive property.
Where properties are not described by simple strings or numbers, anonymous records are used to define the property values:

```
fig.legend.navigation.Set {| activeColor="#a2412f"; inactiveColor="#6a6a6a" |}
```

# FSI Interative

Since the updates are live, FizzPlot is particularly suited to use in an interactive setting where you make an initial plot with the data, and then make subsequent tweaks to the visuals until happy with the results.

# Examples

## Series line width
