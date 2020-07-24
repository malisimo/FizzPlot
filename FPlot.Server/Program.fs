module FPlot.App

open System
open System.IO
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Cors.Infrastructure
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Logging
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Caching.Memory
open Giraffe
open Giraffe.Razor
open FPlot.Models
open FPlot.Middleware

// ---------------------------------
// Web app
// ---------------------------------

let indexHandler =
    let model = {
        Operation = string Update
        ChartIndex = 0
        Target = "title.text"
        Json = "\"\"}"
    }
    
    razorHtmlView "Index" (Some model) None

let handleFetch : HttpHandler =
    fun (next:HttpFunc) (ctx:HttpContext) ->
        task {
            Console.WriteLine("Received HTTP fetch request")
            
            let serializer = ctx.GetJsonSerializer()
            //receivedMessages.Clear()
            
            Console.WriteLine("Sending message to sockets")
            do! sendMessageToSockets (serializer.SerializeToString { Operation = "fetch"; ChartIndex = 0; Target = ""; Json = "{}"})

            // Wait for some time for a message in the received queue
            let rec waitMessage i =
                if i <= 0 then
                    Console.WriteLine("Timeout waiting for message from socket")
                    None
                else
                    match tryGetReceivedMessage() with
                    | Some(msg) ->
                        Console.WriteLine("Found message from socket!!!")
                        Some msg
                    | None ->
                        Console.WriteLine("Sleeping in socket receive...")
                        Threading.Thread.Sleep 200
                        Console.WriteLine("Ended sleep in socket receive")
                        waitMessage (i-1)

            let resp = waitMessage 15

            match resp with
            | Some(s) ->
                Console.WriteLine(sprintf "Got response while handling POST (%i chars)" s.Length)
                return! (setStatusCode 200 >=> json s) next ctx
            | None ->
                Console.WriteLine("Failed to get response while handling POST")
                return! (setStatusCode 808 >=> json "Timeout waiting for Fetch response") next ctx
        }    

let handlePostMessage =
    fun (next:HttpFunc) (ctx:HttpContext) ->
        task {
            let! message = ctx.BindJsonAsync<Message>()
            printfn "Received message (%s)" message.Operation
            
            let serializer = ctx.GetJsonSerializer()
            
            if message.Operation = string Add then
                let cache = ctx.GetService<IMemoryCache>()
                cache.Set("initChartData", serializer.SerializeToString message) |> ignore
                printfn "Cached initial chart data"

            do! sendMessageToSockets (serializer.SerializeToString message)

            Console.WriteLine("No socket response needed - return 204")
            return! text "" next ctx
        }

let webApp =
    choose [
        GET >=>
            choose [
                route "/" >=> indexHandler
                route "/fetch" >=> handleFetch
            ]
        POST >=>
            choose [
                route "/message" >=> handlePostMessage
            ]
        setStatusCode 404 >=> text "Not Found" ]

// ---------------------------------
// Error handler
// ---------------------------------

let errorHandler (ex : Exception) (logger : ILogger) =
    logger.LogError(ex, "An unhandled exception has occurred while executing the request.")
    clearResponse >=> setStatusCode 500 >=> text ex.Message

// ---------------------------------
// Config and Main
// ---------------------------------

let configureCors (builder : CorsPolicyBuilder) =
    builder.WithOrigins("http://localhost:8080")
           .AllowAnyMethod()
           .AllowAnyHeader()
           |> ignore

let configureApp (app : IApplicationBuilder) =
    let env = app.ApplicationServices.GetService<IHostingEnvironment>()
    let webSocketOptions = WebSocketOptions()
    webSocketOptions.KeepAliveInterval <-  TimeSpan.FromSeconds(120.)
    webSocketOptions.ReceiveBufferSize <- 4 * 1024

    (match env.IsDevelopment() with
    | true  -> app.UseDeveloperExceptionPage()
    | false -> app.UseGiraffeErrorHandler errorHandler)
        .UseCors(configureCors)
        .UseWebSockets(webSocketOptions)
        .UseMiddleware<WebSocketMiddleware>()
        .UseStaticFiles()
        .UseGiraffe(webApp)

let configureServices (services : IServiceCollection) =
    let sp  = services.BuildServiceProvider()
    let env = sp.GetService<IHostingEnvironment>()
    let viewsFolderPath = Path.Combine(env.ContentRootPath, "Views")
    services.AddRazorEngine viewsFolderPath |> ignore
    services.AddCors() |> ignore
    services.AddGiraffe() |> ignore
    services.AddMemoryCache() |> ignore

let configureLogging (builder : ILoggingBuilder) =
    builder.AddFilter(fun l -> l.Equals LogLevel.Error)
           .AddConsole()
           .AddDebug() |> ignore

[<EntryPoint>]
let main _ =
    let contentRoot = Directory.GetCurrentDirectory()
    let webRoot     = Path.Combine(contentRoot, "WebRoot")
    WebHostBuilder()
        .UseKestrel()
        .UseContentRoot(contentRoot)
        .UseIISIntegration()
        .UseWebRoot(webRoot)
        .UseUrls("http://localhost:2387/")
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .ConfigureLogging(configureLogging)
        .Build()
        .Run()
    0