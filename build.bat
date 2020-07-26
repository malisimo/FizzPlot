dotnet build ./FizzPlot.Server/FizzPlot.Server.fsproj
dotnet build ./FizzPlot/FizzPlot.fsproj
dotnet build ./SchemaGen/SchemaGen.fsproj
dotnet build ./Demo/Demo.fsproj

dotnet build -c Release ./FizzPlot.Server/FizzPlot.Server.fsproj
dotnet build -c Release ./FizzPlot/FizzPlot.fsproj
dotnet build -c Release ./SchemaGen/SchemaGen.fsproj
dotnet build -c Release ./Demo/Demo.fsproj