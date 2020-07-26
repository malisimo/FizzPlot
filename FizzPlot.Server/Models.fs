namespace FizzPlot.Models

type Operations =
    | Create
    | Add
    | Update
    | Delete
    | Fetch
    override x.ToString() =
        match x with
        | Create -> "create"
        | Add -> "add"
        | Update -> "update"
        | Delete -> "delete"
        | Fetch -> "fetch"

[<CLIMutable>]
type Message = {
    Operation : string
    ChartIndex : int
    Target : string
    Json : string
}