dotnet build ./FPlot.Server/FPlot.Server.fsproj
dotnet build ./FPlot/FPlot.fsproj
dotnet build ./SchemaGen/SchemaGen.fsproj
dotnet build ./Demo/Demo.fsproj

dotnet build -c Release ./FPlot.Server/FPlot.Server.fsproj
dotnet build -c Release ./FPlot/FPlot.fsproj
dotnet build -c Release ./SchemaGen/SchemaGen.fsproj
dotnet build -c Release ./Demo/Demo.fsproj