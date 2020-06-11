open System
open System.IO
open System.Net
open System.Net.Http
open System.Text
open FSharp.Data

let indentSpaces = 4

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
    let baseIndent = (String(' ',indentSpaces))

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
    
    let rec getTypes (state:string option * string * int * string list) (currentSb:StringBuilder) (current:string*JsonValue) =
        let _,curPath,arrayDepth,types = state
        let curKey,curVal = current
        let indent = baseIndent + String(' ',indentSpaces)
        
        match curVal with
        | JsonValue.Record(r) ->
            let childPath =
                if String.IsNullOrEmpty curPath then
                    pascalise curKey
                else
                    sprintf "%s_%s" curPath (pascalise curKey)

            currentSb.AppendLine(sprintf "%s///<summary>%s : <code>%s</code></summary>" indent childPath "##FSHARP##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.%s = {" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%snew IFigureElement with" (indent + String(' ',indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',2*indentSpaces)) "##JSON##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetElementType() = ElementObject" (indent + String(' ',2*indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%s}" (indent + String(' ',indentSpaces))) |> ignore
            
            let childSb = StringBuilder()
            childSb.AppendLine(sprintf "%s///<summary>%s : <code>%s</code></summary>" baseIndent childPath  "##FSHARP##") |> ignore
            childSb.AppendLine(sprintf "%stype %s() =" baseIndent childPath) |> ignore

            let _,_,_,nextTypes =
                r
                |> Array.fold (fun state child ->
                    let s1,s2,_,s4 = state // Reset array depth each time
                    getTypes (s1,s2,0,s4) childSb child) (Some curKey, childPath, 0, types)

            childSb.AppendLine(sprintf "%sinterface IFigureElement with" indent) |> ignore
            childSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',indentSpaces)) "##JSON##") |> ignore
            childSb.AppendLine(sprintf "%smember this.GetElementType() = ElementObject" (indent + String(' ',indentSpaces))) |> ignore
            childSb.AppendLine() |> ignore
            childSb.AppendLine(sprintf "%soverride this.ToString() =" indent) |> ignore
            childSb.AppendLine(sprintf "%s\"%s\"" (indent + String(' ',indentSpaces)) childPath) |> ignore

            (Some curKey, curPath, arrayDepth, childSb.ToString() :: nextTypes)
        | JsonValue.Array(arr) ->
            let arrType,nextArrayDepth,nextTypes =
                match Array.tryHead arr with
                | None ->
                    ("string []",arrayDepth,types)
                | Some(hd) ->
                    let childName,_,arrayDepth,nextTypes = getTypes (None, curPath, arrayDepth+1, types) (StringBuilder()) (pascalise curKey,hd)
                    let arrStr =
                        [|for _ in 1..arrayDepth -> "[]"|]
                        |> Array.reduce (+)
                    
                    match childName with
                    | Some(child) ->
                        (sprintf "%s_%s %s" curPath (pascalise child) arrStr,arrayDepth,nextTypes)
                    | None ->
                        (sprintf "string %s" arrStr,arrayDepth,nextTypes)
            
            currentSb.AppendLine(sprintf "%s///<summary>%s : <code>%s</code></summary>" indent curKey arrType) |> ignore
            currentSb.AppendLine(sprintf "%smember this.%s = {" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%snew IFigureElement with" (indent + String(' ',indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',2*indentSpaces)) "##JSON##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetElementType() = ElementArray" (indent + String(' ',2*indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%s}" (indent + String(' ',indentSpaces))) |> ignore      
            (Some curKey, curPath, nextArrayDepth, nextTypes)
        | JsonValue.String(_) ->
            currentSb.AppendLine(sprintf "%s///<summary>%s : <code>string</code></summary>" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%smember this.%s = {" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%snew IFigureElement with" (indent + String(' ',indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',2*indentSpaces)) "##JSON##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetElementType() = ElementString" (indent + String(' ',2*indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%s}" (indent + String(' ',indentSpaces))) |> ignore
            state
        | JsonValue.Float(_) ->
            currentSb.AppendLine(sprintf "%s///<summary>%s : <code>float</code></summary>" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%smember this.%s = {" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%snew IFigureElement with" (indent + String(' ',indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',2*indentSpaces)) "##JSON##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetElementType() = ElementFloat" (indent + String(' ',2*indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%s}" (indent + String(' ',indentSpaces))) |> ignore
            state
        | JsonValue.Number(_) ->
            currentSb.AppendLine(sprintf "%s///<summary>%s : <code>float</code></summary>" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%smember this.%s = {" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%snew IFigureElement with" (indent + String(' ',indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',2*indentSpaces)) "##JSON##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetElementType() = ElementFloat" (indent + String(' ',2*indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%s}" (indent + String(' ',indentSpaces))) |> ignore
            state
        | JsonValue.Boolean(_) ->
            currentSb.AppendLine(sprintf "%s///<summary>%s : <code>bool</code></summary>" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%smember this.%s = {" indent curKey) |> ignore
            currentSb.AppendLine(sprintf "%snew IFigureElement with" (indent + String(' ',indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetJson() = \"%s\"" (indent + String(' ',2*indentSpaces)) "##JSON##") |> ignore
            currentSb.AppendLine(sprintf "%smember this.GetElementType() = ElementBool" (indent + String(' ',2*indentSpaces))) |> ignore
            currentSb.AppendLine(sprintf "%s}" (indent + String(' ',indentSpaces))) |> ignore
            state
        | _ ->
            state

    let fig = JsonValue.Parse json

    let sb = StringBuilder()
    let _,_,_,types = getTypes (None, "", 0, []) sb ("figure",fig)
    let typeStr =
        types
        |> List.rev
        |> List.fold (fun s cur -> s + Environment.NewLine + cur) ""

    sb.Clear() |> ignore
    sb.AppendLine(sprintf "namespace %s\n\n" namespaceName) |> ignore
    sb.AppendLine("open FPlot.Common\n\n") |> ignore
    sb.AppendLine(sprintf "module %s =" moduleName) |> ignore
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
