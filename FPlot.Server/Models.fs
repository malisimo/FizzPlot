namespace FPlot.Models

type Operations =
    | Update
    | Fetch
    override x.ToString() =
        match x with
        | Update -> "update"
        | Fetch -> "fetch"

[<CLIMutable>]
type Message = {
    Operation : string
    Target : string
    Json : string
}