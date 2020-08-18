echo off

echo.
echo ###
echo ### FizzPlot.Server (Debug)
echo ###
dotnet build ./FizzPlot.Server/FizzPlot.Server.fsproj --nologo
echo.
echo ###
echo ### FizzPlot (Debug)
echo ###
dotnet build ./FizzPlot/FizzPlot.fsproj --nologo
echo.
echo ###
echo ### SchemGen (Debug)
echo ###
dotnet build ./SchemaGen/SchemaGen.fsproj --nologo
echo.
echo ###
echo ### Demo (Debug)
echo ###
dotnet build ./Demo/Demo.fsproj --nologo

echo.
echo ###
echo ### FizzPlot.Server (Release)
echo ###
dotnet build -c Release ./FizzPlot.Server/FizzPlot.Server.fsproj --nologo
echo.
echo ###
echo ### FizzPlot (Release)
echo ###
dotnet build -c Release ./FizzPlot/FizzPlot.fsproj --nologo
echo.
echo ###
echo ### SchemGen (Release)
echo ###
dotnet build -c Release ./SchemaGen/SchemaGen.fsproj --nologo
echo.
echo ###
echo ### Demo (Release)
echo ###
dotnet build -c Release ./Demo/Demo.fsproj --nologo