// Learn more about F# at http://fsharp.org

open System
open System.IO
open System.Diagnostics

[<EntryPoint>]
let main argv =
    let workDir = "FPlot.Server"
    let binDir = "bin/Debug/netcoreapp2.2/"
    let server = Path.Combine(binDir,"FPlot.Server.dll")

    printfn "Running server from %s" (Path.GetFullPath(Path.Combine(workDir,server)))

    let psi = ProcessStartInfo()    
    psi.FileName <- "dotnet"
    psi.Arguments <- server
    psi.UseShellExecute <- false
    psi.RedirectStandardOutput <- false
    psi.RedirectStandardError <- false
    psi.CreateNoWindow <- false
    psi.WorkingDirectory <- workDir

    let proc = new Process()
    proc.StartInfo <- psi
    let res = proc.Start()
    printfn "Running (res = %A)" res
    //printfn "%s" (proc.StandardOutput.ReadToEnd())

    Console.WriteLine("Press anything to stop...")
    Console.ReadKey() |> ignore

    if proc.HasExited |> not then
        proc.Kill()

    0 // return an integer exit code
