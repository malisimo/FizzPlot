# FizzPlot

Plotting library for .Net, with live updates.
Version: 0.0.1-pre1

Author: Matt Jones
License: MIT

## What it is

This is a specially designed wrapper around the HighCharts and Plotly (coming!) JS charting libraries to allow you to generate beautiful line charts from .Net applications. The API is designed to be particularly friendly used from within a FSI (FSharp Interactive) window.

> Please note: Commercial use of HighCharts requires a [license](https://shop.highsoft.com/).

# Getting Started

> Requirements: Uses the dotnet CLI ([install here](https://docs.microsoft.com/en-us/dotnet/core/install/sdk)).

## Demo Project

In the root folder of the repo, open a terminal and type:

```
dotnet run --project Demo/Demo.fsproj
```

This will open your browser and navigate to http://localhost:2387/ to show your plot.

## New Project

To create a new project for plotting data with FizzPlot, run the following from a command prompt / shell:

```
dotnet new console -lang f# -n FizzDemo
cd FizzTest
dotnet add package fizzplot -v 0.0.1-*
```

Then, open Program.fs and enter the following:

```
open FizzPlot.HighCharts.Plot

let d = [for t in 0.0 .. 0.01 .. 1.0 -> (t,t * sin 20.0 * t) ]
plot d
```

To run the program, navigate to the project directory and type the following in the command prompt / shell:

```
dotnet run
```

This will open your browser and navigate to http://localhost:2387/ to show your plot.

## New Script

To run FizzPlot in an Fsharp Interactive window (FSI) from an F# Script, you will first need to get hold of the nuget package.
Until .Net 5 is released, this is best achieved by first creating a new project:

```
dotnet new console -lang f# -n FizzTest
cd FizzTest
dotnet add package fizzplot -v 0.0.1-* --package-directory .\packages
```

The last command will download the nuget package and place it in a subdirectory called 'packages' within the project directory.  This makes it easier to reference from within a script.
Next, create a new .fsx script file in the project directory, and reference the downloaded nuget package to start plotting:

```
#r "./packages/fizzplot/0.0.1-pre1/lib/netcoreapp3.1/FizzPlot.dll"

open FizzPlot.HighCharts.Plot

let d = [for t in 0.0 .. 0.01 .. 1.0 -> (t,t * sin 20.0 * t) ]
plot d
```

Highlight all these lines and send to FSI using ```Alt-Enter```.

# API Reference

## Basic Usage

Once the appropriate reference to the FizzPlot library has been added, you can generate a chart like so:

```
open FizzPlot.HighCharts.Plot

let xy = [(0.0,2.2),(1.0,1.4),(2.0,0.8)]

plot xy
title "X vs Y"
xlabel "X"
ylabel "Y"

setWidth 1200
setHeight 500
```

This will start the local server and generate the chart which can be viewed in any tab of the browser (all tabs show the same set of plots).

Refer to the [Demo.fsx](./Demo/Demo.fsx) script for additional examples.

## Advanced Usage

To access more chart-specific options (e.g. series formatting, tooltips and lgend properties) you need to use the ```fig``` object, which exposes all available options:

```
fig.colors.[0].Set "#F123A2"

fig.series.[0].name.Set "NewSeriesName"
fig.series.[0].lineWidth.Set 2
```

You will get intellisense on all available objects when pressing the ```.``` after fig, and each successive property.
Where properties are not described by simple strings or numbers, anonymous records are used to define the property values:

```
fig.legend.navigation.Set {| activeColor="#a2412f"; inactiveColor="#6a6a6a" |}
```

# FSI Interative

Since the updates are live, FizzPlot is particularly suited to use in an interactive setting where you make an initial plot with the data, and then make subsequent tweaks to the visuals until happy with the results.
