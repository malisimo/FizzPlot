module FizzPlot.App

open System
open System.IO
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Cors.Infrastructure
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Logging
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Caching.Memory
open Giraffe
open Giraffe.Razor
open FizzPlot.Models
open FizzPlot.Middleware

// ---------------------------------
// Web app
// ---------------------------------
module Views =
    open GiraffeViewEngine

    let layout (content: XmlNode list) =
        html [] [
            head [] [
                title []  [ str "FizzPlot" ]

                link [ _rel  "stylesheet"
                       _type "text/css"
                       _href "/main.css" ]
                
                script [_type "application/javascript"; _src "https://code.highcharts.com/highcharts.js"] []
                script [_type "application/javascript"; _src "https://code.highcharts.com/modules/annotations.js"] []
                script [_type "application/javascript"; _src "https://code.highcharts.com/modules/exporting.js"] []
                script [_type "application/javascript"; _src "https://code.highcharts.com/modules/export-data.js"] []
                script [_type "application/javascript"; _src "https://code.highcharts.com/modules/accessibility.js"] []
                script [_type "application/javascript"; _src "https://cdn.jsdelivr.net/npm/lodash@4.17.19/lodash.min.js"] []
                script [_type "application/javascript"; _src "scripts/appBundle.js"] []
            ]
            body [] content
        ]

    let partial () =
        h1 [] [ encodedText "FizzPlot" ]

    let index (model : Message) =
        [
            partial()
            
            div [ _id "chartContainer" ] []
            script [_type "application/javascript"] [
                rawText """
                    window.addEventListener('load', 
                        function () {            
                            var appData = {
                                charts:[],
                                maxChartId:0,
                                socket:null
                            };

                            initApp();
                            openWebSocket(appData);
                        }, false);
                """
            ]
        ] |> layout

let indexHandler =
    let model = {
        Operation = string Update
        ChartIndex = 0
        Target = "title.text"
        Json = "\"\"}"
    }
    let view = Views.index model
    htmlView view
    
    //razorHtmlView "Index" (Some model) None

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
    let env = app.ApplicationServices.GetService<IWebHostEnvironment>()
    let lifetime = app.ApplicationServices.GetService<IHostApplicationLifetime>()
    let webSocketOptions = WebSocketOptions()
    webSocketOptions.KeepAliveInterval <-  TimeSpan.FromSeconds(120.)
    webSocketOptions.ReceiveBufferSize <- 4 * 1024

    (match env.EnvironmentName with
    | "Development"  -> app.UseDeveloperExceptionPage()
    | _ -> app.UseGiraffeErrorHandler errorHandler)
        .UseCors(configureCors)
        .UseWebSockets(webSocketOptions)
        .UseMiddleware<WebSocketMiddleware>(lifetime)
        .UseStaticFiles()
        .UseGiraffe(webApp)

let configureServices (services : IServiceCollection) =
    let sp  = services.BuildServiceProvider()
    let env = sp.GetService<IHostEnvironment>()
    let viewsFolderPath = Path.Combine(env.ContentRootPath, "Views")
    //services.AddRazorEngine viewsFolderPath |> ignore
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
        .UseUrls("http://localhost:2387") 
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .ConfigureLogging(configureLogging)
        .Build()
        .Run()
    0