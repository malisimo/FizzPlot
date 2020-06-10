namespace FPlot.HighCharts

open FPlot.Common

module Figure =
    ///<summary>figure.xAxis.title : <code>{ text:string }</code></summary>
    type Figure_Xaxis_Title() =
        ///<summary>figure.xAxis.title.text : <code>string</code></summary>
        member this.text = {
            new IFigureElement with
                member this.GetJson() = "{\"xAxis\":{\"title\":{\"text\":##VALUE##}}}"
                member this.GetElementType() = ElementString
            }
        interface IFigureElement with
            member this.GetJson() = "{\"xAxis\":{\"title\":##VALUE##}}"
            member this.GetElementType() = ElementString

        override this.ToString() =
            sprintf "Figure_Xaxis_Title"
 
    
    ///<summary>figure.xAxis : <code>{ title:string, range:float [] }</code></summary>
    type Figure_Xaxis() =
        ///<summary>figure.xAxis.title : <code>{ text:string }</code></summary>
        member this.title = Figure_Xaxis_Title()

        ///<summary>figure.xAxis.range : <code>float []</code></summary>
        member this.range = {
            new IFigureElement with
                member this.GetJson() = "{\"xaxis\":{\"range\":##VALUE##}}"
                member this.GetElementType() = ElementString
            }

        interface IFigureElement with
            member this.GetJson() = "{\"xaxis\":##VALUE##}"
            member this.GetElementType() = ElementString

        override this.ToString() =
            sprintf "Figure_Xaxis"

    ///<summary>figure.title : <code>{ text:string }</code></summary>
    type Figure_Title() =
        ///<summary>figure.title.text : <code>string</code></summary>
        member val text = {
            new IFigureElement with
                member this.GetJson() = "{\"title\":{\"text\":##VALUE##}}"
                member this.GetElementType() = ElementString
            } with get,set
        interface IFigureElement with
            member this.GetJson() = "{\"title\":##VALUE##}"
            member this.GetElementType() = ElementString

        override this.ToString() =
            sprintf "Figure_Title"

    ///<summary>figure : <code>{ xAxis:{ title:string, range:float [] }, title:{ text:string } }</code></summary>
    type Figure() =
        ///<summary>figure.xAxis : <code>{ title:string, range:float [] }</code></summary>
        member this.xAxis = Figure_Xaxis()
        ///<summary>figure.title : <code>{ text:string }</code></summary>
        member this.title = Figure_Title()
        interface IFigureElement with
            member this.GetJson() = "{##VALUE##}"
            member this.GetElementType() = ElementString
