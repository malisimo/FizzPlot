module FPlot.App

open System
open System.IO
open Microsoft.AspNetCore.Http
open Microsoft.AspNetCore.Builder
open Microsoft.AspNetCore.Cors.Infrastructure
open Microsoft.AspNetCore.Hosting
open Microsoft.Extensions.Logging
open Microsoft.Extensions.DependencyInjection
open Giraffe
open Giraffe.Razor
open FPlot.Models
open FPlot.Middleware

// ---------------------------------
// Web app
// ---------------------------------

let indexHandler =
    let model = { Operation = string Update; Target = "title"; Json = "{\"text\":\"\"}" }
    razorHtmlView "Index" (Some model) None

let handlePostMessage =
    fun (next : HttpFunc) (ctx : HttpContext) ->
        printfn "Received message"
        task {
            let! message = ctx.BindJsonAsync<Message>()
            printfn "Received message: %A" message
            
            let serializer = ctx.GetJsonSerializer()

            do! sendMessageToSockets (serializer.SerializeToString message)

            return! next ctx
        }

let webApp =
    choose [
        GET >=>
            choose [
                route "/" >=> indexHandler
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
        .UseHttpsRedirection()
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
        .Configure(Action<IApplicationBuilder> configureApp)
        .ConfigureServices(configureServices)
        .ConfigureLogging(configureLogging)
        .Build()
        .Run()
    0