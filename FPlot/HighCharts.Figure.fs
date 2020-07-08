namespace FPlot.HighCharts


module Figure =
    type IFigureItem =
        abstract ParentPath : unit -> string

    type IFigureArray =
        abstract SetLastIndex : index:int -> unit

    open Server

    let mutable currentChartIndex = 0


    ///<summary>Figure_Colors_Item : <code>string</code></summary>
    type Figure_Colors_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"colors\\\":{\\\"item\\\":%s}}" (Figure_Colors_Item.ToJson o))

    ///<summary>Figure_Colors : <code>string seq</code></summary>
    type Figure_Colors() =
        let item = Figure_Colors_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Colors_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"colors\\\":%s}" (Figure_Colors.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Symbols_Item : <code>string</code></summary>
    type Figure_Symbols_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"symbols\\\":{\\\"item\\\":%s}}" (Figure_Symbols_Item.ToJson o))

    ///<summary>Figure_Symbols : <code>string seq</code></summary>
    type Figure_Symbols() =
        let item = Figure_Symbols_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Symbols_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"symbols\\\":%s}" (Figure_Symbols.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_Loading : <code>string</code></summary>
    type Figure_Lang_Loading() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"loading\\\":%s}}" (Figure_Lang_Loading.ToJson o))

    ///<summary>Figure_Lang_Months_Item : <code>string</code></summary>
    type Figure_Lang_Months_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"months\\\":{\\\"item\\\":%s}}}" (Figure_Lang_Months_Item.ToJson o))

    ///<summary>Figure_Lang_Months : <code>string seq</code></summary>
    type Figure_Lang_Months() =
        let item = Figure_Lang_Months_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Lang_Months_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"months\\\":%s}}" (Figure_Lang_Months.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_ShortMonths_Item : <code>string</code></summary>
    type Figure_Lang_ShortMonths_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"shortMonths\\\":{\\\"item\\\":%s}}}" (Figure_Lang_ShortMonths_Item.ToJson o))

    ///<summary>Figure_Lang_ShortMonths : <code>string seq</code></summary>
    type Figure_Lang_ShortMonths() =
        let item = Figure_Lang_ShortMonths_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Lang_ShortMonths_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"shortMonths\\\":%s}}" (Figure_Lang_ShortMonths.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_Weekdays_Item : <code>string</code></summary>
    type Figure_Lang_Weekdays_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"weekdays\\\":{\\\"item\\\":%s}}}" (Figure_Lang_Weekdays_Item.ToJson o))

    ///<summary>Figure_Lang_Weekdays : <code>string seq</code></summary>
    type Figure_Lang_Weekdays() =
        let item = Figure_Lang_Weekdays_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Lang_Weekdays_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"weekdays\\\":%s}}" (Figure_Lang_Weekdays.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_DecimalPoint : <code>string</code></summary>
    type Figure_Lang_DecimalPoint() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"decimalPoint\\\":%s}}" (Figure_Lang_DecimalPoint.ToJson o))

    ///<summary>Figure_Lang_NumericSymbols_Item : <code>string</code></summary>
    type Figure_Lang_NumericSymbols_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"numericSymbols\\\":{\\\"item\\\":%s}}}" (Figure_Lang_NumericSymbols_Item.ToJson o))

    ///<summary>Figure_Lang_NumericSymbols : <code>string seq</code></summary>
    type Figure_Lang_NumericSymbols() =
        let item = Figure_Lang_NumericSymbols_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Lang_NumericSymbols_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"numericSymbols\\\":%s}}" (Figure_Lang_NumericSymbols.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_ResetZoom : <code>string</code></summary>
    type Figure_Lang_ResetZoom() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"resetZoom\\\":%s}}" (Figure_Lang_ResetZoom.ToJson o))

    ///<summary>Figure_Lang_ResetZoomTitle : <code>string</code></summary>
    type Figure_Lang_ResetZoomTitle() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"resetZoomTitle\\\":%s}}" (Figure_Lang_ResetZoomTitle.ToJson o))

    ///<summary>Figure_Lang_ThousandsSep : <code>string</code></summary>
    type Figure_Lang_ThousandsSep() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"thousandsSep\\\":%s}}" (Figure_Lang_ThousandsSep.ToJson o))

    ///<summary>Figure_Lang_ViewFullscreen : <code>string</code></summary>
    type Figure_Lang_ViewFullscreen() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"viewFullscreen\\\":%s}}" (Figure_Lang_ViewFullscreen.ToJson o))

    ///<summary>Figure_Lang_ExitFullscreen : <code>string</code></summary>
    type Figure_Lang_ExitFullscreen() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"exitFullscreen\\\":%s}}" (Figure_Lang_ExitFullscreen.ToJson o))

    ///<summary>Figure_Lang_PrintChart : <code>string</code></summary>
    type Figure_Lang_PrintChart() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"printChart\\\":%s}}" (Figure_Lang_PrintChart.ToJson o))

    ///<summary>Figure_Lang_DownloadPNG : <code>string</code></summary>
    type Figure_Lang_DownloadPNG() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"downloadPNG\\\":%s}}" (Figure_Lang_DownloadPNG.ToJson o))

    ///<summary>Figure_Lang_DownloadJPEG : <code>string</code></summary>
    type Figure_Lang_DownloadJPEG() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"downloadJPEG\\\":%s}}" (Figure_Lang_DownloadJPEG.ToJson o))

    ///<summary>Figure_Lang_DownloadPDF : <code>string</code></summary>
    type Figure_Lang_DownloadPDF() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"downloadPDF\\\":%s}}" (Figure_Lang_DownloadPDF.ToJson o))

    ///<summary>Figure_Lang_DownloadSVG : <code>string</code></summary>
    type Figure_Lang_DownloadSVG() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"downloadSVG\\\":%s}}" (Figure_Lang_DownloadSVG.ToJson o))

    ///<summary>Figure_Lang_ContextButtonTitle : <code>string</code></summary>
    type Figure_Lang_ContextButtonTitle() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":{\\\"contextButtonTitle\\\":%s}}" (Figure_Lang_ContextButtonTitle.ToJson o))

    ///<summary>Figure_Lang : <code>{| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}</code></summary>
    type Figure_Lang() = 

        ///<summary>Figure_Lang_Loading : <code>string</code></summary>
        member this.loading = Figure_Lang_Loading()

        ///<summary>Figure_Lang_Months : <code>string seq</code></summary>
        member this.months = Figure_Lang_Months()

        ///<summary>Figure_Lang_ShortMonths : <code>string seq</code></summary>
        member this.shortMonths = Figure_Lang_ShortMonths()

        ///<summary>Figure_Lang_Weekdays : <code>string seq</code></summary>
        member this.weekdays = Figure_Lang_Weekdays()

        ///<summary>Figure_Lang_DecimalPoint : <code>string</code></summary>
        member this.decimalPoint = Figure_Lang_DecimalPoint()

        ///<summary>Figure_Lang_NumericSymbols : <code>string seq</code></summary>
        member this.numericSymbols = Figure_Lang_NumericSymbols()

        ///<summary>Figure_Lang_ResetZoom : <code>string</code></summary>
        member this.resetZoom = Figure_Lang_ResetZoom()

        ///<summary>Figure_Lang_ResetZoomTitle : <code>string</code></summary>
        member this.resetZoomTitle = Figure_Lang_ResetZoomTitle()

        ///<summary>Figure_Lang_ThousandsSep : <code>string</code></summary>
        member this.thousandsSep = Figure_Lang_ThousandsSep()

        ///<summary>Figure_Lang_ViewFullscreen : <code>string</code></summary>
        member this.viewFullscreen = Figure_Lang_ViewFullscreen()

        ///<summary>Figure_Lang_ExitFullscreen : <code>string</code></summary>
        member this.exitFullscreen = Figure_Lang_ExitFullscreen()

        ///<summary>Figure_Lang_PrintChart : <code>string</code></summary>
        member this.printChart = Figure_Lang_PrintChart()

        ///<summary>Figure_Lang_DownloadPNG : <code>string</code></summary>
        member this.downloadPNG = Figure_Lang_DownloadPNG()

        ///<summary>Figure_Lang_DownloadJPEG : <code>string</code></summary>
        member this.downloadJPEG = Figure_Lang_DownloadJPEG()

        ///<summary>Figure_Lang_DownloadPDF : <code>string</code></summary>
        member this.downloadPDF = Figure_Lang_DownloadPDF()

        ///<summary>Figure_Lang_DownloadSVG : <code>string</code></summary>
        member this.downloadSVG = Figure_Lang_DownloadSVG()

        ///<summary>Figure_Lang_ContextButtonTitle : <code>string</code></summary>
        member this.contextButtonTitle = Figure_Lang_ContextButtonTitle()
        static member ToJson (o:{| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}) =
            let loading = sprintf "\\\"%s\\\"" o.loading
            let months = Figure_Lang_Months.ToJson o.months
            let shortMonths = Figure_Lang_ShortMonths.ToJson o.shortMonths
            let weekdays = Figure_Lang_Weekdays.ToJson o.weekdays
            let decimalPoint = sprintf "\\\"%s\\\"" o.decimalPoint
            let numericSymbols = Figure_Lang_NumericSymbols.ToJson o.numericSymbols
            let resetZoom = sprintf "\\\"%s\\\"" o.resetZoom
            let resetZoomTitle = sprintf "\\\"%s\\\"" o.resetZoomTitle
            let thousandsSep = sprintf "\\\"%s\\\"" o.thousandsSep
            let viewFullscreen = sprintf "\\\"%s\\\"" o.viewFullscreen
            let exitFullscreen = sprintf "\\\"%s\\\"" o.exitFullscreen
            let printChart = sprintf "\\\"%s\\\"" o.printChart
            let downloadPNG = sprintf "\\\"%s\\\"" o.downloadPNG
            let downloadJPEG = sprintf "\\\"%s\\\"" o.downloadJPEG
            let downloadPDF = sprintf "\\\"%s\\\"" o.downloadPDF
            let downloadSVG = sprintf "\\\"%s\\\"" o.downloadSVG
            let contextButtonTitle = sprintf "\\\"%s\\\"" o.contextButtonTitle
            sprintf "{\\\"loading\\\":%s,\\\"months\\\":%s,\\\"shortMonths\\\":%s,\\\"weekdays\\\":%s,\\\"decimalPoint\\\":%s,\\\"numericSymbols\\\":%s,\\\"resetZoom\\\":%s,\\\"resetZoomTitle\\\":%s,\\\"thousandsSep\\\":%s,\\\"viewFullscreen\\\":%s,\\\"exitFullscreen\\\":%s,\\\"printChart\\\":%s,\\\"downloadPNG\\\":%s,\\\"downloadJPEG\\\":%s,\\\"downloadPDF\\\":%s,\\\"downloadSVG\\\":%s,\\\"contextButtonTitle\\\":%s}" loading months shortMonths weekdays decimalPoint numericSymbols resetZoom resetZoomTitle thousandsSep viewFullscreen exitFullscreen printChart downloadPNG downloadJPEG downloadPDF downloadSVG contextButtonTitle

        member this.Set (o:{| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}) =
            update currentChartIndex "" (sprintf "{\\\"lang\\\":%s}" (Figure_Lang.ToJson o))


    ///<summary>Figure_Global : <code>{| dummy:string |}</code></summary>
    type Figure_Global() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"global\\\":%s}" (Figure_Global.ToJson o))


    ///<summary>Figure_Time_TimezoneOffset : <code>int</code></summary>
    type Figure_Time_TimezoneOffset() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"time\\\":{\\\"timezoneOffset\\\":%s}}" (Figure_Time_TimezoneOffset.ToJson o))

    ///<summary>Figure_Time_UseUTC : <code>bool</code></summary>
    type Figure_Time_UseUTC() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"time\\\":{\\\"useUTC\\\":%s}}" (Figure_Time_UseUTC.ToJson o))

    ///<summary>Figure_Time : <code>{| timezoneOffset:int; useUTC:bool |}</code></summary>
    type Figure_Time() = 

        ///<summary>Figure_Time_TimezoneOffset : <code>int</code></summary>
        member this.timezoneOffset = Figure_Time_TimezoneOffset()

        ///<summary>Figure_Time_UseUTC : <code>bool</code></summary>
        member this.useUTC = Figure_Time_UseUTC()
        static member ToJson (o:{| timezoneOffset:int; useUTC:bool |}) =
            let timezoneOffset = sprintf "%i" o.timezoneOffset
            let useUTC = sprintf "%b" o.useUTC
            sprintf "{\\\"timezoneOffset\\\":%s,\\\"useUTC\\\":%s}" timezoneOffset useUTC

        member this.Set (o:{| timezoneOffset:int; useUTC:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"time\\\":%s}" (Figure_Time.ToJson o))


    ///<summary>Figure_Chart_StyledMode : <code>bool</code></summary>
    type Figure_Chart_StyledMode() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"styledMode\\\":%s}}" (Figure_Chart_StyledMode.ToJson o))

    ///<summary>Figure_Chart_BorderRadius : <code>int</code></summary>
    type Figure_Chart_BorderRadius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"borderRadius\\\":%s}}" (Figure_Chart_BorderRadius.ToJson o))

    ///<summary>Figure_Chart_ColorCount : <code>int</code></summary>
    type Figure_Chart_ColorCount() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"colorCount\\\":%s}}" (Figure_Chart_ColorCount.ToJson o))

    ///<summary>Figure_Chart_DefaultSeriesType : <code>string</code></summary>
    type Figure_Chart_DefaultSeriesType() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"defaultSeriesType\\\":%s}}" (Figure_Chart_DefaultSeriesType.ToJson o))

    ///<summary>Figure_Chart_IgnoreHiddenSeries : <code>bool</code></summary>
    type Figure_Chart_IgnoreHiddenSeries() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"ignoreHiddenSeries\\\":%s}}" (Figure_Chart_IgnoreHiddenSeries.ToJson o))

    ///<summary>Figure_Chart_Spacing_Item : <code>int</code></summary>
    type Figure_Chart_Spacing_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"spacing\\\":{\\\"item\\\":%s}}}" (Figure_Chart_Spacing_Item.ToJson o))

    ///<summary>Figure_Chart_Spacing : <code>int seq</code></summary>
    type Figure_Chart_Spacing() =
        let item = Figure_Chart_Spacing_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Chart_Spacing_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"spacing\\\":%s}}" (Figure_Chart_Spacing.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Chart_ResetZoomButton_Theme_ZIndex : <code>int</code></summary>
    type Figure_Chart_ResetZoomButton_Theme_ZIndex() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":{\\\"theme\\\":{\\\"zIndex\\\":%s}}}}" (Figure_Chart_ResetZoomButton_Theme_ZIndex.ToJson o))

    ///<summary>Figure_Chart_ResetZoomButton_Theme : <code>{| zIndex:int |}</code></summary>
    type Figure_Chart_ResetZoomButton_Theme() = 

        ///<summary>Figure_Chart_ResetZoomButton_Theme_ZIndex : <code>int</code></summary>
        member this.zIndex = Figure_Chart_ResetZoomButton_Theme_ZIndex()
        static member ToJson (o:{| zIndex:int |}) =
            let zIndex = sprintf "%i" o.zIndex
            sprintf "{\\\"zIndex\\\":%s}" zIndex

        member this.Set (o:{| zIndex:int |}) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":{\\\"theme\\\":%s}}}" (Figure_Chart_ResetZoomButton_Theme.ToJson o))


    ///<summary>Figure_Chart_ResetZoomButton_Position_Align : <code>string</code></summary>
    type Figure_Chart_ResetZoomButton_Position_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":{\\\"position\\\":{\\\"align\\\":%s}}}}" (Figure_Chart_ResetZoomButton_Position_Align.ToJson o))

    ///<summary>Figure_Chart_ResetZoomButton_Position_X : <code>int</code></summary>
    type Figure_Chart_ResetZoomButton_Position_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":{\\\"position\\\":{\\\"x\\\":%s}}}}" (Figure_Chart_ResetZoomButton_Position_X.ToJson o))

    ///<summary>Figure_Chart_ResetZoomButton_Position_Y : <code>int</code></summary>
    type Figure_Chart_ResetZoomButton_Position_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":{\\\"position\\\":{\\\"y\\\":%s}}}}" (Figure_Chart_ResetZoomButton_Position_Y.ToJson o))

    ///<summary>Figure_Chart_ResetZoomButton_Position : <code>{| align:string; x:int; y:int |}</code></summary>
    type Figure_Chart_ResetZoomButton_Position() = 

        ///<summary>Figure_Chart_ResetZoomButton_Position_Align : <code>string</code></summary>
        member this.align = Figure_Chart_ResetZoomButton_Position_Align()

        ///<summary>Figure_Chart_ResetZoomButton_Position_X : <code>int</code></summary>
        member this.x = Figure_Chart_ResetZoomButton_Position_X()

        ///<summary>Figure_Chart_ResetZoomButton_Position_Y : <code>int</code></summary>
        member this.y = Figure_Chart_ResetZoomButton_Position_Y()
        static member ToJson (o:{| align:string; x:int; y:int |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            sprintf "{\\\"align\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s}" align x y

        member this.Set (o:{| align:string; x:int; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":{\\\"position\\\":%s}}}" (Figure_Chart_ResetZoomButton_Position.ToJson o))


    ///<summary>Figure_Chart_ResetZoomButton : <code>{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}</code></summary>
    type Figure_Chart_ResetZoomButton() = 

        ///<summary>Figure_Chart_ResetZoomButton_Theme : <code>{| zIndex:int |}</code></summary>
        member this.theme = Figure_Chart_ResetZoomButton_Theme()

        ///<summary>Figure_Chart_ResetZoomButton_Position : <code>{| align:string; x:int; y:int |}</code></summary>
        member this.position = Figure_Chart_ResetZoomButton_Position()
        static member ToJson (o:{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}) =
            let theme = Figure_Chart_ResetZoomButton_Theme.ToJson o.theme
            let position = Figure_Chart_ResetZoomButton_Position.ToJson o.position
            sprintf "{\\\"theme\\\":%s,\\\"position\\\":%s}" theme position

        member this.Set (o:{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"resetZoomButton\\\":%s}}" (Figure_Chart_ResetZoomButton.ToJson o))


    ///<summary>Figure_Chart_Width : <code>float</code></summary>
    type Figure_Chart_Width() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"width\\\":%s}}" (Figure_Chart_Width.ToJson o))

    ///<summary>Figure_Chart_Height : <code>float</code></summary>
    type Figure_Chart_Height() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"height\\\":%s}}" (Figure_Chart_Height.ToJson o))

    ///<summary>Figure_Chart_BorderColor : <code>string</code></summary>
    type Figure_Chart_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"borderColor\\\":%s}}" (Figure_Chart_BorderColor.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}" (Figure_Chart_BackgroundColor_LinearGradient_X1.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}" (Figure_Chart_BackgroundColor_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}" (Figure_Chart_BackgroundColor_LinearGradient_X2.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}" (Figure_Chart_BackgroundColor_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Id : <code>string</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_Id() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"linearGradient\\\":{\\\"id\\\":%s}}}}" (Figure_Chart_BackgroundColor_LinearGradient_Id.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int; id:string |}</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient() = 

        ///<summary>Figure_Chart_BackgroundColor_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_Chart_BackgroundColor_LinearGradient_X1()

        ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_Chart_BackgroundColor_LinearGradient_Y1()

        ///<summary>Figure_Chart_BackgroundColor_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_Chart_BackgroundColor_LinearGradient_X2()

        ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_Chart_BackgroundColor_LinearGradient_Y2()

        ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Id : <code>string</code></summary>
        member this.id = Figure_Chart_BackgroundColor_LinearGradient_Id()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int; id:string |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            let id = sprintf "\\\"%s\\\"" o.id
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s,\\\"id\\\":%s}" x1 y1 x2 y2 id

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int; id:string |}) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"linearGradient\\\":%s}}}" (Figure_Chart_BackgroundColor_LinearGradient.ToJson o))


    ///<summary>Figure_Chart_BackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}" (Figure_Chart_BackgroundColor_Stops_Item_Item.ToJson o))

    ///<summary>Figure_Chart_BackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Chart_BackgroundColor_Stops_Item() =
        let item = Figure_Chart_BackgroundColor_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Chart_BackgroundColor_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}" (Figure_Chart_BackgroundColor_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Chart_BackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Chart_BackgroundColor_Stops() =
        let item = Figure_Chart_BackgroundColor_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Chart_BackgroundColor_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":{\\\"stops\\\":%s}}}" (Figure_Chart_BackgroundColor_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Chart_BackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}</code></summary>
    type Figure_Chart_BackgroundColor() = 

        ///<summary>Figure_Chart_BackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int; id:string |}</code></summary>
        member this.linearGradient = Figure_Chart_BackgroundColor_LinearGradient()

        ///<summary>Figure_Chart_BackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Chart_BackgroundColor_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}) =
            let linearGradient = Figure_Chart_BackgroundColor_LinearGradient.ToJson o.linearGradient
            let stops = Figure_Chart_BackgroundColor_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"backgroundColor\\\":%s}}" (Figure_Chart_BackgroundColor.ToJson o))


    ///<summary>Figure_Chart_PlotBorderColor : <code>string</code></summary>
    type Figure_Chart_PlotBorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"plotBorderColor\\\":%s}}" (Figure_Chart_PlotBorderColor.ToJson o))

    ///<summary>Figure_Chart_BorderWidth : <code>int</code></summary>
    type Figure_Chart_BorderWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"borderWidth\\\":%s}}" (Figure_Chart_BorderWidth.ToJson o))

    ///<summary>Figure_Chart_ClassName : <code>string</code></summary>
    type Figure_Chart_ClassName() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"className\\\":%s}}" (Figure_Chart_ClassName.ToJson o))

    ///<summary>Figure_Chart_PlotBackgroundColor : <code>string</code></summary>
    type Figure_Chart_PlotBackgroundColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"plotBackgroundColor\\\":%s}}" (Figure_Chart_PlotBackgroundColor.ToJson o))

    ///<summary>Figure_Chart_PlotBorderWidth : <code>int</code></summary>
    type Figure_Chart_PlotBorderWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":{\\\"plotBorderWidth\\\":%s}}" (Figure_Chart_PlotBorderWidth.ToJson o))

    ///<summary>Figure_Chart : <code>{| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}</code></summary>
    type Figure_Chart() = 

        ///<summary>Figure_Chart_StyledMode : <code>bool</code></summary>
        member this.styledMode = Figure_Chart_StyledMode()

        ///<summary>Figure_Chart_BorderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_Chart_BorderRadius()

        ///<summary>Figure_Chart_ColorCount : <code>int</code></summary>
        member this.colorCount = Figure_Chart_ColorCount()

        ///<summary>Figure_Chart_DefaultSeriesType : <code>string</code></summary>
        member this.defaultSeriesType = Figure_Chart_DefaultSeriesType()

        ///<summary>Figure_Chart_IgnoreHiddenSeries : <code>bool</code></summary>
        member this.ignoreHiddenSeries = Figure_Chart_IgnoreHiddenSeries()

        ///<summary>Figure_Chart_Spacing : <code>int seq</code></summary>
        member this.spacing = Figure_Chart_Spacing()

        ///<summary>Figure_Chart_ResetZoomButton : <code>{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}</code></summary>
        member this.resetZoomButton = Figure_Chart_ResetZoomButton()

        ///<summary>Figure_Chart_Width : <code>float</code></summary>
        member this.width = Figure_Chart_Width()

        ///<summary>Figure_Chart_Height : <code>float</code></summary>
        member this.height = Figure_Chart_Height()

        ///<summary>Figure_Chart_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_Chart_BorderColor()

        ///<summary>Figure_Chart_BackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}</code></summary>
        member this.backgroundColor = Figure_Chart_BackgroundColor()

        ///<summary>Figure_Chart_PlotBorderColor : <code>string</code></summary>
        member this.plotBorderColor = Figure_Chart_PlotBorderColor()

        ///<summary>Figure_Chart_BorderWidth : <code>int</code></summary>
        member this.borderWidth = Figure_Chart_BorderWidth()

        ///<summary>Figure_Chart_ClassName : <code>string</code></summary>
        member this.className = Figure_Chart_ClassName()

        ///<summary>Figure_Chart_PlotBackgroundColor : <code>string</code></summary>
        member this.plotBackgroundColor = Figure_Chart_PlotBackgroundColor()

        ///<summary>Figure_Chart_PlotBorderWidth : <code>int</code></summary>
        member this.plotBorderWidth = Figure_Chart_PlotBorderWidth()
        static member ToJson (o:{| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}) =
            let styledMode = sprintf "%b" o.styledMode
            let borderRadius = sprintf "%i" o.borderRadius
            let colorCount = sprintf "%i" o.colorCount
            let defaultSeriesType = sprintf "\\\"%s\\\"" o.defaultSeriesType
            let ignoreHiddenSeries = sprintf "%b" o.ignoreHiddenSeries
            let spacing = Figure_Chart_Spacing.ToJson o.spacing
            let resetZoomButton = Figure_Chart_ResetZoomButton.ToJson o.resetZoomButton
            let width = sprintf "%f" o.width
            let height = sprintf "%f" o.height
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            let backgroundColor = Figure_Chart_BackgroundColor.ToJson o.backgroundColor
            let plotBorderColor = sprintf "\\\"%s\\\"" o.plotBorderColor
            let borderWidth = sprintf "%i" o.borderWidth
            let className = sprintf "\\\"%s\\\"" o.className
            let plotBackgroundColor = sprintf "\\\"%s\\\"" o.plotBackgroundColor
            let plotBorderWidth = sprintf "%i" o.plotBorderWidth
            sprintf "{\\\"styledMode\\\":%s,\\\"borderRadius\\\":%s,\\\"colorCount\\\":%s,\\\"defaultSeriesType\\\":%s,\\\"ignoreHiddenSeries\\\":%s,\\\"spacing\\\":%s,\\\"resetZoomButton\\\":%s,\\\"width\\\":%s,\\\"height\\\":%s,\\\"borderColor\\\":%s,\\\"backgroundColor\\\":%s,\\\"plotBorderColor\\\":%s,\\\"borderWidth\\\":%s,\\\"className\\\":%s,\\\"plotBackgroundColor\\\":%s,\\\"plotBorderWidth\\\":%s}" styledMode borderRadius colorCount defaultSeriesType ignoreHiddenSeries spacing resetZoomButton width height borderColor backgroundColor plotBorderColor borderWidth className plotBackgroundColor plotBorderWidth

        member this.Set (o:{| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"chart\\\":%s}" (Figure_Chart.ToJson o))


    ///<summary>Figure_Title_Style_Color : <code>string</code></summary>
    type Figure_Title_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"style\\\":{\\\"color\\\":%s}}}" (Figure_Title_Style_Color.ToJson o))

    ///<summary>Figure_Title_Style_FontSize : <code>string</code></summary>
    type Figure_Title_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}" (Figure_Title_Style_FontSize.ToJson o))

    ///<summary>Figure_Title_Style_Font : <code>string</code></summary>
    type Figure_Title_Style_Font() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"style\\\":{\\\"font\\\":%s}}}" (Figure_Title_Style_Font.ToJson o))

    ///<summary>Figure_Title_Style_Fill : <code>string</code></summary>
    type Figure_Title_Style_Fill() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"style\\\":{\\\"fill\\\":%s}}}" (Figure_Title_Style_Fill.ToJson o))

    ///<summary>Figure_Title_Style_Width : <code>string</code></summary>
    type Figure_Title_Style_Width() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"style\\\":{\\\"width\\\":%s}}}" (Figure_Title_Style_Width.ToJson o))

    ///<summary>Figure_Title_Style : <code>{| color:string; fontSize:string; font:string; fill:string; width:string |}</code></summary>
    type Figure_Title_Style() = 

        ///<summary>Figure_Title_Style_Color : <code>string</code></summary>
        member this.color = Figure_Title_Style_Color()

        ///<summary>Figure_Title_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_Title_Style_FontSize()

        ///<summary>Figure_Title_Style_Font : <code>string</code></summary>
        member this.font = Figure_Title_Style_Font()

        ///<summary>Figure_Title_Style_Fill : <code>string</code></summary>
        member this.fill = Figure_Title_Style_Fill()

        ///<summary>Figure_Title_Style_Width : <code>string</code></summary>
        member this.width = Figure_Title_Style_Width()
        static member ToJson (o:{| color:string; fontSize:string; font:string; fill:string; width:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let font = sprintf "\\\"%s\\\"" o.font
            let fill = sprintf "\\\"%s\\\"" o.fill
            let width = sprintf "\\\"%s\\\"" o.width
            sprintf "{\\\"color\\\":%s,\\\"fontSize\\\":%s,\\\"font\\\":%s,\\\"fill\\\":%s,\\\"width\\\":%s}" color fontSize font fill width

        member this.Set (o:{| color:string; fontSize:string; font:string; fill:string; width:string |}) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"style\\\":%s}}" (Figure_Title_Style.ToJson o))


    ///<summary>Figure_Title_Text : <code>string</code></summary>
    type Figure_Title_Text() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"text\\\":%s}}" (Figure_Title_Text.ToJson o))

    ///<summary>Figure_Title_Align : <code>string</code></summary>
    type Figure_Title_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"align\\\":%s}}" (Figure_Title_Align.ToJson o))

    ///<summary>Figure_Title_Margin : <code>int</code></summary>
    type Figure_Title_Margin() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"margin\\\":%s}}" (Figure_Title_Margin.ToJson o))

    ///<summary>Figure_Title_WidthAdjust : <code>int</code></summary>
    type Figure_Title_WidthAdjust() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":{\\\"widthAdjust\\\":%s}}" (Figure_Title_WidthAdjust.ToJson o))

    ///<summary>Figure_Title : <code>{| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}</code></summary>
    type Figure_Title() = 

        ///<summary>Figure_Title_Style : <code>{| color:string; fontSize:string; font:string; fill:string; width:string |}</code></summary>
        member this.style = Figure_Title_Style()

        ///<summary>Figure_Title_Text : <code>string</code></summary>
        member this.text = Figure_Title_Text()

        ///<summary>Figure_Title_Align : <code>string</code></summary>
        member this.align = Figure_Title_Align()

        ///<summary>Figure_Title_Margin : <code>int</code></summary>
        member this.margin = Figure_Title_Margin()

        ///<summary>Figure_Title_WidthAdjust : <code>int</code></summary>
        member this.widthAdjust = Figure_Title_WidthAdjust()
        static member ToJson (o:{| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}) =
            let style = Figure_Title_Style.ToJson o.style
            let text = sprintf "\\\"%s\\\"" o.text
            let align = sprintf "\\\"%s\\\"" o.align
            let margin = sprintf "%i" o.margin
            let widthAdjust = sprintf "%i" o.widthAdjust
            sprintf "{\\\"style\\\":%s,\\\"text\\\":%s,\\\"align\\\":%s,\\\"margin\\\":%s,\\\"widthAdjust\\\":%s}" style text align margin widthAdjust

        member this.Set (o:{| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}) =
            update currentChartIndex "" (sprintf "{\\\"title\\\":%s}" (Figure_Title.ToJson o))


    ///<summary>Figure_Subtitle_Style_Color : <code>string</code></summary>
    type Figure_Subtitle_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"style\\\":{\\\"color\\\":%s}}}" (Figure_Subtitle_Style_Color.ToJson o))

    ///<summary>Figure_Subtitle_Style_Font : <code>string</code></summary>
    type Figure_Subtitle_Style_Font() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"style\\\":{\\\"font\\\":%s}}}" (Figure_Subtitle_Style_Font.ToJson o))

    ///<summary>Figure_Subtitle_Style_Fill : <code>string</code></summary>
    type Figure_Subtitle_Style_Fill() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"style\\\":{\\\"fill\\\":%s}}}" (Figure_Subtitle_Style_Fill.ToJson o))

    ///<summary>Figure_Subtitle_Style_Width : <code>string</code></summary>
    type Figure_Subtitle_Style_Width() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"style\\\":{\\\"width\\\":%s}}}" (Figure_Subtitle_Style_Width.ToJson o))

    ///<summary>Figure_Subtitle_Style : <code>{| color:string; font:string; fill:string; width:string |}</code></summary>
    type Figure_Subtitle_Style() = 

        ///<summary>Figure_Subtitle_Style_Color : <code>string</code></summary>
        member this.color = Figure_Subtitle_Style_Color()

        ///<summary>Figure_Subtitle_Style_Font : <code>string</code></summary>
        member this.font = Figure_Subtitle_Style_Font()

        ///<summary>Figure_Subtitle_Style_Fill : <code>string</code></summary>
        member this.fill = Figure_Subtitle_Style_Fill()

        ///<summary>Figure_Subtitle_Style_Width : <code>string</code></summary>
        member this.width = Figure_Subtitle_Style_Width()
        static member ToJson (o:{| color:string; font:string; fill:string; width:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let font = sprintf "\\\"%s\\\"" o.font
            let fill = sprintf "\\\"%s\\\"" o.fill
            let width = sprintf "\\\"%s\\\"" o.width
            sprintf "{\\\"color\\\":%s,\\\"font\\\":%s,\\\"fill\\\":%s,\\\"width\\\":%s}" color font fill width

        member this.Set (o:{| color:string; font:string; fill:string; width:string |}) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"style\\\":%s}}" (Figure_Subtitle_Style.ToJson o))


    ///<summary>Figure_Subtitle_Text : <code>string</code></summary>
    type Figure_Subtitle_Text() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"text\\\":%s}}" (Figure_Subtitle_Text.ToJson o))

    ///<summary>Figure_Subtitle_Align : <code>string</code></summary>
    type Figure_Subtitle_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"align\\\":%s}}" (Figure_Subtitle_Align.ToJson o))

    ///<summary>Figure_Subtitle_WidthAdjust : <code>int</code></summary>
    type Figure_Subtitle_WidthAdjust() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":{\\\"widthAdjust\\\":%s}}" (Figure_Subtitle_WidthAdjust.ToJson o))

    ///<summary>Figure_Subtitle : <code>{| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}</code></summary>
    type Figure_Subtitle() = 

        ///<summary>Figure_Subtitle_Style : <code>{| color:string; font:string; fill:string; width:string |}</code></summary>
        member this.style = Figure_Subtitle_Style()

        ///<summary>Figure_Subtitle_Text : <code>string</code></summary>
        member this.text = Figure_Subtitle_Text()

        ///<summary>Figure_Subtitle_Align : <code>string</code></summary>
        member this.align = Figure_Subtitle_Align()

        ///<summary>Figure_Subtitle_WidthAdjust : <code>int</code></summary>
        member this.widthAdjust = Figure_Subtitle_WidthAdjust()
        static member ToJson (o:{| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}) =
            let style = Figure_Subtitle_Style.ToJson o.style
            let text = sprintf "\\\"%s\\\"" o.text
            let align = sprintf "\\\"%s\\\"" o.align
            let widthAdjust = sprintf "%i" o.widthAdjust
            sprintf "{\\\"style\\\":%s,\\\"text\\\":%s,\\\"align\\\":%s,\\\"widthAdjust\\\":%s}" style text align widthAdjust

        member this.Set (o:{| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}) =
            update currentChartIndex "" (sprintf "{\\\"subtitle\\\":%s}" (Figure_Subtitle.ToJson o))


    ///<summary>Figure_Caption_Style_Color : <code>string</code></summary>
    type Figure_Caption_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"style\\\":{\\\"color\\\":%s}}}" (Figure_Caption_Style_Color.ToJson o))

    ///<summary>Figure_Caption_Style_Fill : <code>string</code></summary>
    type Figure_Caption_Style_Fill() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"style\\\":{\\\"fill\\\":%s}}}" (Figure_Caption_Style_Fill.ToJson o))

    ///<summary>Figure_Caption_Style_Width : <code>string</code></summary>
    type Figure_Caption_Style_Width() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"style\\\":{\\\"width\\\":%s}}}" (Figure_Caption_Style_Width.ToJson o))

    ///<summary>Figure_Caption_Style : <code>{| color:string; fill:string; width:string |}</code></summary>
    type Figure_Caption_Style() = 

        ///<summary>Figure_Caption_Style_Color : <code>string</code></summary>
        member this.color = Figure_Caption_Style_Color()

        ///<summary>Figure_Caption_Style_Fill : <code>string</code></summary>
        member this.fill = Figure_Caption_Style_Fill()

        ///<summary>Figure_Caption_Style_Width : <code>string</code></summary>
        member this.width = Figure_Caption_Style_Width()
        static member ToJson (o:{| color:string; fill:string; width:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let fill = sprintf "\\\"%s\\\"" o.fill
            let width = sprintf "\\\"%s\\\"" o.width
            sprintf "{\\\"color\\\":%s,\\\"fill\\\":%s,\\\"width\\\":%s}" color fill width

        member this.Set (o:{| color:string; fill:string; width:string |}) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"style\\\":%s}}" (Figure_Caption_Style.ToJson o))


    ///<summary>Figure_Caption_Margin : <code>int</code></summary>
    type Figure_Caption_Margin() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"margin\\\":%s}}" (Figure_Caption_Margin.ToJson o))

    ///<summary>Figure_Caption_Text : <code>string</code></summary>
    type Figure_Caption_Text() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"text\\\":%s}}" (Figure_Caption_Text.ToJson o))

    ///<summary>Figure_Caption_Align : <code>string</code></summary>
    type Figure_Caption_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"align\\\":%s}}" (Figure_Caption_Align.ToJson o))

    ///<summary>Figure_Caption_VerticalAlign : <code>string</code></summary>
    type Figure_Caption_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":{\\\"verticalAlign\\\":%s}}" (Figure_Caption_VerticalAlign.ToJson o))

    ///<summary>Figure_Caption : <code>{| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}</code></summary>
    type Figure_Caption() = 

        ///<summary>Figure_Caption_Style : <code>{| color:string; fill:string; width:string |}</code></summary>
        member this.style = Figure_Caption_Style()

        ///<summary>Figure_Caption_Margin : <code>int</code></summary>
        member this.margin = Figure_Caption_Margin()

        ///<summary>Figure_Caption_Text : <code>string</code></summary>
        member this.text = Figure_Caption_Text()

        ///<summary>Figure_Caption_Align : <code>string</code></summary>
        member this.align = Figure_Caption_Align()

        ///<summary>Figure_Caption_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Caption_VerticalAlign()
        static member ToJson (o:{| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}) =
            let style = Figure_Caption_Style.ToJson o.style
            let margin = sprintf "%i" o.margin
            let text = sprintf "\\\"%s\\\"" o.text
            let align = sprintf "\\\"%s\\\"" o.align
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            sprintf "{\\\"style\\\":%s,\\\"margin\\\":%s,\\\"text\\\":%s,\\\"align\\\":%s,\\\"verticalAlign\\\":%s}" style margin text align verticalAlign

        member this.Set (o:{| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}) =
            update currentChartIndex "" (sprintf "{\\\"caption\\\":%s}" (Figure_Caption.ToJson o))


    ///<summary>Figure_PlotOptions_Line_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Line_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Line_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Line_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Line_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Line_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Line_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Line_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Line_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Line_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Line_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Line_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_Animation() = 

        ///<summary>Figure_PlotOptions_Line_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Line_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Line_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Line_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_EnabledThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"enabledThreshold\\\":%s}}}}" (Figure_PlotOptions_Line_Marker_EnabledThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Line_Marker_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"lineColor\\\":%s}}}}" (Figure_PlotOptions_Line_Marker_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"lineWidth\\\":%s}}}}" (Figure_PlotOptions_Line_Marker_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_Radius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"radius\\\":%s}}}}" (Figure_PlotOptions_Line_Marker_Radius.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Normal() = 

        ///<summary>Figure_PlotOptions_Line_Marker_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Line_Marker_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}}" (Figure_PlotOptions_Line_Marker_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}}" (Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"enabled\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Hover_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"radiusPlus\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover() = 

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_Marker_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Line_Marker_States_Hover_Enabled()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus()
        static member ToJson (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            let animation = Figure_PlotOptions_Line_Marker_States_Hover_Animation.ToJson o.animation
            let enabled = sprintf "%b" o.enabled
            let radiusPlus = sprintf "%i" o.radiusPlus
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            sprintf "{\\\"animation\\\":%s,\\\"enabled\\\":%s,\\\"radiusPlus\\\":%s,\\\"lineWidthPlus\\\":%s}" animation enabled radiusPlus lineWidthPlus

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}}" (Figure_PlotOptions_Line_Marker_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select_FillColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fillColor\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Select_FillColor.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineColor\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Select_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineWidth\\\":%s}}}}}}" (Figure_PlotOptions_Line_Marker_States_Select_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select() = 

        ///<summary>Figure_PlotOptions_Line_Marker_States_Select_FillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Line_Marker_States_Select_FillColor()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Select_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Line_Marker_States_Select_LineColor()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Select_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Line_Marker_States_Select_LineWidth()
        static member ToJson (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            let fillColor = sprintf "\\\"%s\\\"" o.fillColor
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            sprintf "{\\\"fillColor\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s}" fillColor lineColor lineWidth

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}}" (Figure_PlotOptions_Line_Marker_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States() = 

        ///<summary>Figure_PlotOptions_Line_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Line_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Line_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Line_Marker_States_Select()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            let normal = Figure_PlotOptions_Line_Marker_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Line_Marker_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Line_Marker_States_Select.ToJson o.select
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s}" normal hover select

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":{\\\"states\\\":%s}}}}" (Figure_PlotOptions_Line_Marker_States.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Line_Marker() = 

        ///<summary>Figure_PlotOptions_Line_Marker_EnabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Line_Marker_EnabledThreshold()

        ///<summary>Figure_PlotOptions_Line_Marker_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Line_Marker_LineColor()

        ///<summary>Figure_PlotOptions_Line_Marker_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Line_Marker_LineWidth()

        ///<summary>Figure_PlotOptions_Line_Marker_Radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Line_Marker_Radius()

        ///<summary>Figure_PlotOptions_Line_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Line_Marker_States()
        static member ToJson (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            let enabledThreshold = sprintf "%i" o.enabledThreshold
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            let radius = sprintf "%i" o.radius
            let states = Figure_PlotOptions_Line_Marker_States.ToJson o.states
            sprintf "{\\\"enabledThreshold\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s,\\\"radius\\\":%s,\\\"states\\\":%s}" enabledThreshold lineColor lineWidth radius states

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Line_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Line_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Line_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Line_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Line_Point() = 

        ///<summary>Figure_PlotOptions_Line_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Line_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Line_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Line_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Line_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"align\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_Align.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Line_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Line_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Line_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Line_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Line_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Line_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Line_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Line_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Line_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Line_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"verticalAlign\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_VerticalAlign.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Line_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels_Color : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":{\\\"color\\\":%s}}}}" (Figure_PlotOptions_Line_DataLabels_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Line_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}</code></summary>
    type Figure_PlotOptions_Line_DataLabels() = 

        ///<summary>Figure_PlotOptions_Line_DataLabels_Align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Line_DataLabels_Align()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Line_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Line_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Line_DataLabels_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Line_DataLabels_VerticalAlign()

        ///<summary>Figure_PlotOptions_Line_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Line_DataLabels_X()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Line_DataLabels_Y()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Line_DataLabels_Color()
        static member ToJson (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Line_DataLabels_Style.ToJson o.style
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"align\\\":%s,\\\"padding\\\":%s,\\\"style\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s,\\\"color\\\":%s}" align padding style verticalAlign x y color

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Line_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Line_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Line_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Line_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Line_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Line_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Line_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Line_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Line_PointRange() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Line_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Line_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Line_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Line_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Line_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Line_States_Normal() = 

        ///<summary>Figure_PlotOptions_Line_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Line_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Line_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Line_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Halo_Size() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"size\\\":%s}}}}}}" (Figure_PlotOptions_Line_States_Hover_Halo_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Halo_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"opacity\\\":%s}}}}}}" (Figure_PlotOptions_Line_States_Hover_Halo_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Halo() = 

        ///<summary>Figure_PlotOptions_Line_States_Hover_Halo_Size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Line_States_Hover_Halo_Size()

        ///<summary>Figure_PlotOptions_Line_States_Hover_Halo_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Line_States_Hover_Halo_Opacity()
        static member ToJson (o:{| size:int; opacity:int |}) =
            let size = sprintf "%i" o.size
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"size\\\":%s,\\\"opacity\\\":%s}" size opacity

        member this.Set (o:{| size:int; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Hover_Halo.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover() = 

        ///<summary>Figure_PlotOptions_Line_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Line_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Line_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Line_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Line_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Line_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Line_States_Hover_Halo()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            let animation = Figure_PlotOptions_Line_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Line_States_Hover_Marker.ToJson o.marker
            let halo = Figure_PlotOptions_Line_States_Hover_Halo.ToJson o.halo
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s}" animation lineWidthPlus marker halo

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Line_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Line_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Line_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Line_States_Select() = 

        ///<summary>Figure_PlotOptions_Line_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Select_Animation()
        static member ToJson (o:{| animation: {| duration:int |} |}) =
            let animation = Figure_PlotOptions_Line_States_Select_Animation.ToJson o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation: {| duration:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Line_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Line_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Line_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Line_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Line_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Line_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Line_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Line_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Line_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Line_States() = 

        ///<summary>Figure_PlotOptions_Line_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Line_States_Normal()

        ///<summary>Figure_PlotOptions_Line_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
        member this.hover = Figure_PlotOptions_Line_States_Hover()

        ///<summary>Figure_PlotOptions_Line_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
        member this.select = Figure_PlotOptions_Line_States_Select()

        ///<summary>Figure_PlotOptions_Line_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Line_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Line_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Line_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Line_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Line_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Line_States.ToJson o))


    ///<summary>Figure_PlotOptions_Line_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Line_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Line_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Line_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Line_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Line_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Line_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Line_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Line_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Line : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}</code></summary>
    type Figure_PlotOptions_Line() = 

        ///<summary>Figure_PlotOptions_Line_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Line_LineWidth()

        ///<summary>Figure_PlotOptions_Line_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Line_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Line_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Line_Crisp()

        ///<summary>Figure_PlotOptions_Line_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Line_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Line_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_Animation()

        ///<summary>Figure_PlotOptions_Line_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Line_Events()

        ///<summary>Figure_PlotOptions_Line_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
        member this.marker = Figure_PlotOptions_Line_Marker()

        ///<summary>Figure_PlotOptions_Line_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Line_Point()

        ///<summary>Figure_PlotOptions_Line_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Line_DataLabels()

        ///<summary>Figure_PlotOptions_Line_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Line_CropThreshold()

        ///<summary>Figure_PlotOptions_Line_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Line_Opacity()

        ///<summary>Figure_PlotOptions_Line_PointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Line_PointRange()

        ///<summary>Figure_PlotOptions_Line_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Line_SoftThreshold()

        ///<summary>Figure_PlotOptions_Line_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Line_States()

        ///<summary>Figure_PlotOptions_Line_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Line_StickyTracking()

        ///<summary>Figure_PlotOptions_Line_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Line_TurboThreshold()

        ///<summary>Figure_PlotOptions_Line_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Line_FindNearestPointBy()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Line_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Line_Events.ToJson o.events
            let marker = Figure_PlotOptions_Line_Marker.ToJson o.marker
            let point = Figure_PlotOptions_Line_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Line_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%i" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Line_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"line\\\":%s}}" (Figure_PlotOptions_Line.ToJson o))


    ///<summary>Figure_PlotOptions_Area_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Area_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Area_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Area_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Area_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Area_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Area_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Area_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Area_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Area_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Area_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Area_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_Animation() = 

        ///<summary>Figure_PlotOptions_Area_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Area_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Area_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Area_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_EnabledThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"enabledThreshold\\\":%s}}}}" (Figure_PlotOptions_Area_Marker_EnabledThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Area_Marker_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"lineColor\\\":%s}}}}" (Figure_PlotOptions_Area_Marker_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"lineWidth\\\":%s}}}}" (Figure_PlotOptions_Area_Marker_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_Radius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"radius\\\":%s}}}}" (Figure_PlotOptions_Area_Marker_Radius.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Normal() = 

        ///<summary>Figure_PlotOptions_Area_Marker_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Area_Marker_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}}" (Figure_PlotOptions_Area_Marker_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}}" (Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"enabled\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Hover_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"radiusPlus\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover() = 

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_Marker_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Area_Marker_States_Hover_Enabled()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus()
        static member ToJson (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            let animation = Figure_PlotOptions_Area_Marker_States_Hover_Animation.ToJson o.animation
            let enabled = sprintf "%b" o.enabled
            let radiusPlus = sprintf "%i" o.radiusPlus
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            sprintf "{\\\"animation\\\":%s,\\\"enabled\\\":%s,\\\"radiusPlus\\\":%s,\\\"lineWidthPlus\\\":%s}" animation enabled radiusPlus lineWidthPlus

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}}" (Figure_PlotOptions_Area_Marker_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select_FillColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fillColor\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Select_FillColor.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineColor\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Select_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineWidth\\\":%s}}}}}}" (Figure_PlotOptions_Area_Marker_States_Select_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select() = 

        ///<summary>Figure_PlotOptions_Area_Marker_States_Select_FillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Area_Marker_States_Select_FillColor()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Select_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Area_Marker_States_Select_LineColor()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Select_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Area_Marker_States_Select_LineWidth()
        static member ToJson (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            let fillColor = sprintf "\\\"%s\\\"" o.fillColor
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            sprintf "{\\\"fillColor\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s}" fillColor lineColor lineWidth

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}}" (Figure_PlotOptions_Area_Marker_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States() = 

        ///<summary>Figure_PlotOptions_Area_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Area_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Area_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Area_Marker_States_Select()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            let normal = Figure_PlotOptions_Area_Marker_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Area_Marker_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Area_Marker_States_Select.ToJson o.select
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s}" normal hover select

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":{\\\"states\\\":%s}}}}" (Figure_PlotOptions_Area_Marker_States.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Area_Marker() = 

        ///<summary>Figure_PlotOptions_Area_Marker_EnabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Area_Marker_EnabledThreshold()

        ///<summary>Figure_PlotOptions_Area_Marker_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Area_Marker_LineColor()

        ///<summary>Figure_PlotOptions_Area_Marker_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Area_Marker_LineWidth()

        ///<summary>Figure_PlotOptions_Area_Marker_Radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Area_Marker_Radius()

        ///<summary>Figure_PlotOptions_Area_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Area_Marker_States()
        static member ToJson (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            let enabledThreshold = sprintf "%i" o.enabledThreshold
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            let radius = sprintf "%i" o.radius
            let states = Figure_PlotOptions_Area_Marker_States.ToJson o.states
            sprintf "{\\\"enabledThreshold\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s,\\\"radius\\\":%s,\\\"states\\\":%s}" enabledThreshold lineColor lineWidth radius states

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Area_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Area_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Area_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Area_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Area_Point() = 

        ///<summary>Figure_PlotOptions_Area_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Area_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Area_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Area_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Area_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"align\\\":%s}}}}" (Figure_PlotOptions_Area_DataLabels_Align.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Area_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Area_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Area_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Area_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Area_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Area_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Area_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Area_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Area_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Area_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Area_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Area_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"verticalAlign\\\":%s}}}}" (Figure_PlotOptions_Area_DataLabels_VerticalAlign.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Area_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Area_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Area_DataLabels_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Area_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Area_DataLabels() = 

        ///<summary>Figure_PlotOptions_Area_DataLabels_Align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Area_DataLabels_Align()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Area_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Area_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Area_DataLabels_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Area_DataLabels_VerticalAlign()

        ///<summary>Figure_PlotOptions_Area_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Area_DataLabels_X()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Area_DataLabels_Y()
        static member ToJson (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Area_DataLabels_Style.ToJson o.style
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            sprintf "{\\\"align\\\":%s,\\\"padding\\\":%s,\\\"style\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s}" align padding style verticalAlign x y

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Area_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Area_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Area_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Area_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Area_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Area_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Area_PointRange() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Area_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Area_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Area_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Area_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Area_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Area_States_Normal() = 

        ///<summary>Figure_PlotOptions_Area_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Area_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Area_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Area_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Halo_Size() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"size\\\":%s}}}}}}" (Figure_PlotOptions_Area_States_Hover_Halo_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Halo_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"opacity\\\":%s}}}}}}" (Figure_PlotOptions_Area_States_Hover_Halo_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Halo() = 

        ///<summary>Figure_PlotOptions_Area_States_Hover_Halo_Size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Area_States_Hover_Halo_Size()

        ///<summary>Figure_PlotOptions_Area_States_Hover_Halo_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Area_States_Hover_Halo_Opacity()
        static member ToJson (o:{| size:int; opacity:int |}) =
            let size = sprintf "%i" o.size
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"size\\\":%s,\\\"opacity\\\":%s}" size opacity

        member this.Set (o:{| size:int; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Hover_Halo.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover() = 

        ///<summary>Figure_PlotOptions_Area_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Area_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Area_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Area_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Area_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Area_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Area_States_Hover_Halo()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            let animation = Figure_PlotOptions_Area_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Area_States_Hover_Marker.ToJson o.marker
            let halo = Figure_PlotOptions_Area_States_Hover_Halo.ToJson o.halo
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s}" animation lineWidthPlus marker halo

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Area_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Area_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Area_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Area_States_Select() = 

        ///<summary>Figure_PlotOptions_Area_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Select_Animation()
        static member ToJson (o:{| animation: {| duration:int |} |}) =
            let animation = Figure_PlotOptions_Area_States_Select_Animation.ToJson o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation: {| duration:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Area_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Area_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Area_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Area_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Area_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Area_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Area_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Area_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Area_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Area_States() = 

        ///<summary>Figure_PlotOptions_Area_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Area_States_Normal()

        ///<summary>Figure_PlotOptions_Area_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
        member this.hover = Figure_PlotOptions_Area_States_Hover()

        ///<summary>Figure_PlotOptions_Area_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
        member this.select = Figure_PlotOptions_Area_States_Select()

        ///<summary>Figure_PlotOptions_Area_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Area_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Area_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Area_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Area_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Area_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Area_States.ToJson o))


    ///<summary>Figure_PlotOptions_Area_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Area_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Area_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Area_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Area_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Area_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Area_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Area_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Area_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_Threshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":{\\\"threshold\\\":%s}}}" (Figure_PlotOptions_Area_Threshold.ToJson o))

    ///<summary>Figure_PlotOptions_Area : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}</code></summary>
    type Figure_PlotOptions_Area() = 

        ///<summary>Figure_PlotOptions_Area_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Area_LineWidth()

        ///<summary>Figure_PlotOptions_Area_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Area_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Area_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Area_Crisp()

        ///<summary>Figure_PlotOptions_Area_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Area_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Area_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_Animation()

        ///<summary>Figure_PlotOptions_Area_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Area_Events()

        ///<summary>Figure_PlotOptions_Area_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
        member this.marker = Figure_PlotOptions_Area_Marker()

        ///<summary>Figure_PlotOptions_Area_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Area_Point()

        ///<summary>Figure_PlotOptions_Area_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Area_DataLabels()

        ///<summary>Figure_PlotOptions_Area_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Area_CropThreshold()

        ///<summary>Figure_PlotOptions_Area_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Area_Opacity()

        ///<summary>Figure_PlotOptions_Area_PointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Area_PointRange()

        ///<summary>Figure_PlotOptions_Area_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Area_SoftThreshold()

        ///<summary>Figure_PlotOptions_Area_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Area_States()

        ///<summary>Figure_PlotOptions_Area_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Area_StickyTracking()

        ///<summary>Figure_PlotOptions_Area_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Area_TurboThreshold()

        ///<summary>Figure_PlotOptions_Area_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Area_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Area_Threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Area_Threshold()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Area_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Area_Events.ToJson o.events
            let marker = Figure_PlotOptions_Area_Marker.ToJson o.marker
            let point = Figure_PlotOptions_Area_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Area_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%i" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Area_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            let threshold = sprintf "%i" o.threshold
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s,\\\"threshold\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy threshold

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"area\\\":%s}}" (Figure_PlotOptions_Area.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Spline_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Spline_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Spline_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Spline_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Spline_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Spline_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_Animation() = 

        ///<summary>Figure_PlotOptions_Spline_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Spline_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Spline_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Spline_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_EnabledThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"enabledThreshold\\\":%s}}}}" (Figure_PlotOptions_Spline_Marker_EnabledThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Spline_Marker_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"lineColor\\\":%s}}}}" (Figure_PlotOptions_Spline_Marker_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"lineWidth\\\":%s}}}}" (Figure_PlotOptions_Spline_Marker_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_Radius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"radius\\\":%s}}}}" (Figure_PlotOptions_Spline_Marker_Radius.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Normal() = 

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Spline_Marker_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}}" (Figure_PlotOptions_Spline_Marker_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"enabled\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Hover_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"radiusPlus\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover() = 

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_Marker_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Spline_Marker_States_Hover_Enabled()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus()
        static member ToJson (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            let animation = Figure_PlotOptions_Spline_Marker_States_Hover_Animation.ToJson o.animation
            let enabled = sprintf "%b" o.enabled
            let radiusPlus = sprintf "%i" o.radiusPlus
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            sprintf "{\\\"animation\\\":%s,\\\"enabled\\\":%s,\\\"radiusPlus\\\":%s,\\\"lineWidthPlus\\\":%s}" animation enabled radiusPlus lineWidthPlus

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}}" (Figure_PlotOptions_Spline_Marker_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select_FillColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fillColor\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Select_FillColor.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineColor\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Select_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineWidth\\\":%s}}}}}}" (Figure_PlotOptions_Spline_Marker_States_Select_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select() = 

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_FillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Spline_Marker_States_Select_FillColor()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Spline_Marker_States_Select_LineColor()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Spline_Marker_States_Select_LineWidth()
        static member ToJson (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            let fillColor = sprintf "\\\"%s\\\"" o.fillColor
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            sprintf "{\\\"fillColor\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s}" fillColor lineColor lineWidth

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}}" (Figure_PlotOptions_Spline_Marker_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States() = 

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Spline_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Spline_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Spline_Marker_States_Select()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            let normal = Figure_PlotOptions_Spline_Marker_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Spline_Marker_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Spline_Marker_States_Select.ToJson o.select
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s}" normal hover select

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":{\\\"states\\\":%s}}}}" (Figure_PlotOptions_Spline_Marker_States.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Spline_Marker() = 

        ///<summary>Figure_PlotOptions_Spline_Marker_EnabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Spline_Marker_EnabledThreshold()

        ///<summary>Figure_PlotOptions_Spline_Marker_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Spline_Marker_LineColor()

        ///<summary>Figure_PlotOptions_Spline_Marker_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Spline_Marker_LineWidth()

        ///<summary>Figure_PlotOptions_Spline_Marker_Radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Spline_Marker_Radius()

        ///<summary>Figure_PlotOptions_Spline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Spline_Marker_States()
        static member ToJson (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            let enabledThreshold = sprintf "%i" o.enabledThreshold
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            let radius = sprintf "%i" o.radius
            let states = Figure_PlotOptions_Spline_Marker_States.ToJson o.states
            sprintf "{\\\"enabledThreshold\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s,\\\"radius\\\":%s,\\\"states\\\":%s}" enabledThreshold lineColor lineWidth radius states

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Spline_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Spline_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Spline_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Spline_Point() = 

        ///<summary>Figure_PlotOptions_Spline_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Spline_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Spline_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Spline_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"align\\\":%s}}}}" (Figure_PlotOptions_Spline_DataLabels_Align.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Spline_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Spline_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Spline_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Spline_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Spline_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Spline_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Spline_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Spline_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Spline_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Spline_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"verticalAlign\\\":%s}}}}" (Figure_PlotOptions_Spline_DataLabels_VerticalAlign.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Spline_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Spline_DataLabels_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Spline_DataLabels() = 

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Spline_DataLabels_Align()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Spline_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Spline_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Spline_DataLabels_VerticalAlign()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Spline_DataLabels_X()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Spline_DataLabels_Y()
        static member ToJson (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Spline_DataLabels_Style.ToJson o.style
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            sprintf "{\\\"align\\\":%s,\\\"padding\\\":%s,\\\"style\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s}" align padding style verticalAlign x y

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Spline_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Spline_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Spline_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Spline_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Spline_PointRange() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Spline_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Spline_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Spline_States_Normal() = 

        ///<summary>Figure_PlotOptions_Spline_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Spline_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Spline_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Halo_Size() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"size\\\":%s}}}}}}" (Figure_PlotOptions_Spline_States_Hover_Halo_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Halo_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"opacity\\\":%s}}}}}}" (Figure_PlotOptions_Spline_States_Hover_Halo_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Halo() = 

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo_Size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Spline_States_Hover_Halo_Size()

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Spline_States_Hover_Halo_Opacity()
        static member ToJson (o:{| size:int; opacity:int |}) =
            let size = sprintf "%i" o.size
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"size\\\":%s,\\\"opacity\\\":%s}" size opacity

        member this.Set (o:{| size:int; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Hover_Halo.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover() = 

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Spline_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Spline_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Spline_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Spline_States_Hover_Halo()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            let animation = Figure_PlotOptions_Spline_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Spline_States_Hover_Marker.ToJson o.marker
            let halo = Figure_PlotOptions_Spline_States_Hover_Halo.ToJson o.halo
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s}" animation lineWidthPlus marker halo

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Spline_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Spline_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Spline_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_States_Select() = 

        ///<summary>Figure_PlotOptions_Spline_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Select_Animation()
        static member ToJson (o:{| animation: {| duration:int |} |}) =
            let animation = Figure_PlotOptions_Spline_States_Select_Animation.ToJson o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation: {| duration:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Spline_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Spline_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Spline_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Spline_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Spline_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Spline_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Spline_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_States() = 

        ///<summary>Figure_PlotOptions_Spline_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Spline_States_Normal()

        ///<summary>Figure_PlotOptions_Spline_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
        member this.hover = Figure_PlotOptions_Spline_States_Hover()

        ///<summary>Figure_PlotOptions_Spline_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
        member this.select = Figure_PlotOptions_Spline_States_Select()

        ///<summary>Figure_PlotOptions_Spline_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Spline_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Spline_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Spline_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Spline_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Spline_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Spline_States.ToJson o))


    ///<summary>Figure_PlotOptions_Spline_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Spline_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Spline_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Spline_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Spline_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Spline_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Spline_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Spline : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}</code></summary>
    type Figure_PlotOptions_Spline() = 

        ///<summary>Figure_PlotOptions_Spline_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Spline_LineWidth()

        ///<summary>Figure_PlotOptions_Spline_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Spline_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Spline_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Spline_Crisp()

        ///<summary>Figure_PlotOptions_Spline_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Spline_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Spline_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_Animation()

        ///<summary>Figure_PlotOptions_Spline_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Spline_Events()

        ///<summary>Figure_PlotOptions_Spline_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
        member this.marker = Figure_PlotOptions_Spline_Marker()

        ///<summary>Figure_PlotOptions_Spline_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Spline_Point()

        ///<summary>Figure_PlotOptions_Spline_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Spline_DataLabels()

        ///<summary>Figure_PlotOptions_Spline_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Spline_CropThreshold()

        ///<summary>Figure_PlotOptions_Spline_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Spline_Opacity()

        ///<summary>Figure_PlotOptions_Spline_PointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Spline_PointRange()

        ///<summary>Figure_PlotOptions_Spline_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Spline_SoftThreshold()

        ///<summary>Figure_PlotOptions_Spline_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Spline_States()

        ///<summary>Figure_PlotOptions_Spline_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Spline_StickyTracking()

        ///<summary>Figure_PlotOptions_Spline_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Spline_TurboThreshold()

        ///<summary>Figure_PlotOptions_Spline_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Spline_FindNearestPointBy()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Spline_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Spline_Events.ToJson o.events
            let marker = Figure_PlotOptions_Spline_Marker.ToJson o.marker
            let point = Figure_PlotOptions_Spline_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Spline_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%i" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Spline_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"spline\\\":%s}}" (Figure_PlotOptions_Spline.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Areaspline_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Areaspline_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Areaspline_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Areaspline_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Animation() = 

        ///<summary>Figure_PlotOptions_Areaspline_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Areaspline_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Areaspline_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_EnabledThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"enabledThreshold\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Marker_EnabledThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"lineColor\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Marker_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"lineWidth\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Marker_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_Radius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"radius\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Marker_Radius.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Normal() = 

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"enabled\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"radiusPlus\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover() = 

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus()
        static member ToJson (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            let animation = Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation.ToJson o.animation
            let enabled = sprintf "%b" o.enabled
            let radiusPlus = sprintf "%i" o.radiusPlus
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            sprintf "{\\\"animation\\\":%s,\\\"enabled\\\":%s,\\\"radiusPlus\\\":%s,\\\"lineWidthPlus\\\":%s}" animation enabled radiusPlus lineWidthPlus

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fillColor\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineColor\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineWidth\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select() = 

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth()
        static member ToJson (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            let fillColor = sprintf "\\\"%s\\\"" o.fillColor
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            sprintf "{\\\"fillColor\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s}" fillColor lineColor lineWidth

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_Marker_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States() = 

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Areaspline_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Areaspline_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Areaspline_Marker_States_Select()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            let normal = Figure_PlotOptions_Areaspline_Marker_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Areaspline_Marker_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Areaspline_Marker_States_Select.ToJson o.select
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s}" normal hover select

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":{\\\"states\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Marker_States.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker() = 

        ///<summary>Figure_PlotOptions_Areaspline_Marker_EnabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Areaspline_Marker_EnabledThreshold()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Areaspline_Marker_LineColor()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Areaspline_Marker_LineWidth()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_Radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Areaspline_Marker_Radius()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Areaspline_Marker_States()
        static member ToJson (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            let enabledThreshold = sprintf "%i" o.enabledThreshold
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            let radius = sprintf "%i" o.radius
            let states = Figure_PlotOptions_Areaspline_Marker_States.ToJson o.states
            sprintf "{\\\"enabledThreshold\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s,\\\"radius\\\":%s,\\\"states\\\":%s}" enabledThreshold lineColor lineWidth radius states

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Areaspline_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Areaspline_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_Point() = 

        ///<summary>Figure_PlotOptions_Areaspline_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Areaspline_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Areaspline_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Areaspline_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"align\\\":%s}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Align.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Areaspline_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"verticalAlign\\\":%s}}}}" (Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Areaspline_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Areaspline_DataLabels_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels() = 

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Areaspline_DataLabels_Align()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Areaspline_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Areaspline_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Areaspline_DataLabels_X()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Areaspline_DataLabels_Y()
        static member ToJson (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Areaspline_DataLabels_Style.ToJson o.style
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            sprintf "{\\\"align\\\":%s,\\\"padding\\\":%s,\\\"style\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s}" align padding style verticalAlign x y

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Areaspline_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Areaspline_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Areaspline_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_PointRange() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Areaspline_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Areaspline_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Normal() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Areaspline_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Halo_Size() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"size\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_Halo_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"opacity\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Halo() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo_Size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Areaspline_States_Hover_Halo_Size()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity()
        static member ToJson (o:{| size:int; opacity:int |}) =
            let size = sprintf "%i" o.size
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"size\\\":%s,\\\"opacity\\\":%s}" size opacity

        member this.Set (o:{| size:int; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Hover_Halo.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Areaspline_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Areaspline_States_Hover_Halo()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            let animation = Figure_PlotOptions_Areaspline_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Areaspline_States_Hover_Marker.ToJson o.marker
            let halo = Figure_PlotOptions_Areaspline_States_Hover_Halo.ToJson o.halo
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s}" animation lineWidthPlus marker halo

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Areaspline_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Select() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Select_Animation()
        static member ToJson (o:{| animation: {| duration:int |} |}) =
            let animation = Figure_PlotOptions_Areaspline_States_Select_Animation.ToJson o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation: {| duration:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Areaspline_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Areaspline_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Areaspline_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Areaspline_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Areaspline_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_States() = 

        ///<summary>Figure_PlotOptions_Areaspline_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Areaspline_States_Normal()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
        member this.hover = Figure_PlotOptions_Areaspline_States_Hover()

        ///<summary>Figure_PlotOptions_Areaspline_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
        member this.select = Figure_PlotOptions_Areaspline_States_Select()

        ///<summary>Figure_PlotOptions_Areaspline_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Areaspline_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Areaspline_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Areaspline_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Areaspline_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Areaspline_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Areaspline_States.ToJson o))


    ///<summary>Figure_PlotOptions_Areaspline_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Areaspline_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Areaspline_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Areaspline_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Threshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":{\\\"threshold\\\":%s}}}" (Figure_PlotOptions_Areaspline_Threshold.ToJson o))

    ///<summary>Figure_PlotOptions_Areaspline : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}</code></summary>
    type Figure_PlotOptions_Areaspline() = 

        ///<summary>Figure_PlotOptions_Areaspline_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Areaspline_LineWidth()

        ///<summary>Figure_PlotOptions_Areaspline_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Areaspline_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Areaspline_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Areaspline_Crisp()

        ///<summary>Figure_PlotOptions_Areaspline_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Areaspline_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Areaspline_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_Animation()

        ///<summary>Figure_PlotOptions_Areaspline_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Areaspline_Events()

        ///<summary>Figure_PlotOptions_Areaspline_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
        member this.marker = Figure_PlotOptions_Areaspline_Marker()

        ///<summary>Figure_PlotOptions_Areaspline_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Areaspline_Point()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Areaspline_DataLabels()

        ///<summary>Figure_PlotOptions_Areaspline_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Areaspline_CropThreshold()

        ///<summary>Figure_PlotOptions_Areaspline_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Areaspline_Opacity()

        ///<summary>Figure_PlotOptions_Areaspline_PointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Areaspline_PointRange()

        ///<summary>Figure_PlotOptions_Areaspline_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Areaspline_SoftThreshold()

        ///<summary>Figure_PlotOptions_Areaspline_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Areaspline_States()

        ///<summary>Figure_PlotOptions_Areaspline_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Areaspline_StickyTracking()

        ///<summary>Figure_PlotOptions_Areaspline_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Areaspline_TurboThreshold()

        ///<summary>Figure_PlotOptions_Areaspline_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Areaspline_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Areaspline_Threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Areaspline_Threshold()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Areaspline_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Areaspline_Events.ToJson o.events
            let marker = Figure_PlotOptions_Areaspline_Marker.ToJson o.marker
            let point = Figure_PlotOptions_Areaspline_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Areaspline_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%i" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Areaspline_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            let threshold = sprintf "%i" o.threshold
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s,\\\"threshold\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy threshold

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"areaspline\\\":%s}}" (Figure_PlotOptions_Areaspline.ToJson o))


    ///<summary>Figure_PlotOptions_Column_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Column_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Column_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Column_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Column_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Column_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Column_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Column_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Column_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Column_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Column_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Column_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Column_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Column_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Column_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_Animation() = 

        ///<summary>Figure_PlotOptions_Column_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Column_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Column_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Column_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Column_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Column_Marker : <code>float</code></summary>
    type Figure_PlotOptions_Column_Marker() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Column_Marker.ToJson o))

    ///<summary>Figure_PlotOptions_Column_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Column_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Column_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Column_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Column_Point() = 

        ///<summary>Figure_PlotOptions_Column_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Column_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Column_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Column_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Column_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Column_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Column_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Column_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Column_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Column_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Column_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Column_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Column_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Column_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Column_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Column_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Column_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Column_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Column_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Column_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Column_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Column_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Column_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
    type Figure_PlotOptions_Column_DataLabels() = 

        ///<summary>Figure_PlotOptions_Column_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Column_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Column_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Column_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Column_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Column_DataLabels_X()
        static member ToJson (o:{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}) =
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Column_DataLabels_Style.ToJson o.style
            let x = sprintf "%i" o.x
            sprintf "{\\\"padding\\\":%s,\\\"style\\\":%s,\\\"x\\\":%s}" padding style x

        member this.Set (o:{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Column_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Column_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Column_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Column_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Column_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Column_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Column_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Column_PointRange : <code>float</code></summary>
    type Figure_PlotOptions_Column_PointRange() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Column_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Column_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Column_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Column_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Column_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Column_States_Normal() = 

        ///<summary>Figure_PlotOptions_Column_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Column_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Column_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Column_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Hover_Halo : <code>bool</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Halo() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Hover_Halo.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Hover_Brightness : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Brightness() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"brightness\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Hover_Brightness.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Hover() = 

        ///<summary>Figure_PlotOptions_Column_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Column_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Column_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Column_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Column_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Column_States_Hover_Halo : <code>bool</code></summary>
        member this.halo = Figure_PlotOptions_Column_States_Hover_Halo()

        ///<summary>Figure_PlotOptions_Column_States_Hover_Brightness : <code>int</code></summary>
        member this.brightness = Figure_PlotOptions_Column_States_Hover_Brightness()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}) =
            let animation = Figure_PlotOptions_Column_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Column_States_Hover_Marker.ToJson o.marker
            let halo = sprintf "%b" o.halo
            let brightness = sprintf "%i" o.brightness
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s,\\\"brightness\\\":%s}" animation lineWidthPlus marker halo brightness

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Column_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Column_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Column_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Select_Color : <code>string</code></summary>
    type Figure_PlotOptions_Column_States_Select_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"select\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Select_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Select_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Column_States_Select_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"select\\\":{\\\"borderColor\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Select_BorderColor.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Select : <code>{| animation: {| duration:int |}; color:string; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Column_States_Select() = 

        ///<summary>Figure_PlotOptions_Column_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Select_Animation()

        ///<summary>Figure_PlotOptions_Column_States_Select_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Column_States_Select_Color()

        ///<summary>Figure_PlotOptions_Column_States_Select_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Column_States_Select_BorderColor()
        static member ToJson (o:{| animation: {| duration:int |}; color:string; borderColor:string |}) =
            let animation = Figure_PlotOptions_Column_States_Select_Animation.ToJson o.animation
            let color = sprintf "\\\"%s\\\"" o.color
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            sprintf "{\\\"animation\\\":%s,\\\"color\\\":%s,\\\"borderColor\\\":%s}" animation color borderColor

        member this.Set (o:{| animation: {| duration:int |}; color:string; borderColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Column_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Column_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Column_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Column_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Column_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Column_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Column_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Column_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Column_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Column_States() = 

        ///<summary>Figure_PlotOptions_Column_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Column_States_Normal()

        ///<summary>Figure_PlotOptions_Column_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Column_States_Hover()

        ///<summary>Figure_PlotOptions_Column_States_Select : <code>{| animation: {| duration:int |}; color:string; borderColor:string |}</code></summary>
        member this.select = Figure_PlotOptions_Column_States_Select()

        ///<summary>Figure_PlotOptions_Column_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Column_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Column_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Column_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Column_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Column_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Column_States.ToJson o))


    ///<summary>Figure_PlotOptions_Column_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Column_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Column_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Column_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Column_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Column_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Column_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Column_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Column_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Column_BorderRadius : <code>int</code></summary>
    type Figure_PlotOptions_Column_BorderRadius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"borderRadius\\\":%s}}}" (Figure_PlotOptions_Column_BorderRadius.ToJson o))

    ///<summary>Figure_PlotOptions_Column_CenterInCategory : <code>bool</code></summary>
    type Figure_PlotOptions_Column_CenterInCategory() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"centerInCategory\\\":%s}}}" (Figure_PlotOptions_Column_CenterInCategory.ToJson o))

    ///<summary>Figure_PlotOptions_Column_GroupPadding : <code>int</code></summary>
    type Figure_PlotOptions_Column_GroupPadding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"groupPadding\\\":%s}}}" (Figure_PlotOptions_Column_GroupPadding.ToJson o))

    ///<summary>Figure_PlotOptions_Column_PointPadding : <code>int</code></summary>
    type Figure_PlotOptions_Column_PointPadding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"pointPadding\\\":%s}}}" (Figure_PlotOptions_Column_PointPadding.ToJson o))

    ///<summary>Figure_PlotOptions_Column_MinPointLength : <code>int</code></summary>
    type Figure_PlotOptions_Column_MinPointLength() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"minPointLength\\\":%s}}}" (Figure_PlotOptions_Column_MinPointLength.ToJson o))

    ///<summary>Figure_PlotOptions_Column_StartFromThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Column_StartFromThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"startFromThreshold\\\":%s}}}" (Figure_PlotOptions_Column_StartFromThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Column_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Column_Threshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"threshold\\\":%s}}}" (Figure_PlotOptions_Column_Threshold.ToJson o))

    ///<summary>Figure_PlotOptions_Column_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Column_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":{\\\"borderColor\\\":%s}}}" (Figure_PlotOptions_Column_BorderColor.ToJson o))

    ///<summary>Figure_PlotOptions_Column : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Column() = 

        ///<summary>Figure_PlotOptions_Column_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Column_LineWidth()

        ///<summary>Figure_PlotOptions_Column_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Column_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Column_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Column_Crisp()

        ///<summary>Figure_PlotOptions_Column_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Column_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Column_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_Animation()

        ///<summary>Figure_PlotOptions_Column_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Column_Events()

        ///<summary>Figure_PlotOptions_Column_Marker : <code>float</code></summary>
        member this.marker = Figure_PlotOptions_Column_Marker()

        ///<summary>Figure_PlotOptions_Column_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Column_Point()

        ///<summary>Figure_PlotOptions_Column_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Column_DataLabels()

        ///<summary>Figure_PlotOptions_Column_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Column_CropThreshold()

        ///<summary>Figure_PlotOptions_Column_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Column_Opacity()

        ///<summary>Figure_PlotOptions_Column_PointRange : <code>float</code></summary>
        member this.pointRange = Figure_PlotOptions_Column_PointRange()

        ///<summary>Figure_PlotOptions_Column_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Column_SoftThreshold()

        ///<summary>Figure_PlotOptions_Column_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Column_States()

        ///<summary>Figure_PlotOptions_Column_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Column_StickyTracking()

        ///<summary>Figure_PlotOptions_Column_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Column_TurboThreshold()

        ///<summary>Figure_PlotOptions_Column_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Column_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Column_BorderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_PlotOptions_Column_BorderRadius()

        ///<summary>Figure_PlotOptions_Column_CenterInCategory : <code>bool</code></summary>
        member this.centerInCategory = Figure_PlotOptions_Column_CenterInCategory()

        ///<summary>Figure_PlotOptions_Column_GroupPadding : <code>int</code></summary>
        member this.groupPadding = Figure_PlotOptions_Column_GroupPadding()

        ///<summary>Figure_PlotOptions_Column_PointPadding : <code>int</code></summary>
        member this.pointPadding = Figure_PlotOptions_Column_PointPadding()

        ///<summary>Figure_PlotOptions_Column_MinPointLength : <code>int</code></summary>
        member this.minPointLength = Figure_PlotOptions_Column_MinPointLength()

        ///<summary>Figure_PlotOptions_Column_StartFromThreshold : <code>bool</code></summary>
        member this.startFromThreshold = Figure_PlotOptions_Column_StartFromThreshold()

        ///<summary>Figure_PlotOptions_Column_Threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Column_Threshold()

        ///<summary>Figure_PlotOptions_Column_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Column_BorderColor()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Column_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Column_Events.ToJson o.events
            let marker = sprintf "%f" o.marker
            let point = Figure_PlotOptions_Column_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Column_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%f" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Column_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            let borderRadius = sprintf "%i" o.borderRadius
            let centerInCategory = sprintf "%b" o.centerInCategory
            let groupPadding = sprintf "%i" o.groupPadding
            let pointPadding = sprintf "%i" o.pointPadding
            let minPointLength = sprintf "%i" o.minPointLength
            let startFromThreshold = sprintf "%b" o.startFromThreshold
            let threshold = sprintf "%i" o.threshold
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s,\\\"borderRadius\\\":%s,\\\"centerInCategory\\\":%s,\\\"groupPadding\\\":%s,\\\"pointPadding\\\":%s,\\\"minPointLength\\\":%s,\\\"startFromThreshold\\\":%s,\\\"threshold\\\":%s,\\\"borderColor\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy borderRadius centerInCategory groupPadding pointPadding minPointLength startFromThreshold threshold borderColor

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"column\\\":%s}}" (Figure_PlotOptions_Column.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Bar_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Bar_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Bar_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Bar_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Bar_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Bar_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_Animation() = 

        ///<summary>Figure_PlotOptions_Bar_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Bar_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Bar_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Bar_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_Marker : <code>float</code></summary>
    type Figure_PlotOptions_Bar_Marker() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Bar_Marker.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Bar_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Bar_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Bar_Point() = 

        ///<summary>Figure_PlotOptions_Bar_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Bar_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Bar_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Bar_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Bar_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Bar_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Bar_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Bar_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Bar_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Bar_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Bar_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Bar_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Bar_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Bar_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Bar_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
    type Figure_PlotOptions_Bar_DataLabels() = 

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Bar_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Bar_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Bar_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Bar_DataLabels_X()
        static member ToJson (o:{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}) =
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Bar_DataLabels_Style.ToJson o.style
            let x = sprintf "%i" o.x
            sprintf "{\\\"padding\\\":%s,\\\"style\\\":%s,\\\"x\\\":%s}" padding style x

        member this.Set (o:{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Bar_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Bar_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Bar_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Bar_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Bar_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_PointRange : <code>float</code></summary>
    type Figure_PlotOptions_Bar_PointRange() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Bar_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Bar_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Bar_States_Normal() = 

        ///<summary>Figure_PlotOptions_Bar_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Bar_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Bar_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Hover_Halo : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Halo() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Hover_Halo.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Brightness : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Brightness() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"brightness\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Hover_Brightness.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Hover() = 

        ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Bar_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Bar_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Bar_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Bar_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Bar_States_Hover_Halo : <code>bool</code></summary>
        member this.halo = Figure_PlotOptions_Bar_States_Hover_Halo()

        ///<summary>Figure_PlotOptions_Bar_States_Hover_Brightness : <code>int</code></summary>
        member this.brightness = Figure_PlotOptions_Bar_States_Hover_Brightness()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}) =
            let animation = Figure_PlotOptions_Bar_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Bar_States_Hover_Marker.ToJson o.marker
            let halo = sprintf "%b" o.halo
            let brightness = sprintf "%i" o.brightness
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s,\\\"brightness\\\":%s}" animation lineWidthPlus marker halo brightness

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Bar_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Bar_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Bar_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Select_Color : <code>string</code></summary>
    type Figure_PlotOptions_Bar_States_Select_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"select\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Select_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Select_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Bar_States_Select_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"select\\\":{\\\"borderColor\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Select_BorderColor.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Select : <code>{| animation: {| duration:int |}; color:string; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Bar_States_Select() = 

        ///<summary>Figure_PlotOptions_Bar_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Select_Animation()

        ///<summary>Figure_PlotOptions_Bar_States_Select_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Bar_States_Select_Color()

        ///<summary>Figure_PlotOptions_Bar_States_Select_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Bar_States_Select_BorderColor()
        static member ToJson (o:{| animation: {| duration:int |}; color:string; borderColor:string |}) =
            let animation = Figure_PlotOptions_Bar_States_Select_Animation.ToJson o.animation
            let color = sprintf "\\\"%s\\\"" o.color
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            sprintf "{\\\"animation\\\":%s,\\\"color\\\":%s,\\\"borderColor\\\":%s}" animation color borderColor

        member this.Set (o:{| animation: {| duration:int |}; color:string; borderColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Bar_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Bar_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Bar_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Bar_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Bar_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Bar_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Bar_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Bar_States() = 

        ///<summary>Figure_PlotOptions_Bar_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Bar_States_Normal()

        ///<summary>Figure_PlotOptions_Bar_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Bar_States_Hover()

        ///<summary>Figure_PlotOptions_Bar_States_Select : <code>{| animation: {| duration:int |}; color:string; borderColor:string |}</code></summary>
        member this.select = Figure_PlotOptions_Bar_States_Select()

        ///<summary>Figure_PlotOptions_Bar_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Bar_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Bar_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Bar_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Bar_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Bar_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Bar_States.ToJson o))


    ///<summary>Figure_PlotOptions_Bar_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Bar_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Bar_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Bar_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Bar_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Bar_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_BorderRadius : <code>int</code></summary>
    type Figure_PlotOptions_Bar_BorderRadius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"borderRadius\\\":%s}}}" (Figure_PlotOptions_Bar_BorderRadius.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_CenterInCategory : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_CenterInCategory() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"centerInCategory\\\":%s}}}" (Figure_PlotOptions_Bar_CenterInCategory.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_GroupPadding : <code>int</code></summary>
    type Figure_PlotOptions_Bar_GroupPadding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"groupPadding\\\":%s}}}" (Figure_PlotOptions_Bar_GroupPadding.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_PointPadding : <code>int</code></summary>
    type Figure_PlotOptions_Bar_PointPadding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"pointPadding\\\":%s}}}" (Figure_PlotOptions_Bar_PointPadding.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_MinPointLength : <code>int</code></summary>
    type Figure_PlotOptions_Bar_MinPointLength() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"minPointLength\\\":%s}}}" (Figure_PlotOptions_Bar_MinPointLength.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_StartFromThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_StartFromThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"startFromThreshold\\\":%s}}}" (Figure_PlotOptions_Bar_StartFromThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Bar_Threshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"threshold\\\":%s}}}" (Figure_PlotOptions_Bar_Threshold.ToJson o))

    ///<summary>Figure_PlotOptions_Bar_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Bar_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":{\\\"borderColor\\\":%s}}}" (Figure_PlotOptions_Bar_BorderColor.ToJson o))

    ///<summary>Figure_PlotOptions_Bar : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Bar() = 

        ///<summary>Figure_PlotOptions_Bar_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Bar_LineWidth()

        ///<summary>Figure_PlotOptions_Bar_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Bar_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Bar_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Bar_Crisp()

        ///<summary>Figure_PlotOptions_Bar_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Bar_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Bar_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_Animation()

        ///<summary>Figure_PlotOptions_Bar_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Bar_Events()

        ///<summary>Figure_PlotOptions_Bar_Marker : <code>float</code></summary>
        member this.marker = Figure_PlotOptions_Bar_Marker()

        ///<summary>Figure_PlotOptions_Bar_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Bar_Point()

        ///<summary>Figure_PlotOptions_Bar_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Bar_DataLabels()

        ///<summary>Figure_PlotOptions_Bar_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Bar_CropThreshold()

        ///<summary>Figure_PlotOptions_Bar_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Bar_Opacity()

        ///<summary>Figure_PlotOptions_Bar_PointRange : <code>float</code></summary>
        member this.pointRange = Figure_PlotOptions_Bar_PointRange()

        ///<summary>Figure_PlotOptions_Bar_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Bar_SoftThreshold()

        ///<summary>Figure_PlotOptions_Bar_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Bar_States()

        ///<summary>Figure_PlotOptions_Bar_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Bar_StickyTracking()

        ///<summary>Figure_PlotOptions_Bar_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Bar_TurboThreshold()

        ///<summary>Figure_PlotOptions_Bar_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Bar_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Bar_BorderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_PlotOptions_Bar_BorderRadius()

        ///<summary>Figure_PlotOptions_Bar_CenterInCategory : <code>bool</code></summary>
        member this.centerInCategory = Figure_PlotOptions_Bar_CenterInCategory()

        ///<summary>Figure_PlotOptions_Bar_GroupPadding : <code>int</code></summary>
        member this.groupPadding = Figure_PlotOptions_Bar_GroupPadding()

        ///<summary>Figure_PlotOptions_Bar_PointPadding : <code>int</code></summary>
        member this.pointPadding = Figure_PlotOptions_Bar_PointPadding()

        ///<summary>Figure_PlotOptions_Bar_MinPointLength : <code>int</code></summary>
        member this.minPointLength = Figure_PlotOptions_Bar_MinPointLength()

        ///<summary>Figure_PlotOptions_Bar_StartFromThreshold : <code>bool</code></summary>
        member this.startFromThreshold = Figure_PlotOptions_Bar_StartFromThreshold()

        ///<summary>Figure_PlotOptions_Bar_Threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Bar_Threshold()

        ///<summary>Figure_PlotOptions_Bar_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Bar_BorderColor()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Bar_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Bar_Events.ToJson o.events
            let marker = sprintf "%f" o.marker
            let point = Figure_PlotOptions_Bar_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Bar_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%f" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Bar_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            let borderRadius = sprintf "%i" o.borderRadius
            let centerInCategory = sprintf "%b" o.centerInCategory
            let groupPadding = sprintf "%i" o.groupPadding
            let pointPadding = sprintf "%i" o.pointPadding
            let minPointLength = sprintf "%i" o.minPointLength
            let startFromThreshold = sprintf "%b" o.startFromThreshold
            let threshold = sprintf "%i" o.threshold
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s,\\\"borderRadius\\\":%s,\\\"centerInCategory\\\":%s,\\\"groupPadding\\\":%s,\\\"pointPadding\\\":%s,\\\"minPointLength\\\":%s,\\\"startFromThreshold\\\":%s,\\\"threshold\\\":%s,\\\"borderColor\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy borderRadius centerInCategory groupPadding pointPadding minPointLength startFromThreshold threshold borderColor

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"bar\\\":%s}}" (Figure_PlotOptions_Bar.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"lineWidth\\\":%s}}}" (Figure_PlotOptions_Scatter_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Scatter_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Scatter_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Scatter_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Scatter_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Animation() = 

        ///<summary>Figure_PlotOptions_Scatter_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Scatter_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Scatter_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Scatter_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_EnabledThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"enabledThreshold\\\":%s}}}}" (Figure_PlotOptions_Scatter_Marker_EnabledThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_Marker_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"lineColor\\\":%s}}}}" (Figure_PlotOptions_Scatter_Marker_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"lineWidth\\\":%s}}}}" (Figure_PlotOptions_Scatter_Marker_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_Radius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"radius\\\":%s}}}}" (Figure_PlotOptions_Scatter_Marker_Radius.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Normal() = 

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_Marker_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"enabled\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"radiusPlus\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover() = 

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_Marker_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus()
        static member ToJson (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            let animation = Figure_PlotOptions_Scatter_Marker_States_Hover_Animation.ToJson o.animation
            let enabled = sprintf "%b" o.enabled
            let radiusPlus = sprintf "%i" o.radiusPlus
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            sprintf "{\\\"animation\\\":%s,\\\"enabled\\\":%s,\\\"radiusPlus\\\":%s,\\\"lineWidthPlus\\\":%s}" animation enabled radiusPlus lineWidthPlus

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select_FillColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fillColor\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Select_FillColor.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineColor\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Select_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":{\\\"lineWidth\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select() = 

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_FillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Scatter_Marker_States_Select_FillColor()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Scatter_Marker_States_Select_LineColor()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth()
        static member ToJson (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            let fillColor = sprintf "\\\"%s\\\"" o.fillColor
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            sprintf "{\\\"fillColor\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s}" fillColor lineColor lineWidth

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}}" (Figure_PlotOptions_Scatter_Marker_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States() = 

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Scatter_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Scatter_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Scatter_Marker_States_Select()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            let normal = Figure_PlotOptions_Scatter_Marker_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Scatter_Marker_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Scatter_Marker_States_Select.ToJson o.select
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s}" normal hover select

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"states\\\":%s}}}}" (Figure_PlotOptions_Scatter_Marker_States.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Marker_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Marker_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":{\\\"enabled\\\":%s}}}}" (Figure_PlotOptions_Scatter_Marker_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker() = 

        ///<summary>Figure_PlotOptions_Scatter_Marker_EnabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Scatter_Marker_EnabledThreshold()

        ///<summary>Figure_PlotOptions_Scatter_Marker_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Scatter_Marker_LineColor()

        ///<summary>Figure_PlotOptions_Scatter_Marker_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Scatter_Marker_LineWidth()

        ///<summary>Figure_PlotOptions_Scatter_Marker_Radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Scatter_Marker_Radius()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Scatter_Marker_States()

        ///<summary>Figure_PlotOptions_Scatter_Marker_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Scatter_Marker_Enabled()
        static member ToJson (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}) =
            let enabledThreshold = sprintf "%i" o.enabledThreshold
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let lineWidth = sprintf "%i" o.lineWidth
            let radius = sprintf "%i" o.radius
            let states = Figure_PlotOptions_Scatter_Marker_States.ToJson o.states
            let enabled = sprintf "%b" o.enabled
            sprintf "{\\\"enabledThreshold\\\":%s,\\\"lineColor\\\":%s,\\\"lineWidth\\\":%s,\\\"radius\\\":%s,\\\"states\\\":%s,\\\"enabled\\\":%s}" enabledThreshold lineColor lineWidth radius states enabled

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Scatter_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Scatter_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Scatter_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Scatter_Point() = 

        ///<summary>Figure_PlotOptions_Scatter_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Scatter_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Scatter_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Scatter_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"align\\\":%s}}}}" (Figure_PlotOptions_Scatter_DataLabels_Align.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Scatter_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Scatter_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Scatter_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Scatter_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Scatter_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Scatter_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"verticalAlign\\\":%s}}}}" (Figure_PlotOptions_Scatter_DataLabels_VerticalAlign.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Scatter_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Scatter_DataLabels_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels() = 

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Scatter_DataLabels_Align()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Scatter_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Scatter_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Scatter_DataLabels_VerticalAlign()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Scatter_DataLabels_X()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Scatter_DataLabels_Y()
        static member ToJson (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Scatter_DataLabels_Style.ToJson o.style
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            sprintf "{\\\"align\\\":%s,\\\"padding\\\":%s,\\\"style\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s}" align padding style verticalAlign x y

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Scatter_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Scatter_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Scatter_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_PointRange() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Scatter_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Scatter_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Normal() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Scatter_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Halo_Size() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"size\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_States_Hover_Halo_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"opacity\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Halo() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo_Size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Scatter_States_Hover_Halo_Size()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity()
        static member ToJson (o:{| size:int; opacity:int |}) =
            let size = sprintf "%i" o.size
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"size\\\":%s,\\\"opacity\\\":%s}" size opacity

        member this.Set (o:{| size:int; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Hover_Halo.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Scatter_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Scatter_States_Hover_Halo()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            let animation = Figure_PlotOptions_Scatter_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Scatter_States_Hover_Marker.ToJson o.marker
            let halo = Figure_PlotOptions_Scatter_States_Hover_Halo.ToJson o.halo
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s}" animation lineWidthPlus marker halo

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Scatter_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Select() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Select_Animation()
        static member ToJson (o:{| animation: {| duration:int |} |}) =
            let animation = Figure_PlotOptions_Scatter_States_Select_Animation.ToJson o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation: {| duration:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Scatter_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Scatter_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Scatter_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Scatter_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Scatter_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_States() = 

        ///<summary>Figure_PlotOptions_Scatter_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Scatter_States_Normal()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
        member this.hover = Figure_PlotOptions_Scatter_States_Hover()

        ///<summary>Figure_PlotOptions_Scatter_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
        member this.select = Figure_PlotOptions_Scatter_States_Select()

        ///<summary>Figure_PlotOptions_Scatter_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Scatter_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Scatter_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Scatter_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Scatter_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Scatter_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Scatter_States.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Scatter_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Scatter_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Scatter_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Jitter_X : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Jitter_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"jitter\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Scatter_Jitter_X.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Jitter_Y : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Jitter_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"jitter\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Scatter_Jitter_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Scatter_Jitter : <code>{| x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Jitter() = 

        ///<summary>Figure_PlotOptions_Scatter_Jitter_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Scatter_Jitter_X()

        ///<summary>Figure_PlotOptions_Scatter_Jitter_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Scatter_Jitter_Y()
        static member ToJson (o:{| x:int; y:int |}) =
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            sprintf "{\\\"x\\\":%s,\\\"y\\\":%s}" x y

        member this.Set (o:{| x:int; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":{\\\"jitter\\\":%s}}}" (Figure_PlotOptions_Scatter_Jitter.ToJson o))


    ///<summary>Figure_PlotOptions_Scatter : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter() = 

        ///<summary>Figure_PlotOptions_Scatter_LineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Scatter_LineWidth()

        ///<summary>Figure_PlotOptions_Scatter_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Scatter_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Scatter_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Scatter_Crisp()

        ///<summary>Figure_PlotOptions_Scatter_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Scatter_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Scatter_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_Animation()

        ///<summary>Figure_PlotOptions_Scatter_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Scatter_Events()

        ///<summary>Figure_PlotOptions_Scatter_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}</code></summary>
        member this.marker = Figure_PlotOptions_Scatter_Marker()

        ///<summary>Figure_PlotOptions_Scatter_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Scatter_Point()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Scatter_DataLabels()

        ///<summary>Figure_PlotOptions_Scatter_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Scatter_CropThreshold()

        ///<summary>Figure_PlotOptions_Scatter_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Scatter_Opacity()

        ///<summary>Figure_PlotOptions_Scatter_PointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Scatter_PointRange()

        ///<summary>Figure_PlotOptions_Scatter_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Scatter_SoftThreshold()

        ///<summary>Figure_PlotOptions_Scatter_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Scatter_States()

        ///<summary>Figure_PlotOptions_Scatter_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Scatter_StickyTracking()

        ///<summary>Figure_PlotOptions_Scatter_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Scatter_TurboThreshold()

        ///<summary>Figure_PlotOptions_Scatter_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Scatter_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Scatter_Jitter : <code>{| x:int; y:int |}</code></summary>
        member this.jitter = Figure_PlotOptions_Scatter_Jitter()
        static member ToJson (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}) =
            let lineWidth = sprintf "%i" o.lineWidth
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Scatter_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Scatter_Events.ToJson o.events
            let marker = Figure_PlotOptions_Scatter_Marker.ToJson o.marker
            let point = Figure_PlotOptions_Scatter_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Scatter_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%i" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Scatter_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            let jitter = Figure_PlotOptions_Scatter_Jitter.ToJson o.jitter
            sprintf "{\\\"lineWidth\\\":%s,\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s,\\\"jitter\\\":%s}" lineWidth allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy jitter

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"scatter\\\":%s}}" (Figure_PlotOptions_Scatter.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_AllowPointSelect() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"allowPointSelect\\\":%s}}}" (Figure_PlotOptions_Pie_AllowPointSelect.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_Crisp() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"crisp\\\":%s}}}" (Figure_PlotOptions_Pie_Crisp.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_ShowCheckbox() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"showCheckbox\\\":%s}}}" (Figure_PlotOptions_Pie_ShowCheckbox.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}" (Figure_PlotOptions_Pie_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_Animation() = 

        ///<summary>Figure_PlotOptions_Pie_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"animation\\\":%s}}}" (Figure_PlotOptions_Pie_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Pie_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"events\\\":%s}}}" (Figure_PlotOptions_Pie_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_Marker : <code>float</code></summary>
    type Figure_PlotOptions_Pie_Marker() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"marker\\\":%s}}}" (Figure_PlotOptions_Pie_Marker.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Pie_Point_Events() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"point\\\":{\\\"events\\\":%s}}}}" (Figure_PlotOptions_Pie_Point_Events.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Pie_Point() = 

        ///<summary>Figure_PlotOptions_Pie_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Pie_Point_Events()
        static member ToJson (o:{| events: {| dummy:string |} |}) =
            let events = Figure_PlotOptions_Pie_Point_Events.ToJson o.events
            sprintf "{\\\"events\\\":%s}" events

        member this.Set (o:{| events: {| dummy:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"point\\\":%s}}}" (Figure_PlotOptions_Pie_Point.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"align\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_Align.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"padding\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_Padding.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_PlotOptions_Pie_DataLabels_Style_FontSize.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_PlotOptions_Pie_DataLabels_Style_FontWeight.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_PlotOptions_Pie_DataLabels_Style_Color.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_TextOutline() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"style\\\":{\\\"textOutline\\\":%s}}}}}" (Figure_PlotOptions_Pie_DataLabels_Style_TextOutline.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style() = 

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Pie_DataLabels_Style_FontSize()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Pie_DataLabels_Style_FontWeight()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_Color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Pie_DataLabels_Style_Color()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_TextOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Pie_DataLabels_Style_TextOutline()
        static member ToJson (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            let textOutline = sprintf "\\\"%s\\\"" o.textOutline
            sprintf "{\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"color\\\":%s,\\\"textOutline\\\":%s}" fontSize fontWeight color textOutline

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"style\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_Style.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"verticalAlign\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_VerticalAlign.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"x\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_X.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"y\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_Y.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_AllowOverlap : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_AllowOverlap() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"allowOverlap\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_AllowOverlap.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_ConnectorPadding : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_ConnectorPadding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"connectorPadding\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_ConnectorPadding.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_ConnectorShape : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_ConnectorShape() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"connectorShape\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_ConnectorShape.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_CrookDistance : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_CrookDistance() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"crookDistance\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_CrookDistance.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Distance : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Distance() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"distance\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_Distance.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"enabled\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_Enabled.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels_SoftConnector : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_SoftConnector() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":{\\\"softConnector\\\":%s}}}}" (Figure_PlotOptions_Pie_DataLabels_SoftConnector.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}</code></summary>
    type Figure_PlotOptions_Pie_DataLabels() = 

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Pie_DataLabels_Align()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Pie_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Pie_DataLabels_Style()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Pie_DataLabels_VerticalAlign()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_X : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Pie_DataLabels_X()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Pie_DataLabels_Y()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_AllowOverlap : <code>bool</code></summary>
        member this.allowOverlap = Figure_PlotOptions_Pie_DataLabels_AllowOverlap()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_ConnectorPadding : <code>int</code></summary>
        member this.connectorPadding = Figure_PlotOptions_Pie_DataLabels_ConnectorPadding()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_ConnectorShape : <code>string</code></summary>
        member this.connectorShape = Figure_PlotOptions_Pie_DataLabels_ConnectorShape()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_CrookDistance : <code>string</code></summary>
        member this.crookDistance = Figure_PlotOptions_Pie_DataLabels_CrookDistance()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Distance : <code>int</code></summary>
        member this.distance = Figure_PlotOptions_Pie_DataLabels_Distance()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Pie_DataLabels_Enabled()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_SoftConnector : <code>bool</code></summary>
        member this.softConnector = Figure_PlotOptions_Pie_DataLabels_SoftConnector()
        static member ToJson (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let padding = sprintf "%i" o.padding
            let style = Figure_PlotOptions_Pie_DataLabels_Style.ToJson o.style
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            let allowOverlap = sprintf "%b" o.allowOverlap
            let connectorPadding = sprintf "%i" o.connectorPadding
            let connectorShape = sprintf "\\\"%s\\\"" o.connectorShape
            let crookDistance = sprintf "\\\"%s\\\"" o.crookDistance
            let distance = sprintf "%i" o.distance
            let enabled = sprintf "%b" o.enabled
            let softConnector = sprintf "%b" o.softConnector
            sprintf "{\\\"align\\\":%s,\\\"padding\\\":%s,\\\"style\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s,\\\"allowOverlap\\\":%s,\\\"connectorPadding\\\":%s,\\\"connectorShape\\\":%s,\\\"crookDistance\\\":%s,\\\"distance\\\":%s,\\\"enabled\\\":%s,\\\"softConnector\\\":%s}" align padding style verticalAlign x y allowOverlap connectorPadding connectorShape crookDistance distance enabled softConnector

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"dataLabels\\\":%s}}}" (Figure_PlotOptions_Pie_DataLabels.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Pie_CropThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"cropThreshold\\\":%s}}}" (Figure_PlotOptions_Pie_CropThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Pie_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"opacity\\\":%s}}}" (Figure_PlotOptions_Pie_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Pie_PointRange() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"pointRange\\\":%s}}}" (Figure_PlotOptions_Pie_PointRange.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_SoftThreshold() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"softThreshold\\\":%s}}}" (Figure_PlotOptions_Pie_SoftThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_States_Normal_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"normal\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Normal_Animation.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Pie_States_Normal() = 

        ///<summary>Figure_PlotOptions_Pie_States_Normal_Animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Normal_Animation()
        static member ToJson (o:{| animation:bool |}) =
            let animation = sprintf "%b" o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"normal\\\":%s}}}}" (Figure_PlotOptions_Pie_States_Normal.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Pie_States_Hover_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Animation() = 

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_States_Hover_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Hover_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_LineWidthPlus() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"lineWidthPlus\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Hover_LineWidthPlus.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Marker() = 
        static member ToJson (o:{| dummy:string |}) =

            sprintf "{\\\"dummy\\\":%s}" o.dummy

        member this.Set (o:{| dummy:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"marker\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Hover_Marker.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Halo_Size() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"size\\\":%s}}}}}}" (Figure_PlotOptions_Pie_States_Hover_Halo_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Halo_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":{\\\"opacity\\\":%s}}}}}}" (Figure_PlotOptions_Pie_States_Hover_Halo_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Halo() = 

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo_Size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Pie_States_Hover_Halo_Size()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Pie_States_Hover_Halo_Opacity()
        static member ToJson (o:{| size:int; opacity:int |}) =
            let size = sprintf "%i" o.size
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"size\\\":%s,\\\"opacity\\\":%s}" size opacity

        member this.Set (o:{| size:int; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"halo\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Hover_Halo.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Hover_Brightness : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Brightness() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"brightness\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Hover_Brightness.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover() = 

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Hover_Animation()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_LineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Pie_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Pie_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Pie_States_Hover_Halo()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Brightness : <code>int</code></summary>
        member this.brightness = Figure_PlotOptions_Pie_States_Hover_Brightness()
        static member ToJson (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}) =
            let animation = Figure_PlotOptions_Pie_States_Hover_Animation.ToJson o.animation
            let lineWidthPlus = sprintf "%i" o.lineWidthPlus
            let marker = Figure_PlotOptions_Pie_States_Hover_Marker.ToJson o.marker
            let halo = Figure_PlotOptions_Pie_States_Hover_Halo.ToJson o.halo
            let brightness = sprintf "%i" o.brightness
            sprintf "{\\\"animation\\\":%s,\\\"lineWidthPlus\\\":%s,\\\"marker\\\":%s,\\\"halo\\\":%s,\\\"brightness\\\":%s}" animation lineWidthPlus marker halo brightness

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_PlotOptions_Pie_States_Hover.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Select_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Pie_States_Select_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Select_Animation() = 

        ///<summary>Figure_PlotOptions_Pie_States_Select_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_States_Select_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"select\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Select_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Pie_States_Select() = 

        ///<summary>Figure_PlotOptions_Pie_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Select_Animation()
        static member ToJson (o:{| animation: {| duration:int |} |}) =
            let animation = Figure_PlotOptions_Pie_States_Select_Animation.ToJson o.animation
            sprintf "{\\\"animation\\\":%s}" animation

        member this.Set (o:{| animation: {| duration:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_PlotOptions_Pie_States_Select.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive_Animation_Duration() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":{\\\"duration\\\":%s}}}}}}" (Figure_PlotOptions_Pie_States_Inactive_Animation_Duration.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive_Animation() = 

        ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation_Duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_States_Inactive_Animation_Duration()
        static member ToJson (o:{| duration:int |}) =
            let duration = sprintf "%i" o.duration
            sprintf "{\\\"duration\\\":%s}" duration

        member this.Set (o:{| duration:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"animation\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Inactive_Animation.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"inactive\\\":{\\\"opacity\\\":%s}}}}}" (Figure_PlotOptions_Pie_States_Inactive_Opacity.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive() = 

        ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Inactive_Animation()

        ///<summary>Figure_PlotOptions_Pie_States_Inactive_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Pie_States_Inactive_Opacity()
        static member ToJson (o:{| animation: {| duration:int |}; opacity:int |}) =
            let animation = Figure_PlotOptions_Pie_States_Inactive_Animation.ToJson o.animation
            let opacity = sprintf "%i" o.opacity
            sprintf "{\\\"animation\\\":%s,\\\"opacity\\\":%s}" animation opacity

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":{\\\"inactive\\\":%s}}}}" (Figure_PlotOptions_Pie_States_Inactive.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Pie_States() = 

        ///<summary>Figure_PlotOptions_Pie_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Pie_States_Normal()

        ///<summary>Figure_PlotOptions_Pie_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Pie_States_Hover()

        ///<summary>Figure_PlotOptions_Pie_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
        member this.select = Figure_PlotOptions_Pie_States_Select()

        ///<summary>Figure_PlotOptions_Pie_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
        member this.inactive = Figure_PlotOptions_Pie_States_Inactive()
        static member ToJson (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            let normal = Figure_PlotOptions_Pie_States_Normal.ToJson o.normal
            let hover = Figure_PlotOptions_Pie_States_Hover.ToJson o.hover
            let select = Figure_PlotOptions_Pie_States_Select.ToJson o.select
            let inactive = Figure_PlotOptions_Pie_States_Inactive.ToJson o.inactive
            sprintf "{\\\"normal\\\":%s,\\\"hover\\\":%s,\\\"select\\\":%s,\\\"inactive\\\":%s}" normal hover select inactive

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"states\\\":%s}}}" (Figure_PlotOptions_Pie_States.ToJson o))


    ///<summary>Figure_PlotOptions_Pie_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_StickyTracking() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"stickyTracking\\\":%s}}}" (Figure_PlotOptions_Pie_StickyTracking.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Pie_TurboThreshold() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"turboThreshold\\\":%s}}}" (Figure_PlotOptions_Pie_TurboThreshold.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Pie_FindNearestPointBy() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"findNearestPointBy\\\":%s}}}" (Figure_PlotOptions_Pie_FindNearestPointBy.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Center_Item : <code>float</code></summary>
    type Figure_PlotOptions_Pie_Center_Item() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"center\\\":{\\\"item\\\":%s}}}}" (Figure_PlotOptions_Pie_Center_Item.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Center : <code>float seq</code></summary>
    type Figure_PlotOptions_Pie_Center() =
        let item = Figure_PlotOptions_Pie_Center_Item()

        static member ToJson (o:float seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_PlotOptions_Pie_Center_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:float seq) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"center\\\":%s}}}" (Figure_PlotOptions_Pie_Center.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_PlotOptions_Pie_Clip : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_Clip() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"clip\\\":%s}}}" (Figure_PlotOptions_Pie_Clip.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_ColorByPoint : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_ColorByPoint() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"colorByPoint\\\":%s}}}" (Figure_PlotOptions_Pie_ColorByPoint.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_IgnoreHiddenPoint : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_IgnoreHiddenPoint() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"ignoreHiddenPoint\\\":%s}}}" (Figure_PlotOptions_Pie_IgnoreHiddenPoint.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_InactiveOtherPoints : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_InactiveOtherPoints() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"inactiveOtherPoints\\\":%s}}}" (Figure_PlotOptions_Pie_InactiveOtherPoints.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_LegendType : <code>string</code></summary>
    type Figure_PlotOptions_Pie_LegendType() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"legendType\\\":%s}}}" (Figure_PlotOptions_Pie_LegendType.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_Size : <code>float</code></summary>
    type Figure_PlotOptions_Pie_Size() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"size\\\":%s}}}" (Figure_PlotOptions_Pie_Size.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_ShowInLegend : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_ShowInLegend() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"showInLegend\\\":%s}}}" (Figure_PlotOptions_Pie_ShowInLegend.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_SlicedOffset : <code>int</code></summary>
    type Figure_PlotOptions_Pie_SlicedOffset() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"slicedOffset\\\":%s}}}" (Figure_PlotOptions_Pie_SlicedOffset.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Pie_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"borderColor\\\":%s}}}" (Figure_PlotOptions_Pie_BorderColor.ToJson o))

    ///<summary>Figure_PlotOptions_Pie_BorderWidth : <code>int</code></summary>
    type Figure_PlotOptions_Pie_BorderWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":{\\\"borderWidth\\\":%s}}}" (Figure_PlotOptions_Pie_BorderWidth.ToJson o))

    ///<summary>Figure_PlotOptions_Pie : <code>{| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}</code></summary>
    type Figure_PlotOptions_Pie() = 

        ///<summary>Figure_PlotOptions_Pie_AllowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Pie_AllowPointSelect()

        ///<summary>Figure_PlotOptions_Pie_Crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Pie_Crisp()

        ///<summary>Figure_PlotOptions_Pie_ShowCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Pie_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Pie_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_Animation()

        ///<summary>Figure_PlotOptions_Pie_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Pie_Events()

        ///<summary>Figure_PlotOptions_Pie_Marker : <code>float</code></summary>
        member this.marker = Figure_PlotOptions_Pie_Marker()

        ///<summary>Figure_PlotOptions_Pie_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Pie_Point()

        ///<summary>Figure_PlotOptions_Pie_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Pie_DataLabels()

        ///<summary>Figure_PlotOptions_Pie_CropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Pie_CropThreshold()

        ///<summary>Figure_PlotOptions_Pie_Opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Pie_Opacity()

        ///<summary>Figure_PlotOptions_Pie_PointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Pie_PointRange()

        ///<summary>Figure_PlotOptions_Pie_SoftThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Pie_SoftThreshold()

        ///<summary>Figure_PlotOptions_Pie_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Pie_States()

        ///<summary>Figure_PlotOptions_Pie_StickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Pie_StickyTracking()

        ///<summary>Figure_PlotOptions_Pie_TurboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Pie_TurboThreshold()

        ///<summary>Figure_PlotOptions_Pie_FindNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Pie_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Pie_Center : <code>float seq</code></summary>
        member this.center = Figure_PlotOptions_Pie_Center()

        ///<summary>Figure_PlotOptions_Pie_Clip : <code>bool</code></summary>
        member this.clip = Figure_PlotOptions_Pie_Clip()

        ///<summary>Figure_PlotOptions_Pie_ColorByPoint : <code>bool</code></summary>
        member this.colorByPoint = Figure_PlotOptions_Pie_ColorByPoint()

        ///<summary>Figure_PlotOptions_Pie_IgnoreHiddenPoint : <code>bool</code></summary>
        member this.ignoreHiddenPoint = Figure_PlotOptions_Pie_IgnoreHiddenPoint()

        ///<summary>Figure_PlotOptions_Pie_InactiveOtherPoints : <code>bool</code></summary>
        member this.inactiveOtherPoints = Figure_PlotOptions_Pie_InactiveOtherPoints()

        ///<summary>Figure_PlotOptions_Pie_LegendType : <code>string</code></summary>
        member this.legendType = Figure_PlotOptions_Pie_LegendType()

        ///<summary>Figure_PlotOptions_Pie_Size : <code>float</code></summary>
        member this.size = Figure_PlotOptions_Pie_Size()

        ///<summary>Figure_PlotOptions_Pie_ShowInLegend : <code>bool</code></summary>
        member this.showInLegend = Figure_PlotOptions_Pie_ShowInLegend()

        ///<summary>Figure_PlotOptions_Pie_SlicedOffset : <code>int</code></summary>
        member this.slicedOffset = Figure_PlotOptions_Pie_SlicedOffset()

        ///<summary>Figure_PlotOptions_Pie_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Pie_BorderColor()

        ///<summary>Figure_PlotOptions_Pie_BorderWidth : <code>int</code></summary>
        member this.borderWidth = Figure_PlotOptions_Pie_BorderWidth()
        static member ToJson (o:{| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}) =
            let allowPointSelect = sprintf "%b" o.allowPointSelect
            let crisp = sprintf "%b" o.crisp
            let showCheckbox = sprintf "%b" o.showCheckbox
            let animation = Figure_PlotOptions_Pie_Animation.ToJson o.animation
            let events = Figure_PlotOptions_Pie_Events.ToJson o.events
            let marker = sprintf "%f" o.marker
            let point = Figure_PlotOptions_Pie_Point.ToJson o.point
            let dataLabels = Figure_PlotOptions_Pie_DataLabels.ToJson o.dataLabels
            let cropThreshold = sprintf "%i" o.cropThreshold
            let opacity = sprintf "%i" o.opacity
            let pointRange = sprintf "%i" o.pointRange
            let softThreshold = sprintf "%b" o.softThreshold
            let states = Figure_PlotOptions_Pie_States.ToJson o.states
            let stickyTracking = sprintf "%b" o.stickyTracking
            let turboThreshold = sprintf "%i" o.turboThreshold
            let findNearestPointBy = sprintf "\\\"%s\\\"" o.findNearestPointBy
            let center = Figure_PlotOptions_Pie_Center.ToJson o.center
            let clip = sprintf "%b" o.clip
            let colorByPoint = sprintf "%b" o.colorByPoint
            let ignoreHiddenPoint = sprintf "%b" o.ignoreHiddenPoint
            let inactiveOtherPoints = sprintf "%b" o.inactiveOtherPoints
            let legendType = sprintf "\\\"%s\\\"" o.legendType
            let size = sprintf "%f" o.size
            let showInLegend = sprintf "%b" o.showInLegend
            let slicedOffset = sprintf "%i" o.slicedOffset
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            let borderWidth = sprintf "%i" o.borderWidth
            sprintf "{\\\"allowPointSelect\\\":%s,\\\"crisp\\\":%s,\\\"showCheckbox\\\":%s,\\\"animation\\\":%s,\\\"events\\\":%s,\\\"marker\\\":%s,\\\"point\\\":%s,\\\"dataLabels\\\":%s,\\\"cropThreshold\\\":%s,\\\"opacity\\\":%s,\\\"pointRange\\\":%s,\\\"softThreshold\\\":%s,\\\"states\\\":%s,\\\"stickyTracking\\\":%s,\\\"turboThreshold\\\":%s,\\\"findNearestPointBy\\\":%s,\\\"center\\\":%s,\\\"clip\\\":%s,\\\"colorByPoint\\\":%s,\\\"ignoreHiddenPoint\\\":%s,\\\"inactiveOtherPoints\\\":%s,\\\"legendType\\\":%s,\\\"size\\\":%s,\\\"showInLegend\\\":%s,\\\"slicedOffset\\\":%s,\\\"borderColor\\\":%s,\\\"borderWidth\\\":%s}" allowPointSelect crisp showCheckbox animation events marker point dataLabels cropThreshold opacity pointRange softThreshold states stickyTracking turboThreshold findNearestPointBy center clip colorByPoint ignoreHiddenPoint inactiveOtherPoints legendType size showInLegend slicedOffset borderColor borderWidth

        member this.Set (o:{| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"pie\\\":%s}}" (Figure_PlotOptions_Pie.ToJson o))


    ///<summary>Figure_PlotOptions_Candlestick_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Candlestick_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"candlestick\\\":{\\\"lineColor\\\":%s}}}" (Figure_PlotOptions_Candlestick_LineColor.ToJson o))

    ///<summary>Figure_PlotOptions_Candlestick : <code>{| lineColor:string |}</code></summary>
    type Figure_PlotOptions_Candlestick() = 

        ///<summary>Figure_PlotOptions_Candlestick_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Candlestick_LineColor()
        static member ToJson (o:{| lineColor:string |}) =
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            sprintf "{\\\"lineColor\\\":%s}" lineColor

        member this.Set (o:{| lineColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":{\\\"candlestick\\\":%s}}" (Figure_PlotOptions_Candlestick.ToJson o))


    ///<summary>Figure_PlotOptions : <code>{| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}</code></summary>
    type Figure_PlotOptions() = 

        ///<summary>Figure_PlotOptions_Line : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}</code></summary>
        member this.line = Figure_PlotOptions_Line()

        ///<summary>Figure_PlotOptions_Area : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}</code></summary>
        member this.area = Figure_PlotOptions_Area()

        ///<summary>Figure_PlotOptions_Spline : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}</code></summary>
        member this.spline = Figure_PlotOptions_Spline()

        ///<summary>Figure_PlotOptions_Areaspline : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}</code></summary>
        member this.areaspline = Figure_PlotOptions_Areaspline()

        ///<summary>Figure_PlotOptions_Column : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}</code></summary>
        member this.column = Figure_PlotOptions_Column()

        ///<summary>Figure_PlotOptions_Bar : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}</code></summary>
        member this.bar = Figure_PlotOptions_Bar()

        ///<summary>Figure_PlotOptions_Scatter : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}</code></summary>
        member this.scatter = Figure_PlotOptions_Scatter()

        ///<summary>Figure_PlotOptions_Pie : <code>{| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}</code></summary>
        member this.pie = Figure_PlotOptions_Pie()

        ///<summary>Figure_PlotOptions_Candlestick : <code>{| lineColor:string |}</code></summary>
        member this.candlestick = Figure_PlotOptions_Candlestick()
        static member ToJson (o:{| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}) =
            let line = Figure_PlotOptions_Line.ToJson o.line
            let area = Figure_PlotOptions_Area.ToJson o.area
            let spline = Figure_PlotOptions_Spline.ToJson o.spline
            let areaspline = Figure_PlotOptions_Areaspline.ToJson o.areaspline
            let column = Figure_PlotOptions_Column.ToJson o.column
            let bar = Figure_PlotOptions_Bar.ToJson o.bar
            let scatter = Figure_PlotOptions_Scatter.ToJson o.scatter
            let pie = Figure_PlotOptions_Pie.ToJson o.pie
            let candlestick = Figure_PlotOptions_Candlestick.ToJson o.candlestick
            sprintf "{\\\"line\\\":%s,\\\"area\\\":%s,\\\"spline\\\":%s,\\\"areaspline\\\":%s,\\\"column\\\":%s,\\\"bar\\\":%s,\\\"scatter\\\":%s,\\\"pie\\\":%s,\\\"candlestick\\\":%s}" line area spline areaspline column bar scatter pie candlestick

        member this.Set (o:{| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"plotOptions\\\":%s}" (Figure_PlotOptions.ToJson o))


    ///<summary>Figure_Labels_Style_Position : <code>string</code></summary>
    type Figure_Labels_Style_Position() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"labels\\\":{\\\"style\\\":{\\\"position\\\":%s}}}" (Figure_Labels_Style_Position.ToJson o))

    ///<summary>Figure_Labels_Style_Color : <code>string</code></summary>
    type Figure_Labels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"labels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}" (Figure_Labels_Style_Color.ToJson o))

    ///<summary>Figure_Labels_Style : <code>{| position:string; color:string |}</code></summary>
    type Figure_Labels_Style() = 

        ///<summary>Figure_Labels_Style_Position : <code>string</code></summary>
        member this.position = Figure_Labels_Style_Position()

        ///<summary>Figure_Labels_Style_Color : <code>string</code></summary>
        member this.color = Figure_Labels_Style_Color()
        static member ToJson (o:{| position:string; color:string |}) =
            let position = sprintf "\\\"%s\\\"" o.position
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"position\\\":%s,\\\"color\\\":%s}" position color

        member this.Set (o:{| position:string; color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"labels\\\":{\\\"style\\\":%s}}" (Figure_Labels_Style.ToJson o))


    ///<summary>Figure_Labels : <code>{| style: {| position:string; color:string |} |}</code></summary>
    type Figure_Labels() = 

        ///<summary>Figure_Labels_Style : <code>{| position:string; color:string |}</code></summary>
        member this.style = Figure_Labels_Style()
        static member ToJson (o:{| style: {| position:string; color:string |} |}) =
            let style = Figure_Labels_Style.ToJson o.style
            sprintf "{\\\"style\\\":%s}" style

        member this.Set (o:{| style: {| position:string; color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"labels\\\":%s}" (Figure_Labels.ToJson o))


    ///<summary>Figure_Legend_Enabled : <code>bool</code></summary>
    type Figure_Legend_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"enabled\\\":%s}}" (Figure_Legend_Enabled.ToJson o))

    ///<summary>Figure_Legend_Align : <code>string</code></summary>
    type Figure_Legend_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"align\\\":%s}}" (Figure_Legend_Align.ToJson o))

    ///<summary>Figure_Legend_AlignColumns : <code>bool</code></summary>
    type Figure_Legend_AlignColumns() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"alignColumns\\\":%s}}" (Figure_Legend_AlignColumns.ToJson o))

    ///<summary>Figure_Legend_Layout : <code>string</code></summary>
    type Figure_Legend_Layout() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"layout\\\":%s}}" (Figure_Legend_Layout.ToJson o))

    ///<summary>Figure_Legend_BorderColor : <code>string</code></summary>
    type Figure_Legend_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"borderColor\\\":%s}}" (Figure_Legend_BorderColor.ToJson o))

    ///<summary>Figure_Legend_BorderRadius : <code>int</code></summary>
    type Figure_Legend_BorderRadius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"borderRadius\\\":%s}}" (Figure_Legend_BorderRadius.ToJson o))

    ///<summary>Figure_Legend_Navigation_ActiveColor : <code>string</code></summary>
    type Figure_Legend_Navigation_ActiveColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"navigation\\\":{\\\"activeColor\\\":%s}}}" (Figure_Legend_Navigation_ActiveColor.ToJson o))

    ///<summary>Figure_Legend_Navigation_InactiveColor : <code>string</code></summary>
    type Figure_Legend_Navigation_InactiveColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"navigation\\\":{\\\"inactiveColor\\\":%s}}}" (Figure_Legend_Navigation_InactiveColor.ToJson o))

    ///<summary>Figure_Legend_Navigation : <code>{| activeColor:string; inactiveColor:string |}</code></summary>
    type Figure_Legend_Navigation() = 

        ///<summary>Figure_Legend_Navigation_ActiveColor : <code>string</code></summary>
        member this.activeColor = Figure_Legend_Navigation_ActiveColor()

        ///<summary>Figure_Legend_Navigation_InactiveColor : <code>string</code></summary>
        member this.inactiveColor = Figure_Legend_Navigation_InactiveColor()
        static member ToJson (o:{| activeColor:string; inactiveColor:string |}) =
            let activeColor = sprintf "\\\"%s\\\"" o.activeColor
            let inactiveColor = sprintf "\\\"%s\\\"" o.inactiveColor
            sprintf "{\\\"activeColor\\\":%s,\\\"inactiveColor\\\":%s}" activeColor inactiveColor

        member this.Set (o:{| activeColor:string; inactiveColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"navigation\\\":%s}}" (Figure_Legend_Navigation.ToJson o))


    ///<summary>Figure_Legend_ItemStyle_Color : <code>string</code></summary>
    type Figure_Legend_ItemStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":{\\\"color\\\":%s}}}" (Figure_Legend_ItemStyle_Color.ToJson o))

    ///<summary>Figure_Legend_ItemStyle_Cursor : <code>string</code></summary>
    type Figure_Legend_ItemStyle_Cursor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":{\\\"cursor\\\":%s}}}" (Figure_Legend_ItemStyle_Cursor.ToJson o))

    ///<summary>Figure_Legend_ItemStyle_FontSize : <code>string</code></summary>
    type Figure_Legend_ItemStyle_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":{\\\"fontSize\\\":%s}}}" (Figure_Legend_ItemStyle_FontSize.ToJson o))

    ///<summary>Figure_Legend_ItemStyle_FontWeight : <code>string</code></summary>
    type Figure_Legend_ItemStyle_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":{\\\"fontWeight\\\":%s}}}" (Figure_Legend_ItemStyle_FontWeight.ToJson o))

    ///<summary>Figure_Legend_ItemStyle_TextOverflow : <code>string</code></summary>
    type Figure_Legend_ItemStyle_TextOverflow() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":{\\\"textOverflow\\\":%s}}}" (Figure_Legend_ItemStyle_TextOverflow.ToJson o))

    ///<summary>Figure_Legend_ItemStyle_Font : <code>string</code></summary>
    type Figure_Legend_ItemStyle_Font() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":{\\\"font\\\":%s}}}" (Figure_Legend_ItemStyle_Font.ToJson o))

    ///<summary>Figure_Legend_ItemStyle : <code>{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}</code></summary>
    type Figure_Legend_ItemStyle() = 

        ///<summary>Figure_Legend_ItemStyle_Color : <code>string</code></summary>
        member this.color = Figure_Legend_ItemStyle_Color()

        ///<summary>Figure_Legend_ItemStyle_Cursor : <code>string</code></summary>
        member this.cursor = Figure_Legend_ItemStyle_Cursor()

        ///<summary>Figure_Legend_ItemStyle_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_Legend_ItemStyle_FontSize()

        ///<summary>Figure_Legend_ItemStyle_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_Legend_ItemStyle_FontWeight()

        ///<summary>Figure_Legend_ItemStyle_TextOverflow : <code>string</code></summary>
        member this.textOverflow = Figure_Legend_ItemStyle_TextOverflow()

        ///<summary>Figure_Legend_ItemStyle_Font : <code>string</code></summary>
        member this.font = Figure_Legend_ItemStyle_Font()
        static member ToJson (o:{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let cursor = sprintf "\\\"%s\\\"" o.cursor
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let textOverflow = sprintf "\\\"%s\\\"" o.textOverflow
            let font = sprintf "\\\"%s\\\"" o.font
            sprintf "{\\\"color\\\":%s,\\\"cursor\\\":%s,\\\"fontSize\\\":%s,\\\"fontWeight\\\":%s,\\\"textOverflow\\\":%s,\\\"font\\\":%s}" color cursor fontSize fontWeight textOverflow font

        member this.Set (o:{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemStyle\\\":%s}}" (Figure_Legend_ItemStyle.ToJson o))


    ///<summary>Figure_Legend_ItemHoverStyle_Color : <code>string</code></summary>
    type Figure_Legend_ItemHoverStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemHoverStyle\\\":{\\\"color\\\":%s}}}" (Figure_Legend_ItemHoverStyle_Color.ToJson o))

    ///<summary>Figure_Legend_ItemHoverStyle : <code>{| color:string |}</code></summary>
    type Figure_Legend_ItemHoverStyle() = 

        ///<summary>Figure_Legend_ItemHoverStyle_Color : <code>string</code></summary>
        member this.color = Figure_Legend_ItemHoverStyle_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemHoverStyle\\\":%s}}" (Figure_Legend_ItemHoverStyle.ToJson o))


    ///<summary>Figure_Legend_ItemHiddenStyle_Color : <code>string</code></summary>
    type Figure_Legend_ItemHiddenStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemHiddenStyle\\\":{\\\"color\\\":%s}}}" (Figure_Legend_ItemHiddenStyle_Color.ToJson o))

    ///<summary>Figure_Legend_ItemHiddenStyle : <code>{| color:string |}</code></summary>
    type Figure_Legend_ItemHiddenStyle() = 

        ///<summary>Figure_Legend_ItemHiddenStyle_Color : <code>string</code></summary>
        member this.color = Figure_Legend_ItemHiddenStyle_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemHiddenStyle\\\":%s}}" (Figure_Legend_ItemHiddenStyle.ToJson o))


    ///<summary>Figure_Legend_Shadow : <code>bool</code></summary>
    type Figure_Legend_Shadow() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"shadow\\\":%s}}" (Figure_Legend_Shadow.ToJson o))

    ///<summary>Figure_Legend_ItemCheckboxStyle_Position : <code>string</code></summary>
    type Figure_Legend_ItemCheckboxStyle_Position() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemCheckboxStyle\\\":{\\\"position\\\":%s}}}" (Figure_Legend_ItemCheckboxStyle_Position.ToJson o))

    ///<summary>Figure_Legend_ItemCheckboxStyle_Width : <code>string</code></summary>
    type Figure_Legend_ItemCheckboxStyle_Width() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemCheckboxStyle\\\":{\\\"width\\\":%s}}}" (Figure_Legend_ItemCheckboxStyle_Width.ToJson o))

    ///<summary>Figure_Legend_ItemCheckboxStyle_Height : <code>string</code></summary>
    type Figure_Legend_ItemCheckboxStyle_Height() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemCheckboxStyle\\\":{\\\"height\\\":%s}}}" (Figure_Legend_ItemCheckboxStyle_Height.ToJson o))

    ///<summary>Figure_Legend_ItemCheckboxStyle : <code>{| position:string; width:string; height:string |}</code></summary>
    type Figure_Legend_ItemCheckboxStyle() = 

        ///<summary>Figure_Legend_ItemCheckboxStyle_Position : <code>string</code></summary>
        member this.position = Figure_Legend_ItemCheckboxStyle_Position()

        ///<summary>Figure_Legend_ItemCheckboxStyle_Width : <code>string</code></summary>
        member this.width = Figure_Legend_ItemCheckboxStyle_Width()

        ///<summary>Figure_Legend_ItemCheckboxStyle_Height : <code>string</code></summary>
        member this.height = Figure_Legend_ItemCheckboxStyle_Height()
        static member ToJson (o:{| position:string; width:string; height:string |}) =
            let position = sprintf "\\\"%s\\\"" o.position
            let width = sprintf "\\\"%s\\\"" o.width
            let height = sprintf "\\\"%s\\\"" o.height
            sprintf "{\\\"position\\\":%s,\\\"width\\\":%s,\\\"height\\\":%s}" position width height

        member this.Set (o:{| position:string; width:string; height:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"itemCheckboxStyle\\\":%s}}" (Figure_Legend_ItemCheckboxStyle.ToJson o))


    ///<summary>Figure_Legend_SquareSymbol : <code>bool</code></summary>
    type Figure_Legend_SquareSymbol() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"squareSymbol\\\":%s}}" (Figure_Legend_SquareSymbol.ToJson o))

    ///<summary>Figure_Legend_SymbolPadding : <code>int</code></summary>
    type Figure_Legend_SymbolPadding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"symbolPadding\\\":%s}}" (Figure_Legend_SymbolPadding.ToJson o))

    ///<summary>Figure_Legend_VerticalAlign : <code>string</code></summary>
    type Figure_Legend_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"verticalAlign\\\":%s}}" (Figure_Legend_VerticalAlign.ToJson o))

    ///<summary>Figure_Legend_X : <code>int</code></summary>
    type Figure_Legend_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"x\\\":%s}}" (Figure_Legend_X.ToJson o))

    ///<summary>Figure_Legend_Y : <code>int</code></summary>
    type Figure_Legend_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"y\\\":%s}}" (Figure_Legend_Y.ToJson o))

    ///<summary>Figure_Legend_Title_Style_FontWeight : <code>string</code></summary>
    type Figure_Legend_Title_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}" (Figure_Legend_Title_Style_FontWeight.ToJson o))

    ///<summary>Figure_Legend_Title_Style_Color : <code>string</code></summary>
    type Figure_Legend_Title_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"title\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}" (Figure_Legend_Title_Style_Color.ToJson o))

    ///<summary>Figure_Legend_Title_Style : <code>{| fontWeight:string; color:string |}</code></summary>
    type Figure_Legend_Title_Style() = 

        ///<summary>Figure_Legend_Title_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_Legend_Title_Style_FontWeight()

        ///<summary>Figure_Legend_Title_Style_Color : <code>string</code></summary>
        member this.color = Figure_Legend_Title_Style_Color()
        static member ToJson (o:{| fontWeight:string; color:string |}) =
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"fontWeight\\\":%s,\\\"color\\\":%s}" fontWeight color

        member this.Set (o:{| fontWeight:string; color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"title\\\":{\\\"style\\\":%s}}}" (Figure_Legend_Title_Style.ToJson o))


    ///<summary>Figure_Legend_Title : <code>{| style: {| fontWeight:string; color:string |} |}</code></summary>
    type Figure_Legend_Title() = 

        ///<summary>Figure_Legend_Title_Style : <code>{| fontWeight:string; color:string |}</code></summary>
        member this.style = Figure_Legend_Title_Style()
        static member ToJson (o:{| style: {| fontWeight:string; color:string |} |}) =
            let style = Figure_Legend_Title_Style.ToJson o.style
            sprintf "{\\\"style\\\":%s}" style

        member this.Set (o:{| style: {| fontWeight:string; color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"title\\\":%s}}" (Figure_Legend_Title.ToJson o))


    ///<summary>Figure_Legend_BackgroundColor : <code>string</code></summary>
    type Figure_Legend_BackgroundColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":{\\\"backgroundColor\\\":%s}}" (Figure_Legend_BackgroundColor.ToJson o))

    ///<summary>Figure_Legend : <code>{| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}</code></summary>
    type Figure_Legend() = 

        ///<summary>Figure_Legend_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_Legend_Enabled()

        ///<summary>Figure_Legend_Align : <code>string</code></summary>
        member this.align = Figure_Legend_Align()

        ///<summary>Figure_Legend_AlignColumns : <code>bool</code></summary>
        member this.alignColumns = Figure_Legend_AlignColumns()

        ///<summary>Figure_Legend_Layout : <code>string</code></summary>
        member this.layout = Figure_Legend_Layout()

        ///<summary>Figure_Legend_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_Legend_BorderColor()

        ///<summary>Figure_Legend_BorderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_Legend_BorderRadius()

        ///<summary>Figure_Legend_Navigation : <code>{| activeColor:string; inactiveColor:string |}</code></summary>
        member this.navigation = Figure_Legend_Navigation()

        ///<summary>Figure_Legend_ItemStyle : <code>{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}</code></summary>
        member this.itemStyle = Figure_Legend_ItemStyle()

        ///<summary>Figure_Legend_ItemHoverStyle : <code>{| color:string |}</code></summary>
        member this.itemHoverStyle = Figure_Legend_ItemHoverStyle()

        ///<summary>Figure_Legend_ItemHiddenStyle : <code>{| color:string |}</code></summary>
        member this.itemHiddenStyle = Figure_Legend_ItemHiddenStyle()

        ///<summary>Figure_Legend_Shadow : <code>bool</code></summary>
        member this.shadow = Figure_Legend_Shadow()

        ///<summary>Figure_Legend_ItemCheckboxStyle : <code>{| position:string; width:string; height:string |}</code></summary>
        member this.itemCheckboxStyle = Figure_Legend_ItemCheckboxStyle()

        ///<summary>Figure_Legend_SquareSymbol : <code>bool</code></summary>
        member this.squareSymbol = Figure_Legend_SquareSymbol()

        ///<summary>Figure_Legend_SymbolPadding : <code>int</code></summary>
        member this.symbolPadding = Figure_Legend_SymbolPadding()

        ///<summary>Figure_Legend_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Legend_VerticalAlign()

        ///<summary>Figure_Legend_X : <code>int</code></summary>
        member this.x = Figure_Legend_X()

        ///<summary>Figure_Legend_Y : <code>int</code></summary>
        member this.y = Figure_Legend_Y()

        ///<summary>Figure_Legend_Title : <code>{| style: {| fontWeight:string; color:string |} |}</code></summary>
        member this.title = Figure_Legend_Title()

        ///<summary>Figure_Legend_BackgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Legend_BackgroundColor()
        static member ToJson (o:{| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}) =
            let enabled = sprintf "%b" o.enabled
            let align = sprintf "\\\"%s\\\"" o.align
            let alignColumns = sprintf "%b" o.alignColumns
            let layout = sprintf "\\\"%s\\\"" o.layout
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            let borderRadius = sprintf "%i" o.borderRadius
            let navigation = Figure_Legend_Navigation.ToJson o.navigation
            let itemStyle = Figure_Legend_ItemStyle.ToJson o.itemStyle
            let itemHoverStyle = Figure_Legend_ItemHoverStyle.ToJson o.itemHoverStyle
            let itemHiddenStyle = Figure_Legend_ItemHiddenStyle.ToJson o.itemHiddenStyle
            let shadow = sprintf "%b" o.shadow
            let itemCheckboxStyle = Figure_Legend_ItemCheckboxStyle.ToJson o.itemCheckboxStyle
            let squareSymbol = sprintf "%b" o.squareSymbol
            let symbolPadding = sprintf "%i" o.symbolPadding
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let x = sprintf "%i" o.x
            let y = sprintf "%i" o.y
            let title = Figure_Legend_Title.ToJson o.title
            let backgroundColor = sprintf "\\\"%s\\\"" o.backgroundColor
            sprintf "{\\\"enabled\\\":%s,\\\"align\\\":%s,\\\"alignColumns\\\":%s,\\\"layout\\\":%s,\\\"borderColor\\\":%s,\\\"borderRadius\\\":%s,\\\"navigation\\\":%s,\\\"itemStyle\\\":%s,\\\"itemHoverStyle\\\":%s,\\\"itemHiddenStyle\\\":%s,\\\"shadow\\\":%s,\\\"itemCheckboxStyle\\\":%s,\\\"squareSymbol\\\":%s,\\\"symbolPadding\\\":%s,\\\"verticalAlign\\\":%s,\\\"x\\\":%s,\\\"y\\\":%s,\\\"title\\\":%s,\\\"backgroundColor\\\":%s}" enabled align alignColumns layout borderColor borderRadius navigation itemStyle itemHoverStyle itemHiddenStyle shadow itemCheckboxStyle squareSymbol symbolPadding verticalAlign x y title backgroundColor

        member this.Set (o:{| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"legend\\\":%s}" (Figure_Legend.ToJson o))


    ///<summary>Figure_Loading_LabelStyle_FontWeight : <code>string</code></summary>
    type Figure_Loading_LabelStyle_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"labelStyle\\\":{\\\"fontWeight\\\":%s}}}" (Figure_Loading_LabelStyle_FontWeight.ToJson o))

    ///<summary>Figure_Loading_LabelStyle_Position : <code>string</code></summary>
    type Figure_Loading_LabelStyle_Position() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"labelStyle\\\":{\\\"position\\\":%s}}}" (Figure_Loading_LabelStyle_Position.ToJson o))

    ///<summary>Figure_Loading_LabelStyle_Top : <code>string</code></summary>
    type Figure_Loading_LabelStyle_Top() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"labelStyle\\\":{\\\"top\\\":%s}}}" (Figure_Loading_LabelStyle_Top.ToJson o))

    ///<summary>Figure_Loading_LabelStyle : <code>{| fontWeight:string; position:string; top:string |}</code></summary>
    type Figure_Loading_LabelStyle() = 

        ///<summary>Figure_Loading_LabelStyle_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_Loading_LabelStyle_FontWeight()

        ///<summary>Figure_Loading_LabelStyle_Position : <code>string</code></summary>
        member this.position = Figure_Loading_LabelStyle_Position()

        ///<summary>Figure_Loading_LabelStyle_Top : <code>string</code></summary>
        member this.top = Figure_Loading_LabelStyle_Top()
        static member ToJson (o:{| fontWeight:string; position:string; top:string |}) =
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let position = sprintf "\\\"%s\\\"" o.position
            let top = sprintf "\\\"%s\\\"" o.top
            sprintf "{\\\"fontWeight\\\":%s,\\\"position\\\":%s,\\\"top\\\":%s}" fontWeight position top

        member this.Set (o:{| fontWeight:string; position:string; top:string |}) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"labelStyle\\\":%s}}" (Figure_Loading_LabelStyle.ToJson o))


    ///<summary>Figure_Loading_Style_Position : <code>string</code></summary>
    type Figure_Loading_Style_Position() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"style\\\":{\\\"position\\\":%s}}}" (Figure_Loading_Style_Position.ToJson o))

    ///<summary>Figure_Loading_Style_BackgroundColor : <code>string</code></summary>
    type Figure_Loading_Style_BackgroundColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"style\\\":{\\\"backgroundColor\\\":%s}}}" (Figure_Loading_Style_BackgroundColor.ToJson o))

    ///<summary>Figure_Loading_Style_Opacity : <code>int</code></summary>
    type Figure_Loading_Style_Opacity() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"style\\\":{\\\"opacity\\\":%s}}}" (Figure_Loading_Style_Opacity.ToJson o))

    ///<summary>Figure_Loading_Style_TextAlign : <code>string</code></summary>
    type Figure_Loading_Style_TextAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"style\\\":{\\\"textAlign\\\":%s}}}" (Figure_Loading_Style_TextAlign.ToJson o))

    ///<summary>Figure_Loading_Style : <code>{| position:string; backgroundColor:string; opacity:int; textAlign:string |}</code></summary>
    type Figure_Loading_Style() = 

        ///<summary>Figure_Loading_Style_Position : <code>string</code></summary>
        member this.position = Figure_Loading_Style_Position()

        ///<summary>Figure_Loading_Style_BackgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Loading_Style_BackgroundColor()

        ///<summary>Figure_Loading_Style_Opacity : <code>int</code></summary>
        member this.opacity = Figure_Loading_Style_Opacity()

        ///<summary>Figure_Loading_Style_TextAlign : <code>string</code></summary>
        member this.textAlign = Figure_Loading_Style_TextAlign()
        static member ToJson (o:{| position:string; backgroundColor:string; opacity:int; textAlign:string |}) =
            let position = sprintf "\\\"%s\\\"" o.position
            let backgroundColor = sprintf "\\\"%s\\\"" o.backgroundColor
            let opacity = sprintf "%i" o.opacity
            let textAlign = sprintf "\\\"%s\\\"" o.textAlign
            sprintf "{\\\"position\\\":%s,\\\"backgroundColor\\\":%s,\\\"opacity\\\":%s,\\\"textAlign\\\":%s}" position backgroundColor opacity textAlign

        member this.Set (o:{| position:string; backgroundColor:string; opacity:int; textAlign:string |}) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":{\\\"style\\\":%s}}" (Figure_Loading_Style.ToJson o))


    ///<summary>Figure_Loading : <code>{| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}</code></summary>
    type Figure_Loading() = 

        ///<summary>Figure_Loading_LabelStyle : <code>{| fontWeight:string; position:string; top:string |}</code></summary>
        member this.labelStyle = Figure_Loading_LabelStyle()

        ///<summary>Figure_Loading_Style : <code>{| position:string; backgroundColor:string; opacity:int; textAlign:string |}</code></summary>
        member this.style = Figure_Loading_Style()
        static member ToJson (o:{| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}) =
            let labelStyle = Figure_Loading_LabelStyle.ToJson o.labelStyle
            let style = Figure_Loading_Style.ToJson o.style
            sprintf "{\\\"labelStyle\\\":%s,\\\"style\\\":%s}" labelStyle style

        member this.Set (o:{| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"loading\\\":%s}" (Figure_Loading.ToJson o))


    ///<summary>Figure_Tooltip_Enabled : <code>bool</code></summary>
    type Figure_Tooltip_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"enabled\\\":%s}}" (Figure_Tooltip_Enabled.ToJson o))

    ///<summary>Figure_Tooltip_Animation : <code>bool</code></summary>
    type Figure_Tooltip_Animation() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"animation\\\":%s}}" (Figure_Tooltip_Animation.ToJson o))

    ///<summary>Figure_Tooltip_BorderRadius : <code>int</code></summary>
    type Figure_Tooltip_BorderRadius() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"borderRadius\\\":%s}}" (Figure_Tooltip_BorderRadius.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Millisecond : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Millisecond() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"millisecond\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Millisecond.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Second : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Second() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"second\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Second.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Minute : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Minute() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"minute\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Minute.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Hour : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Hour() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"hour\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Hour.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Day : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Day() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"day\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Day.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Week : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Week() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"week\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Week.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Month : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Month() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"month\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Month.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Year : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Year() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":{\\\"year\\\":%s}}}" (Figure_Tooltip_DateTimeLabelFormats_Year.ToJson o))

    ///<summary>Figure_Tooltip_DateTimeLabelFormats : <code>{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats() = 

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Millisecond : <code>string</code></summary>
        member this.millisecond = Figure_Tooltip_DateTimeLabelFormats_Millisecond()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Second : <code>string</code></summary>
        member this.second = Figure_Tooltip_DateTimeLabelFormats_Second()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Minute : <code>string</code></summary>
        member this.minute = Figure_Tooltip_DateTimeLabelFormats_Minute()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Hour : <code>string</code></summary>
        member this.hour = Figure_Tooltip_DateTimeLabelFormats_Hour()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Day : <code>string</code></summary>
        member this.day = Figure_Tooltip_DateTimeLabelFormats_Day()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Week : <code>string</code></summary>
        member this.week = Figure_Tooltip_DateTimeLabelFormats_Week()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Month : <code>string</code></summary>
        member this.month = Figure_Tooltip_DateTimeLabelFormats_Month()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats_Year : <code>string</code></summary>
        member this.year = Figure_Tooltip_DateTimeLabelFormats_Year()
        static member ToJson (o:{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}) =
            let millisecond = sprintf "\\\"%s\\\"" o.millisecond
            let second = sprintf "\\\"%s\\\"" o.second
            let minute = sprintf "\\\"%s\\\"" o.minute
            let hour = sprintf "\\\"%s\\\"" o.hour
            let day = sprintf "\\\"%s\\\"" o.day
            let week = sprintf "\\\"%s\\\"" o.week
            let month = sprintf "\\\"%s\\\"" o.month
            let year = sprintf "\\\"%s\\\"" o.year
            sprintf "{\\\"millisecond\\\":%s,\\\"second\\\":%s,\\\"minute\\\":%s,\\\"hour\\\":%s,\\\"day\\\":%s,\\\"week\\\":%s,\\\"month\\\":%s,\\\"year\\\":%s}" millisecond second minute hour day week month year

        member this.Set (o:{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"dateTimeLabelFormats\\\":%s}}" (Figure_Tooltip_DateTimeLabelFormats.ToJson o))


    ///<summary>Figure_Tooltip_FooterFormat : <code>string</code></summary>
    type Figure_Tooltip_FooterFormat() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"footerFormat\\\":%s}}" (Figure_Tooltip_FooterFormat.ToJson o))

    ///<summary>Figure_Tooltip_Padding : <code>int</code></summary>
    type Figure_Tooltip_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"padding\\\":%s}}" (Figure_Tooltip_Padding.ToJson o))

    ///<summary>Figure_Tooltip_Snap : <code>int</code></summary>
    type Figure_Tooltip_Snap() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"snap\\\":%s}}" (Figure_Tooltip_Snap.ToJson o))

    ///<summary>Figure_Tooltip_HeaderFormat : <code>string</code></summary>
    type Figure_Tooltip_HeaderFormat() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"headerFormat\\\":%s}}" (Figure_Tooltip_HeaderFormat.ToJson o))

    ///<summary>Figure_Tooltip_PointFormat : <code>string</code></summary>
    type Figure_Tooltip_PointFormat() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"pointFormat\\\":%s}}" (Figure_Tooltip_PointFormat.ToJson o))

    ///<summary>Figure_Tooltip_BackgroundColor : <code>string</code></summary>
    type Figure_Tooltip_BackgroundColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"backgroundColor\\\":%s}}" (Figure_Tooltip_BackgroundColor.ToJson o))

    ///<summary>Figure_Tooltip_BorderWidth : <code>int</code></summary>
    type Figure_Tooltip_BorderWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"borderWidth\\\":%s}}" (Figure_Tooltip_BorderWidth.ToJson o))

    ///<summary>Figure_Tooltip_Shadow : <code>bool</code></summary>
    type Figure_Tooltip_Shadow() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"shadow\\\":%s}}" (Figure_Tooltip_Shadow.ToJson o))

    ///<summary>Figure_Tooltip_Style_Color : <code>string</code></summary>
    type Figure_Tooltip_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"style\\\":{\\\"color\\\":%s}}}" (Figure_Tooltip_Style_Color.ToJson o))

    ///<summary>Figure_Tooltip_Style_Cursor : <code>string</code></summary>
    type Figure_Tooltip_Style_Cursor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"style\\\":{\\\"cursor\\\":%s}}}" (Figure_Tooltip_Style_Cursor.ToJson o))

    ///<summary>Figure_Tooltip_Style_FontSize : <code>string</code></summary>
    type Figure_Tooltip_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}" (Figure_Tooltip_Style_FontSize.ToJson o))

    ///<summary>Figure_Tooltip_Style_WhiteSpace : <code>string</code></summary>
    type Figure_Tooltip_Style_WhiteSpace() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"style\\\":{\\\"whiteSpace\\\":%s}}}" (Figure_Tooltip_Style_WhiteSpace.ToJson o))

    ///<summary>Figure_Tooltip_Style : <code>{| color:string; cursor:string; fontSize:string; whiteSpace:string |}</code></summary>
    type Figure_Tooltip_Style() = 

        ///<summary>Figure_Tooltip_Style_Color : <code>string</code></summary>
        member this.color = Figure_Tooltip_Style_Color()

        ///<summary>Figure_Tooltip_Style_Cursor : <code>string</code></summary>
        member this.cursor = Figure_Tooltip_Style_Cursor()

        ///<summary>Figure_Tooltip_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_Tooltip_Style_FontSize()

        ///<summary>Figure_Tooltip_Style_WhiteSpace : <code>string</code></summary>
        member this.whiteSpace = Figure_Tooltip_Style_WhiteSpace()
        static member ToJson (o:{| color:string; cursor:string; fontSize:string; whiteSpace:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let cursor = sprintf "\\\"%s\\\"" o.cursor
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let whiteSpace = sprintf "\\\"%s\\\"" o.whiteSpace
            sprintf "{\\\"color\\\":%s,\\\"cursor\\\":%s,\\\"fontSize\\\":%s,\\\"whiteSpace\\\":%s}" color cursor fontSize whiteSpace

        member this.Set (o:{| color:string; cursor:string; fontSize:string; whiteSpace:string |}) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":{\\\"style\\\":%s}}" (Figure_Tooltip_Style.ToJson o))


    ///<summary>Figure_Tooltip : <code>{| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}</code></summary>
    type Figure_Tooltip() = 

        ///<summary>Figure_Tooltip_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_Tooltip_Enabled()

        ///<summary>Figure_Tooltip_Animation : <code>bool</code></summary>
        member this.animation = Figure_Tooltip_Animation()

        ///<summary>Figure_Tooltip_BorderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_Tooltip_BorderRadius()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats : <code>{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}</code></summary>
        member this.dateTimeLabelFormats = Figure_Tooltip_DateTimeLabelFormats()

        ///<summary>Figure_Tooltip_FooterFormat : <code>string</code></summary>
        member this.footerFormat = Figure_Tooltip_FooterFormat()

        ///<summary>Figure_Tooltip_Padding : <code>int</code></summary>
        member this.padding = Figure_Tooltip_Padding()

        ///<summary>Figure_Tooltip_Snap : <code>int</code></summary>
        member this.snap = Figure_Tooltip_Snap()

        ///<summary>Figure_Tooltip_HeaderFormat : <code>string</code></summary>
        member this.headerFormat = Figure_Tooltip_HeaderFormat()

        ///<summary>Figure_Tooltip_PointFormat : <code>string</code></summary>
        member this.pointFormat = Figure_Tooltip_PointFormat()

        ///<summary>Figure_Tooltip_BackgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Tooltip_BackgroundColor()

        ///<summary>Figure_Tooltip_BorderWidth : <code>int</code></summary>
        member this.borderWidth = Figure_Tooltip_BorderWidth()

        ///<summary>Figure_Tooltip_Shadow : <code>bool</code></summary>
        member this.shadow = Figure_Tooltip_Shadow()

        ///<summary>Figure_Tooltip_Style : <code>{| color:string; cursor:string; fontSize:string; whiteSpace:string |}</code></summary>
        member this.style = Figure_Tooltip_Style()
        static member ToJson (o:{| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}) =
            let enabled = sprintf "%b" o.enabled
            let animation = sprintf "%b" o.animation
            let borderRadius = sprintf "%i" o.borderRadius
            let dateTimeLabelFormats = Figure_Tooltip_DateTimeLabelFormats.ToJson o.dateTimeLabelFormats
            let footerFormat = sprintf "\\\"%s\\\"" o.footerFormat
            let padding = sprintf "%i" o.padding
            let snap = sprintf "%i" o.snap
            let headerFormat = sprintf "\\\"%s\\\"" o.headerFormat
            let pointFormat = sprintf "\\\"%s\\\"" o.pointFormat
            let backgroundColor = sprintf "\\\"%s\\\"" o.backgroundColor
            let borderWidth = sprintf "%i" o.borderWidth
            let shadow = sprintf "%b" o.shadow
            let style = Figure_Tooltip_Style.ToJson o.style
            sprintf "{\\\"enabled\\\":%s,\\\"animation\\\":%s,\\\"borderRadius\\\":%s,\\\"dateTimeLabelFormats\\\":%s,\\\"footerFormat\\\":%s,\\\"padding\\\":%s,\\\"snap\\\":%s,\\\"headerFormat\\\":%s,\\\"pointFormat\\\":%s,\\\"backgroundColor\\\":%s,\\\"borderWidth\\\":%s,\\\"shadow\\\":%s,\\\"style\\\":%s}" enabled animation borderRadius dateTimeLabelFormats footerFormat padding snap headerFormat pointFormat backgroundColor borderWidth shadow style

        member this.Set (o:{| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"tooltip\\\":%s}" (Figure_Tooltip.ToJson o))


    ///<summary>Figure_Credits_Enabled : <code>bool</code></summary>
    type Figure_Credits_Enabled() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"enabled\\\":%s}}" (Figure_Credits_Enabled.ToJson o))

    ///<summary>Figure_Credits_Href : <code>string</code></summary>
    type Figure_Credits_Href() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"href\\\":%s}}" (Figure_Credits_Href.ToJson o))

    ///<summary>Figure_Credits_Position_Align : <code>string</code></summary>
    type Figure_Credits_Position_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"position\\\":{\\\"align\\\":%s}}}" (Figure_Credits_Position_Align.ToJson o))

    ///<summary>Figure_Credits_Position_X : <code>int</code></summary>
    type Figure_Credits_Position_X() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"position\\\":{\\\"x\\\":%s}}}" (Figure_Credits_Position_X.ToJson o))

    ///<summary>Figure_Credits_Position_VerticalAlign : <code>string</code></summary>
    type Figure_Credits_Position_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"position\\\":{\\\"verticalAlign\\\":%s}}}" (Figure_Credits_Position_VerticalAlign.ToJson o))

    ///<summary>Figure_Credits_Position_Y : <code>int</code></summary>
    type Figure_Credits_Position_Y() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"position\\\":{\\\"y\\\":%s}}}" (Figure_Credits_Position_Y.ToJson o))

    ///<summary>Figure_Credits_Position : <code>{| align:string; x:int; verticalAlign:string; y:int |}</code></summary>
    type Figure_Credits_Position() = 

        ///<summary>Figure_Credits_Position_Align : <code>string</code></summary>
        member this.align = Figure_Credits_Position_Align()

        ///<summary>Figure_Credits_Position_X : <code>int</code></summary>
        member this.x = Figure_Credits_Position_X()

        ///<summary>Figure_Credits_Position_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Credits_Position_VerticalAlign()

        ///<summary>Figure_Credits_Position_Y : <code>int</code></summary>
        member this.y = Figure_Credits_Position_Y()
        static member ToJson (o:{| align:string; x:int; verticalAlign:string; y:int |}) =
            let align = sprintf "\\\"%s\\\"" o.align
            let x = sprintf "%i" o.x
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let y = sprintf "%i" o.y
            sprintf "{\\\"align\\\":%s,\\\"x\\\":%s,\\\"verticalAlign\\\":%s,\\\"y\\\":%s}" align x verticalAlign y

        member this.Set (o:{| align:string; x:int; verticalAlign:string; y:int |}) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"position\\\":%s}}" (Figure_Credits_Position.ToJson o))


    ///<summary>Figure_Credits_Style_Cursor : <code>string</code></summary>
    type Figure_Credits_Style_Cursor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"style\\\":{\\\"cursor\\\":%s}}}" (Figure_Credits_Style_Cursor.ToJson o))

    ///<summary>Figure_Credits_Style_Color : <code>string</code></summary>
    type Figure_Credits_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"style\\\":{\\\"color\\\":%s}}}" (Figure_Credits_Style_Color.ToJson o))

    ///<summary>Figure_Credits_Style_FontSize : <code>string</code></summary>
    type Figure_Credits_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}" (Figure_Credits_Style_FontSize.ToJson o))

    ///<summary>Figure_Credits_Style_Fill : <code>string</code></summary>
    type Figure_Credits_Style_Fill() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"style\\\":{\\\"fill\\\":%s}}}" (Figure_Credits_Style_Fill.ToJson o))

    ///<summary>Figure_Credits_Style : <code>{| cursor:string; color:string; fontSize:string; fill:string |}</code></summary>
    type Figure_Credits_Style() = 

        ///<summary>Figure_Credits_Style_Cursor : <code>string</code></summary>
        member this.cursor = Figure_Credits_Style_Cursor()

        ///<summary>Figure_Credits_Style_Color : <code>string</code></summary>
        member this.color = Figure_Credits_Style_Color()

        ///<summary>Figure_Credits_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_Credits_Style_FontSize()

        ///<summary>Figure_Credits_Style_Fill : <code>string</code></summary>
        member this.fill = Figure_Credits_Style_Fill()
        static member ToJson (o:{| cursor:string; color:string; fontSize:string; fill:string |}) =
            let cursor = sprintf "\\\"%s\\\"" o.cursor
            let color = sprintf "\\\"%s\\\"" o.color
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fill = sprintf "\\\"%s\\\"" o.fill
            sprintf "{\\\"cursor\\\":%s,\\\"color\\\":%s,\\\"fontSize\\\":%s,\\\"fill\\\":%s}" cursor color fontSize fill

        member this.Set (o:{| cursor:string; color:string; fontSize:string; fill:string |}) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"style\\\":%s}}" (Figure_Credits_Style.ToJson o))


    ///<summary>Figure_Credits_Text : <code>string</code></summary>
    type Figure_Credits_Text() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":{\\\"text\\\":%s}}" (Figure_Credits_Text.ToJson o))

    ///<summary>Figure_Credits : <code>{| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}</code></summary>
    type Figure_Credits() = 

        ///<summary>Figure_Credits_Enabled : <code>bool</code></summary>
        member this.enabled = Figure_Credits_Enabled()

        ///<summary>Figure_Credits_Href : <code>string</code></summary>
        member this.href = Figure_Credits_Href()

        ///<summary>Figure_Credits_Position : <code>{| align:string; x:int; verticalAlign:string; y:int |}</code></summary>
        member this.position = Figure_Credits_Position()

        ///<summary>Figure_Credits_Style : <code>{| cursor:string; color:string; fontSize:string; fill:string |}</code></summary>
        member this.style = Figure_Credits_Style()

        ///<summary>Figure_Credits_Text : <code>string</code></summary>
        member this.text = Figure_Credits_Text()
        static member ToJson (o:{| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}) =
            let enabled = sprintf "%b" o.enabled
            let href = sprintf "\\\"%s\\\"" o.href
            let position = Figure_Credits_Position.ToJson o.position
            let style = Figure_Credits_Style.ToJson o.style
            let text = sprintf "\\\"%s\\\"" o.text
            sprintf "{\\\"enabled\\\":%s,\\\"href\\\":%s,\\\"position\\\":%s,\\\"style\\\":%s,\\\"text\\\":%s}" enabled href position style text

        member this.Set (o:{| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}) =
            update currentChartIndex "" (sprintf "{\\\"credits\\\":%s}" (Figure_Credits.ToJson o))


    ///<summary>Figure_Navigation_ButtonOptions_Theme_Padding : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Padding() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"padding\\\":%s}}}}" (Figure_Navigation_ButtonOptions_Theme_Padding.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient() = 

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":%s}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient.ToJson o))


    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item() =
        let item = Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_Stops() =
        let item = Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":{\\\"stops\\\":%s}}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill() = 

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Navigation_ButtonOptions_Theme_Fill_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient.ToJson o.linearGradient
            let stops = Figure_Navigation_ButtonOptions_Theme_Fill_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"fill\\\":%s}}}}" (Figure_Navigation_ButtonOptions_Theme_Fill.ToJson o))


    ///<summary>Figure_Navigation_ButtonOptions_Theme_Stroke : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Stroke() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":{\\\"stroke\\\":%s}}}}" (Figure_Navigation_ButtonOptions_Theme_Stroke.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Theme : <code>{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}</code></summary>
    type Figure_Navigation_ButtonOptions_Theme() = 

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Padding : <code>int</code></summary>
        member this.padding = Figure_Navigation_ButtonOptions_Theme_Padding()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_Navigation_ButtonOptions_Theme_Fill()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Stroke : <code>string</code></summary>
        member this.stroke = Figure_Navigation_ButtonOptions_Theme_Stroke()
        static member ToJson (o:{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}) =
            let padding = sprintf "%i" o.padding
            let fill = Figure_Navigation_ButtonOptions_Theme_Fill.ToJson o.fill
            let stroke = sprintf "\\\"%s\\\"" o.stroke
            sprintf "{\\\"padding\\\":%s,\\\"fill\\\":%s,\\\"stroke\\\":%s}" padding fill stroke

        member this.Set (o:{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"theme\\\":%s}}}" (Figure_Navigation_ButtonOptions_Theme.ToJson o))


    ///<summary>Figure_Navigation_ButtonOptions_SymbolSize : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolSize() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"symbolSize\\\":%s}}}" (Figure_Navigation_ButtonOptions_SymbolSize.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_SymbolX : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolX() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"symbolX\\\":%s}}}" (Figure_Navigation_ButtonOptions_SymbolX.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_SymbolY : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolY() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"symbolY\\\":%s}}}" (Figure_Navigation_ButtonOptions_SymbolY.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Align : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_Align() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"align\\\":%s}}}" (Figure_Navigation_ButtonOptions_Align.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_ButtonSpacing : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_ButtonSpacing() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"buttonSpacing\\\":%s}}}" (Figure_Navigation_ButtonOptions_ButtonSpacing.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Height : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Height() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"height\\\":%s}}}" (Figure_Navigation_ButtonOptions_Height.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_VerticalAlign : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_VerticalAlign() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"verticalAlign\\\":%s}}}" (Figure_Navigation_ButtonOptions_VerticalAlign.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_Width : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Width() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"width\\\":%s}}}" (Figure_Navigation_ButtonOptions_Width.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_SymbolFill : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolFill() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"symbolFill\\\":%s}}}" (Figure_Navigation_ButtonOptions_SymbolFill.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_SymbolStroke : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolStroke() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"symbolStroke\\\":%s}}}" (Figure_Navigation_ButtonOptions_SymbolStroke.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions_SymbolStrokeWidth : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolStrokeWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":{\\\"symbolStrokeWidth\\\":%s}}}" (Figure_Navigation_ButtonOptions_SymbolStrokeWidth.ToJson o))

    ///<summary>Figure_Navigation_ButtonOptions : <code>{| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}</code></summary>
    type Figure_Navigation_ButtonOptions() = 

        ///<summary>Figure_Navigation_ButtonOptions_Theme : <code>{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}</code></summary>
        member this.theme = Figure_Navigation_ButtonOptions_Theme()

        ///<summary>Figure_Navigation_ButtonOptions_SymbolSize : <code>int</code></summary>
        member this.symbolSize = Figure_Navigation_ButtonOptions_SymbolSize()

        ///<summary>Figure_Navigation_ButtonOptions_SymbolX : <code>int</code></summary>
        member this.symbolX = Figure_Navigation_ButtonOptions_SymbolX()

        ///<summary>Figure_Navigation_ButtonOptions_SymbolY : <code>int</code></summary>
        member this.symbolY = Figure_Navigation_ButtonOptions_SymbolY()

        ///<summary>Figure_Navigation_ButtonOptions_Align : <code>string</code></summary>
        member this.align = Figure_Navigation_ButtonOptions_Align()

        ///<summary>Figure_Navigation_ButtonOptions_ButtonSpacing : <code>int</code></summary>
        member this.buttonSpacing = Figure_Navigation_ButtonOptions_ButtonSpacing()

        ///<summary>Figure_Navigation_ButtonOptions_Height : <code>int</code></summary>
        member this.height = Figure_Navigation_ButtonOptions_Height()

        ///<summary>Figure_Navigation_ButtonOptions_VerticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Navigation_ButtonOptions_VerticalAlign()

        ///<summary>Figure_Navigation_ButtonOptions_Width : <code>int</code></summary>
        member this.width = Figure_Navigation_ButtonOptions_Width()

        ///<summary>Figure_Navigation_ButtonOptions_SymbolFill : <code>string</code></summary>
        member this.symbolFill = Figure_Navigation_ButtonOptions_SymbolFill()

        ///<summary>Figure_Navigation_ButtonOptions_SymbolStroke : <code>string</code></summary>
        member this.symbolStroke = Figure_Navigation_ButtonOptions_SymbolStroke()

        ///<summary>Figure_Navigation_ButtonOptions_SymbolStrokeWidth : <code>int</code></summary>
        member this.symbolStrokeWidth = Figure_Navigation_ButtonOptions_SymbolStrokeWidth()
        static member ToJson (o:{| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}) =
            let theme = Figure_Navigation_ButtonOptions_Theme.ToJson o.theme
            let symbolSize = sprintf "%i" o.symbolSize
            let symbolX = sprintf "%i" o.symbolX
            let symbolY = sprintf "%i" o.symbolY
            let align = sprintf "\\\"%s\\\"" o.align
            let buttonSpacing = sprintf "%i" o.buttonSpacing
            let height = sprintf "%i" o.height
            let verticalAlign = sprintf "\\\"%s\\\"" o.verticalAlign
            let width = sprintf "%i" o.width
            let symbolFill = sprintf "\\\"%s\\\"" o.symbolFill
            let symbolStroke = sprintf "\\\"%s\\\"" o.symbolStroke
            let symbolStrokeWidth = sprintf "%i" o.symbolStrokeWidth
            sprintf "{\\\"theme\\\":%s,\\\"symbolSize\\\":%s,\\\"symbolX\\\":%s,\\\"symbolY\\\":%s,\\\"align\\\":%s,\\\"buttonSpacing\\\":%s,\\\"height\\\":%s,\\\"verticalAlign\\\":%s,\\\"width\\\":%s,\\\"symbolFill\\\":%s,\\\"symbolStroke\\\":%s,\\\"symbolStrokeWidth\\\":%s}" theme symbolSize symbolX symbolY align buttonSpacing height verticalAlign width symbolFill symbolStroke symbolStrokeWidth

        member this.Set (o:{| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"buttonOptions\\\":%s}}" (Figure_Navigation_ButtonOptions.ToJson o))


    ///<summary>Figure_Navigation_MenuStyle_Border : <code>string</code></summary>
    type Figure_Navigation_MenuStyle_Border() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuStyle\\\":{\\\"border\\\":%s}}}" (Figure_Navigation_MenuStyle_Border.ToJson o))

    ///<summary>Figure_Navigation_MenuStyle_Background : <code>string</code></summary>
    type Figure_Navigation_MenuStyle_Background() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuStyle\\\":{\\\"background\\\":%s}}}" (Figure_Navigation_MenuStyle_Background.ToJson o))

    ///<summary>Figure_Navigation_MenuStyle_Padding : <code>string</code></summary>
    type Figure_Navigation_MenuStyle_Padding() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuStyle\\\":{\\\"padding\\\":%s}}}" (Figure_Navigation_MenuStyle_Padding.ToJson o))

    ///<summary>Figure_Navigation_MenuStyle : <code>{| border:string; background:string; padding:string |}</code></summary>
    type Figure_Navigation_MenuStyle() = 

        ///<summary>Figure_Navigation_MenuStyle_Border : <code>string</code></summary>
        member this.border = Figure_Navigation_MenuStyle_Border()

        ///<summary>Figure_Navigation_MenuStyle_Background : <code>string</code></summary>
        member this.background = Figure_Navigation_MenuStyle_Background()

        ///<summary>Figure_Navigation_MenuStyle_Padding : <code>string</code></summary>
        member this.padding = Figure_Navigation_MenuStyle_Padding()
        static member ToJson (o:{| border:string; background:string; padding:string |}) =
            let border = sprintf "\\\"%s\\\"" o.border
            let background = sprintf "\\\"%s\\\"" o.background
            let padding = sprintf "\\\"%s\\\"" o.padding
            sprintf "{\\\"border\\\":%s,\\\"background\\\":%s,\\\"padding\\\":%s}" border background padding

        member this.Set (o:{| border:string; background:string; padding:string |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuStyle\\\":%s}}" (Figure_Navigation_MenuStyle.ToJson o))


    ///<summary>Figure_Navigation_MenuItemStyle_Padding : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Padding() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemStyle\\\":{\\\"padding\\\":%s}}}" (Figure_Navigation_MenuItemStyle_Padding.ToJson o))

    ///<summary>Figure_Navigation_MenuItemStyle_Color : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemStyle\\\":{\\\"color\\\":%s}}}" (Figure_Navigation_MenuItemStyle_Color.ToJson o))

    ///<summary>Figure_Navigation_MenuItemStyle_Background : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Background() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemStyle\\\":{\\\"background\\\":%s}}}" (Figure_Navigation_MenuItemStyle_Background.ToJson o))

    ///<summary>Figure_Navigation_MenuItemStyle_FontSize : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemStyle\\\":{\\\"fontSize\\\":%s}}}" (Figure_Navigation_MenuItemStyle_FontSize.ToJson o))

    ///<summary>Figure_Navigation_MenuItemStyle_Transition : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Transition() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemStyle\\\":{\\\"transition\\\":%s}}}" (Figure_Navigation_MenuItemStyle_Transition.ToJson o))

    ///<summary>Figure_Navigation_MenuItemStyle : <code>{| padding:string; color:string; background:string; fontSize:string; transition:string |}</code></summary>
    type Figure_Navigation_MenuItemStyle() = 

        ///<summary>Figure_Navigation_MenuItemStyle_Padding : <code>string</code></summary>
        member this.padding = Figure_Navigation_MenuItemStyle_Padding()

        ///<summary>Figure_Navigation_MenuItemStyle_Color : <code>string</code></summary>
        member this.color = Figure_Navigation_MenuItemStyle_Color()

        ///<summary>Figure_Navigation_MenuItemStyle_Background : <code>string</code></summary>
        member this.background = Figure_Navigation_MenuItemStyle_Background()

        ///<summary>Figure_Navigation_MenuItemStyle_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_Navigation_MenuItemStyle_FontSize()

        ///<summary>Figure_Navigation_MenuItemStyle_Transition : <code>string</code></summary>
        member this.transition = Figure_Navigation_MenuItemStyle_Transition()
        static member ToJson (o:{| padding:string; color:string; background:string; fontSize:string; transition:string |}) =
            let padding = sprintf "\\\"%s\\\"" o.padding
            let color = sprintf "\\\"%s\\\"" o.color
            let background = sprintf "\\\"%s\\\"" o.background
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let transition = sprintf "\\\"%s\\\"" o.transition
            sprintf "{\\\"padding\\\":%s,\\\"color\\\":%s,\\\"background\\\":%s,\\\"fontSize\\\":%s,\\\"transition\\\":%s}" padding color background fontSize transition

        member this.Set (o:{| padding:string; color:string; background:string; fontSize:string; transition:string |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemStyle\\\":%s}}" (Figure_Navigation_MenuItemStyle.ToJson o))


    ///<summary>Figure_Navigation_MenuItemHoverStyle_Background : <code>string</code></summary>
    type Figure_Navigation_MenuItemHoverStyle_Background() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemHoverStyle\\\":{\\\"background\\\":%s}}}" (Figure_Navigation_MenuItemHoverStyle_Background.ToJson o))

    ///<summary>Figure_Navigation_MenuItemHoverStyle_Color : <code>string</code></summary>
    type Figure_Navigation_MenuItemHoverStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemHoverStyle\\\":{\\\"color\\\":%s}}}" (Figure_Navigation_MenuItemHoverStyle_Color.ToJson o))

    ///<summary>Figure_Navigation_MenuItemHoverStyle : <code>{| background:string; color:string |}</code></summary>
    type Figure_Navigation_MenuItemHoverStyle() = 

        ///<summary>Figure_Navigation_MenuItemHoverStyle_Background : <code>string</code></summary>
        member this.background = Figure_Navigation_MenuItemHoverStyle_Background()

        ///<summary>Figure_Navigation_MenuItemHoverStyle_Color : <code>string</code></summary>
        member this.color = Figure_Navigation_MenuItemHoverStyle_Color()
        static member ToJson (o:{| background:string; color:string |}) =
            let background = sprintf "\\\"%s\\\"" o.background
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"background\\\":%s,\\\"color\\\":%s}" background color

        member this.Set (o:{| background:string; color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":{\\\"menuItemHoverStyle\\\":%s}}" (Figure_Navigation_MenuItemHoverStyle.ToJson o))


    ///<summary>Figure_Navigation : <code>{| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}</code></summary>
    type Figure_Navigation() = 

        ///<summary>Figure_Navigation_ButtonOptions : <code>{| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}</code></summary>
        member this.buttonOptions = Figure_Navigation_ButtonOptions()

        ///<summary>Figure_Navigation_MenuStyle : <code>{| border:string; background:string; padding:string |}</code></summary>
        member this.menuStyle = Figure_Navigation_MenuStyle()

        ///<summary>Figure_Navigation_MenuItemStyle : <code>{| padding:string; color:string; background:string; fontSize:string; transition:string |}</code></summary>
        member this.menuItemStyle = Figure_Navigation_MenuItemStyle()

        ///<summary>Figure_Navigation_MenuItemHoverStyle : <code>{| background:string; color:string |}</code></summary>
        member this.menuItemHoverStyle = Figure_Navigation_MenuItemHoverStyle()
        static member ToJson (o:{| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}) =
            let buttonOptions = Figure_Navigation_ButtonOptions.ToJson o.buttonOptions
            let menuStyle = Figure_Navigation_MenuStyle.ToJson o.menuStyle
            let menuItemStyle = Figure_Navigation_MenuItemStyle.ToJson o.menuItemStyle
            let menuItemHoverStyle = Figure_Navigation_MenuItemHoverStyle.ToJson o.menuItemHoverStyle
            sprintf "{\\\"buttonOptions\\\":%s,\\\"menuStyle\\\":%s,\\\"menuItemStyle\\\":%s,\\\"menuItemHoverStyle\\\":%s}" buttonOptions menuStyle menuItemStyle menuItemHoverStyle

        member this.Set (o:{| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"navigation\\\":%s}" (Figure_Navigation.ToJson o))


    ///<summary>Figure_Exporting_Type : <code>string</code></summary>
    type Figure_Exporting_Type() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"type\\\":%s}}" (Figure_Exporting_Type.ToJson o))

    ///<summary>Figure_Exporting_Url : <code>string</code></summary>
    type Figure_Exporting_Url() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"url\\\":%s}}" (Figure_Exporting_Url.ToJson o))

    ///<summary>Figure_Exporting_PrintMaxWidth : <code>int</code></summary>
    type Figure_Exporting_PrintMaxWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"printMaxWidth\\\":%s}}" (Figure_Exporting_PrintMaxWidth.ToJson o))

    ///<summary>Figure_Exporting_Scale : <code>int</code></summary>
    type Figure_Exporting_Scale() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"scale\\\":%s}}" (Figure_Exporting_Scale.ToJson o))

    ///<summary>Figure_Exporting_Buttons_ContextButton_ClassName : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_ClassName() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":{\\\"className\\\":%s}}}}" (Figure_Exporting_Buttons_ContextButton_ClassName.ToJson o))

    ///<summary>Figure_Exporting_Buttons_ContextButton_MenuClassName : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_MenuClassName() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":{\\\"menuClassName\\\":%s}}}}" (Figure_Exporting_Buttons_ContextButton_MenuClassName.ToJson o))

    ///<summary>Figure_Exporting_Buttons_ContextButton_Symbol : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_Symbol() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":{\\\"symbol\\\":%s}}}}" (Figure_Exporting_Buttons_ContextButton_Symbol.ToJson o))

    ///<summary>Figure_Exporting_Buttons_ContextButton_TitleKey : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_TitleKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":{\\\"titleKey\\\":%s}}}}" (Figure_Exporting_Buttons_ContextButton_TitleKey.ToJson o))

    ///<summary>Figure_Exporting_Buttons_ContextButton_MenuItems_Item : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_MenuItems_Item() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":{\\\"menuItems\\\":{\\\"item\\\":%s}}}}}" (Figure_Exporting_Buttons_ContextButton_MenuItems_Item.ToJson o))

    ///<summary>Figure_Exporting_Buttons_ContextButton_MenuItems : <code>string seq</code></summary>
    type Figure_Exporting_Buttons_ContextButton_MenuItems() =
        let item = Figure_Exporting_Buttons_ContextButton_MenuItems_Item()

        static member ToJson (o:string seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Exporting_Buttons_ContextButton_MenuItems_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:string seq) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":{\\\"menuItems\\\":%s}}}}" (Figure_Exporting_Buttons_ContextButton_MenuItems.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Exporting_Buttons_ContextButton : <code>{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}</code></summary>
    type Figure_Exporting_Buttons_ContextButton() = 

        ///<summary>Figure_Exporting_Buttons_ContextButton_ClassName : <code>string</code></summary>
        member this.className = Figure_Exporting_Buttons_ContextButton_ClassName()

        ///<summary>Figure_Exporting_Buttons_ContextButton_MenuClassName : <code>string</code></summary>
        member this.menuClassName = Figure_Exporting_Buttons_ContextButton_MenuClassName()

        ///<summary>Figure_Exporting_Buttons_ContextButton_Symbol : <code>string</code></summary>
        member this.symbol = Figure_Exporting_Buttons_ContextButton_Symbol()

        ///<summary>Figure_Exporting_Buttons_ContextButton_TitleKey : <code>string</code></summary>
        member this.titleKey = Figure_Exporting_Buttons_ContextButton_TitleKey()

        ///<summary>Figure_Exporting_Buttons_ContextButton_MenuItems : <code>string seq</code></summary>
        member this.menuItems = Figure_Exporting_Buttons_ContextButton_MenuItems()
        static member ToJson (o:{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}) =
            let className = sprintf "\\\"%s\\\"" o.className
            let menuClassName = sprintf "\\\"%s\\\"" o.menuClassName
            let symbol = sprintf "\\\"%s\\\"" o.symbol
            let titleKey = sprintf "\\\"%s\\\"" o.titleKey
            let menuItems = Figure_Exporting_Buttons_ContextButton_MenuItems.ToJson o.menuItems
            sprintf "{\\\"className\\\":%s,\\\"menuClassName\\\":%s,\\\"symbol\\\":%s,\\\"titleKey\\\":%s,\\\"menuItems\\\":%s}" className menuClassName symbol titleKey menuItems

        member this.Set (o:{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":{\\\"contextButton\\\":%s}}}" (Figure_Exporting_Buttons_ContextButton.ToJson o))


    ///<summary>Figure_Exporting_Buttons : <code>{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}</code></summary>
    type Figure_Exporting_Buttons() = 

        ///<summary>Figure_Exporting_Buttons_ContextButton : <code>{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}</code></summary>
        member this.contextButton = Figure_Exporting_Buttons_ContextButton()
        static member ToJson (o:{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}) =
            let contextButton = Figure_Exporting_Buttons_ContextButton.ToJson o.contextButton
            sprintf "{\\\"contextButton\\\":%s}" contextButton

        member this.Set (o:{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"buttons\\\":%s}}" (Figure_Exporting_Buttons.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"viewFullscreen\\\":{\\\"textKey\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_ViewFullscreen : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_ViewFullscreen() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey()
        static member ToJson (o:{| textKey:string |}) =
            let textKey = sprintf "\\\"%s\\\"" o.textKey
            sprintf "{\\\"textKey\\\":%s}" textKey

        member this.Set (o:{| textKey:string |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"viewFullscreen\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_ViewFullscreen.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"printChart\\\":{\\\"textKey\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_PrintChart : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_PrintChart() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey()
        static member ToJson (o:{| textKey:string |}) =
            let textKey = sprintf "\\\"%s\\\"" o.textKey
            sprintf "{\\\"textKey\\\":%s}" textKey

        member this.Set (o:{| textKey:string |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"printChart\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_PrintChart.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_Separator_Separator : <code>bool</code></summary>
    type Figure_Exporting_MenuItemDefinitions_Separator_Separator() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"separator\\\":{\\\"separator\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_Separator_Separator.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_Separator : <code>{| separator:bool |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_Separator() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_Separator_Separator : <code>bool</code></summary>
        member this.separator = Figure_Exporting_MenuItemDefinitions_Separator_Separator()
        static member ToJson (o:{| separator:bool |}) =
            let separator = sprintf "%b" o.separator
            sprintf "{\\\"separator\\\":%s}" separator

        member this.Set (o:{| separator:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"separator\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_Separator.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadPNG\\\":{\\\"textKey\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPNG : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPNG() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey()
        static member ToJson (o:{| textKey:string |}) =
            let textKey = sprintf "\\\"%s\\\"" o.textKey
            sprintf "{\\\"textKey\\\":%s}" textKey

        member this.Set (o:{| textKey:string |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadPNG\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_DownloadPNG.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadJPEG\\\":{\\\"textKey\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadJPEG : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadJPEG() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey()
        static member ToJson (o:{| textKey:string |}) =
            let textKey = sprintf "\\\"%s\\\"" o.textKey
            sprintf "{\\\"textKey\\\":%s}" textKey

        member this.Set (o:{| textKey:string |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadJPEG\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_DownloadJPEG.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadPDF\\\":{\\\"textKey\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPDF : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPDF() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey()
        static member ToJson (o:{| textKey:string |}) =
            let textKey = sprintf "\\\"%s\\\"" o.textKey
            sprintf "{\\\"textKey\\\":%s}" textKey

        member this.Set (o:{| textKey:string |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadPDF\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_DownloadPDF.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadSVG\\\":{\\\"textKey\\\":%s}}}}" (Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey.ToJson o))

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadSVG : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadSVG() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey()
        static member ToJson (o:{| textKey:string |}) =
            let textKey = sprintf "\\\"%s\\\"" o.textKey
            sprintf "{\\\"textKey\\\":%s}" textKey

        member this.Set (o:{| textKey:string |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":{\\\"downloadSVG\\\":%s}}}" (Figure_Exporting_MenuItemDefinitions_DownloadSVG.ToJson o))


    ///<summary>Figure_Exporting_MenuItemDefinitions : <code>{| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions() = 

        ///<summary>Figure_Exporting_MenuItemDefinitions_ViewFullscreen : <code>{| textKey:string |}</code></summary>
        member this.viewFullscreen = Figure_Exporting_MenuItemDefinitions_ViewFullscreen()

        ///<summary>Figure_Exporting_MenuItemDefinitions_PrintChart : <code>{| textKey:string |}</code></summary>
        member this.printChart = Figure_Exporting_MenuItemDefinitions_PrintChart()

        ///<summary>Figure_Exporting_MenuItemDefinitions_Separator : <code>{| separator:bool |}</code></summary>
        member this.separator = Figure_Exporting_MenuItemDefinitions_Separator()

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPNG : <code>{| textKey:string |}</code></summary>
        member this.downloadPNG = Figure_Exporting_MenuItemDefinitions_DownloadPNG()

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadJPEG : <code>{| textKey:string |}</code></summary>
        member this.downloadJPEG = Figure_Exporting_MenuItemDefinitions_DownloadJPEG()

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPDF : <code>{| textKey:string |}</code></summary>
        member this.downloadPDF = Figure_Exporting_MenuItemDefinitions_DownloadPDF()

        ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadSVG : <code>{| textKey:string |}</code></summary>
        member this.downloadSVG = Figure_Exporting_MenuItemDefinitions_DownloadSVG()
        static member ToJson (o:{| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |}) =
            let viewFullscreen = Figure_Exporting_MenuItemDefinitions_ViewFullscreen.ToJson o.viewFullscreen
            let printChart = Figure_Exporting_MenuItemDefinitions_PrintChart.ToJson o.printChart
            let separator = Figure_Exporting_MenuItemDefinitions_Separator.ToJson o.separator
            let downloadPNG = Figure_Exporting_MenuItemDefinitions_DownloadPNG.ToJson o.downloadPNG
            let downloadJPEG = Figure_Exporting_MenuItemDefinitions_DownloadJPEG.ToJson o.downloadJPEG
            let downloadPDF = Figure_Exporting_MenuItemDefinitions_DownloadPDF.ToJson o.downloadPDF
            let downloadSVG = Figure_Exporting_MenuItemDefinitions_DownloadSVG.ToJson o.downloadSVG
            sprintf "{\\\"viewFullscreen\\\":%s,\\\"printChart\\\":%s,\\\"separator\\\":%s,\\\"downloadPNG\\\":%s,\\\"downloadJPEG\\\":%s,\\\"downloadPDF\\\":%s,\\\"downloadSVG\\\":%s}" viewFullscreen printChart separator downloadPNG downloadJPEG downloadPDF downloadSVG

        member this.Set (o:{| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":{\\\"menuItemDefinitions\\\":%s}}" (Figure_Exporting_MenuItemDefinitions.ToJson o))


    ///<summary>Figure_Exporting : <code>{| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}</code></summary>
    type Figure_Exporting() = 

        ///<summary>Figure_Exporting_Type : <code>string</code></summary>
        member this._type = Figure_Exporting_Type()

        ///<summary>Figure_Exporting_Url : <code>string</code></summary>
        member this.url = Figure_Exporting_Url()

        ///<summary>Figure_Exporting_PrintMaxWidth : <code>int</code></summary>
        member this.printMaxWidth = Figure_Exporting_PrintMaxWidth()

        ///<summary>Figure_Exporting_Scale : <code>int</code></summary>
        member this.scale = Figure_Exporting_Scale()

        ///<summary>Figure_Exporting_Buttons : <code>{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}</code></summary>
        member this.buttons = Figure_Exporting_Buttons()

        ///<summary>Figure_Exporting_MenuItemDefinitions : <code>{| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |}</code></summary>
        member this.menuItemDefinitions = Figure_Exporting_MenuItemDefinitions()
        static member ToJson (o:{| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}) =
            let _type = sprintf "\\\"%s\\\"" o._type
            let url = sprintf "\\\"%s\\\"" o.url
            let printMaxWidth = sprintf "%i" o.printMaxWidth
            let scale = sprintf "%i" o.scale
            let buttons = Figure_Exporting_Buttons.ToJson o.buttons
            let menuItemDefinitions = Figure_Exporting_MenuItemDefinitions.ToJson o.menuItemDefinitions
            sprintf "{\\\"_type\\\":%s,\\\"url\\\":%s,\\\"printMaxWidth\\\":%s,\\\"scale\\\":%s,\\\"buttons\\\":%s,\\\"menuItemDefinitions\\\":%s}" _type url printMaxWidth scale buttons menuItemDefinitions

        member this.Set (o:{| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"exporting\\\":%s}" (Figure_Exporting.ToJson o))


    ///<summary>Figure_XAxis_Item_GridLineColor : <code>string</code></summary>
    type Figure_XAxis_Item_GridLineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"gridLineColor\\\":%s}}}" (Figure_XAxis_Item_GridLineColor.ToJson o))

    ///<summary>Figure_XAxis_Item_GridLineWidth : <code>int</code></summary>
    type Figure_XAxis_Item_GridLineWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"gridLineWidth\\\":%s}}}" (Figure_XAxis_Item_GridLineWidth.ToJson o))

    ///<summary>Figure_XAxis_Item_Labels_Style_Color : <code>string</code></summary>
    type Figure_XAxis_Item_Labels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"labels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_XAxis_Item_Labels_Style_Color.ToJson o))

    ///<summary>Figure_XAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
    type Figure_XAxis_Item_Labels_Style() = 

        ///<summary>Figure_XAxis_Item_Labels_Style_Color : <code>string</code></summary>
        member this.color = Figure_XAxis_Item_Labels_Style_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"labels\\\":{\\\"style\\\":%s}}}}" (Figure_XAxis_Item_Labels_Style.ToJson o))


    ///<summary>Figure_XAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
    type Figure_XAxis_Item_Labels() = 

        ///<summary>Figure_XAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_XAxis_Item_Labels_Style()
        static member ToJson (o:{| style: {| color:string |} |}) =
            let style = Figure_XAxis_Item_Labels_Style.ToJson o.style
            sprintf "{\\\"style\\\":%s}" style

        member this.Set (o:{| style: {| color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"labels\\\":%s}}}" (Figure_XAxis_Item_Labels.ToJson o))


    ///<summary>Figure_XAxis_Item_LineColor : <code>string</code></summary>
    type Figure_XAxis_Item_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"lineColor\\\":%s}}}" (Figure_XAxis_Item_LineColor.ToJson o))

    ///<summary>Figure_XAxis_Item_TickColor : <code>string</code></summary>
    type Figure_XAxis_Item_TickColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"tickColor\\\":%s}}}" (Figure_XAxis_Item_TickColor.ToJson o))

    ///<summary>Figure_XAxis_Item_Title_Style_Color : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_XAxis_Item_Title_Style_Color.ToJson o))

    ///<summary>Figure_XAxis_Item_Title_Style_FontWeight : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_XAxis_Item_Title_Style_FontWeight.ToJson o))

    ///<summary>Figure_XAxis_Item_Title_Style_FontSize : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_XAxis_Item_Title_Style_FontSize.ToJson o))

    ///<summary>Figure_XAxis_Item_Title_Style_FontFamily : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_FontFamily() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontFamily\\\":%s}}}}}" (Figure_XAxis_Item_Title_Style_FontFamily.ToJson o))

    ///<summary>Figure_XAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
    type Figure_XAxis_Item_Title_Style() = 

        ///<summary>Figure_XAxis_Item_Title_Style_Color : <code>string</code></summary>
        member this.color = Figure_XAxis_Item_Title_Style_Color()

        ///<summary>Figure_XAxis_Item_Title_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_XAxis_Item_Title_Style_FontWeight()

        ///<summary>Figure_XAxis_Item_Title_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_XAxis_Item_Title_Style_FontSize()

        ///<summary>Figure_XAxis_Item_Title_Style_FontFamily : <code>string</code></summary>
        member this.fontFamily = Figure_XAxis_Item_Title_Style_FontFamily()
        static member ToJson (o:{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontFamily = sprintf "\\\"%s\\\"" o.fontFamily
            sprintf "{\\\"color\\\":%s,\\\"fontWeight\\\":%s,\\\"fontSize\\\":%s,\\\"fontFamily\\\":%s}" color fontWeight fontSize fontFamily

        member this.Set (o:{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":%s}}}}" (Figure_XAxis_Item_Title_Style.ToJson o))


    ///<summary>Figure_XAxis_Item_Title_Text : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Text() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"text\\\":%s}}}}" (Figure_XAxis_Item_Title_Text.ToJson o))

    ///<summary>Figure_XAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
    type Figure_XAxis_Item_Title() = 

        ///<summary>Figure_XAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
        member this.style = Figure_XAxis_Item_Title_Style()

        ///<summary>Figure_XAxis_Item_Title_Text : <code>string</code></summary>
        member this.text = Figure_XAxis_Item_Title_Text()
        static member ToJson (o:{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}) =
            let style = Figure_XAxis_Item_Title_Style.ToJson o.style
            let text = sprintf "\\\"%s\\\"" o.text
            sprintf "{\\\"style\\\":%s,\\\"text\\\":%s}" style text

        member this.Set (o:{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"title\\\":%s}}}" (Figure_XAxis_Item_Title.ToJson o))


    ///<summary>Figure_XAxis_Item_Index : <code>int</code></summary>
    type Figure_XAxis_Item_Index() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"index\\\":%s}}}" (Figure_XAxis_Item_Index.ToJson o))

    ///<summary>Figure_XAxis_Item_IsX : <code>bool</code></summary>
    type Figure_XAxis_Item_IsX() =
        static member ToJson (o:bool) =
            sprintf "%b" o

        member this.Set (o:bool) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":{\\\"isX\\\":%s}}}" (Figure_XAxis_Item_IsX.ToJson o))

    ///<summary>Figure_XAxis_Item : <code>{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |}</code></summary>
    type Figure_XAxis_Item() = 

        ///<summary>Figure_XAxis_Item_GridLineColor : <code>string</code></summary>
        member this.gridLineColor = Figure_XAxis_Item_GridLineColor()

        ///<summary>Figure_XAxis_Item_GridLineWidth : <code>int</code></summary>
        member this.gridLineWidth = Figure_XAxis_Item_GridLineWidth()

        ///<summary>Figure_XAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
        member this.labels = Figure_XAxis_Item_Labels()

        ///<summary>Figure_XAxis_Item_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_XAxis_Item_LineColor()

        ///<summary>Figure_XAxis_Item_TickColor : <code>string</code></summary>
        member this.tickColor = Figure_XAxis_Item_TickColor()

        ///<summary>Figure_XAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
        member this.title = Figure_XAxis_Item_Title()

        ///<summary>Figure_XAxis_Item_Index : <code>int</code></summary>
        member this.index = Figure_XAxis_Item_Index()

        ///<summary>Figure_XAxis_Item_IsX : <code>bool</code></summary>
        member this.isX = Figure_XAxis_Item_IsX()
        static member ToJson (o:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |}) =
            let gridLineColor = sprintf "\\\"%s\\\"" o.gridLineColor
            let gridLineWidth = sprintf "%i" o.gridLineWidth
            let labels = Figure_XAxis_Item_Labels.ToJson o.labels
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let tickColor = sprintf "\\\"%s\\\"" o.tickColor
            let title = Figure_XAxis_Item_Title.ToJson o.title
            let index = sprintf "%i" o.index
            let isX = sprintf "%b" o.isX
            sprintf "{\\\"gridLineColor\\\":%s,\\\"gridLineWidth\\\":%s,\\\"labels\\\":%s,\\\"lineColor\\\":%s,\\\"tickColor\\\":%s,\\\"title\\\":%s,\\\"index\\\":%s,\\\"isX\\\":%s}" gridLineColor gridLineWidth labels lineColor tickColor title index isX

        member this.Set (o:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |}) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":{\\\"item\\\":%s}}" (Figure_XAxis_Item.ToJson o))


    ///<summary>Figure_XAxis : <code>{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq</code></summary>
    type Figure_XAxis() =
        let item = Figure_XAxis_Item()

        static member ToJson (o:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_XAxis_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq) =
            update currentChartIndex "" (sprintf "{\\\"xAxis\\\":%s}" (Figure_XAxis.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_YAxis_Item_GridLineColor : <code>string</code></summary>
    type Figure_YAxis_Item_GridLineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"gridLineColor\\\":%s}}}" (Figure_YAxis_Item_GridLineColor.ToJson o))

    ///<summary>Figure_YAxis_Item_Labels_Style_Color : <code>string</code></summary>
    type Figure_YAxis_Item_Labels_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"labels\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_YAxis_Item_Labels_Style_Color.ToJson o))

    ///<summary>Figure_YAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
    type Figure_YAxis_Item_Labels_Style() = 

        ///<summary>Figure_YAxis_Item_Labels_Style_Color : <code>string</code></summary>
        member this.color = Figure_YAxis_Item_Labels_Style_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"labels\\\":{\\\"style\\\":%s}}}}" (Figure_YAxis_Item_Labels_Style.ToJson o))


    ///<summary>Figure_YAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
    type Figure_YAxis_Item_Labels() = 

        ///<summary>Figure_YAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_YAxis_Item_Labels_Style()
        static member ToJson (o:{| style: {| color:string |} |}) =
            let style = Figure_YAxis_Item_Labels_Style.ToJson o.style
            sprintf "{\\\"style\\\":%s}" style

        member this.Set (o:{| style: {| color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"labels\\\":%s}}}" (Figure_YAxis_Item_Labels.ToJson o))


    ///<summary>Figure_YAxis_Item_LineColor : <code>string</code></summary>
    type Figure_YAxis_Item_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"lineColor\\\":%s}}}" (Figure_YAxis_Item_LineColor.ToJson o))

    ///<summary>Figure_YAxis_Item_MinorTickInterval : <code>float</code></summary>
    type Figure_YAxis_Item_MinorTickInterval() =
        static member ToJson (o:float) =
            sprintf "%f" o

        member this.Set (o:float) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"minorTickInterval\\\":%s}}}" (Figure_YAxis_Item_MinorTickInterval.ToJson o))

    ///<summary>Figure_YAxis_Item_TickColor : <code>string</code></summary>
    type Figure_YAxis_Item_TickColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"tickColor\\\":%s}}}" (Figure_YAxis_Item_TickColor.ToJson o))

    ///<summary>Figure_YAxis_Item_TickWidth : <code>int</code></summary>
    type Figure_YAxis_Item_TickWidth() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"tickWidth\\\":%s}}}" (Figure_YAxis_Item_TickWidth.ToJson o))

    ///<summary>Figure_YAxis_Item_Title_Style_Color : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}" (Figure_YAxis_Item_Title_Style_Color.ToJson o))

    ///<summary>Figure_YAxis_Item_Title_Style_FontWeight : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}}" (Figure_YAxis_Item_Title_Style_FontWeight.ToJson o))

    ///<summary>Figure_YAxis_Item_Title_Style_FontSize : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_FontSize() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontSize\\\":%s}}}}}" (Figure_YAxis_Item_Title_Style_FontSize.ToJson o))

    ///<summary>Figure_YAxis_Item_Title_Style_FontFamily : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_FontFamily() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":{\\\"fontFamily\\\":%s}}}}}" (Figure_YAxis_Item_Title_Style_FontFamily.ToJson o))

    ///<summary>Figure_YAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
    type Figure_YAxis_Item_Title_Style() = 

        ///<summary>Figure_YAxis_Item_Title_Style_Color : <code>string</code></summary>
        member this.color = Figure_YAxis_Item_Title_Style_Color()

        ///<summary>Figure_YAxis_Item_Title_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_YAxis_Item_Title_Style_FontWeight()

        ///<summary>Figure_YAxis_Item_Title_Style_FontSize : <code>string</code></summary>
        member this.fontSize = Figure_YAxis_Item_Title_Style_FontSize()

        ///<summary>Figure_YAxis_Item_Title_Style_FontFamily : <code>string</code></summary>
        member this.fontFamily = Figure_YAxis_Item_Title_Style_FontFamily()
        static member ToJson (o:{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            let fontSize = sprintf "\\\"%s\\\"" o.fontSize
            let fontFamily = sprintf "\\\"%s\\\"" o.fontFamily
            sprintf "{\\\"color\\\":%s,\\\"fontWeight\\\":%s,\\\"fontSize\\\":%s,\\\"fontFamily\\\":%s}" color fontWeight fontSize fontFamily

        member this.Set (o:{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"style\\\":%s}}}}" (Figure_YAxis_Item_Title_Style.ToJson o))


    ///<summary>Figure_YAxis_Item_Title_Text : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Text() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":{\\\"text\\\":%s}}}}" (Figure_YAxis_Item_Title_Text.ToJson o))

    ///<summary>Figure_YAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
    type Figure_YAxis_Item_Title() = 

        ///<summary>Figure_YAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
        member this.style = Figure_YAxis_Item_Title_Style()

        ///<summary>Figure_YAxis_Item_Title_Text : <code>string</code></summary>
        member this.text = Figure_YAxis_Item_Title_Text()
        static member ToJson (o:{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}) =
            let style = Figure_YAxis_Item_Title_Style.ToJson o.style
            let text = sprintf "\\\"%s\\\"" o.text
            sprintf "{\\\"style\\\":%s,\\\"text\\\":%s}" style text

        member this.Set (o:{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"title\\\":%s}}}" (Figure_YAxis_Item_Title.ToJson o))


    ///<summary>Figure_YAxis_Item_Index : <code>int</code></summary>
    type Figure_YAxis_Item_Index() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":{\\\"index\\\":%s}}}" (Figure_YAxis_Item_Index.ToJson o))

    ///<summary>Figure_YAxis_Item : <code>{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |}</code></summary>
    type Figure_YAxis_Item() = 

        ///<summary>Figure_YAxis_Item_GridLineColor : <code>string</code></summary>
        member this.gridLineColor = Figure_YAxis_Item_GridLineColor()

        ///<summary>Figure_YAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
        member this.labels = Figure_YAxis_Item_Labels()

        ///<summary>Figure_YAxis_Item_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_YAxis_Item_LineColor()

        ///<summary>Figure_YAxis_Item_MinorTickInterval : <code>float</code></summary>
        member this.minorTickInterval = Figure_YAxis_Item_MinorTickInterval()

        ///<summary>Figure_YAxis_Item_TickColor : <code>string</code></summary>
        member this.tickColor = Figure_YAxis_Item_TickColor()

        ///<summary>Figure_YAxis_Item_TickWidth : <code>int</code></summary>
        member this.tickWidth = Figure_YAxis_Item_TickWidth()

        ///<summary>Figure_YAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
        member this.title = Figure_YAxis_Item_Title()

        ///<summary>Figure_YAxis_Item_Index : <code>int</code></summary>
        member this.index = Figure_YAxis_Item_Index()
        static member ToJson (o:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |}) =
            let gridLineColor = sprintf "\\\"%s\\\"" o.gridLineColor
            let labels = Figure_YAxis_Item_Labels.ToJson o.labels
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            let minorTickInterval = sprintf "%f" o.minorTickInterval
            let tickColor = sprintf "\\\"%s\\\"" o.tickColor
            let tickWidth = sprintf "%i" o.tickWidth
            let title = Figure_YAxis_Item_Title.ToJson o.title
            let index = sprintf "%i" o.index
            sprintf "{\\\"gridLineColor\\\":%s,\\\"labels\\\":%s,\\\"lineColor\\\":%s,\\\"minorTickInterval\\\":%s,\\\"tickColor\\\":%s,\\\"tickWidth\\\":%s,\\\"title\\\":%s,\\\"index\\\":%s}" gridLineColor labels lineColor minorTickInterval tickColor tickWidth title index

        member this.Set (o:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |}) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":{\\\"item\\\":%s}}" (Figure_YAxis_Item.ToJson o))


    ///<summary>Figure_YAxis : <code>{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq</code></summary>
    type Figure_YAxis() =
        let item = Figure_YAxis_Item()

        static member ToJson (o:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_YAxis_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq) =
            update currentChartIndex "" (sprintf "{\\\"yAxis\\\":%s}" (Figure_YAxis.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Toolbar_ItemStyle_Color : <code>string</code></summary>
    type Figure_Toolbar_ItemStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"toolbar\\\":{\\\"itemStyle\\\":{\\\"color\\\":%s}}}" (Figure_Toolbar_ItemStyle_Color.ToJson o))

    ///<summary>Figure_Toolbar_ItemStyle : <code>{| color:string |}</code></summary>
    type Figure_Toolbar_ItemStyle() = 

        ///<summary>Figure_Toolbar_ItemStyle_Color : <code>string</code></summary>
        member this.color = Figure_Toolbar_ItemStyle_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"toolbar\\\":{\\\"itemStyle\\\":%s}}" (Figure_Toolbar_ItemStyle.ToJson o))


    ///<summary>Figure_Toolbar : <code>{| itemStyle: {| color:string |} |}</code></summary>
    type Figure_Toolbar() = 

        ///<summary>Figure_Toolbar_ItemStyle : <code>{| color:string |}</code></summary>
        member this.itemStyle = Figure_Toolbar_ItemStyle()
        static member ToJson (o:{| itemStyle: {| color:string |} |}) =
            let itemStyle = Figure_Toolbar_ItemStyle.ToJson o.itemStyle
            sprintf "{\\\"itemStyle\\\":%s}" itemStyle

        member this.Set (o:{| itemStyle: {| color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"toolbar\\\":%s}" (Figure_Toolbar.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1()

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1()

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2()

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"linearGradient\\\":%s}}}}" (Figure_RangeSelector_ButtonTheme_Fill_LinearGradient.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_Stops_Item() =
        let item = Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_Fill_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_Stops() =
        let item = Figure_RangeSelector_ButtonTheme_Fill_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_RangeSelector_ButtonTheme_Fill_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":{\\\"stops\\\":%s}}}}" (Figure_RangeSelector_ButtonTheme_Fill_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient()

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_RangeSelector_ButtonTheme_Fill_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient.ToJson o.linearGradient
            let stops = Figure_RangeSelector_ButtonTheme_Fill_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"fill\\\":%s}}}" (Figure_RangeSelector_ButtonTheme_Fill.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_Stroke : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_Stroke() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"stroke\\\":%s}}}" (Figure_RangeSelector_ButtonTheme_Stroke.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Style_Color : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}" (Figure_RangeSelector_ButtonTheme_Style_Color.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Style_FontWeight : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_Style_FontWeight() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"style\\\":{\\\"fontWeight\\\":%s}}}}" (Figure_RangeSelector_ButtonTheme_Style_FontWeight.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_Style : <code>{| color:string; fontWeight:string |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_Style() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_Style_Color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_ButtonTheme_Style_Color()

        ///<summary>Figure_RangeSelector_ButtonTheme_Style_FontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_RangeSelector_ButtonTheme_Style_FontWeight()
        static member ToJson (o:{| color:string; fontWeight:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let fontWeight = sprintf "\\\"%s\\\"" o.fontWeight
            sprintf "{\\\"color\\\":%s,\\\"fontWeight\\\":%s}" color fontWeight

        member this.Set (o:{| color:string; fontWeight:string |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"style\\\":%s}}}" (Figure_RangeSelector_ButtonTheme_Style.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"linearGradient\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item() =
        let item = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops() =
        let item = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":{\\\"stops\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient.ToJson o.linearGradient
            let stops = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"fill\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Fill.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Stroke : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Stroke() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"stroke\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Stroke.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style : <code>{| color:string |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Style() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":{\\\"style\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover_Style.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_RangeSelector_ButtonTheme_States_Hover_Fill()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Stroke : <code>string</code></summary>
        member this.stroke = Figure_RangeSelector_ButtonTheme_States_Hover_Stroke()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_RangeSelector_ButtonTheme_States_Hover_Style()
        static member ToJson (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}) =
            let fill = Figure_RangeSelector_ButtonTheme_States_Hover_Fill.ToJson o.fill
            let stroke = sprintf "\\\"%s\\\"" o.stroke
            let style = Figure_RangeSelector_ButtonTheme_States_Hover_Style.ToJson o.style
            sprintf "{\\\"fill\\\":%s,\\\"stroke\\\":%s,\\\"style\\\":%s}" fill stroke style

        member this.Set (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"hover\\\":%s}}}}" (Figure_RangeSelector_ButtonTheme_States_Hover.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"linearGradient\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item() =
        let item = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops() =
        let item = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":{\\\"stops\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient.ToJson o.linearGradient
            let stops = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"fill\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Fill.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Stroke : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Stroke() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"stroke\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Stroke.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style_Color : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Style_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"style\\\":{\\\"color\\\":%s}}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Style_Color.ToJson o))

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style : <code>{| color:string |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Style() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style_Color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_ButtonTheme_States_Select_Style_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":{\\\"style\\\":%s}}}}}" (Figure_RangeSelector_ButtonTheme_States_Select_Style.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_RangeSelector_ButtonTheme_States_Select_Fill()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Stroke : <code>string</code></summary>
        member this.stroke = Figure_RangeSelector_ButtonTheme_States_Select_Stroke()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_RangeSelector_ButtonTheme_States_Select_Style()
        static member ToJson (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}) =
            let fill = Figure_RangeSelector_ButtonTheme_States_Select_Fill.ToJson o.fill
            let stroke = sprintf "\\\"%s\\\"" o.stroke
            let style = Figure_RangeSelector_ButtonTheme_States_Select_Style.ToJson o.style
            sprintf "{\\\"fill\\\":%s,\\\"stroke\\\":%s,\\\"style\\\":%s}" fill stroke style

        member this.Set (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":{\\\"select\\\":%s}}}}" (Figure_RangeSelector_ButtonTheme_States_Select.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme_States : <code>{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
        member this.hover = Figure_RangeSelector_ButtonTheme_States_Hover()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
        member this.select = Figure_RangeSelector_ButtonTheme_States_Select()
        static member ToJson (o:{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}) =
            let hover = Figure_RangeSelector_ButtonTheme_States_Hover.ToJson o.hover
            let select = Figure_RangeSelector_ButtonTheme_States_Select.ToJson o.select
            sprintf "{\\\"hover\\\":%s,\\\"select\\\":%s}" hover select

        member this.Set (o:{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":{\\\"states\\\":%s}}}" (Figure_RangeSelector_ButtonTheme_States.ToJson o))


    ///<summary>Figure_RangeSelector_ButtonTheme : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme() = 

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_RangeSelector_ButtonTheme_Fill()

        ///<summary>Figure_RangeSelector_ButtonTheme_Stroke : <code>string</code></summary>
        member this.stroke = Figure_RangeSelector_ButtonTheme_Stroke()

        ///<summary>Figure_RangeSelector_ButtonTheme_Style : <code>{| color:string; fontWeight:string |}</code></summary>
        member this.style = Figure_RangeSelector_ButtonTheme_Style()

        ///<summary>Figure_RangeSelector_ButtonTheme_States : <code>{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}</code></summary>
        member this.states = Figure_RangeSelector_ButtonTheme_States()
        static member ToJson (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}) =
            let fill = Figure_RangeSelector_ButtonTheme_Fill.ToJson o.fill
            let stroke = sprintf "\\\"%s\\\"" o.stroke
            let style = Figure_RangeSelector_ButtonTheme_Style.ToJson o.style
            let states = Figure_RangeSelector_ButtonTheme_States.ToJson o.states
            sprintf "{\\\"fill\\\":%s,\\\"stroke\\\":%s,\\\"style\\\":%s,\\\"states\\\":%s}" fill stroke style states

        member this.Set (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"buttonTheme\\\":%s}}" (Figure_RangeSelector_ButtonTheme.ToJson o))


    ///<summary>Figure_RangeSelector_InputStyle_BackgroundColor : <code>string</code></summary>
    type Figure_RangeSelector_InputStyle_BackgroundColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"inputStyle\\\":{\\\"backgroundColor\\\":%s}}}" (Figure_RangeSelector_InputStyle_BackgroundColor.ToJson o))

    ///<summary>Figure_RangeSelector_InputStyle_Color : <code>string</code></summary>
    type Figure_RangeSelector_InputStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"inputStyle\\\":{\\\"color\\\":%s}}}" (Figure_RangeSelector_InputStyle_Color.ToJson o))

    ///<summary>Figure_RangeSelector_InputStyle : <code>{| backgroundColor:string; color:string |}</code></summary>
    type Figure_RangeSelector_InputStyle() = 

        ///<summary>Figure_RangeSelector_InputStyle_BackgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_RangeSelector_InputStyle_BackgroundColor()

        ///<summary>Figure_RangeSelector_InputStyle_Color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_InputStyle_Color()
        static member ToJson (o:{| backgroundColor:string; color:string |}) =
            let backgroundColor = sprintf "\\\"%s\\\"" o.backgroundColor
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"backgroundColor\\\":%s,\\\"color\\\":%s}" backgroundColor color

        member this.Set (o:{| backgroundColor:string; color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"inputStyle\\\":%s}}" (Figure_RangeSelector_InputStyle.ToJson o))


    ///<summary>Figure_RangeSelector_LabelStyle_Color : <code>string</code></summary>
    type Figure_RangeSelector_LabelStyle_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"labelStyle\\\":{\\\"color\\\":%s}}}" (Figure_RangeSelector_LabelStyle_Color.ToJson o))

    ///<summary>Figure_RangeSelector_LabelStyle : <code>{| color:string |}</code></summary>
    type Figure_RangeSelector_LabelStyle() = 

        ///<summary>Figure_RangeSelector_LabelStyle_Color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_LabelStyle_Color()
        static member ToJson (o:{| color:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            sprintf "{\\\"color\\\":%s}" color

        member this.Set (o:{| color:string |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":{\\\"labelStyle\\\":%s}}" (Figure_RangeSelector_LabelStyle.ToJson o))


    ///<summary>Figure_RangeSelector : <code>{| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}</code></summary>
    type Figure_RangeSelector() = 

        ///<summary>Figure_RangeSelector_ButtonTheme : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}</code></summary>
        member this.buttonTheme = Figure_RangeSelector_ButtonTheme()

        ///<summary>Figure_RangeSelector_InputStyle : <code>{| backgroundColor:string; color:string |}</code></summary>
        member this.inputStyle = Figure_RangeSelector_InputStyle()

        ///<summary>Figure_RangeSelector_LabelStyle : <code>{| color:string |}</code></summary>
        member this.labelStyle = Figure_RangeSelector_LabelStyle()
        static member ToJson (o:{| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}) =
            let buttonTheme = Figure_RangeSelector_ButtonTheme.ToJson o.buttonTheme
            let inputStyle = Figure_RangeSelector_InputStyle.ToJson o.inputStyle
            let labelStyle = Figure_RangeSelector_LabelStyle.ToJson o.labelStyle
            sprintf "{\\\"buttonTheme\\\":%s,\\\"inputStyle\\\":%s,\\\"labelStyle\\\":%s}" buttonTheme inputStyle labelStyle

        member this.Set (o:{| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"rangeSelector\\\":%s}" (Figure_RangeSelector.ToJson o))


    ///<summary>Figure_Navigator_Handles_BackgroundColor : <code>string</code></summary>
    type Figure_Navigator_Handles_BackgroundColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"handles\\\":{\\\"backgroundColor\\\":%s}}}" (Figure_Navigator_Handles_BackgroundColor.ToJson o))

    ///<summary>Figure_Navigator_Handles_BorderColor : <code>string</code></summary>
    type Figure_Navigator_Handles_BorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"handles\\\":{\\\"borderColor\\\":%s}}}" (Figure_Navigator_Handles_BorderColor.ToJson o))

    ///<summary>Figure_Navigator_Handles : <code>{| backgroundColor:string; borderColor:string |}</code></summary>
    type Figure_Navigator_Handles() = 

        ///<summary>Figure_Navigator_Handles_BackgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Navigator_Handles_BackgroundColor()

        ///<summary>Figure_Navigator_Handles_BorderColor : <code>string</code></summary>
        member this.borderColor = Figure_Navigator_Handles_BorderColor()
        static member ToJson (o:{| backgroundColor:string; borderColor:string |}) =
            let backgroundColor = sprintf "\\\"%s\\\"" o.backgroundColor
            let borderColor = sprintf "\\\"%s\\\"" o.borderColor
            sprintf "{\\\"backgroundColor\\\":%s,\\\"borderColor\\\":%s}" backgroundColor borderColor

        member this.Set (o:{| backgroundColor:string; borderColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"handles\\\":%s}}" (Figure_Navigator_Handles.ToJson o))


    ///<summary>Figure_Navigator_OutlineColor : <code>string</code></summary>
    type Figure_Navigator_OutlineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"outlineColor\\\":%s}}" (Figure_Navigator_OutlineColor.ToJson o))

    ///<summary>Figure_Navigator_MaskFill : <code>string</code></summary>
    type Figure_Navigator_MaskFill() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"maskFill\\\":%s}}" (Figure_Navigator_MaskFill.ToJson o))

    ///<summary>Figure_Navigator_Series_Color : <code>string</code></summary>
    type Figure_Navigator_Series_Color() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"series\\\":{\\\"color\\\":%s}}}" (Figure_Navigator_Series_Color.ToJson o))

    ///<summary>Figure_Navigator_Series_LineColor : <code>string</code></summary>
    type Figure_Navigator_Series_LineColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"series\\\":{\\\"lineColor\\\":%s}}}" (Figure_Navigator_Series_LineColor.ToJson o))

    ///<summary>Figure_Navigator_Series : <code>{| color:string; lineColor:string |}</code></summary>
    type Figure_Navigator_Series() = 

        ///<summary>Figure_Navigator_Series_Color : <code>string</code></summary>
        member this.color = Figure_Navigator_Series_Color()

        ///<summary>Figure_Navigator_Series_LineColor : <code>string</code></summary>
        member this.lineColor = Figure_Navigator_Series_LineColor()
        static member ToJson (o:{| color:string; lineColor:string |}) =
            let color = sprintf "\\\"%s\\\"" o.color
            let lineColor = sprintf "\\\"%s\\\"" o.lineColor
            sprintf "{\\\"color\\\":%s,\\\"lineColor\\\":%s}" color lineColor

        member this.Set (o:{| color:string; lineColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":{\\\"series\\\":%s}}" (Figure_Navigator_Series.ToJson o))


    ///<summary>Figure_Navigator : <code>{| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}</code></summary>
    type Figure_Navigator() = 

        ///<summary>Figure_Navigator_Handles : <code>{| backgroundColor:string; borderColor:string |}</code></summary>
        member this.handles = Figure_Navigator_Handles()

        ///<summary>Figure_Navigator_OutlineColor : <code>string</code></summary>
        member this.outlineColor = Figure_Navigator_OutlineColor()

        ///<summary>Figure_Navigator_MaskFill : <code>string</code></summary>
        member this.maskFill = Figure_Navigator_MaskFill()

        ///<summary>Figure_Navigator_Series : <code>{| color:string; lineColor:string |}</code></summary>
        member this.series = Figure_Navigator_Series()
        static member ToJson (o:{| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}) =
            let handles = Figure_Navigator_Handles.ToJson o.handles
            let outlineColor = sprintf "\\\"%s\\\"" o.outlineColor
            let maskFill = sprintf "\\\"%s\\\"" o.maskFill
            let series = Figure_Navigator_Series.ToJson o.series
            sprintf "{\\\"handles\\\":%s,\\\"outlineColor\\\":%s,\\\"maskFill\\\":%s,\\\"series\\\":%s}" handles outlineColor maskFill series

        member this.Set (o:{| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}) =
            update currentChartIndex "" (sprintf "{\\\"navigator\\\":%s}" (Figure_Navigator.ToJson o))


    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}" (Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1.ToJson o))

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}" (Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}" (Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2.ToJson o))

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}" (Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient() = 

        ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1()

        ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1()

        ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2()

        ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"linearGradient\\\":%s}}}" (Figure_Scrollbar_BarBackgroundColor_LinearGradient.ToJson o))


    ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}" (Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item.ToJson o))

    ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_Stops_Item() =
        let item = Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}" (Figure_Scrollbar_BarBackgroundColor_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_Stops() =
        let item = Figure_Scrollbar_BarBackgroundColor_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Scrollbar_BarBackgroundColor_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":{\\\"stops\\\":%s}}}" (Figure_Scrollbar_BarBackgroundColor_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_BarBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Scrollbar_BarBackgroundColor() = 

        ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Scrollbar_BarBackgroundColor_LinearGradient()

        ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Scrollbar_BarBackgroundColor_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_Scrollbar_BarBackgroundColor_LinearGradient.ToJson o.linearGradient
            let stops = Figure_Scrollbar_BarBackgroundColor_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBackgroundColor\\\":%s}}" (Figure_Scrollbar_BarBackgroundColor.ToJson o))


    ///<summary>Figure_Scrollbar_BarBorderColor : <code>string</code></summary>
    type Figure_Scrollbar_BarBorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"barBorderColor\\\":%s}}" (Figure_Scrollbar_BarBorderColor.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonArrowColor : <code>string</code></summary>
    type Figure_Scrollbar_ButtonArrowColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonArrowColor\\\":%s}}" (Figure_Scrollbar_ButtonArrowColor.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}" (Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}" (Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}" (Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}" (Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient() = 

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"linearGradient\\\":%s}}}" (Figure_Scrollbar_ButtonBackgroundColor_LinearGradient.ToJson o))


    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}" (Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item.ToJson o))

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_Stops_Item() =
        let item = Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}" (Figure_Scrollbar_ButtonBackgroundColor_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_Stops() =
        let item = Figure_Scrollbar_ButtonBackgroundColor_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Scrollbar_ButtonBackgroundColor_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":{\\\"stops\\\":%s}}}" (Figure_Scrollbar_ButtonBackgroundColor_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor() = 

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Scrollbar_ButtonBackgroundColor_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient.ToJson o.linearGradient
            let stops = Figure_Scrollbar_ButtonBackgroundColor_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBackgroundColor\\\":%s}}" (Figure_Scrollbar_ButtonBackgroundColor.ToJson o))


    ///<summary>Figure_Scrollbar_ButtonBorderColor : <code>string</code></summary>
    type Figure_Scrollbar_ButtonBorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"buttonBorderColor\\\":%s}}" (Figure_Scrollbar_ButtonBorderColor.ToJson o))

    ///<summary>Figure_Scrollbar_RifleColor : <code>string</code></summary>
    type Figure_Scrollbar_RifleColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"rifleColor\\\":%s}}" (Figure_Scrollbar_RifleColor.ToJson o))

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"x1\\\":%s}}}}" (Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1.ToJson o))

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"y1\\\":%s}}}}" (Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1.ToJson o))

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"x2\\\":%s}}}}" (Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2.ToJson o))

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"linearGradient\\\":{\\\"y2\\\":%s}}}}" (Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2.ToJson o))

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient() = 

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
        member this.x1 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
        member this.y1 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
        member this.x2 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
        member this.y2 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2()
        static member ToJson (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            let x1 = sprintf "%i" o.x1
            let y1 = sprintf "%i" o.y1
            let x2 = sprintf "%i" o.x2
            let y2 = sprintf "%i" o.y2
            sprintf "{\\\"x1\\\":%s,\\\"y1\\\":%s,\\\"x2\\\":%s,\\\"y2\\\":%s}" x1 y1 x2 y2

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"linearGradient\\\":%s}}}" (Figure_Scrollbar_TrackBackgroundColor_LinearGradient.ToJson o))


    ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item() =
        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":{\\\"item\\\":%s}}}}}" (Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item.ToJson o))

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_Stops_Item() =
        let item = Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item()

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"stops\\\":{\\\"item\\\":%s}}}}" (Figure_Scrollbar_TrackBackgroundColor_Stops_Item.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_Stops() =
        let item = Figure_Scrollbar_TrackBackgroundColor_Stops_Item()

        static member ToJson (o:int seq seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Scrollbar_TrackBackgroundColor_Stops_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq seq) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":{\\\"stops\\\":%s}}}" (Figure_Scrollbar_TrackBackgroundColor_Stops.ToJson o))

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_TrackBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor() = 

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Scrollbar_TrackBackgroundColor_LinearGradient()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Scrollbar_TrackBackgroundColor_Stops()
        static member ToJson (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            let linearGradient = Figure_Scrollbar_TrackBackgroundColor_LinearGradient.ToJson o.linearGradient
            let stops = Figure_Scrollbar_TrackBackgroundColor_Stops.ToJson o.stops
            sprintf "{\\\"linearGradient\\\":%s,\\\"stops\\\":%s}" linearGradient stops

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBackgroundColor\\\":%s}}" (Figure_Scrollbar_TrackBackgroundColor.ToJson o))


    ///<summary>Figure_Scrollbar_TrackBorderColor : <code>string</code></summary>
    type Figure_Scrollbar_TrackBorderColor() =
        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":{\\\"trackBorderColor\\\":%s}}" (Figure_Scrollbar_TrackBorderColor.ToJson o))

    ///<summary>Figure_Scrollbar : <code>{| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}</code></summary>
    type Figure_Scrollbar() = 

        ///<summary>Figure_Scrollbar_BarBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.barBackgroundColor = Figure_Scrollbar_BarBackgroundColor()

        ///<summary>Figure_Scrollbar_BarBorderColor : <code>string</code></summary>
        member this.barBorderColor = Figure_Scrollbar_BarBorderColor()

        ///<summary>Figure_Scrollbar_ButtonArrowColor : <code>string</code></summary>
        member this.buttonArrowColor = Figure_Scrollbar_ButtonArrowColor()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.buttonBackgroundColor = Figure_Scrollbar_ButtonBackgroundColor()

        ///<summary>Figure_Scrollbar_ButtonBorderColor : <code>string</code></summary>
        member this.buttonBorderColor = Figure_Scrollbar_ButtonBorderColor()

        ///<summary>Figure_Scrollbar_RifleColor : <code>string</code></summary>
        member this.rifleColor = Figure_Scrollbar_RifleColor()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.trackBackgroundColor = Figure_Scrollbar_TrackBackgroundColor()

        ///<summary>Figure_Scrollbar_TrackBorderColor : <code>string</code></summary>
        member this.trackBorderColor = Figure_Scrollbar_TrackBorderColor()
        static member ToJson (o:{| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}) =
            let barBackgroundColor = Figure_Scrollbar_BarBackgroundColor.ToJson o.barBackgroundColor
            let barBorderColor = sprintf "\\\"%s\\\"" o.barBorderColor
            let buttonArrowColor = sprintf "\\\"%s\\\"" o.buttonArrowColor
            let buttonBackgroundColor = Figure_Scrollbar_ButtonBackgroundColor.ToJson o.buttonBackgroundColor
            let buttonBorderColor = sprintf "\\\"%s\\\"" o.buttonBorderColor
            let rifleColor = sprintf "\\\"%s\\\"" o.rifleColor
            let trackBackgroundColor = Figure_Scrollbar_TrackBackgroundColor.ToJson o.trackBackgroundColor
            let trackBorderColor = sprintf "\\\"%s\\\"" o.trackBorderColor
            sprintf "{\\\"barBackgroundColor\\\":%s,\\\"barBorderColor\\\":%s,\\\"buttonArrowColor\\\":%s,\\\"buttonBackgroundColor\\\":%s,\\\"buttonBorderColor\\\":%s,\\\"rifleColor\\\":%s,\\\"trackBackgroundColor\\\":%s,\\\"trackBorderColor\\\":%s}" barBackgroundColor barBorderColor buttonArrowColor buttonBackgroundColor buttonBorderColor rifleColor trackBackgroundColor trackBorderColor

        member this.Set (o:{| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}) =
            update currentChartIndex "" (sprintf "{\\\"scrollbar\\\":%s}" (Figure_Scrollbar.ToJson o))


    ///<summary>Figure_Series_Item_Name : <code>string</code></summary>
    type Figure_Series_Item_Name(parent:IFigureItem option) =
        let parentItem = parent

        interface IFigureItem with
            member this.ParentPath() =
                let prePath = parentItem |> function | Some(parent) -> parent.ParentPath() | None -> ""
                prePath + ".series"

        static member ToJson (o:string) =
            sprintf "\\\"%s\\\"" o

        member this.Set (o:string) =
            update currentChartIndex ((this :> IFigureItem).ParentPath()) (sprintf "{\\\"name\\\":%s}" (Figure_Series_Item_Name.ToJson o))
            //update currentChartIndex "" (sprintf "{\\\"series\\\":{\\\"item\\\":{\\\"name\\\":%s}}}" (Figure_Series_Item_Name.ToJson o))

    ///<summary>Figure_Series_Item_Data_Item : <code>int</code></summary>
    type Figure_Series_Item_Data_Item(parent:IFigureItem option) =
        let parentItem = parent
        let mutable lastIndex:int = 0

        interface IFigureItem with
            member this.ParentPath() =
                let prePath = parentItem |> function | Some(parent) -> parent.ParentPath() | None -> ""
                prePath + (sprintf "[%i]" lastIndex)

        interface IFigureArray with
            member this.SetLastIndex index =
                lastIndex <- index

        static member ToJson (o:int) =
            sprintf "%i" o

        member this.Set (o:int) =
            update currentChartIndex ((this :> IFigureItem).ParentPath()) (sprintf "%s" (Figure_Series_Item_Data_Item.ToJson o))

    ///<summary>Figure_Series_Item_Data : <code>int seq</code></summary>
    type Figure_Series_Item_Data(parent:IFigureItem option) as this =
        let parentItem = parent
        let item = Figure_Series_Item_Data_Item(Some (this :> IFigureItem))

        interface IFigureItem with
            member this.ParentPath() =
                let prePath = parentItem |> function | Some(parent) -> parent.ParentPath() | None -> ""
                prePath + ".data"

        static member ToJson (o:int seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Series_Item_Data_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:int seq) =
            update currentChartIndex ((this :> IFigureItem).ParentPath()) (sprintf "{\\\"data\\\":%s}" (Figure_Series_Item_Data.ToJson o))

        member this.Item
            with get(i) =
                (item :> IFigureArray).SetLastIndex(i)
                item

    ///<summary>Figure_Series_Item : <code>{| name:string; data:int seq |}</code></summary>
    type Figure_Series_Item(parent:IFigureItem option) =
        let parentItem = parent
        let mutable lastIndex:int = 0

        interface IFigureItem with
            member this.ParentPath() =
                let prePath = parentItem |> function | Some(parent) -> parent.ParentPath() | None -> ""
                prePath + (sprintf "[%i]" lastIndex)

        interface IFigureArray with
            member this.SetLastIndex index =
                lastIndex <- index

        ///<summary>Figure_Series_Item_Name : <code>string</code></summary>
        member this.name = Figure_Series_Item_Name(Some (this :> IFigureItem))

        ///<summary>Figure_Series_Item_Data : <code>int seq</code></summary>
        member this.data = Figure_Series_Item_Data(Some (this :> IFigureItem))
        static member ToJson (o:{| name:string; data:int seq |}) =
            let name = sprintf "\\\"%s\\\"" o.name
            let data = Figure_Series_Item_Data.ToJson o.data
            sprintf "{\\\"name\\\":%s,\\\"data\\\":%s}" name data

        member this.Set (o:{| name:string; data:int seq |}) =
            update currentChartIndex ((this :> IFigureItem).ParentPath()) (Figure_Series_Item.ToJson o)
            //update currentChartIndex "" (sprintf "{\\\"series\\\":{\\\"item\\\":%s}}" (Figure_Series_Item.ToJson o))


    ///<summary>Figure_Series : <code>{| name:string; data:int seq |} seq</code></summary>
    type Figure_Series(parent:IFigureItem option) as this =
        let parentItem = parent
        let item = Figure_Series_Item(Some (this :> IFigureItem))

        interface IFigureItem with
            member this.ParentPath() =
                let prePath = parentItem |> function | Some(parent) -> parent.ParentPath() | None -> ""
                prePath + ".data"

        static member ToJson (o:{| name:string; data:int seq |} seq) =
            if Seq.isEmpty o then "[]"
            else
                o
                |> Seq.fold (fun s oi -> sprintf "%s,[%s]" s ( Figure_Series_Item.ToJson oi)) ""
                |> fun s -> s.Substring(1)

        member this.Set (o:{| name:string; data:int seq |} seq) =
            update currentChartIndex ((this :> IFigureItem).ParentPath()) (sprintf "{\\\"series\\\":%s}" (Figure_Series.ToJson o))

        member this.Item
            with get(i) =
                (item :> IFigureArray).SetLastIndex(i)
                item

    ///<summary>Figure : <code>{| colors:string seq; symbols:string seq; lang: {| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}; _global: {| dummy:string |}; time: {| timezoneOffset:int; useUTC:bool |}; chart: {| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}; title: {| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}; subtitle: {| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}; caption: {| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}; plotOptions: {| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}; labels: {| style: {| position:string; color:string |} |}; legend: {| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}; loading: {| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}; tooltip: {| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}; credits: {| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}; navigation: {| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}; exporting: {| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}; xAxis:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq; yAxis:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq; toolbar: {| itemStyle: {| color:string |} |}; rangeSelector: {| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}; navigator: {| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}; scrollbar: {| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}; series:{| name:string; data:int seq |} seq |}</code></summary>
    type Figure() = 

        interface IFigureItem with
            member this.ParentPath() =
                ""

        ///<summary>Figure_Colors : <code>string seq</code></summary>
        member this.colors = Figure_Colors()

        ///<summary>Figure_Symbols : <code>string seq</code></summary>
        member this.symbols = Figure_Symbols()

        ///<summary>Figure_Lang : <code>{| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}</code></summary>
        member this.lang = Figure_Lang()

        ///<summary>Figure_Global : <code>{| dummy:string |}</code></summary>
        member this._global = Figure_Global()

        ///<summary>Figure_Time : <code>{| timezoneOffset:int; useUTC:bool |}</code></summary>
        member this.time = Figure_Time()

        ///<summary>Figure_Chart : <code>{| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}</code></summary>
        member this.chart = Figure_Chart()

        ///<summary>Figure_Title : <code>{| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}</code></summary>
        member this.title = Figure_Title()

        ///<summary>Figure_Subtitle : <code>{| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}</code></summary>
        member this.subtitle = Figure_Subtitle()

        ///<summary>Figure_Caption : <code>{| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}</code></summary>
        member this.caption = Figure_Caption()

        ///<summary>Figure_PlotOptions : <code>{| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}</code></summary>
        member this.plotOptions = Figure_PlotOptions()

        ///<summary>Figure_Labels : <code>{| style: {| position:string; color:string |} |}</code></summary>
        member this.labels = Figure_Labels()

        ///<summary>Figure_Legend : <code>{| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}</code></summary>
        member this.legend = Figure_Legend()

        ///<summary>Figure_Loading : <code>{| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}</code></summary>
        member this.loading = Figure_Loading()

        ///<summary>Figure_Tooltip : <code>{| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}</code></summary>
        member this.tooltip = Figure_Tooltip()

        ///<summary>Figure_Credits : <code>{| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}</code></summary>
        member this.credits = Figure_Credits()

        ///<summary>Figure_Navigation : <code>{| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}</code></summary>
        member this.navigation = Figure_Navigation()

        ///<summary>Figure_Exporting : <code>{| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}</code></summary>
        member this.exporting = Figure_Exporting()

        ///<summary>Figure_XAxis : <code>{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq</code></summary>
        member this.xAxis = Figure_XAxis()

        ///<summary>Figure_YAxis : <code>{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq</code></summary>
        member this.yAxis = Figure_YAxis()

        ///<summary>Figure_Toolbar : <code>{| itemStyle: {| color:string |} |}</code></summary>
        member this.toolbar = Figure_Toolbar()

        ///<summary>Figure_RangeSelector : <code>{| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}</code></summary>
        member this.rangeSelector = Figure_RangeSelector()

        ///<summary>Figure_Navigator : <code>{| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}</code></summary>
        member this.navigator = Figure_Navigator()

        ///<summary>Figure_Scrollbar : <code>{| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}</code></summary>
        member this.scrollbar = Figure_Scrollbar()

        ///<summary>Figure_Series : <code>{| name:string; data:int seq |} seq</code></summary>
        member this.series = Figure_Series(Some (this :> IFigureItem))
        static member ToJson (o:{| colors:string seq; symbols:string seq; lang: {| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}; _global: {| dummy:string |}; time: {| timezoneOffset:int; useUTC:bool |}; chart: {| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}; title: {| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}; subtitle: {| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}; caption: {| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}; plotOptions: {| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}; labels: {| style: {| position:string; color:string |} |}; legend: {| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}; loading: {| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}; tooltip: {| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}; credits: {| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}; navigation: {| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}; exporting: {| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}; xAxis:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq; yAxis:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq; toolbar: {| itemStyle: {| color:string |} |}; rangeSelector: {| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}; navigator: {| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}; scrollbar: {| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}; series:{| name:string; data:int seq |} seq |}) =
            let colors = Figure_Colors.ToJson o.colors
            let symbols = Figure_Symbols.ToJson o.symbols
            let lang = Figure_Lang.ToJson o.lang
            let _global = Figure_Global.ToJson o._global
            let time = Figure_Time.ToJson o.time
            let chart = Figure_Chart.ToJson o.chart
            let title = Figure_Title.ToJson o.title
            let subtitle = Figure_Subtitle.ToJson o.subtitle
            let caption = Figure_Caption.ToJson o.caption
            let plotOptions = Figure_PlotOptions.ToJson o.plotOptions
            let labels = Figure_Labels.ToJson o.labels
            let legend = Figure_Legend.ToJson o.legend
            let loading = Figure_Loading.ToJson o.loading
            let tooltip = Figure_Tooltip.ToJson o.tooltip
            let credits = Figure_Credits.ToJson o.credits
            let navigation = Figure_Navigation.ToJson o.navigation
            let exporting = Figure_Exporting.ToJson o.exporting
            let xAxis = Figure_XAxis.ToJson o.xAxis
            let yAxis = Figure_YAxis.ToJson o.yAxis
            let toolbar = Figure_Toolbar.ToJson o.toolbar
            let rangeSelector = Figure_RangeSelector.ToJson o.rangeSelector
            let navigator = Figure_Navigator.ToJson o.navigator
            let scrollbar = Figure_Scrollbar.ToJson o.scrollbar
            let series = Figure_Series.ToJson o.series
            sprintf "{\\\"colors\\\":%s,\\\"symbols\\\":%s,\\\"lang\\\":%s,\\\"_global\\\":%s,\\\"time\\\":%s,\\\"chart\\\":%s,\\\"title\\\":%s,\\\"subtitle\\\":%s,\\\"caption\\\":%s,\\\"plotOptions\\\":%s,\\\"labels\\\":%s,\\\"legend\\\":%s,\\\"loading\\\":%s,\\\"tooltip\\\":%s,\\\"credits\\\":%s,\\\"navigation\\\":%s,\\\"exporting\\\":%s,\\\"xAxis\\\":%s,\\\"yAxis\\\":%s,\\\"toolbar\\\":%s,\\\"rangeSelector\\\":%s,\\\"navigator\\\":%s,\\\"scrollbar\\\":%s,\\\"series\\\":%s}" colors symbols lang _global time chart title subtitle caption plotOptions labels legend loading tooltip credits navigation exporting xAxis yAxis toolbar rangeSelector navigator scrollbar series

        member this.Set (o:{| colors:string seq; symbols:string seq; lang: {| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}; _global: {| dummy:string |}; time: {| timezoneOffset:int; useUTC:bool |}; chart: {| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}; title: {| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}; subtitle: {| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}; caption: {| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}; plotOptions: {| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}; labels: {| style: {| position:string; color:string |} |}; legend: {| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}; loading: {| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}; tooltip: {| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}; credits: {| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}; navigation: {| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}; exporting: {| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}; xAxis:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq; yAxis:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq; toolbar: {| itemStyle: {| color:string |} |}; rangeSelector: {| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}; navigator: {| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}; scrollbar: {| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}; series:{| name:string; data:int seq |} seq |}) =
            update currentChartIndex "" (sprintf "%s" (Figure.ToJson o))

