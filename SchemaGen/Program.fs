open System
open System.IO
open System.Net
open System.Net.Http
open System.Text
open FSharp.Data

let indentSpaces = 4

type GetTypesState = {
    ParentPath:string list
    Parent:JsonValue
    CurSb:string
    CurCodeSb:string
    Types:string list
}

let loadJson (url:string) = async {
    try
        use clientHandler = new HttpClientHandler()
        clientHandler.ServerCertificateCustomValidationCallback <- (fun sender cert chain sslPolicyErrors -> true)

        use client = new HttpClient(clientHandler)

        let! resp = client.GetAsync(url) |> Async.AwaitTask

        printfn "Response code %s from Http request" (string resp.StatusCode)
        
        match resp.StatusCode with
        | HttpStatusCode.OK ->
            let! content = resp.Content.ReadAsStringAsync() |> Async.AwaitTask
            printfn "Got %i chars in response (%s)" content.Length (resp.ToString())
            return (resp.StatusCode,content)
        | _ ->
            printfn "Failed posting to server: %s" (string resp.StatusCode)
            return (resp.StatusCode,"")
    with ex ->
        printfn "Exception posting to server: %s" (string ex)
        return (HttpStatusCode.InternalServerError,"")
}

let jsonToSchema (namespaceName:string) (moduleName:string) (json:string) =
    let baseIndent = String(' ',indentSpaces)

    let pascalise (s:string) =
        let sTrim =
            s.Trim()
            |> Seq.toList

        match sTrim with
        | hd::tl ->
            Char.ToUpper(hd) :: tl
            |> List.toArray
            |> String
        | _ ->
            sTrim
            |> List.toArray
            |> String

    let (>~>) s str =
        s + Environment.NewLine + str

    let addPath p t =
        t::p

    let remPath p =
        match p with
        | _::tl ->
            tl
        | _ ->
            p

    let pathToString p =
        if List.isEmpty p then
            ""
        else
            p
            |> List.reduce (fun s p -> sprintf "%s.%s" p s)
    
    let pathToType p =
        if List.isEmpty p then
            ""
        else
            p
            |> List.reduce (fun s p -> sprintf "%s_%s" (pascalise p) (pascalise s))

    let pathToJson p =
        if List.isEmpty p then
            ""
        else
            p
            |> List.reduce (fun s p -> sprintf "%s:{%s}" p s)
    
    let rec getTypes (state:GetTypesState) (current:string*JsonValue) =
        let curKey,curVal = current
        let indent = baseIndent + String(' ',indentSpaces)
        let indent2 = indent + String(' ',indentSpaces)
        
        match curVal with
        | JsonValue.Record(r) ->
            let curPath = addPath state.ParentPath curKey

            let nextState =
                r
                |> Array.fold getTypes { ParentPath = curPath; Parent = curVal; CurSb = ""; CurCodeSb = ""; Types = state.Types }
            
            let curType =
                ""
                >~> sprintf "%s///<summary>%s : <code>{| %s |}</code></summary>" baseIndent (pathToType curPath) nextState.CurCodeSb
                >~> sprintf "%stype %s() =" baseIndent (pathToType curPath)
                >~> nextState.CurSb
                >~> ""
                >~> sprintf "%smember this.Set (o:{| %s |}) =" indent nextState.CurCodeSb
                >~> sprintf "%ssend \"%s\"" indent2 "##JSON##"
            
            let curSb =
                state.CurSb
                >~> ""
                >~> sprintf "%s///<summary>%s : <code>{| %s |}</code></summary>" indent (pathToType curPath) nextState.CurCodeSb
                >~> sprintf "%smember this.%s = %s()" indent curKey (pathToType curPath)

            let curCodeSb =
                match state.Parent with
                | JsonValue.Record(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "%s: {| %s |}" curKey nextState.CurCodeSb
                    else
                        sprintf "; %s: {| %s |}" curKey nextState.CurCodeSb
                | JsonValue.Array(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "{| %s |}" nextState.CurCodeSb
                    else
                        sprintf "; {| %s |}" nextState.CurCodeSb
                | _ ->
                    sprintf "; %s: {| %s |}" curKey nextState.CurCodeSb
            
            { state with CurSb = curSb; CurCodeSb = state.CurCodeSb + curCodeSb; Types = curType::nextState.Types }
        | JsonValue.Array(arr) ->
            let curPath = addPath state.ParentPath curKey
            let indent3 = indent2 + String(' ',indentSpaces)

            let nextState =
                match Array.tryHead arr with
                | None ->
                    // Assume type is float array
                    { state with CurSb = "type + child sb"; CurCodeSb = state.CurCodeSb + "; curKey:string seq"; Types = "curType seqqy"::state.Types }
                | Some(hd) ->
                    getTypes { state with ParentPath = curPath; Parent = curVal; CurSb = ""; CurCodeSb = ""; Types = state.Types } ("item",hd)
            
            let curType =
                ""
                >~> sprintf "%s///<summary>%s : <code>%s seq</code></summary>" baseIndent (pathToType curPath) nextState.CurCodeSb
                >~> sprintf "%stype %s() =" baseIndent (pathToType curPath)
                >~> sprintf "%slet item = %s()" indent (pathToType (addPath curPath "item"))
                >~> ""
                >~> sprintf "%smember this.Set (o:%s seq) =" indent nextState.CurCodeSb
                >~> sprintf "%ssend \"%s\"" indent2 "##JSON##"
                >~> ""
                >~> sprintf "%smember this.Item" indent
                >~> sprintf "%swith get(_) =" indent2
                >~> sprintf "%sitem" indent3
            
            let curSb = 
                state.CurSb
                >~> ""
                >~> sprintf "%s///<summary>%s : <code>%s seq</code></summary>" indent (pathToType curPath) nextState.CurCodeSb
                >~> sprintf "%smember this.%s = %s()" indent curKey (pathToType curPath)

            let curCodeSb =
                match state.Parent with
                | JsonValue.Array(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "%s seq" nextState.CurCodeSb
                    else
                        sprintf "; %s seq" nextState.CurCodeSb
                | _ ->
                    sprintf "; %s:%s seq" curKey nextState.CurCodeSb
            
            { state with CurSb = curSb; CurCodeSb = state.CurCodeSb + curCodeSb; Types = curType::nextState.Types }
        | JsonValue.String(_) ->
            let curPath = addPath state.ParentPath curKey

            let curSb = 
                state.CurSb
                >~> ""
                >~> sprintf "%s///<summary>%s : <code>string</code></summary>" indent curKey
                >~> sprintf "%smember this.%s = %s()" indent curKey (pathToType curPath)

            let curCodeSb =
                match state.Parent with
                | JsonValue.Record(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "%s:string" curKey
                    else
                        sprintf "; %s:string" curKey
                | _ ->
                    sprintf "string"

            let curType =
                ""
                >~> sprintf "%s///<summary>%s : <code>string</code></summary>" baseIndent (pathToType curPath)
                >~> sprintf "%stype %s() =" baseIndent (pathToType curPath)
                >~> sprintf "%smember this.Set (o:string) =" indent
                >~> sprintf "%ssend \"%s\"" indent2 "##JSON##"

            { state with CurSb = curSb; CurCodeSb = state.CurCodeSb + curCodeSb; Types = curType::state.Types }
        | JsonValue.Float(_) ->
            let curPath = addPath state.ParentPath curKey

            let curSb = 
                state.CurSb
                >~> ""
                >~> sprintf "%s///<summary>%s : <code>float</code></summary>" indent curKey
                >~> sprintf "%smember this.%s = %s()" indent curKey (pathToType curPath)

            let curCodeSb =
                match state.Parent with
                | JsonValue.Record(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "%s:float" curKey
                    else
                        sprintf "; %s:float" curKey
                | _ ->
                    sprintf "float"

            let curType =
                ""
                >~> sprintf "%s///<summary>%s : <code>float</code></summary>" baseIndent (pathToType curPath)
                >~> sprintf "%stype %s() =" baseIndent (pathToType curPath)
                >~> sprintf "%smember this.Set (o:float) =" indent
                >~> sprintf "%ssend \"%s\"" indent2 "##JSON##"

            { state with CurSb = curSb; CurCodeSb = state.CurCodeSb + curCodeSb; Types = curType::state.Types }
        | JsonValue.Number(_) ->
            let curPath = addPath state.ParentPath curKey

            let curSb = 
                state.CurSb
                >~> ""
                >~> sprintf "%s///<summary>%s : <code>int</code></summary>" indent curKey
                >~> sprintf "%smember this.%s = %s()" indent curKey (pathToType curPath)

            let curCodeSb =
                match state.Parent with
                | JsonValue.Record(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "%s:int" curKey
                    else
                        sprintf "; %s:int" curKey
                | _ ->
                    sprintf "int"

            let curType =
                ""
                >~> sprintf "%s///<summary>%s : <code>int</code></summary>" baseIndent (pathToType curPath)
                >~> sprintf "%stype %s() =" baseIndent (pathToType curPath)
                >~> sprintf "%smember this.Set (o:int) =" indent
                >~> sprintf "%ssend \"%s\"" indent2 "##JSON##"

            { state with CurSb = curSb; CurCodeSb = state.CurCodeSb + curCodeSb; Types = curType::state.Types }
        | JsonValue.Boolean(_) ->
            let curPath = addPath state.ParentPath curKey

            let curSb = 
                state.CurSb
                >~> ""
                >~> sprintf "%s///<summary>%s : <code>bool</code></summary>" indent curKey
                >~> sprintf "%smember this.%s = %s()" indent curKey (pathToType curPath)

            let curCodeSb =
                match state.Parent with
                | JsonValue.Record(_) ->
                    if String.IsNullOrEmpty state.CurCodeSb then
                        sprintf "%s:bool" curKey
                    else
                        sprintf "; %s:bool" curKey
                | _ ->
                    sprintf "bool"

            let curType =
                ""
                >~> sprintf "%s///<summary>%s : <code>bool</code></summary>" baseIndent (pathToType curPath)
                >~> sprintf "%stype %s() =" baseIndent (pathToType curPath)
                >~> sprintf "%smember this.Set (o:bool) =" indent
                >~> sprintf "%ssend \"%s\"" indent2 "##JSON##"

            { state with CurSb = curSb; CurCodeSb = state.CurCodeSb + curCodeSb; Types = curType::state.Types }
        | _ ->
            state

    let fig = JsonValue.Parse json

    let nextState = getTypes { ParentPath = []; Parent = fig; CurSb = ""; CurCodeSb = "{| "; Types = [] } ("figure",fig)
    let typeStr =
        nextState.Types
        |> List.rev
        |> List.fold (>~>) ""

    let sb = StringBuilder()
    sb.Clear() |> ignore
    sb.AppendLine(sprintf "namespace %s\n\n" namespaceName) |> ignore
    //sb.AppendLine("open FPlot.Common\n\n") |> ignore
    sb.AppendLine(sprintf "module %s =" moduleName) |> ignore
    sb.AppendLine("    let send s = ()") |> ignore
    sb.AppendLine(typeStr) |> ignore

    sb.ToString()
    

let storeSchema (filename:string) str =
    if Directory.Exists(Path.GetDirectoryName(filename)) |> not then
        Directory.CreateDirectory(Path.GetDirectoryName(filename)) |> ignore
    
    File.WriteAllText(filename, str)

[<EntryPoint>]
let main argv =
    // let highChartsUrl = "https://api.highcharts.com/highcharts/tree.json"

    // let respCode,highChartsJson =
    //     loadJson highChartsUrl |> Async.RunSynchronously
    
    // printfn "Got %i chars" highChartsJson.Length

    let highChartsJson = "{\"title\":\"Title\",\"xaxis\":{\"name\":\"x\",\"font\":\"arial\"},\"range\":[0.0,10.0],\"data\":[[{\"t\":0,\"v\":0.0,\"point\":{\"name\":\"a1\"}},{\"t\":1,\"v\":1.0,\"point\":{\"name\":\"b1\"}}],[{\"t\":0,\"v\":2.0,\"point\":{\"name\":\"a2\"}},{\"t\":1,\"v\":3.0,\"point\":{\"name\":\"b2\"}}],[{\"t\":0,\"v\":4.0,\"point\":{\"name\":\"a3\"}},{\"t\":1,\"v\":5.0,\"point\":{\"name\":\"b3\"}}]],\"legend\":[{\"label\":\"one\"},{\"label\":\"two\"}]}"
    let fsStr = jsonToSchema "FPlot.HighCharts" "Figure" highChartsJson

    printfn "Fsharp Code:"
    printfn "========\n"

    printfn "%s" fsStr
    storeSchema "./HighCharts.Figure.Test.fs" fsStr

    printfn "========\n"

    0
