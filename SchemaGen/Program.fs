open System
open System.IO
open System.Text
open FSharp.Data

let indentSpaces = 4


type GetTypesState = {
    ParentPath:string list
    Parent:JsonValue
    CurSb:StringBuilder
    CurCodeSb:StringBuilder
    Types:string list
}


let loadJson (file:string) =
    // Grab the JSON from a live chart object using something like
    // JSON.stringify(Highcharts.charts[0].options)
    // in the browser console, then save to a file to be loaded here.

    File.ReadAllText(file)


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

    let append str (sb:StringBuilder) =
        sb.AppendLine(str)

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
                |> Array.fold getTypes { ParentPath = curPath; Parent = curVal; CurSb = StringBuilder(); CurCodeSb = StringBuilder(); Types = state.Types }
            
            let hh = String.Format("{0}///<summary>{1} : <code>{{| {2} |}}</code></summary>", baseIndent, pathToType curPath, nextState.CurCodeSb.ToString())
            
            let curType =
                StringBuilder()
                |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>{{| {2} |}}</code></summary>", baseIndent, pathToType curPath, nextState.CurCodeSb.ToString()))
                |> fun sb -> sb.AppendLine(String.Format("{0}type {1}() =", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(nextState.CurSb.ToString())
                |> fun sb -> sb.AppendLine()
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Set (o:{{| {1} |}}) =", indent, nextState.CurCodeSb.ToString()))
                |> fun sb -> sb.AppendLine(String.Format("{0}send \"{1}\"", indent2, "##JSON##"))
                |> fun sb -> sb.ToString()
            
            state.CurSb
            |> fun sb -> sb.AppendLine()
            |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>{{| {2} |}}</code></summary>", indent, pathToType curPath, nextState.ToString()))
            |> fun sb -> sb.AppendLine(String.Format("{0}member this.{1}= {2}()", indent, curKey, pathToType curPath))
            |> ignore

            match state.Parent with
            | JsonValue.Record(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{0}: {{| {1} |}}", curKey, nextState.CurCodeSb.ToString())) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {0}: {{| {1} |}}", curKey, nextState.CurCodeSb.ToString())) |> ignore
            | JsonValue.Array(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{{| {0} |}}", nextState.CurCodeSb.ToString())) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {{| {0} |}}", nextState.CurCodeSb.ToString())) |> ignore
            | _ ->
                state.CurCodeSb.Append(String.Format("; {0}: {{| {1} |}}", curKey, nextState.CurCodeSb.ToString())) |> ignore
            
            { state with CurSb = state.CurSb; CurCodeSb = state.CurCodeSb; Types = curType::nextState.Types }
        | JsonValue.Array(arr) ->
            let curPath = addPath state.ParentPath curKey
            let indent3 = indent2 + String(' ',indentSpaces)

            let nextState =
                let hd =
                    match Array.tryHead arr with
                    | None ->
                        JsonValue.Float(0.)
                    | Some(hd) ->
                        hd

                getTypes { state with ParentPath = curPath; Parent = curVal; CurSb = StringBuilder(); CurCodeSb = StringBuilder(); Types = state.Types } ("item",hd)
            
            let curType =
                StringBuilder()
                |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>{2} seq</code></summary>", baseIndent, pathToType curPath, nextState.CurCodeSb.ToString()))
                |> fun sb -> sb.AppendLine(String.Format("{0}type {1}() =", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}let item = {1}()", indent, pathToType (addPath curPath "item")))
                |> fun sb -> sb.AppendLine()
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Set (o:{1} seq) =", indent, nextState.CurCodeSb.ToString()))
                |> fun sb -> sb.AppendLine(String.Format("{0}send \"{1}\"", indent2, "##JSON##"))
                |> fun sb -> sb.AppendLine()
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Item", indent))
                |> fun sb -> sb.AppendLine(String.Format("{0}with get(_) =", indent2))
                |> fun sb -> sb.AppendLine(String.Format("{0}item", indent3))
                |> fun sb -> sb.ToString()
            
            state.CurSb
            |> fun sb -> sb.AppendLine()
            |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>{2} seq</code></summary>", indent, pathToType curPath, nextState.CurCodeSb.ToString()))
            |> fun sb -> sb.AppendLine(String.Format("{0}member this.{1} = {2}()", indent, curKey, pathToType curPath))
            |> ignore

            match state.Parent with
            | JsonValue.Array(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{0} seq", nextState.CurCodeSb.ToString())) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {0} seq", nextState.CurCodeSb.ToString())) |> ignore
            | _ ->
                state.CurCodeSb.Append(String.Format("; {0}:{1} seq", curKey, nextState.CurCodeSb.ToString())) |> ignore
            
            { state with CurSb = state.CurSb; CurCodeSb = state.CurCodeSb; Types = curType::nextState.Types }
        | JsonValue.String(_) ->
            let curPath = addPath state.ParentPath curKey

            state.CurSb
            |> fun sb -> sb.AppendLine()
            |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>string</code></summary>", indent, curKey))
            |> fun sb -> sb.AppendLine(String.Format("{0}member this.{1} = {2}()", indent, curKey, pathToType curPath))
            |> ignore

            match state.Parent with
            | JsonValue.Record(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{0}:string", curKey)) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {0}:string", curKey)) |> ignore
            | _ ->
                state.CurCodeSb.Append("string") |> ignore

            let curType =
                StringBuilder()
                |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>string</code></summary>", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}type {1}() =", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Set (o:string) =", indent))
                |> fun sb -> sb.AppendLine(String.Format("{0}send \"{1}\"", indent2, "##JSON##"))
                |> fun sb -> sb.ToString()

            { state with CurSb = state.CurSb; CurCodeSb = state.CurCodeSb; Types = curType::state.Types }
        | JsonValue.Float(_) ->
            let curPath = addPath state.ParentPath curKey

            state.CurSb
            |> fun sb -> sb.AppendLine()
            |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>float</code></summary>", indent, curKey))
            |> fun sb -> sb.AppendLine(String.Format("{0}member this.{1} = {2}()", indent, curKey, pathToType curPath))
            |> ignore

            match state.Parent with
            | JsonValue.Record(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{0}:float", curKey)) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {0}:float", curKey)) |> ignore
            | _ ->
                state.CurCodeSb.Append("float") |> ignore

            let curType =
                StringBuilder()
                |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>float</code></summary>", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}type {1}() =", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Set (o:float) =", indent))
                |> fun sb -> sb.AppendLine(String.Format("{0}send \"{1}\"", indent2, "##JSON##"))
                |> fun sb -> sb.ToString()

            { state with CurSb = state.CurSb; CurCodeSb = state.CurCodeSb; Types = curType::state.Types }
        | JsonValue.Number(_) ->
            let curPath = addPath state.ParentPath curKey

            state.CurSb
            |> fun sb -> sb.AppendLine()
            |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>int</code></summary>", indent, curKey))
            |> fun sb -> sb.AppendLine(String.Format("{0}member this.{1} = {2}()", indent, curKey, pathToType curPath))
            |> ignore

            match state.Parent with
            | JsonValue.Record(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{0}:int", curKey)) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {0}:int", curKey)) |> ignore
            | _ ->
                state.CurCodeSb.Append("int") |> ignore

            let curType =
                StringBuilder()
                |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>int</code></summary>", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}type {1}() =", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Set (o:int) =", indent))
                |> fun sb -> sb.AppendLine(String.Format("{0}send \"{1}\"", indent2, "##JSON##"))
                |> fun sb -> sb.ToString()

            { state with CurSb = state.CurSb; CurCodeSb = state.CurCodeSb; Types = curType::state.Types }
        | JsonValue.Boolean(_) ->
            let curPath = addPath state.ParentPath curKey

            state.CurSb
            |> fun sb -> sb.AppendLine()
            |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>bool</code></summary>", indent, curKey))
            |> fun sb -> sb.AppendLine(String.Format("{0}member this.{1} = {2}()", indent, curKey, pathToType curPath))
            |> ignore

            match state.Parent with
            | JsonValue.Record(_) ->
                if state.CurCodeSb.Length = 0 then
                    state.CurCodeSb.Append(String.Format("{0}:bool", curKey)) |> ignore
                else
                    state.CurCodeSb.Append(String.Format("; {0}:bool", curKey)) |> ignore
            | _ ->
                state.CurCodeSb.Append("bool") |> ignore

            let curType =
                StringBuilder()
                |> fun sb -> sb.AppendLine(String.Format("{0}///<summary>{1} : <code>bool</code></summary>", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}type {1}() =", baseIndent, pathToType curPath))
                |> fun sb -> sb.AppendLine(String.Format("{0}member this.Set (o:bool) =", indent))
                |> fun sb -> sb.AppendLine(String.Format("{0}send \"{1}\"", indent2, "##JSON##"))
                |> fun sb -> sb.ToString()

            { state with CurSb = state.CurSb; CurCodeSb = state.CurCodeSb; Types = curType::state.Types }
        | _ ->
            state

    let fig = JsonValue.Parse json

    let nextState = getTypes { ParentPath = []; Parent = fig; CurSb = StringBuilder(); CurCodeSb = StringBuilder("{{| "); Types = [] } ("figure",fig)
    let typeStr =
        nextState.Types
        |> List.rev
        |> List.fold (fun (sb:StringBuilder) s -> sb.AppendLine(s)) (StringBuilder())
        |> fun sb -> sb.ToString()

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
    let chartType = "HighCharts"
    let json = loadJson (sprintf "%s.json" chartType)

    //let json = "{\"title\":\"Title\",\"xaxis\":{\"name\":\"x\",\"font\":\"arial\"},\"range\":[0.0,10.0],\"data\":[[{\"t\":0,\"v\":0.0,\"point\":{\"name\":\"a1\"}},{\"t\":1,\"v\":1.0,\"point\":{\"name\":\"b1\"}}],[{\"t\":0,\"v\":2.0,\"point\":{\"name\":\"a2\"}},{\"t\":1,\"v\":3.0,\"point\":{\"name\":\"b2\"}}],[{\"t\":0,\"v\":4.0,\"point\":{\"name\":\"a3\"}},{\"t\":1,\"v\":5.0,\"point\":{\"name\":\"b3\"}}]],\"legend\":[{\"label\":\"one\"},{\"label\":\"two\"}]}"
    let fsStr = jsonToSchema (sprintf "FPlot.%s" chartType) "Figure" json

    printfn "Fsharp Code for %s:" chartType
    printfn "========\n"

    printfn "%s" fsStr
    storeSchema (sprintf "./%s.Figure.Test.fs" chartType) fsStr

    printfn "========\n"

    0
