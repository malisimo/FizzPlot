namespace FPlot.HighCharts


module Figure =
    let send s = ()


    ///<summary>Figure_Colors_Item : <code>string</code></summary>
    type Figure_Colors_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Colors : <code>string seq</code></summary>
    type Figure_Colors() =
        let item = Figure_Colors_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Symbols_Item : <code>string</code></summary>
    type Figure_Symbols_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Symbols : <code>string seq</code></summary>
    type Figure_Symbols() =
        let item = Figure_Symbols_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_Loading : <code>string</code></summary>
    type Figure_Lang_Loading() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_Months_Item : <code>string</code></summary>
    type Figure_Lang_Months_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_Months : <code>string seq</code></summary>
    type Figure_Lang_Months() =
        let item = Figure_Lang_Months_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_ShortMonths_Item : <code>string</code></summary>
    type Figure_Lang_ShortMonths_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_ShortMonths : <code>string seq</code></summary>
    type Figure_Lang_ShortMonths() =
        let item = Figure_Lang_ShortMonths_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_Weekdays_Item : <code>string</code></summary>
    type Figure_Lang_Weekdays_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_Weekdays : <code>string seq</code></summary>
    type Figure_Lang_Weekdays() =
        let item = Figure_Lang_Weekdays_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_DecimalPoint : <code>string</code></summary>
    type Figure_Lang_DecimalPoint() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_NumericSymbols_Item : <code>string</code></summary>
    type Figure_Lang_NumericSymbols_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_NumericSymbols : <code>string seq</code></summary>
    type Figure_Lang_NumericSymbols() =
        let item = Figure_Lang_NumericSymbols_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Lang_ResetZoom : <code>string</code></summary>
    type Figure_Lang_ResetZoom() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_ResetZoomTitle : <code>string</code></summary>
    type Figure_Lang_ResetZoomTitle() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_ThousandsSep : <code>string</code></summary>
    type Figure_Lang_ThousandsSep() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_ViewFullscreen : <code>string</code></summary>
    type Figure_Lang_ViewFullscreen() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_ExitFullscreen : <code>string</code></summary>
    type Figure_Lang_ExitFullscreen() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_PrintChart : <code>string</code></summary>
    type Figure_Lang_PrintChart() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_DownloadPNG : <code>string</code></summary>
    type Figure_Lang_DownloadPNG() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_DownloadJPEG : <code>string</code></summary>
    type Figure_Lang_DownloadJPEG() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_DownloadPDF : <code>string</code></summary>
    type Figure_Lang_DownloadPDF() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_DownloadSVG : <code>string</code></summary>
    type Figure_Lang_DownloadSVG() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang_ContextButtonTitle : <code>string</code></summary>
    type Figure_Lang_ContextButtonTitle() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Lang : <code>{| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}</code></summary>
    type Figure_Lang() =


        ///<summary>loading : <code>string</code></summary>
        member this.loading = Figure_Lang_Loading()

        ///<summary>Figure_Lang_Months : <code>string seq</code></summary>
        member this.months = Figure_Lang_Months()

        ///<summary>Figure_Lang_ShortMonths : <code>string seq</code></summary>
        member this.shortMonths = Figure_Lang_ShortMonths()

        ///<summary>Figure_Lang_Weekdays : <code>string seq</code></summary>
        member this.weekdays = Figure_Lang_Weekdays()

        ///<summary>decimalPoint : <code>string</code></summary>
        member this.decimalPoint = Figure_Lang_DecimalPoint()

        ///<summary>Figure_Lang_NumericSymbols : <code>string seq</code></summary>
        member this.numericSymbols = Figure_Lang_NumericSymbols()

        ///<summary>resetZoom : <code>string</code></summary>
        member this.resetZoom = Figure_Lang_ResetZoom()

        ///<summary>resetZoomTitle : <code>string</code></summary>
        member this.resetZoomTitle = Figure_Lang_ResetZoomTitle()

        ///<summary>thousandsSep : <code>string</code></summary>
        member this.thousandsSep = Figure_Lang_ThousandsSep()

        ///<summary>viewFullscreen : <code>string</code></summary>
        member this.viewFullscreen = Figure_Lang_ViewFullscreen()

        ///<summary>exitFullscreen : <code>string</code></summary>
        member this.exitFullscreen = Figure_Lang_ExitFullscreen()

        ///<summary>printChart : <code>string</code></summary>
        member this.printChart = Figure_Lang_PrintChart()

        ///<summary>downloadPNG : <code>string</code></summary>
        member this.downloadPNG = Figure_Lang_DownloadPNG()

        ///<summary>downloadJPEG : <code>string</code></summary>
        member this.downloadJPEG = Figure_Lang_DownloadJPEG()

        ///<summary>downloadPDF : <code>string</code></summary>
        member this.downloadPDF = Figure_Lang_DownloadPDF()

        ///<summary>downloadSVG : <code>string</code></summary>
        member this.downloadSVG = Figure_Lang_DownloadSVG()

        ///<summary>contextButtonTitle : <code>string</code></summary>
        member this.contextButtonTitle = Figure_Lang_ContextButtonTitle()

        member this.Set (o:{| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}) =
            send "##JSON##"

    ///<summary>Figure_Global : <code>{| dummy:string |}</code></summary>
    type Figure_Global() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_Time_TimezoneOffset : <code>int</code></summary>
    type Figure_Time_TimezoneOffset() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Time_UseUTC : <code>bool</code></summary>
    type Figure_Time_UseUTC() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Time : <code>{| timezoneOffset:int; useUTC:bool |}</code></summary>
    type Figure_Time() =


        ///<summary>timezoneOffset : <code>int</code></summary>
        member this.timezoneOffset = Figure_Time_TimezoneOffset()

        ///<summary>useUTC : <code>bool</code></summary>
        member this.useUTC = Figure_Time_UseUTC()

        member this.Set (o:{| timezoneOffset:int; useUTC:bool |}) =
            send "##JSON##"

    ///<summary>Figure_Chart_StyledMode : <code>bool</code></summary>
    type Figure_Chart_StyledMode() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Chart_BorderRadius : <code>int</code></summary>
    type Figure_Chart_BorderRadius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_ColorCount : <code>int</code></summary>
    type Figure_Chart_ColorCount() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_DefaultSeriesType : <code>string</code></summary>
    type Figure_Chart_DefaultSeriesType() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_IgnoreHiddenSeries : <code>bool</code></summary>
    type Figure_Chart_IgnoreHiddenSeries() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Chart_Spacing_Item : <code>int</code></summary>
    type Figure_Chart_Spacing_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_Spacing : <code>int seq</code></summary>
    type Figure_Chart_Spacing() =
        let item = Figure_Chart_Spacing_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Chart_ResetZoomButton_Theme_ZIndex : <code>int</code></summary>
    type Figure_Chart_ResetZoomButton_Theme_ZIndex() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_ResetZoomButton_Theme : <code>{| zIndex:int |}</code></summary>
    type Figure_Chart_ResetZoomButton_Theme() =


        ///<summary>zIndex : <code>int</code></summary>
        member this.zIndex = Figure_Chart_ResetZoomButton_Theme_ZIndex()

        member this.Set (o:{| zIndex:int |}) =
            send "##JSON##"

    ///<summary>Figure_Chart_ResetZoomButton_Position_Align : <code>string</code></summary>
    type Figure_Chart_ResetZoomButton_Position_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_ResetZoomButton_Position_X : <code>int</code></summary>
    type Figure_Chart_ResetZoomButton_Position_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_ResetZoomButton_Position_Y : <code>int</code></summary>
    type Figure_Chart_ResetZoomButton_Position_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_ResetZoomButton_Position : <code>{| align:string; x:int; y:int |}</code></summary>
    type Figure_Chart_ResetZoomButton_Position() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Chart_ResetZoomButton_Position_Align()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_Chart_ResetZoomButton_Position_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_Chart_ResetZoomButton_Position_Y()

        member this.Set (o:{| align:string; x:int; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_Chart_ResetZoomButton : <code>{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}</code></summary>
    type Figure_Chart_ResetZoomButton() =


        ///<summary>Figure_Chart_ResetZoomButton_Theme : <code>{| zIndex:int |}</code></summary>
        member this.theme = Figure_Chart_ResetZoomButton_Theme()

        ///<summary>Figure_Chart_ResetZoomButton_Position : <code>{| align:string; x:int; y:int |}</code></summary>
        member this.position = Figure_Chart_ResetZoomButton_Position()

        member this.Set (o:{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_Chart_Width : <code>float</code></summary>
    type Figure_Chart_Width() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_Chart_Height : <code>float</code></summary>
    type Figure_Chart_Height() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_Chart_BorderColor : <code>string</code></summary>
    type Figure_Chart_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient_Id : <code>string</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient_Id() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int; id:string |}</code></summary>
    type Figure_Chart_BackgroundColor_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_Chart_BackgroundColor_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_Chart_BackgroundColor_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_Chart_BackgroundColor_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_Chart_BackgroundColor_LinearGradient_Y2()

        ///<summary>id : <code>string</code></summary>
        member this.id = Figure_Chart_BackgroundColor_LinearGradient_Id()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int; id:string |}) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Chart_BackgroundColor_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_BackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Chart_BackgroundColor_Stops_Item() =
        let item = Figure_Chart_BackgroundColor_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Chart_BackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Chart_BackgroundColor_Stops() =
        let item = Figure_Chart_BackgroundColor_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Chart_BackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}</code></summary>
    type Figure_Chart_BackgroundColor() =


        ///<summary>Figure_Chart_BackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int; id:string |}</code></summary>
        member this.linearGradient = Figure_Chart_BackgroundColor_LinearGradient()

        ///<summary>Figure_Chart_BackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Chart_BackgroundColor_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_Chart_PlotBorderColor : <code>string</code></summary>
    type Figure_Chart_PlotBorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_BorderWidth : <code>int</code></summary>
    type Figure_Chart_BorderWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart_ClassName : <code>string</code></summary>
    type Figure_Chart_ClassName() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_PlotBackgroundColor : <code>string</code></summary>
    type Figure_Chart_PlotBackgroundColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Chart_PlotBorderWidth : <code>int</code></summary>
    type Figure_Chart_PlotBorderWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Chart : <code>{| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}</code></summary>
    type Figure_Chart() =


        ///<summary>styledMode : <code>bool</code></summary>
        member this.styledMode = Figure_Chart_StyledMode()

        ///<summary>borderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_Chart_BorderRadius()

        ///<summary>colorCount : <code>int</code></summary>
        member this.colorCount = Figure_Chart_ColorCount()

        ///<summary>defaultSeriesType : <code>string</code></summary>
        member this.defaultSeriesType = Figure_Chart_DefaultSeriesType()

        ///<summary>ignoreHiddenSeries : <code>bool</code></summary>
        member this.ignoreHiddenSeries = Figure_Chart_IgnoreHiddenSeries()

        ///<summary>Figure_Chart_Spacing : <code>int seq</code></summary>
        member this.spacing = Figure_Chart_Spacing()

        ///<summary>Figure_Chart_ResetZoomButton : <code>{| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}</code></summary>
        member this.resetZoomButton = Figure_Chart_ResetZoomButton()

        ///<summary>width : <code>float</code></summary>
        member this.width = Figure_Chart_Width()

        ///<summary>height : <code>float</code></summary>
        member this.height = Figure_Chart_Height()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_Chart_BorderColor()

        ///<summary>Figure_Chart_BackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}</code></summary>
        member this.backgroundColor = Figure_Chart_BackgroundColor()

        ///<summary>plotBorderColor : <code>string</code></summary>
        member this.plotBorderColor = Figure_Chart_PlotBorderColor()

        ///<summary>borderWidth : <code>int</code></summary>
        member this.borderWidth = Figure_Chart_BorderWidth()

        ///<summary>className : <code>string</code></summary>
        member this.className = Figure_Chart_ClassName()

        ///<summary>plotBackgroundColor : <code>string</code></summary>
        member this.plotBackgroundColor = Figure_Chart_PlotBackgroundColor()

        ///<summary>plotBorderWidth : <code>int</code></summary>
        member this.plotBorderWidth = Figure_Chart_PlotBorderWidth()

        member this.Set (o:{| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_Title_Style_Color : <code>string</code></summary>
    type Figure_Title_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Style_FontSize : <code>string</code></summary>
    type Figure_Title_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Style_Font : <code>string</code></summary>
    type Figure_Title_Style_Font() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Style_Fill : <code>string</code></summary>
    type Figure_Title_Style_Fill() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Style_Width : <code>string</code></summary>
    type Figure_Title_Style_Width() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Style : <code>{| color:string; fontSize:string; font:string; fill:string; width:string |}</code></summary>
    type Figure_Title_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Title_Style_Color()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_Title_Style_FontSize()

        ///<summary>font : <code>string</code></summary>
        member this.font = Figure_Title_Style_Font()

        ///<summary>fill : <code>string</code></summary>
        member this.fill = Figure_Title_Style_Fill()

        ///<summary>width : <code>string</code></summary>
        member this.width = Figure_Title_Style_Width()

        member this.Set (o:{| color:string; fontSize:string; font:string; fill:string; width:string |}) =
            send "##JSON##"

    ///<summary>Figure_Title_Text : <code>string</code></summary>
    type Figure_Title_Text() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Align : <code>string</code></summary>
    type Figure_Title_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Title_Margin : <code>int</code></summary>
    type Figure_Title_Margin() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Title_WidthAdjust : <code>int</code></summary>
    type Figure_Title_WidthAdjust() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Title : <code>{| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}</code></summary>
    type Figure_Title() =


        ///<summary>Figure_Title_Style : <code>{| color:string; fontSize:string; font:string; fill:string; width:string |}</code></summary>
        member this.style = Figure_Title_Style()

        ///<summary>text : <code>string</code></summary>
        member this.text = Figure_Title_Text()

        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Title_Align()

        ///<summary>margin : <code>int</code></summary>
        member this.margin = Figure_Title_Margin()

        ///<summary>widthAdjust : <code>int</code></summary>
        member this.widthAdjust = Figure_Title_WidthAdjust()

        member this.Set (o:{| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Style_Color : <code>string</code></summary>
    type Figure_Subtitle_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Style_Font : <code>string</code></summary>
    type Figure_Subtitle_Style_Font() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Style_Fill : <code>string</code></summary>
    type Figure_Subtitle_Style_Fill() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Style_Width : <code>string</code></summary>
    type Figure_Subtitle_Style_Width() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Style : <code>{| color:string; font:string; fill:string; width:string |}</code></summary>
    type Figure_Subtitle_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Subtitle_Style_Color()

        ///<summary>font : <code>string</code></summary>
        member this.font = Figure_Subtitle_Style_Font()

        ///<summary>fill : <code>string</code></summary>
        member this.fill = Figure_Subtitle_Style_Fill()

        ///<summary>width : <code>string</code></summary>
        member this.width = Figure_Subtitle_Style_Width()

        member this.Set (o:{| color:string; font:string; fill:string; width:string |}) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Text : <code>string</code></summary>
    type Figure_Subtitle_Text() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_Align : <code>string</code></summary>
    type Figure_Subtitle_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Subtitle_WidthAdjust : <code>int</code></summary>
    type Figure_Subtitle_WidthAdjust() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Subtitle : <code>{| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}</code></summary>
    type Figure_Subtitle() =


        ///<summary>Figure_Subtitle_Style : <code>{| color:string; font:string; fill:string; width:string |}</code></summary>
        member this.style = Figure_Subtitle_Style()

        ///<summary>text : <code>string</code></summary>
        member this.text = Figure_Subtitle_Text()

        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Subtitle_Align()

        ///<summary>widthAdjust : <code>int</code></summary>
        member this.widthAdjust = Figure_Subtitle_WidthAdjust()

        member this.Set (o:{| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}) =
            send "##JSON##"

    ///<summary>Figure_Caption_Style_Color : <code>string</code></summary>
    type Figure_Caption_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Caption_Style_Fill : <code>string</code></summary>
    type Figure_Caption_Style_Fill() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Caption_Style_Width : <code>string</code></summary>
    type Figure_Caption_Style_Width() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Caption_Style : <code>{| color:string; fill:string; width:string |}</code></summary>
    type Figure_Caption_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Caption_Style_Color()

        ///<summary>fill : <code>string</code></summary>
        member this.fill = Figure_Caption_Style_Fill()

        ///<summary>width : <code>string</code></summary>
        member this.width = Figure_Caption_Style_Width()

        member this.Set (o:{| color:string; fill:string; width:string |}) =
            send "##JSON##"

    ///<summary>Figure_Caption_Margin : <code>int</code></summary>
    type Figure_Caption_Margin() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Caption_Text : <code>string</code></summary>
    type Figure_Caption_Text() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Caption_Align : <code>string</code></summary>
    type Figure_Caption_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Caption_VerticalAlign : <code>string</code></summary>
    type Figure_Caption_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Caption : <code>{| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}</code></summary>
    type Figure_Caption() =


        ///<summary>Figure_Caption_Style : <code>{| color:string; fill:string; width:string |}</code></summary>
        member this.style = Figure_Caption_Style()

        ///<summary>margin : <code>int</code></summary>
        member this.margin = Figure_Caption_Margin()

        ///<summary>text : <code>string</code></summary>
        member this.text = Figure_Caption_Text()

        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Caption_Align()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Caption_VerticalAlign()

        member this.Set (o:{| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Line_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Line_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Line_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Line_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Line_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_EnabledThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Line_Marker_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_Radius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Line_Marker_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_Marker_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Hover() =


        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_Marker_States_Hover_Animation()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Line_Marker_States_Hover_Enabled()

        ///<summary>radiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Line_Marker_States_Hover_RadiusPlus()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Line_Marker_States_Hover_LineWidthPlus()

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select_FillColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States_Select() =


        ///<summary>fillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Line_Marker_States_Select_FillColor()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Line_Marker_States_Select_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Line_Marker_States_Select_LineWidth()

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Line_Marker_States() =


        ///<summary>Figure_PlotOptions_Line_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Line_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Line_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Line_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Line_Marker_States_Select()

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Line_Marker() =


        ///<summary>enabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Line_Marker_EnabledThreshold()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Line_Marker_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Line_Marker_LineWidth()

        ///<summary>radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Line_Marker_Radius()

        ///<summary>Figure_PlotOptions_Line_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Line_Marker_States()

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Line_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Line_Point() =


        ///<summary>Figure_PlotOptions_Line_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Line_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Line_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Line_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Line_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Line_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Line_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels_Color : <code>string</code></summary>
    type Figure_PlotOptions_Line_DataLabels_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}</code></summary>
    type Figure_PlotOptions_Line_DataLabels() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Line_DataLabels_Align()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Line_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Line_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Line_DataLabels_Style()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Line_DataLabels_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Line_DataLabels_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Line_DataLabels_Y()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Line_DataLabels_Color()

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Line_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Line_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Line_PointRange() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Line_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Line_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Line_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Halo_Size() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Halo_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover_Halo() =


        ///<summary>size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Line_States_Hover_Halo_Size()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Line_States_Hover_Halo_Opacity()

        member this.Set (o:{| size:int; opacity:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Line_States_Hover() =


        ///<summary>Figure_PlotOptions_Line_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Line_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Line_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Line_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Line_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Line_States_Hover_Halo()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Line_States_Select() =


        ///<summary>Figure_PlotOptions_Line_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Select_Animation()

        member this.Set (o:{| animation: {| duration:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Line_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Line_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Line_States_Inactive() =


        ///<summary>Figure_PlotOptions_Line_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Line_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Line_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Line_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Line_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Line_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Line : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}</code></summary>
    type Figure_PlotOptions_Line() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Line_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Line_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Line_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
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

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Line_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Line_Opacity()

        ///<summary>pointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Line_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Line_SoftThreshold()

        ///<summary>Figure_PlotOptions_Line_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Line_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Line_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Line_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Line_FindNearestPointBy()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Area_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Area_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Area_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Area_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Area_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_EnabledThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Area_Marker_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_Radius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Area_Marker_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_Marker_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Hover() =


        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_Marker_States_Hover_Animation()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Area_Marker_States_Hover_Enabled()

        ///<summary>radiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Area_Marker_States_Hover_RadiusPlus()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Area_Marker_States_Hover_LineWidthPlus()

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select_FillColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States_Select() =


        ///<summary>fillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Area_Marker_States_Select_FillColor()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Area_Marker_States_Select_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Area_Marker_States_Select_LineWidth()

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Area_Marker_States() =


        ///<summary>Figure_PlotOptions_Area_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Area_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Area_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Area_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Area_Marker_States_Select()

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Area_Marker() =


        ///<summary>enabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Area_Marker_EnabledThreshold()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Area_Marker_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Area_Marker_LineWidth()

        ///<summary>radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Area_Marker_Radius()

        ///<summary>Figure_PlotOptions_Area_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Area_Marker_States()

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Area_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Area_Point() =


        ///<summary>Figure_PlotOptions_Area_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Area_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Area_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Area_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Area_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Area_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Area_DataLabels_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Area_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Area_DataLabels_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Area_DataLabels() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Area_DataLabels_Align()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Area_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Area_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Area_DataLabels_Style()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Area_DataLabels_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Area_DataLabels_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Area_DataLabels_Y()

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Area_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Area_PointRange() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Area_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Area_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Area_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Halo_Size() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Halo_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover_Halo() =


        ///<summary>size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Area_States_Hover_Halo_Size()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Area_States_Hover_Halo_Opacity()

        member this.Set (o:{| size:int; opacity:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Area_States_Hover() =


        ///<summary>Figure_PlotOptions_Area_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Area_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Area_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Area_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Area_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Area_States_Hover_Halo()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Area_States_Select() =


        ///<summary>Figure_PlotOptions_Area_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Select_Animation()

        member this.Set (o:{| animation: {| duration:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Area_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Area_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Area_States_Inactive() =


        ///<summary>Figure_PlotOptions_Area_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Area_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Area_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Area_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Area_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Area_Threshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Area : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}</code></summary>
    type Figure_PlotOptions_Area() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Area_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Area_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Area_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
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

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Area_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Area_Opacity()

        ///<summary>pointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Area_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Area_SoftThreshold()

        ///<summary>Figure_PlotOptions_Area_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Area_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Area_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Area_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Area_FindNearestPointBy()

        ///<summary>threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Area_Threshold()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Spline_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Spline_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_EnabledThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Spline_Marker_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_Radius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Spline_Marker_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_Marker_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Hover() =


        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_Marker_States_Hover_Animation()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Spline_Marker_States_Hover_Enabled()

        ///<summary>radiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Spline_Marker_States_Hover_RadiusPlus()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Spline_Marker_States_Hover_LineWidthPlus()

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select_FillColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States_Select() =


        ///<summary>fillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Spline_Marker_States_Select_FillColor()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Spline_Marker_States_Select_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Spline_Marker_States_Select_LineWidth()

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_Marker_States() =


        ///<summary>Figure_PlotOptions_Spline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Spline_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Spline_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Spline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Spline_Marker_States_Select()

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Spline_Marker() =


        ///<summary>enabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Spline_Marker_EnabledThreshold()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Spline_Marker_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Spline_Marker_LineWidth()

        ///<summary>radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Spline_Marker_Radius()

        ///<summary>Figure_PlotOptions_Spline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Spline_Marker_States()

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Spline_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Spline_Point() =


        ///<summary>Figure_PlotOptions_Spline_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Spline_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Spline_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Spline_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Spline_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Spline_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Spline_DataLabels_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Spline_DataLabels() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Spline_DataLabels_Align()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Spline_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Spline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Spline_DataLabels_Style()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Spline_DataLabels_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Spline_DataLabels_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Spline_DataLabels_Y()

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Spline_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Spline_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Spline_PointRange() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Spline_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Halo_Size() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Halo_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover_Halo() =


        ///<summary>size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Spline_States_Hover_Halo_Size()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Spline_States_Hover_Halo_Opacity()

        member this.Set (o:{| size:int; opacity:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_States_Hover() =


        ///<summary>Figure_PlotOptions_Spline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Spline_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Spline_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Spline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Spline_States_Hover_Halo()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Spline_States_Select() =


        ///<summary>Figure_PlotOptions_Spline_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Select_Animation()

        member this.Set (o:{| animation: {| duration:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Spline_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Spline_States_Inactive() =


        ///<summary>Figure_PlotOptions_Spline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Spline_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Spline_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Spline_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Spline_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Spline_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Spline : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}</code></summary>
    type Figure_PlotOptions_Spline() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Spline_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Spline_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Spline_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
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

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Spline_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Spline_Opacity()

        ///<summary>pointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Spline_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Spline_SoftThreshold()

        ///<summary>Figure_PlotOptions_Spline_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Spline_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Spline_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Spline_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Spline_FindNearestPointBy()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_EnabledThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_Radius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_Marker_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Hover() =


        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_Marker_States_Hover_Animation()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Areaspline_Marker_States_Hover_Enabled()

        ///<summary>radiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Areaspline_Marker_States_Hover_RadiusPlus()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Areaspline_Marker_States_Hover_LineWidthPlus()

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States_Select() =


        ///<summary>fillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Areaspline_Marker_States_Select_FillColor()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Areaspline_Marker_States_Select_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Areaspline_Marker_States_Select_LineWidth()

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker_States() =


        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Areaspline_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Areaspline_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Areaspline_Marker_States_Select()

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_Marker() =


        ///<summary>enabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Areaspline_Marker_EnabledThreshold()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Areaspline_Marker_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Areaspline_Marker_LineWidth()

        ///<summary>radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Areaspline_Marker_Radius()

        ///<summary>Figure_PlotOptions_Areaspline_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Areaspline_Marker_States()

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_Point() =


        ///<summary>Figure_PlotOptions_Areaspline_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Areaspline_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Areaspline_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Areaspline_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Areaspline_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Areaspline_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_DataLabels() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Areaspline_DataLabels_Align()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Areaspline_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Areaspline_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Areaspline_DataLabels_Style()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Areaspline_DataLabels_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Areaspline_DataLabels_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Areaspline_DataLabels_Y()

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_PointRange() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Halo_Size() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover_Halo() =


        ///<summary>size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Areaspline_States_Hover_Halo_Size()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Areaspline_States_Hover_Halo_Opacity()

        member this.Set (o:{| size:int; opacity:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Hover() =


        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Areaspline_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Areaspline_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Areaspline_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Areaspline_States_Hover_Halo()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Select() =


        ///<summary>Figure_PlotOptions_Areaspline_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Select_Animation()

        member this.Set (o:{| animation: {| duration:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Areaspline_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Areaspline_States_Inactive() =


        ///<summary>Figure_PlotOptions_Areaspline_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Areaspline_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Areaspline_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Areaspline_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Areaspline_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Areaspline_Threshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Areaspline : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}</code></summary>
    type Figure_PlotOptions_Areaspline() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Areaspline_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Areaspline_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Areaspline_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
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

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Areaspline_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Areaspline_Opacity()

        ///<summary>pointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Areaspline_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Areaspline_SoftThreshold()

        ///<summary>Figure_PlotOptions_Areaspline_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Areaspline_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Areaspline_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Areaspline_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Areaspline_FindNearestPointBy()

        ///<summary>threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Areaspline_Threshold()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Column_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Column_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Column_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Column_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Column_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Marker : <code>float</code></summary>
    type Figure_PlotOptions_Column_Marker() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Column_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Column_Point() =


        ///<summary>Figure_PlotOptions_Column_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Column_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Column_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Column_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Column_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Column_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Column_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Column_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
    type Figure_PlotOptions_Column_DataLabels() =


        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Column_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Column_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Column_DataLabels_Style()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Column_DataLabels_X()

        member this.Set (o:{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Column_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Column_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_PointRange : <code>float</code></summary>
    type Figure_PlotOptions_Column_PointRange() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Column_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Column_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Column_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover_Halo : <code>bool</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Halo() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover_Brightness : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Hover_Brightness() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Hover() =


        ///<summary>Figure_PlotOptions_Column_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Column_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Column_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Column_States_Hover_Marker()

        ///<summary>halo : <code>bool</code></summary>
        member this.halo = Figure_PlotOptions_Column_States_Hover_Halo()

        ///<summary>brightness : <code>int</code></summary>
        member this.brightness = Figure_PlotOptions_Column_States_Hover_Brightness()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Select_Color : <code>string</code></summary>
    type Figure_PlotOptions_Column_States_Select_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Select_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Column_States_Select_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Select : <code>{| animation: {| duration:int |}; color:string; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Column_States_Select() =


        ///<summary>Figure_PlotOptions_Column_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Select_Animation()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Column_States_Select_Color()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Column_States_Select_BorderColor()

        member this.Set (o:{| animation: {| duration:int |}; color:string; borderColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Column_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Column_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Column_States_Inactive() =


        ///<summary>Figure_PlotOptions_Column_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Column_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Column_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Column_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Column_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_BorderRadius : <code>int</code></summary>
    type Figure_PlotOptions_Column_BorderRadius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_CenterInCategory : <code>bool</code></summary>
    type Figure_PlotOptions_Column_CenterInCategory() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_GroupPadding : <code>int</code></summary>
    type Figure_PlotOptions_Column_GroupPadding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_PointPadding : <code>int</code></summary>
    type Figure_PlotOptions_Column_PointPadding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_MinPointLength : <code>int</code></summary>
    type Figure_PlotOptions_Column_MinPointLength() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_StartFromThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Column_StartFromThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Column_Threshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Column_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Column : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Column() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Column_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Column_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Column_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Column_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Column_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Column_Animation()

        ///<summary>Figure_PlotOptions_Column_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Column_Events()

        ///<summary>marker : <code>float</code></summary>
        member this.marker = Figure_PlotOptions_Column_Marker()

        ///<summary>Figure_PlotOptions_Column_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Column_Point()

        ///<summary>Figure_PlotOptions_Column_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Column_DataLabels()

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Column_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Column_Opacity()

        ///<summary>pointRange : <code>float</code></summary>
        member this.pointRange = Figure_PlotOptions_Column_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Column_SoftThreshold()

        ///<summary>Figure_PlotOptions_Column_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Column_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Column_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Column_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Column_FindNearestPointBy()

        ///<summary>borderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_PlotOptions_Column_BorderRadius()

        ///<summary>centerInCategory : <code>bool</code></summary>
        member this.centerInCategory = Figure_PlotOptions_Column_CenterInCategory()

        ///<summary>groupPadding : <code>int</code></summary>
        member this.groupPadding = Figure_PlotOptions_Column_GroupPadding()

        ///<summary>pointPadding : <code>int</code></summary>
        member this.pointPadding = Figure_PlotOptions_Column_PointPadding()

        ///<summary>minPointLength : <code>int</code></summary>
        member this.minPointLength = Figure_PlotOptions_Column_MinPointLength()

        ///<summary>startFromThreshold : <code>bool</code></summary>
        member this.startFromThreshold = Figure_PlotOptions_Column_StartFromThreshold()

        ///<summary>threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Column_Threshold()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Column_BorderColor()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Bar_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Bar_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Marker : <code>float</code></summary>
    type Figure_PlotOptions_Bar_Marker() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Bar_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Bar_Point() =


        ///<summary>Figure_PlotOptions_Bar_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Bar_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Bar_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Bar_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Bar_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Bar_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Bar_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
    type Figure_PlotOptions_Bar_DataLabels() =


        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Bar_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Bar_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Bar_DataLabels_Style()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Bar_DataLabels_X()

        member this.Set (o:{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Bar_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Bar_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_PointRange : <code>float</code></summary>
    type Figure_PlotOptions_Bar_PointRange() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Bar_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Halo : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Halo() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover_Brightness : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Hover_Brightness() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Hover() =


        ///<summary>Figure_PlotOptions_Bar_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Bar_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Bar_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Bar_States_Hover_Marker()

        ///<summary>halo : <code>bool</code></summary>
        member this.halo = Figure_PlotOptions_Bar_States_Hover_Halo()

        ///<summary>brightness : <code>int</code></summary>
        member this.brightness = Figure_PlotOptions_Bar_States_Hover_Brightness()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Select_Color : <code>string</code></summary>
    type Figure_PlotOptions_Bar_States_Select_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Select_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Bar_States_Select_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Select : <code>{| animation: {| duration:int |}; color:string; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Bar_States_Select() =


        ///<summary>Figure_PlotOptions_Bar_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Select_Animation()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Bar_States_Select_Color()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Bar_States_Select_BorderColor()

        member this.Set (o:{| animation: {| duration:int |}; color:string; borderColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Bar_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Bar_States_Inactive() =


        ///<summary>Figure_PlotOptions_Bar_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Bar_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Bar_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Bar_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_BorderRadius : <code>int</code></summary>
    type Figure_PlotOptions_Bar_BorderRadius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_CenterInCategory : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_CenterInCategory() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_GroupPadding : <code>int</code></summary>
    type Figure_PlotOptions_Bar_GroupPadding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_PointPadding : <code>int</code></summary>
    type Figure_PlotOptions_Bar_PointPadding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_MinPointLength : <code>int</code></summary>
    type Figure_PlotOptions_Bar_MinPointLength() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_StartFromThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Bar_StartFromThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_Threshold : <code>int</code></summary>
    type Figure_PlotOptions_Bar_Threshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Bar_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Bar : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}</code></summary>
    type Figure_PlotOptions_Bar() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Bar_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Bar_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Bar_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Bar_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Bar_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Bar_Animation()

        ///<summary>Figure_PlotOptions_Bar_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Bar_Events()

        ///<summary>marker : <code>float</code></summary>
        member this.marker = Figure_PlotOptions_Bar_Marker()

        ///<summary>Figure_PlotOptions_Bar_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Bar_Point()

        ///<summary>Figure_PlotOptions_Bar_DataLabels : <code>{| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Bar_DataLabels()

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Bar_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Bar_Opacity()

        ///<summary>pointRange : <code>float</code></summary>
        member this.pointRange = Figure_PlotOptions_Bar_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Bar_SoftThreshold()

        ///<summary>Figure_PlotOptions_Bar_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Bar_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Bar_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Bar_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Bar_FindNearestPointBy()

        ///<summary>borderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_PlotOptions_Bar_BorderRadius()

        ///<summary>centerInCategory : <code>bool</code></summary>
        member this.centerInCategory = Figure_PlotOptions_Bar_CenterInCategory()

        ///<summary>groupPadding : <code>int</code></summary>
        member this.groupPadding = Figure_PlotOptions_Bar_GroupPadding()

        ///<summary>pointPadding : <code>int</code></summary>
        member this.pointPadding = Figure_PlotOptions_Bar_PointPadding()

        ///<summary>minPointLength : <code>int</code></summary>
        member this.minPointLength = Figure_PlotOptions_Bar_MinPointLength()

        ///<summary>startFromThreshold : <code>bool</code></summary>
        member this.startFromThreshold = Figure_PlotOptions_Bar_StartFromThreshold()

        ///<summary>threshold : <code>int</code></summary>
        member this.threshold = Figure_PlotOptions_Bar_Threshold()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Bar_BorderColor()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Scatter_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_EnabledThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_EnabledThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_Marker_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_Radius : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_Radius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_Marker_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_Marker_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Hover() =


        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_Marker_States_Hover_Animation()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Scatter_Marker_States_Hover_Enabled()

        ///<summary>radiusPlus : <code>int</code></summary>
        member this.radiusPlus = Figure_PlotOptions_Scatter_Marker_States_Hover_RadiusPlus()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Scatter_Marker_States_Hover_LineWidthPlus()

        member this.Set (o:{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_FillColor : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select_FillColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States_Select() =


        ///<summary>fillColor : <code>string</code></summary>
        member this.fillColor = Figure_PlotOptions_Scatter_Marker_States_Select_FillColor()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Scatter_Marker_States_Select_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Scatter_Marker_States_Select_LineWidth()

        member this.Set (o:{| fillColor:string; lineColor:string; lineWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker_States() =


        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Normal : <code>{| animation:bool |}</code></summary>
        member this.normal = Figure_PlotOptions_Scatter_Marker_States_Normal()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Hover : <code>{| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}</code></summary>
        member this.hover = Figure_PlotOptions_Scatter_Marker_States_Hover()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States_Select : <code>{| fillColor:string; lineColor:string; lineWidth:int |}</code></summary>
        member this.select = Figure_PlotOptions_Scatter_Marker_States_Select()

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_Marker_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Marker : <code>{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}</code></summary>
    type Figure_PlotOptions_Scatter_Marker() =


        ///<summary>enabledThreshold : <code>int</code></summary>
        member this.enabledThreshold = Figure_PlotOptions_Scatter_Marker_EnabledThreshold()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Scatter_Marker_LineColor()

        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Scatter_Marker_LineWidth()

        ///<summary>radius : <code>int</code></summary>
        member this.radius = Figure_PlotOptions_Scatter_Marker_Radius()

        ///<summary>Figure_PlotOptions_Scatter_Marker_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Scatter_Marker_States()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Scatter_Marker_Enabled()

        member this.Set (o:{| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Scatter_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Scatter_Point() =


        ///<summary>Figure_PlotOptions_Scatter_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Scatter_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Scatter_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Scatter_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Scatter_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Scatter_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Scatter_DataLabels() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Scatter_DataLabels_Align()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Scatter_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Scatter_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Scatter_DataLabels_Style()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Scatter_DataLabels_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Scatter_DataLabels_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Scatter_DataLabels_Y()

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_PointRange() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Halo_Size() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover_Halo() =


        ///<summary>size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Scatter_States_Hover_Halo_Size()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Scatter_States_Hover_Halo_Opacity()

        member this.Set (o:{| size:int; opacity:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Hover() =


        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Scatter_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Scatter_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Scatter_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Scatter_States_Hover_Halo()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Select() =


        ///<summary>Figure_PlotOptions_Scatter_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Select_Animation()

        member this.Set (o:{| animation: {| duration:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Scatter_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Scatter_States_Inactive() =


        ///<summary>Figure_PlotOptions_Scatter_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Scatter_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Scatter_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Scatter_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Scatter_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Jitter_X : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Jitter_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Jitter_Y : <code>int</code></summary>
    type Figure_PlotOptions_Scatter_Jitter_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter_Jitter : <code>{| x:int; y:int |}</code></summary>
    type Figure_PlotOptions_Scatter_Jitter() =


        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Scatter_Jitter_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Scatter_Jitter_Y()

        member this.Set (o:{| x:int; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Scatter : <code>{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}</code></summary>
    type Figure_PlotOptions_Scatter() =


        ///<summary>lineWidth : <code>int</code></summary>
        member this.lineWidth = Figure_PlotOptions_Scatter_LineWidth()

        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Scatter_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Scatter_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
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

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Scatter_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Scatter_Opacity()

        ///<summary>pointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Scatter_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Scatter_SoftThreshold()

        ///<summary>Figure_PlotOptions_Scatter_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Scatter_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Scatter_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Scatter_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Scatter_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Scatter_Jitter : <code>{| x:int; y:int |}</code></summary>
        member this.jitter = Figure_PlotOptions_Scatter_Jitter()

        member this.Set (o:{| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_AllowPointSelect : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_AllowPointSelect() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Crisp : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_Crisp() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_ShowCheckbox : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_ShowCheckbox() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Pie_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Marker : <code>float</code></summary>
    type Figure_PlotOptions_Pie_Marker() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Point_Events : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Pie_Point_Events() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Point : <code>{| events: {| dummy:string |} |}</code></summary>
    type Figure_PlotOptions_Pie_Point() =


        ///<summary>Figure_PlotOptions_Pie_Point_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Pie_Point_Events()

        member this.Set (o:{| events: {| dummy:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Align : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Padding : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_FontSize : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_FontWeight : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_Color : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style_TextOutline : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style_TextOutline() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Style() =


        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_PlotOptions_Pie_DataLabels_Style_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_PlotOptions_Pie_DataLabels_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_PlotOptions_Pie_DataLabels_Style_Color()

        ///<summary>textOutline : <code>string</code></summary>
        member this.textOutline = Figure_PlotOptions_Pie_DataLabels_Style_TextOutline()

        member this.Set (o:{| fontSize:string; fontWeight:string; color:string; textOutline:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_VerticalAlign : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_X : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Y : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_AllowOverlap : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_AllowOverlap() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_ConnectorPadding : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_ConnectorPadding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_ConnectorShape : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_ConnectorShape() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_CrookDistance : <code>string</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_CrookDistance() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Distance : <code>int</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Distance() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_Enabled : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels_SoftConnector : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_DataLabels_SoftConnector() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}</code></summary>
    type Figure_PlotOptions_Pie_DataLabels() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_PlotOptions_Pie_DataLabels_Align()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_PlotOptions_Pie_DataLabels_Padding()

        ///<summary>Figure_PlotOptions_Pie_DataLabels_Style : <code>{| fontSize:string; fontWeight:string; color:string; textOutline:string |}</code></summary>
        member this.style = Figure_PlotOptions_Pie_DataLabels_Style()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_PlotOptions_Pie_DataLabels_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_PlotOptions_Pie_DataLabels_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_PlotOptions_Pie_DataLabels_Y()

        ///<summary>allowOverlap : <code>bool</code></summary>
        member this.allowOverlap = Figure_PlotOptions_Pie_DataLabels_AllowOverlap()

        ///<summary>connectorPadding : <code>int</code></summary>
        member this.connectorPadding = Figure_PlotOptions_Pie_DataLabels_ConnectorPadding()

        ///<summary>connectorShape : <code>string</code></summary>
        member this.connectorShape = Figure_PlotOptions_Pie_DataLabels_ConnectorShape()

        ///<summary>crookDistance : <code>string</code></summary>
        member this.crookDistance = Figure_PlotOptions_Pie_DataLabels_CrookDistance()

        ///<summary>distance : <code>int</code></summary>
        member this.distance = Figure_PlotOptions_Pie_DataLabels_Distance()

        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_PlotOptions_Pie_DataLabels_Enabled()

        ///<summary>softConnector : <code>bool</code></summary>
        member this.softConnector = Figure_PlotOptions_Pie_DataLabels_SoftConnector()

        member this.Set (o:{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_CropThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Pie_CropThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Pie_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_PointRange : <code>int</code></summary>
    type Figure_PlotOptions_Pie_PointRange() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_SoftThreshold : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_SoftThreshold() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Normal_Animation : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_States_Normal_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Normal : <code>{| animation:bool |}</code></summary>
    type Figure_PlotOptions_Pie_States_Normal() =


        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Normal_Animation()

        member this.Set (o:{| animation:bool |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_States_Hover_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_LineWidthPlus : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_LineWidthPlus() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Marker() =


        member this.Set (o:{| dummy:string |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo_Size : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Halo_Size() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Halo_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Halo() =


        ///<summary>size : <code>int</code></summary>
        member this.size = Figure_PlotOptions_Pie_States_Hover_Halo_Size()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Pie_States_Hover_Halo_Opacity()

        member this.Set (o:{| size:int; opacity:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover_Brightness : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Hover_Brightness() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Hover : <code>{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Hover() =


        ///<summary>Figure_PlotOptions_Pie_States_Hover_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Hover_Animation()

        ///<summary>lineWidthPlus : <code>int</code></summary>
        member this.lineWidthPlus = Figure_PlotOptions_Pie_States_Hover_LineWidthPlus()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Marker : <code>{| dummy:string |}</code></summary>
        member this.marker = Figure_PlotOptions_Pie_States_Hover_Marker()

        ///<summary>Figure_PlotOptions_Pie_States_Hover_Halo : <code>{| size:int; opacity:int |}</code></summary>
        member this.halo = Figure_PlotOptions_Pie_States_Hover_Halo()

        ///<summary>brightness : <code>int</code></summary>
        member this.brightness = Figure_PlotOptions_Pie_States_Hover_Brightness()

        member this.Set (o:{| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Select_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Select_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Select_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Select_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_States_Select_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Select : <code>{| animation: {| duration:int |} |}</code></summary>
    type Figure_PlotOptions_Pie_States_Select() =


        ///<summary>Figure_PlotOptions_Pie_States_Select_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Select_Animation()

        member this.Set (o:{| animation: {| duration:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation_Duration : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive_Animation_Duration() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive_Animation() =


        ///<summary>duration : <code>int</code></summary>
        member this.duration = Figure_PlotOptions_Pie_States_Inactive_Animation_Duration()

        member this.Set (o:{| duration:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Inactive_Opacity : <code>int</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_States_Inactive : <code>{| animation: {| duration:int |}; opacity:int |}</code></summary>
    type Figure_PlotOptions_Pie_States_Inactive() =


        ///<summary>Figure_PlotOptions_Pie_States_Inactive_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_States_Inactive_Animation()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Pie_States_Inactive_Opacity()

        member this.Set (o:{| animation: {| duration:int |}; opacity:int |}) =
            send "##JSON##"

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

        member this.Set (o:{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_StickyTracking : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_StickyTracking() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_TurboThreshold : <code>int</code></summary>
    type Figure_PlotOptions_Pie_TurboThreshold() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_FindNearestPointBy : <code>string</code></summary>
    type Figure_PlotOptions_Pie_FindNearestPointBy() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Center_Item : <code>float</code></summary>
    type Figure_PlotOptions_Pie_Center_Item() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Center : <code>float seq</code></summary>
    type Figure_PlotOptions_Pie_Center() =
        let item = Figure_PlotOptions_Pie_Center_Item()

        member this.Set (o:float seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_PlotOptions_Pie_Clip : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_Clip() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_ColorByPoint : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_ColorByPoint() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_IgnoreHiddenPoint : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_IgnoreHiddenPoint() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_InactiveOtherPoints : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_InactiveOtherPoints() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_LegendType : <code>string</code></summary>
    type Figure_PlotOptions_Pie_LegendType() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_Size : <code>float</code></summary>
    type Figure_PlotOptions_Pie_Size() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_ShowInLegend : <code>bool</code></summary>
    type Figure_PlotOptions_Pie_ShowInLegend() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_SlicedOffset : <code>int</code></summary>
    type Figure_PlotOptions_Pie_SlicedOffset() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_BorderColor : <code>string</code></summary>
    type Figure_PlotOptions_Pie_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie_BorderWidth : <code>int</code></summary>
    type Figure_PlotOptions_Pie_BorderWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Pie : <code>{| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}</code></summary>
    type Figure_PlotOptions_Pie() =


        ///<summary>allowPointSelect : <code>bool</code></summary>
        member this.allowPointSelect = Figure_PlotOptions_Pie_AllowPointSelect()

        ///<summary>crisp : <code>bool</code></summary>
        member this.crisp = Figure_PlotOptions_Pie_Crisp()

        ///<summary>showCheckbox : <code>bool</code></summary>
        member this.showCheckbox = Figure_PlotOptions_Pie_ShowCheckbox()

        ///<summary>Figure_PlotOptions_Pie_Animation : <code>{| duration:int |}</code></summary>
        member this.animation = Figure_PlotOptions_Pie_Animation()

        ///<summary>Figure_PlotOptions_Pie_Events : <code>{| dummy:string |}</code></summary>
        member this.events = Figure_PlotOptions_Pie_Events()

        ///<summary>marker : <code>float</code></summary>
        member this.marker = Figure_PlotOptions_Pie_Marker()

        ///<summary>Figure_PlotOptions_Pie_Point : <code>{| events: {| dummy:string |} |}</code></summary>
        member this.point = Figure_PlotOptions_Pie_Point()

        ///<summary>Figure_PlotOptions_Pie_DataLabels : <code>{| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}</code></summary>
        member this.dataLabels = Figure_PlotOptions_Pie_DataLabels()

        ///<summary>cropThreshold : <code>int</code></summary>
        member this.cropThreshold = Figure_PlotOptions_Pie_CropThreshold()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_PlotOptions_Pie_Opacity()

        ///<summary>pointRange : <code>int</code></summary>
        member this.pointRange = Figure_PlotOptions_Pie_PointRange()

        ///<summary>softThreshold : <code>bool</code></summary>
        member this.softThreshold = Figure_PlotOptions_Pie_SoftThreshold()

        ///<summary>Figure_PlotOptions_Pie_States : <code>{| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}</code></summary>
        member this.states = Figure_PlotOptions_Pie_States()

        ///<summary>stickyTracking : <code>bool</code></summary>
        member this.stickyTracking = Figure_PlotOptions_Pie_StickyTracking()

        ///<summary>turboThreshold : <code>int</code></summary>
        member this.turboThreshold = Figure_PlotOptions_Pie_TurboThreshold()

        ///<summary>findNearestPointBy : <code>string</code></summary>
        member this.findNearestPointBy = Figure_PlotOptions_Pie_FindNearestPointBy()

        ///<summary>Figure_PlotOptions_Pie_Center : <code>float seq</code></summary>
        member this.center = Figure_PlotOptions_Pie_Center()

        ///<summary>clip : <code>bool</code></summary>
        member this.clip = Figure_PlotOptions_Pie_Clip()

        ///<summary>colorByPoint : <code>bool</code></summary>
        member this.colorByPoint = Figure_PlotOptions_Pie_ColorByPoint()

        ///<summary>ignoreHiddenPoint : <code>bool</code></summary>
        member this.ignoreHiddenPoint = Figure_PlotOptions_Pie_IgnoreHiddenPoint()

        ///<summary>inactiveOtherPoints : <code>bool</code></summary>
        member this.inactiveOtherPoints = Figure_PlotOptions_Pie_InactiveOtherPoints()

        ///<summary>legendType : <code>string</code></summary>
        member this.legendType = Figure_PlotOptions_Pie_LegendType()

        ///<summary>size : <code>float</code></summary>
        member this.size = Figure_PlotOptions_Pie_Size()

        ///<summary>showInLegend : <code>bool</code></summary>
        member this.showInLegend = Figure_PlotOptions_Pie_ShowInLegend()

        ///<summary>slicedOffset : <code>int</code></summary>
        member this.slicedOffset = Figure_PlotOptions_Pie_SlicedOffset()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_PlotOptions_Pie_BorderColor()

        ///<summary>borderWidth : <code>int</code></summary>
        member this.borderWidth = Figure_PlotOptions_Pie_BorderWidth()

        member this.Set (o:{| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Candlestick_LineColor : <code>string</code></summary>
    type Figure_PlotOptions_Candlestick_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_PlotOptions_Candlestick : <code>{| lineColor:string |}</code></summary>
    type Figure_PlotOptions_Candlestick() =


        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_PlotOptions_Candlestick_LineColor()

        member this.Set (o:{| lineColor:string |}) =
            send "##JSON##"

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

        member this.Set (o:{| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Labels_Style_Position : <code>string</code></summary>
    type Figure_Labels_Style_Position() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Labels_Style_Color : <code>string</code></summary>
    type Figure_Labels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Labels_Style : <code>{| position:string; color:string |}</code></summary>
    type Figure_Labels_Style() =


        ///<summary>position : <code>string</code></summary>
        member this.position = Figure_Labels_Style_Position()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Labels_Style_Color()

        member this.Set (o:{| position:string; color:string |}) =
            send "##JSON##"

    ///<summary>Figure_Labels : <code>{| style: {| position:string; color:string |} |}</code></summary>
    type Figure_Labels() =


        ///<summary>Figure_Labels_Style : <code>{| position:string; color:string |}</code></summary>
        member this.style = Figure_Labels_Style()

        member this.Set (o:{| style: {| position:string; color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_Enabled : <code>bool</code></summary>
    type Figure_Legend_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Legend_Align : <code>string</code></summary>
    type Figure_Legend_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_AlignColumns : <code>bool</code></summary>
    type Figure_Legend_AlignColumns() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Legend_Layout : <code>string</code></summary>
    type Figure_Legend_Layout() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_BorderColor : <code>string</code></summary>
    type Figure_Legend_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_BorderRadius : <code>int</code></summary>
    type Figure_Legend_BorderRadius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Legend_Navigation_ActiveColor : <code>string</code></summary>
    type Figure_Legend_Navigation_ActiveColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_Navigation_InactiveColor : <code>string</code></summary>
    type Figure_Legend_Navigation_InactiveColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_Navigation : <code>{| activeColor:string; inactiveColor:string |}</code></summary>
    type Figure_Legend_Navigation() =


        ///<summary>activeColor : <code>string</code></summary>
        member this.activeColor = Figure_Legend_Navigation_ActiveColor()

        ///<summary>inactiveColor : <code>string</code></summary>
        member this.inactiveColor = Figure_Legend_Navigation_InactiveColor()

        member this.Set (o:{| activeColor:string; inactiveColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle_Color : <code>string</code></summary>
    type Figure_Legend_ItemStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle_Cursor : <code>string</code></summary>
    type Figure_Legend_ItemStyle_Cursor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle_FontSize : <code>string</code></summary>
    type Figure_Legend_ItemStyle_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle_FontWeight : <code>string</code></summary>
    type Figure_Legend_ItemStyle_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle_TextOverflow : <code>string</code></summary>
    type Figure_Legend_ItemStyle_TextOverflow() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle_Font : <code>string</code></summary>
    type Figure_Legend_ItemStyle_Font() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemStyle : <code>{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}</code></summary>
    type Figure_Legend_ItemStyle() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Legend_ItemStyle_Color()

        ///<summary>cursor : <code>string</code></summary>
        member this.cursor = Figure_Legend_ItemStyle_Cursor()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_Legend_ItemStyle_FontSize()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_Legend_ItemStyle_FontWeight()

        ///<summary>textOverflow : <code>string</code></summary>
        member this.textOverflow = Figure_Legend_ItemStyle_TextOverflow()

        ///<summary>font : <code>string</code></summary>
        member this.font = Figure_Legend_ItemStyle_Font()

        member this.Set (o:{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemHoverStyle_Color : <code>string</code></summary>
    type Figure_Legend_ItemHoverStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemHoverStyle : <code>{| color:string |}</code></summary>
    type Figure_Legend_ItemHoverStyle() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Legend_ItemHoverStyle_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemHiddenStyle_Color : <code>string</code></summary>
    type Figure_Legend_ItemHiddenStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemHiddenStyle : <code>{| color:string |}</code></summary>
    type Figure_Legend_ItemHiddenStyle() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Legend_ItemHiddenStyle_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_Shadow : <code>bool</code></summary>
    type Figure_Legend_Shadow() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemCheckboxStyle_Position : <code>string</code></summary>
    type Figure_Legend_ItemCheckboxStyle_Position() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemCheckboxStyle_Width : <code>string</code></summary>
    type Figure_Legend_ItemCheckboxStyle_Width() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemCheckboxStyle_Height : <code>string</code></summary>
    type Figure_Legend_ItemCheckboxStyle_Height() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_ItemCheckboxStyle : <code>{| position:string; width:string; height:string |}</code></summary>
    type Figure_Legend_ItemCheckboxStyle() =


        ///<summary>position : <code>string</code></summary>
        member this.position = Figure_Legend_ItemCheckboxStyle_Position()

        ///<summary>width : <code>string</code></summary>
        member this.width = Figure_Legend_ItemCheckboxStyle_Width()

        ///<summary>height : <code>string</code></summary>
        member this.height = Figure_Legend_ItemCheckboxStyle_Height()

        member this.Set (o:{| position:string; width:string; height:string |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_SquareSymbol : <code>bool</code></summary>
    type Figure_Legend_SquareSymbol() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Legend_SymbolPadding : <code>int</code></summary>
    type Figure_Legend_SymbolPadding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Legend_VerticalAlign : <code>string</code></summary>
    type Figure_Legend_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_X : <code>int</code></summary>
    type Figure_Legend_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Legend_Y : <code>int</code></summary>
    type Figure_Legend_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Legend_Title_Style_FontWeight : <code>string</code></summary>
    type Figure_Legend_Title_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_Title_Style_Color : <code>string</code></summary>
    type Figure_Legend_Title_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend_Title_Style : <code>{| fontWeight:string; color:string |}</code></summary>
    type Figure_Legend_Title_Style() =


        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_Legend_Title_Style_FontWeight()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Legend_Title_Style_Color()

        member this.Set (o:{| fontWeight:string; color:string |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_Title : <code>{| style: {| fontWeight:string; color:string |} |}</code></summary>
    type Figure_Legend_Title() =


        ///<summary>Figure_Legend_Title_Style : <code>{| fontWeight:string; color:string |}</code></summary>
        member this.style = Figure_Legend_Title_Style()

        member this.Set (o:{| style: {| fontWeight:string; color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Legend_BackgroundColor : <code>string</code></summary>
    type Figure_Legend_BackgroundColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Legend : <code>{| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}</code></summary>
    type Figure_Legend() =


        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_Legend_Enabled()

        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Legend_Align()

        ///<summary>alignColumns : <code>bool</code></summary>
        member this.alignColumns = Figure_Legend_AlignColumns()

        ///<summary>layout : <code>string</code></summary>
        member this.layout = Figure_Legend_Layout()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_Legend_BorderColor()

        ///<summary>borderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_Legend_BorderRadius()

        ///<summary>Figure_Legend_Navigation : <code>{| activeColor:string; inactiveColor:string |}</code></summary>
        member this.navigation = Figure_Legend_Navigation()

        ///<summary>Figure_Legend_ItemStyle : <code>{| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}</code></summary>
        member this.itemStyle = Figure_Legend_ItemStyle()

        ///<summary>Figure_Legend_ItemHoverStyle : <code>{| color:string |}</code></summary>
        member this.itemHoverStyle = Figure_Legend_ItemHoverStyle()

        ///<summary>Figure_Legend_ItemHiddenStyle : <code>{| color:string |}</code></summary>
        member this.itemHiddenStyle = Figure_Legend_ItemHiddenStyle()

        ///<summary>shadow : <code>bool</code></summary>
        member this.shadow = Figure_Legend_Shadow()

        ///<summary>Figure_Legend_ItemCheckboxStyle : <code>{| position:string; width:string; height:string |}</code></summary>
        member this.itemCheckboxStyle = Figure_Legend_ItemCheckboxStyle()

        ///<summary>squareSymbol : <code>bool</code></summary>
        member this.squareSymbol = Figure_Legend_SquareSymbol()

        ///<summary>symbolPadding : <code>int</code></summary>
        member this.symbolPadding = Figure_Legend_SymbolPadding()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Legend_VerticalAlign()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_Legend_X()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_Legend_Y()

        ///<summary>Figure_Legend_Title : <code>{| style: {| fontWeight:string; color:string |} |}</code></summary>
        member this.title = Figure_Legend_Title()

        ///<summary>backgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Legend_BackgroundColor()

        member this.Set (o:{| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_Loading_LabelStyle_FontWeight : <code>string</code></summary>
    type Figure_Loading_LabelStyle_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Loading_LabelStyle_Position : <code>string</code></summary>
    type Figure_Loading_LabelStyle_Position() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Loading_LabelStyle_Top : <code>string</code></summary>
    type Figure_Loading_LabelStyle_Top() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Loading_LabelStyle : <code>{| fontWeight:string; position:string; top:string |}</code></summary>
    type Figure_Loading_LabelStyle() =


        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_Loading_LabelStyle_FontWeight()

        ///<summary>position : <code>string</code></summary>
        member this.position = Figure_Loading_LabelStyle_Position()

        ///<summary>top : <code>string</code></summary>
        member this.top = Figure_Loading_LabelStyle_Top()

        member this.Set (o:{| fontWeight:string; position:string; top:string |}) =
            send "##JSON##"

    ///<summary>Figure_Loading_Style_Position : <code>string</code></summary>
    type Figure_Loading_Style_Position() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Loading_Style_BackgroundColor : <code>string</code></summary>
    type Figure_Loading_Style_BackgroundColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Loading_Style_Opacity : <code>int</code></summary>
    type Figure_Loading_Style_Opacity() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Loading_Style_TextAlign : <code>string</code></summary>
    type Figure_Loading_Style_TextAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Loading_Style : <code>{| position:string; backgroundColor:string; opacity:int; textAlign:string |}</code></summary>
    type Figure_Loading_Style() =


        ///<summary>position : <code>string</code></summary>
        member this.position = Figure_Loading_Style_Position()

        ///<summary>backgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Loading_Style_BackgroundColor()

        ///<summary>opacity : <code>int</code></summary>
        member this.opacity = Figure_Loading_Style_Opacity()

        ///<summary>textAlign : <code>string</code></summary>
        member this.textAlign = Figure_Loading_Style_TextAlign()

        member this.Set (o:{| position:string; backgroundColor:string; opacity:int; textAlign:string |}) =
            send "##JSON##"

    ///<summary>Figure_Loading : <code>{| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}</code></summary>
    type Figure_Loading() =


        ///<summary>Figure_Loading_LabelStyle : <code>{| fontWeight:string; position:string; top:string |}</code></summary>
        member this.labelStyle = Figure_Loading_LabelStyle()

        ///<summary>Figure_Loading_Style : <code>{| position:string; backgroundColor:string; opacity:int; textAlign:string |}</code></summary>
        member this.style = Figure_Loading_Style()

        member this.Set (o:{| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Enabled : <code>bool</code></summary>
    type Figure_Tooltip_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Animation : <code>bool</code></summary>
    type Figure_Tooltip_Animation() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_BorderRadius : <code>int</code></summary>
    type Figure_Tooltip_BorderRadius() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Millisecond : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Millisecond() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Second : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Second() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Minute : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Minute() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Hour : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Hour() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Day : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Day() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Week : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Week() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Month : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Month() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats_Year : <code>string</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats_Year() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_DateTimeLabelFormats : <code>{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}</code></summary>
    type Figure_Tooltip_DateTimeLabelFormats() =


        ///<summary>millisecond : <code>string</code></summary>
        member this.millisecond = Figure_Tooltip_DateTimeLabelFormats_Millisecond()

        ///<summary>second : <code>string</code></summary>
        member this.second = Figure_Tooltip_DateTimeLabelFormats_Second()

        ///<summary>minute : <code>string</code></summary>
        member this.minute = Figure_Tooltip_DateTimeLabelFormats_Minute()

        ///<summary>hour : <code>string</code></summary>
        member this.hour = Figure_Tooltip_DateTimeLabelFormats_Hour()

        ///<summary>day : <code>string</code></summary>
        member this.day = Figure_Tooltip_DateTimeLabelFormats_Day()

        ///<summary>week : <code>string</code></summary>
        member this.week = Figure_Tooltip_DateTimeLabelFormats_Week()

        ///<summary>month : <code>string</code></summary>
        member this.month = Figure_Tooltip_DateTimeLabelFormats_Month()

        ///<summary>year : <code>string</code></summary>
        member this.year = Figure_Tooltip_DateTimeLabelFormats_Year()

        member this.Set (o:{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_FooterFormat : <code>string</code></summary>
    type Figure_Tooltip_FooterFormat() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Padding : <code>int</code></summary>
    type Figure_Tooltip_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Snap : <code>int</code></summary>
    type Figure_Tooltip_Snap() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_HeaderFormat : <code>string</code></summary>
    type Figure_Tooltip_HeaderFormat() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_PointFormat : <code>string</code></summary>
    type Figure_Tooltip_PointFormat() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_BackgroundColor : <code>string</code></summary>
    type Figure_Tooltip_BackgroundColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_BorderWidth : <code>int</code></summary>
    type Figure_Tooltip_BorderWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Shadow : <code>bool</code></summary>
    type Figure_Tooltip_Shadow() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Style_Color : <code>string</code></summary>
    type Figure_Tooltip_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Style_Cursor : <code>string</code></summary>
    type Figure_Tooltip_Style_Cursor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Style_FontSize : <code>string</code></summary>
    type Figure_Tooltip_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Style_WhiteSpace : <code>string</code></summary>
    type Figure_Tooltip_Style_WhiteSpace() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Tooltip_Style : <code>{| color:string; cursor:string; fontSize:string; whiteSpace:string |}</code></summary>
    type Figure_Tooltip_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Tooltip_Style_Color()

        ///<summary>cursor : <code>string</code></summary>
        member this.cursor = Figure_Tooltip_Style_Cursor()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_Tooltip_Style_FontSize()

        ///<summary>whiteSpace : <code>string</code></summary>
        member this.whiteSpace = Figure_Tooltip_Style_WhiteSpace()

        member this.Set (o:{| color:string; cursor:string; fontSize:string; whiteSpace:string |}) =
            send "##JSON##"

    ///<summary>Figure_Tooltip : <code>{| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}</code></summary>
    type Figure_Tooltip() =


        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_Tooltip_Enabled()

        ///<summary>animation : <code>bool</code></summary>
        member this.animation = Figure_Tooltip_Animation()

        ///<summary>borderRadius : <code>int</code></summary>
        member this.borderRadius = Figure_Tooltip_BorderRadius()

        ///<summary>Figure_Tooltip_DateTimeLabelFormats : <code>{| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}</code></summary>
        member this.dateTimeLabelFormats = Figure_Tooltip_DateTimeLabelFormats()

        ///<summary>footerFormat : <code>string</code></summary>
        member this.footerFormat = Figure_Tooltip_FooterFormat()

        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_Tooltip_Padding()

        ///<summary>snap : <code>int</code></summary>
        member this.snap = Figure_Tooltip_Snap()

        ///<summary>headerFormat : <code>string</code></summary>
        member this.headerFormat = Figure_Tooltip_HeaderFormat()

        ///<summary>pointFormat : <code>string</code></summary>
        member this.pointFormat = Figure_Tooltip_PointFormat()

        ///<summary>backgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Tooltip_BackgroundColor()

        ///<summary>borderWidth : <code>int</code></summary>
        member this.borderWidth = Figure_Tooltip_BorderWidth()

        ///<summary>shadow : <code>bool</code></summary>
        member this.shadow = Figure_Tooltip_Shadow()

        ///<summary>Figure_Tooltip_Style : <code>{| color:string; cursor:string; fontSize:string; whiteSpace:string |}</code></summary>
        member this.style = Figure_Tooltip_Style()

        member this.Set (o:{| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Credits_Enabled : <code>bool</code></summary>
    type Figure_Credits_Enabled() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Credits_Href : <code>string</code></summary>
    type Figure_Credits_Href() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Position_Align : <code>string</code></summary>
    type Figure_Credits_Position_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Position_X : <code>int</code></summary>
    type Figure_Credits_Position_X() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Credits_Position_VerticalAlign : <code>string</code></summary>
    type Figure_Credits_Position_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Position_Y : <code>int</code></summary>
    type Figure_Credits_Position_Y() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Credits_Position : <code>{| align:string; x:int; verticalAlign:string; y:int |}</code></summary>
    type Figure_Credits_Position() =


        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Credits_Position_Align()

        ///<summary>x : <code>int</code></summary>
        member this.x = Figure_Credits_Position_X()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Credits_Position_VerticalAlign()

        ///<summary>y : <code>int</code></summary>
        member this.y = Figure_Credits_Position_Y()

        member this.Set (o:{| align:string; x:int; verticalAlign:string; y:int |}) =
            send "##JSON##"

    ///<summary>Figure_Credits_Style_Cursor : <code>string</code></summary>
    type Figure_Credits_Style_Cursor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Style_Color : <code>string</code></summary>
    type Figure_Credits_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Style_FontSize : <code>string</code></summary>
    type Figure_Credits_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Style_Fill : <code>string</code></summary>
    type Figure_Credits_Style_Fill() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits_Style : <code>{| cursor:string; color:string; fontSize:string; fill:string |}</code></summary>
    type Figure_Credits_Style() =


        ///<summary>cursor : <code>string</code></summary>
        member this.cursor = Figure_Credits_Style_Cursor()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Credits_Style_Color()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_Credits_Style_FontSize()

        ///<summary>fill : <code>string</code></summary>
        member this.fill = Figure_Credits_Style_Fill()

        member this.Set (o:{| cursor:string; color:string; fontSize:string; fill:string |}) =
            send "##JSON##"

    ///<summary>Figure_Credits_Text : <code>string</code></summary>
    type Figure_Credits_Text() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Credits : <code>{| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}</code></summary>
    type Figure_Credits() =


        ///<summary>enabled : <code>bool</code></summary>
        member this.enabled = Figure_Credits_Enabled()

        ///<summary>href : <code>string</code></summary>
        member this.href = Figure_Credits_Href()

        ///<summary>Figure_Credits_Position : <code>{| align:string; x:int; verticalAlign:string; y:int |}</code></summary>
        member this.position = Figure_Credits_Position()

        ///<summary>Figure_Credits_Style : <code>{| cursor:string; color:string; fontSize:string; fill:string |}</code></summary>
        member this.style = Figure_Credits_Style()

        ///<summary>text : <code>string</code></summary>
        member this.text = Figure_Credits_Text()

        member this.Set (o:{| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Padding : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Padding() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item() =
        let item = Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill_Stops() =
        let item = Figure_Navigation_ButtonOptions_Theme_Fill_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Fill() =


        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Navigation_ButtonOptions_Theme_Fill_LinearGradient()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Navigation_ButtonOptions_Theme_Fill_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme_Stroke : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_Theme_Stroke() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Theme : <code>{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}</code></summary>
    type Figure_Navigation_ButtonOptions_Theme() =


        ///<summary>padding : <code>int</code></summary>
        member this.padding = Figure_Navigation_ButtonOptions_Theme_Padding()

        ///<summary>Figure_Navigation_ButtonOptions_Theme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_Navigation_ButtonOptions_Theme_Fill()

        ///<summary>stroke : <code>string</code></summary>
        member this.stroke = Figure_Navigation_ButtonOptions_Theme_Stroke()

        member this.Set (o:{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_SymbolSize : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolSize() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_SymbolX : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolX() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_SymbolY : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolY() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Align : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_Align() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_ButtonSpacing : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_ButtonSpacing() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Height : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Height() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_VerticalAlign : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_VerticalAlign() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_Width : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_Width() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_SymbolFill : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolFill() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_SymbolStroke : <code>string</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolStroke() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions_SymbolStrokeWidth : <code>int</code></summary>
    type Figure_Navigation_ButtonOptions_SymbolStrokeWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Navigation_ButtonOptions : <code>{| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}</code></summary>
    type Figure_Navigation_ButtonOptions() =


        ///<summary>Figure_Navigation_ButtonOptions_Theme : <code>{| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}</code></summary>
        member this.theme = Figure_Navigation_ButtonOptions_Theme()

        ///<summary>symbolSize : <code>int</code></summary>
        member this.symbolSize = Figure_Navigation_ButtonOptions_SymbolSize()

        ///<summary>symbolX : <code>int</code></summary>
        member this.symbolX = Figure_Navigation_ButtonOptions_SymbolX()

        ///<summary>symbolY : <code>int</code></summary>
        member this.symbolY = Figure_Navigation_ButtonOptions_SymbolY()

        ///<summary>align : <code>string</code></summary>
        member this.align = Figure_Navigation_ButtonOptions_Align()

        ///<summary>buttonSpacing : <code>int</code></summary>
        member this.buttonSpacing = Figure_Navigation_ButtonOptions_ButtonSpacing()

        ///<summary>height : <code>int</code></summary>
        member this.height = Figure_Navigation_ButtonOptions_Height()

        ///<summary>verticalAlign : <code>string</code></summary>
        member this.verticalAlign = Figure_Navigation_ButtonOptions_VerticalAlign()

        ///<summary>width : <code>int</code></summary>
        member this.width = Figure_Navigation_ButtonOptions_Width()

        ///<summary>symbolFill : <code>string</code></summary>
        member this.symbolFill = Figure_Navigation_ButtonOptions_SymbolFill()

        ///<summary>symbolStroke : <code>string</code></summary>
        member this.symbolStroke = Figure_Navigation_ButtonOptions_SymbolStroke()

        ///<summary>symbolStrokeWidth : <code>int</code></summary>
        member this.symbolStrokeWidth = Figure_Navigation_ButtonOptions_SymbolStrokeWidth()

        member this.Set (o:{| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuStyle_Border : <code>string</code></summary>
    type Figure_Navigation_MenuStyle_Border() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuStyle_Background : <code>string</code></summary>
    type Figure_Navigation_MenuStyle_Background() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuStyle_Padding : <code>string</code></summary>
    type Figure_Navigation_MenuStyle_Padding() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuStyle : <code>{| border:string; background:string; padding:string |}</code></summary>
    type Figure_Navigation_MenuStyle() =


        ///<summary>border : <code>string</code></summary>
        member this.border = Figure_Navigation_MenuStyle_Border()

        ///<summary>background : <code>string</code></summary>
        member this.background = Figure_Navigation_MenuStyle_Background()

        ///<summary>padding : <code>string</code></summary>
        member this.padding = Figure_Navigation_MenuStyle_Padding()

        member this.Set (o:{| border:string; background:string; padding:string |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemStyle_Padding : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Padding() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemStyle_Color : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemStyle_Background : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Background() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemStyle_FontSize : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemStyle_Transition : <code>string</code></summary>
    type Figure_Navigation_MenuItemStyle_Transition() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemStyle : <code>{| padding:string; color:string; background:string; fontSize:string; transition:string |}</code></summary>
    type Figure_Navigation_MenuItemStyle() =


        ///<summary>padding : <code>string</code></summary>
        member this.padding = Figure_Navigation_MenuItemStyle_Padding()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Navigation_MenuItemStyle_Color()

        ///<summary>background : <code>string</code></summary>
        member this.background = Figure_Navigation_MenuItemStyle_Background()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_Navigation_MenuItemStyle_FontSize()

        ///<summary>transition : <code>string</code></summary>
        member this.transition = Figure_Navigation_MenuItemStyle_Transition()

        member this.Set (o:{| padding:string; color:string; background:string; fontSize:string; transition:string |}) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemHoverStyle_Background : <code>string</code></summary>
    type Figure_Navigation_MenuItemHoverStyle_Background() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemHoverStyle_Color : <code>string</code></summary>
    type Figure_Navigation_MenuItemHoverStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigation_MenuItemHoverStyle : <code>{| background:string; color:string |}</code></summary>
    type Figure_Navigation_MenuItemHoverStyle() =


        ///<summary>background : <code>string</code></summary>
        member this.background = Figure_Navigation_MenuItemHoverStyle_Background()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Navigation_MenuItemHoverStyle_Color()

        member this.Set (o:{| background:string; color:string |}) =
            send "##JSON##"

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

        member this.Set (o:{| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Type : <code>string</code></summary>
    type Figure_Exporting_Type() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Url : <code>string</code></summary>
    type Figure_Exporting_Url() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_PrintMaxWidth : <code>int</code></summary>
    type Figure_Exporting_PrintMaxWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Scale : <code>int</code></summary>
    type Figure_Exporting_Scale() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons_ContextButton_ClassName : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_ClassName() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons_ContextButton_MenuClassName : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_MenuClassName() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons_ContextButton_Symbol : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_Symbol() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons_ContextButton_TitleKey : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_TitleKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons_ContextButton_MenuItems_Item : <code>string</code></summary>
    type Figure_Exporting_Buttons_ContextButton_MenuItems_Item() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons_ContextButton_MenuItems : <code>string seq</code></summary>
    type Figure_Exporting_Buttons_ContextButton_MenuItems() =
        let item = Figure_Exporting_Buttons_ContextButton_MenuItems_Item()

        member this.Set (o:string seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Exporting_Buttons_ContextButton : <code>{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}</code></summary>
    type Figure_Exporting_Buttons_ContextButton() =


        ///<summary>className : <code>string</code></summary>
        member this.className = Figure_Exporting_Buttons_ContextButton_ClassName()

        ///<summary>menuClassName : <code>string</code></summary>
        member this.menuClassName = Figure_Exporting_Buttons_ContextButton_MenuClassName()

        ///<summary>symbol : <code>string</code></summary>
        member this.symbol = Figure_Exporting_Buttons_ContextButton_Symbol()

        ///<summary>titleKey : <code>string</code></summary>
        member this.titleKey = Figure_Exporting_Buttons_ContextButton_TitleKey()

        ///<summary>Figure_Exporting_Buttons_ContextButton_MenuItems : <code>string seq</code></summary>
        member this.menuItems = Figure_Exporting_Buttons_ContextButton_MenuItems()

        member this.Set (o:{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_Buttons : <code>{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}</code></summary>
    type Figure_Exporting_Buttons() =


        ///<summary>Figure_Exporting_Buttons_ContextButton : <code>{| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |}</code></summary>
        member this.contextButton = Figure_Exporting_Buttons_ContextButton()

        member this.Set (o:{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_ViewFullscreen : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_ViewFullscreen() =


        ///<summary>textKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_ViewFullscreen_TextKey()

        member this.Set (o:{| textKey:string |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_PrintChart : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_PrintChart() =


        ///<summary>textKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_PrintChart_TextKey()

        member this.Set (o:{| textKey:string |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_Separator_Separator : <code>bool</code></summary>
    type Figure_Exporting_MenuItemDefinitions_Separator_Separator() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_Separator : <code>{| separator:bool |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_Separator() =


        ///<summary>separator : <code>bool</code></summary>
        member this.separator = Figure_Exporting_MenuItemDefinitions_Separator_Separator()

        member this.Set (o:{| separator:bool |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPNG : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPNG() =


        ///<summary>textKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadPNG_TextKey()

        member this.Set (o:{| textKey:string |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadJPEG : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadJPEG() =


        ///<summary>textKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadJPEG_TextKey()

        member this.Set (o:{| textKey:string |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadPDF : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadPDF() =


        ///<summary>textKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadPDF_TextKey()

        member this.Set (o:{| textKey:string |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey : <code>string</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Exporting_MenuItemDefinitions_DownloadSVG : <code>{| textKey:string |}</code></summary>
    type Figure_Exporting_MenuItemDefinitions_DownloadSVG() =


        ///<summary>textKey : <code>string</code></summary>
        member this.textKey = Figure_Exporting_MenuItemDefinitions_DownloadSVG_TextKey()

        member this.Set (o:{| textKey:string |}) =
            send "##JSON##"

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

        member this.Set (o:{| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Exporting : <code>{| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}</code></summary>
    type Figure_Exporting() =


        ///<summary>_type : <code>string</code></summary>
        member this._type = Figure_Exporting_Type()

        ///<summary>url : <code>string</code></summary>
        member this.url = Figure_Exporting_Url()

        ///<summary>printMaxWidth : <code>int</code></summary>
        member this.printMaxWidth = Figure_Exporting_PrintMaxWidth()

        ///<summary>scale : <code>int</code></summary>
        member this.scale = Figure_Exporting_Scale()

        ///<summary>Figure_Exporting_Buttons : <code>{| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}</code></summary>
        member this.buttons = Figure_Exporting_Buttons()

        ///<summary>Figure_Exporting_MenuItemDefinitions : <code>{| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |}</code></summary>
        member this.menuItemDefinitions = Figure_Exporting_MenuItemDefinitions()

        member this.Set (o:{| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_GridLineColor : <code>string</code></summary>
    type Figure_XAxis_Item_GridLineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_GridLineWidth : <code>int</code></summary>
    type Figure_XAxis_Item_GridLineWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Labels_Style_Color : <code>string</code></summary>
    type Figure_XAxis_Item_Labels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
    type Figure_XAxis_Item_Labels_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_XAxis_Item_Labels_Style_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
    type Figure_XAxis_Item_Labels() =


        ///<summary>Figure_XAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_XAxis_Item_Labels_Style()

        member this.Set (o:{| style: {| color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_LineColor : <code>string</code></summary>
    type Figure_XAxis_Item_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_TickColor : <code>string</code></summary>
    type Figure_XAxis_Item_TickColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title_Style_Color : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title_Style_FontWeight : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title_Style_FontSize : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title_Style_FontFamily : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Style_FontFamily() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
    type Figure_XAxis_Item_Title_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_XAxis_Item_Title_Style_Color()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_XAxis_Item_Title_Style_FontWeight()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_XAxis_Item_Title_Style_FontSize()

        ///<summary>fontFamily : <code>string</code></summary>
        member this.fontFamily = Figure_XAxis_Item_Title_Style_FontFamily()

        member this.Set (o:{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title_Text : <code>string</code></summary>
    type Figure_XAxis_Item_Title_Text() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
    type Figure_XAxis_Item_Title() =


        ///<summary>Figure_XAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
        member this.style = Figure_XAxis_Item_Title_Style()

        ///<summary>text : <code>string</code></summary>
        member this.text = Figure_XAxis_Item_Title_Text()

        member this.Set (o:{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_Index : <code>int</code></summary>
    type Figure_XAxis_Item_Index() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item_IsX : <code>bool</code></summary>
    type Figure_XAxis_Item_IsX() =
        member this.Set (o:bool) =
            send "##JSON##"

    ///<summary>Figure_XAxis_Item : <code>{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |}</code></summary>
    type Figure_XAxis_Item() =


        ///<summary>gridLineColor : <code>string</code></summary>
        member this.gridLineColor = Figure_XAxis_Item_GridLineColor()

        ///<summary>gridLineWidth : <code>int</code></summary>
        member this.gridLineWidth = Figure_XAxis_Item_GridLineWidth()

        ///<summary>Figure_XAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
        member this.labels = Figure_XAxis_Item_Labels()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_XAxis_Item_LineColor()

        ///<summary>tickColor : <code>string</code></summary>
        member this.tickColor = Figure_XAxis_Item_TickColor()

        ///<summary>Figure_XAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
        member this.title = Figure_XAxis_Item_Title()

        ///<summary>index : <code>int</code></summary>
        member this.index = Figure_XAxis_Item_Index()

        ///<summary>isX : <code>bool</code></summary>
        member this.isX = Figure_XAxis_Item_IsX()

        member this.Set (o:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |}) =
            send "##JSON##"

    ///<summary>Figure_XAxis : <code>{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq</code></summary>
    type Figure_XAxis() =
        let item = Figure_XAxis_Item()

        member this.Set (o:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_YAxis_Item_GridLineColor : <code>string</code></summary>
    type Figure_YAxis_Item_GridLineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Labels_Style_Color : <code>string</code></summary>
    type Figure_YAxis_Item_Labels_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
    type Figure_YAxis_Item_Labels_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_YAxis_Item_Labels_Style_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
    type Figure_YAxis_Item_Labels() =


        ///<summary>Figure_YAxis_Item_Labels_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_YAxis_Item_Labels_Style()

        member this.Set (o:{| style: {| color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_LineColor : <code>string</code></summary>
    type Figure_YAxis_Item_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_MinorTickInterval : <code>float</code></summary>
    type Figure_YAxis_Item_MinorTickInterval() =
        member this.Set (o:float) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_TickColor : <code>string</code></summary>
    type Figure_YAxis_Item_TickColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_TickWidth : <code>int</code></summary>
    type Figure_YAxis_Item_TickWidth() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title_Style_Color : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title_Style_FontWeight : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title_Style_FontSize : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_FontSize() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title_Style_FontFamily : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Style_FontFamily() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
    type Figure_YAxis_Item_Title_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_YAxis_Item_Title_Style_Color()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_YAxis_Item_Title_Style_FontWeight()

        ///<summary>fontSize : <code>string</code></summary>
        member this.fontSize = Figure_YAxis_Item_Title_Style_FontSize()

        ///<summary>fontFamily : <code>string</code></summary>
        member this.fontFamily = Figure_YAxis_Item_Title_Style_FontFamily()

        member this.Set (o:{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title_Text : <code>string</code></summary>
    type Figure_YAxis_Item_Title_Text() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
    type Figure_YAxis_Item_Title() =


        ///<summary>Figure_YAxis_Item_Title_Style : <code>{| color:string; fontWeight:string; fontSize:string; fontFamily:string |}</code></summary>
        member this.style = Figure_YAxis_Item_Title_Style()

        ///<summary>text : <code>string</code></summary>
        member this.text = Figure_YAxis_Item_Title_Text()

        member this.Set (o:{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item_Index : <code>int</code></summary>
    type Figure_YAxis_Item_Index() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_YAxis_Item : <code>{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |}</code></summary>
    type Figure_YAxis_Item() =


        ///<summary>gridLineColor : <code>string</code></summary>
        member this.gridLineColor = Figure_YAxis_Item_GridLineColor()

        ///<summary>Figure_YAxis_Item_Labels : <code>{| style: {| color:string |} |}</code></summary>
        member this.labels = Figure_YAxis_Item_Labels()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_YAxis_Item_LineColor()

        ///<summary>minorTickInterval : <code>float</code></summary>
        member this.minorTickInterval = Figure_YAxis_Item_MinorTickInterval()

        ///<summary>tickColor : <code>string</code></summary>
        member this.tickColor = Figure_YAxis_Item_TickColor()

        ///<summary>tickWidth : <code>int</code></summary>
        member this.tickWidth = Figure_YAxis_Item_TickWidth()

        ///<summary>Figure_YAxis_Item_Title : <code>{| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}</code></summary>
        member this.title = Figure_YAxis_Item_Title()

        ///<summary>index : <code>int</code></summary>
        member this.index = Figure_YAxis_Item_Index()

        member this.Set (o:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |}) =
            send "##JSON##"

    ///<summary>Figure_YAxis : <code>{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq</code></summary>
    type Figure_YAxis() =
        let item = Figure_YAxis_Item()

        member this.Set (o:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Toolbar_ItemStyle_Color : <code>string</code></summary>
    type Figure_Toolbar_ItemStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Toolbar_ItemStyle : <code>{| color:string |}</code></summary>
    type Figure_Toolbar_ItemStyle() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Toolbar_ItemStyle_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_Toolbar : <code>{| itemStyle: {| color:string |} |}</code></summary>
    type Figure_Toolbar() =


        ///<summary>Figure_Toolbar_ItemStyle : <code>{| color:string |}</code></summary>
        member this.itemStyle = Figure_Toolbar_ItemStyle()

        member this.Set (o:{| itemStyle: {| color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_Stops_Item() =
        let item = Figure_RangeSelector_ButtonTheme_Fill_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill_Stops() =
        let item = Figure_RangeSelector_ButtonTheme_Fill_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_Fill() =


        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_RangeSelector_ButtonTheme_Fill_LinearGradient()

        ///<summary>Figure_RangeSelector_ButtonTheme_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_RangeSelector_ButtonTheme_Fill_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Stroke : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_Stroke() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Style_Color : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Style_FontWeight : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_Style_FontWeight() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_Style : <code>{| color:string; fontWeight:string |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_ButtonTheme_Style_Color()

        ///<summary>fontWeight : <code>string</code></summary>
        member this.fontWeight = Figure_RangeSelector_ButtonTheme_Style_FontWeight()

        member this.Set (o:{| color:string; fontWeight:string |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item() =
        let item = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops() =
        let item = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Fill() =


        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_LinearGradient()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_RangeSelector_ButtonTheme_States_Hover_Fill_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Stroke : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Stroke() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style : <code>{| color:string |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_ButtonTheme_States_Hover_Style_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Hover() =


        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_RangeSelector_ButtonTheme_States_Hover_Fill()

        ///<summary>stroke : <code>string</code></summary>
        member this.stroke = Figure_RangeSelector_ButtonTheme_States_Hover_Stroke()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_RangeSelector_ButtonTheme_States_Hover_Style()

        member this.Set (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item : <code>int</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item : <code>int seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item() =
        let item = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops : <code>int seq seq</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops() =
        let item = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Fill() =


        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_RangeSelector_ButtonTheme_States_Select_Fill_LinearGradient()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_RangeSelector_ButtonTheme_States_Select_Fill_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Stroke : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Stroke() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style_Color : <code>string</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Style_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style : <code>{| color:string |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select_Style() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_ButtonTheme_States_Select_Style_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States_Select : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States_Select() =


        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_RangeSelector_ButtonTheme_States_Select_Fill()

        ///<summary>stroke : <code>string</code></summary>
        member this.stroke = Figure_RangeSelector_ButtonTheme_States_Select_Stroke()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select_Style : <code>{| color:string |}</code></summary>
        member this.style = Figure_RangeSelector_ButtonTheme_States_Select_Style()

        member this.Set (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme_States : <code>{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme_States() =


        ///<summary>Figure_RangeSelector_ButtonTheme_States_Hover : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
        member this.hover = Figure_RangeSelector_ButtonTheme_States_Hover()

        ///<summary>Figure_RangeSelector_ButtonTheme_States_Select : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}</code></summary>
        member this.select = Figure_RangeSelector_ButtonTheme_States_Select()

        member this.Set (o:{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_ButtonTheme : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}</code></summary>
    type Figure_RangeSelector_ButtonTheme() =


        ///<summary>Figure_RangeSelector_ButtonTheme_Fill : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.fill = Figure_RangeSelector_ButtonTheme_Fill()

        ///<summary>stroke : <code>string</code></summary>
        member this.stroke = Figure_RangeSelector_ButtonTheme_Stroke()

        ///<summary>Figure_RangeSelector_ButtonTheme_Style : <code>{| color:string; fontWeight:string |}</code></summary>
        member this.style = Figure_RangeSelector_ButtonTheme_Style()

        ///<summary>Figure_RangeSelector_ButtonTheme_States : <code>{| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |}</code></summary>
        member this.states = Figure_RangeSelector_ButtonTheme_States()

        member this.Set (o:{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_InputStyle_BackgroundColor : <code>string</code></summary>
    type Figure_RangeSelector_InputStyle_BackgroundColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_InputStyle_Color : <code>string</code></summary>
    type Figure_RangeSelector_InputStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_InputStyle : <code>{| backgroundColor:string; color:string |}</code></summary>
    type Figure_RangeSelector_InputStyle() =


        ///<summary>backgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_RangeSelector_InputStyle_BackgroundColor()

        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_InputStyle_Color()

        member this.Set (o:{| backgroundColor:string; color:string |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_LabelStyle_Color : <code>string</code></summary>
    type Figure_RangeSelector_LabelStyle_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector_LabelStyle : <code>{| color:string |}</code></summary>
    type Figure_RangeSelector_LabelStyle() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_RangeSelector_LabelStyle_Color()

        member this.Set (o:{| color:string |}) =
            send "##JSON##"

    ///<summary>Figure_RangeSelector : <code>{| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}</code></summary>
    type Figure_RangeSelector() =


        ///<summary>Figure_RangeSelector_ButtonTheme : <code>{| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}</code></summary>
        member this.buttonTheme = Figure_RangeSelector_ButtonTheme()

        ///<summary>Figure_RangeSelector_InputStyle : <code>{| backgroundColor:string; color:string |}</code></summary>
        member this.inputStyle = Figure_RangeSelector_InputStyle()

        ///<summary>Figure_RangeSelector_LabelStyle : <code>{| color:string |}</code></summary>
        member this.labelStyle = Figure_RangeSelector_LabelStyle()

        member this.Set (o:{| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Navigator_Handles_BackgroundColor : <code>string</code></summary>
    type Figure_Navigator_Handles_BackgroundColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigator_Handles_BorderColor : <code>string</code></summary>
    type Figure_Navigator_Handles_BorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigator_Handles : <code>{| backgroundColor:string; borderColor:string |}</code></summary>
    type Figure_Navigator_Handles() =


        ///<summary>backgroundColor : <code>string</code></summary>
        member this.backgroundColor = Figure_Navigator_Handles_BackgroundColor()

        ///<summary>borderColor : <code>string</code></summary>
        member this.borderColor = Figure_Navigator_Handles_BorderColor()

        member this.Set (o:{| backgroundColor:string; borderColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_Navigator_OutlineColor : <code>string</code></summary>
    type Figure_Navigator_OutlineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigator_MaskFill : <code>string</code></summary>
    type Figure_Navigator_MaskFill() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigator_Series_Color : <code>string</code></summary>
    type Figure_Navigator_Series_Color() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigator_Series_LineColor : <code>string</code></summary>
    type Figure_Navigator_Series_LineColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Navigator_Series : <code>{| color:string; lineColor:string |}</code></summary>
    type Figure_Navigator_Series() =


        ///<summary>color : <code>string</code></summary>
        member this.color = Figure_Navigator_Series_Color()

        ///<summary>lineColor : <code>string</code></summary>
        member this.lineColor = Figure_Navigator_Series_LineColor()

        member this.Set (o:{| color:string; lineColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_Navigator : <code>{| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}</code></summary>
    type Figure_Navigator() =


        ///<summary>Figure_Navigator_Handles : <code>{| backgroundColor:string; borderColor:string |}</code></summary>
        member this.handles = Figure_Navigator_Handles()

        ///<summary>outlineColor : <code>string</code></summary>
        member this.outlineColor = Figure_Navigator_OutlineColor()

        ///<summary>maskFill : <code>string</code></summary>
        member this.maskFill = Figure_Navigator_MaskFill()

        ///<summary>Figure_Navigator_Series : <code>{| color:string; lineColor:string |}</code></summary>
        member this.series = Figure_Navigator_Series()

        member this.Set (o:{| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_Scrollbar_BarBackgroundColor_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_Stops_Item() =
        let item = Figure_Scrollbar_BarBackgroundColor_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Scrollbar_BarBackgroundColor_Stops() =
        let item = Figure_Scrollbar_BarBackgroundColor_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_BarBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Scrollbar_BarBackgroundColor() =


        ///<summary>Figure_Scrollbar_BarBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Scrollbar_BarBackgroundColor_LinearGradient()

        ///<summary>Figure_Scrollbar_BarBackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Scrollbar_BarBackgroundColor_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_BarBorderColor : <code>string</code></summary>
    type Figure_Scrollbar_BarBorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonArrowColor : <code>string</code></summary>
    type Figure_Scrollbar_ButtonArrowColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_Stops_Item() =
        let item = Figure_Scrollbar_ButtonBackgroundColor_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor_Stops() =
        let item = Figure_Scrollbar_ButtonBackgroundColor_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_ButtonBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Scrollbar_ButtonBackgroundColor() =


        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Scrollbar_ButtonBackgroundColor_LinearGradient()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Scrollbar_ButtonBackgroundColor_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_ButtonBorderColor : <code>string</code></summary>
    type Figure_Scrollbar_ButtonBorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_RifleColor : <code>string</code></summary>
    type Figure_Scrollbar_RifleColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2 : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_LinearGradient() =


        ///<summary>x1 : <code>int</code></summary>
        member this.x1 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X1()

        ///<summary>y1 : <code>int</code></summary>
        member this.y1 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y1()

        ///<summary>x2 : <code>int</code></summary>
        member this.x2 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_X2()

        ///<summary>y2 : <code>int</code></summary>
        member this.y2 = Figure_Scrollbar_TrackBackgroundColor_LinearGradient_Y2()

        member this.Set (o:{| x1:int; y1:int; x2:int; y2:int |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item : <code>int</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops_Item : <code>int seq</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_Stops_Item() =
        let item = Figure_Scrollbar_TrackBackgroundColor_Stops_Item_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops : <code>int seq seq</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor_Stops() =
        let item = Figure_Scrollbar_TrackBackgroundColor_Stops_Item()

        member this.Set (o:int seq seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Scrollbar_TrackBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
    type Figure_Scrollbar_TrackBackgroundColor() =


        ///<summary>Figure_Scrollbar_TrackBackgroundColor_LinearGradient : <code>{| x1:int; y1:int; x2:int; y2:int |}</code></summary>
        member this.linearGradient = Figure_Scrollbar_TrackBackgroundColor_LinearGradient()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor_Stops : <code>int seq seq</code></summary>
        member this.stops = Figure_Scrollbar_TrackBackgroundColor_Stops()

        member this.Set (o:{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar_TrackBorderColor : <code>string</code></summary>
    type Figure_Scrollbar_TrackBorderColor() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Scrollbar : <code>{| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}</code></summary>
    type Figure_Scrollbar() =


        ///<summary>Figure_Scrollbar_BarBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.barBackgroundColor = Figure_Scrollbar_BarBackgroundColor()

        ///<summary>barBorderColor : <code>string</code></summary>
        member this.barBorderColor = Figure_Scrollbar_BarBorderColor()

        ///<summary>buttonArrowColor : <code>string</code></summary>
        member this.buttonArrowColor = Figure_Scrollbar_ButtonArrowColor()

        ///<summary>Figure_Scrollbar_ButtonBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.buttonBackgroundColor = Figure_Scrollbar_ButtonBackgroundColor()

        ///<summary>buttonBorderColor : <code>string</code></summary>
        member this.buttonBorderColor = Figure_Scrollbar_ButtonBorderColor()

        ///<summary>rifleColor : <code>string</code></summary>
        member this.rifleColor = Figure_Scrollbar_RifleColor()

        ///<summary>Figure_Scrollbar_TrackBackgroundColor : <code>{| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}</code></summary>
        member this.trackBackgroundColor = Figure_Scrollbar_TrackBackgroundColor()

        ///<summary>trackBorderColor : <code>string</code></summary>
        member this.trackBorderColor = Figure_Scrollbar_TrackBorderColor()

        member this.Set (o:{| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}) =
            send "##JSON##"

    ///<summary>Figure_Series_Item_Name : <code>string</code></summary>
    type Figure_Series_Item_Name() =
        member this.Set (o:string) =
            send "##JSON##"

    ///<summary>Figure_Series_Item_Data_Item : <code>int</code></summary>
    type Figure_Series_Item_Data_Item() =
        member this.Set (o:int) =
            send "##JSON##"

    ///<summary>Figure_Series_Item_Data : <code>int seq</code></summary>
    type Figure_Series_Item_Data() =
        let item = Figure_Series_Item_Data_Item()

        member this.Set (o:int seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure_Series_Item : <code>{| name:string; data:int seq |}</code></summary>
    type Figure_Series_Item() =


        ///<summary>name : <code>string</code></summary>
        member this.name = Figure_Series_Item_Name()

        ///<summary>Figure_Series_Item_Data : <code>int seq</code></summary>
        member this.data = Figure_Series_Item_Data()

        member this.Set (o:{| name:string; data:int seq |}) =
            send "##JSON##"

    ///<summary>Figure_Series : <code>{| name:string; data:int seq |} seq</code></summary>
    type Figure_Series() =
        let item = Figure_Series_Item()

        member this.Set (o:{| name:string; data:int seq |} seq) =
            send "##JSON##"

        member this.Item
            with get(_) =
                item

    ///<summary>Figure : <code>{| colors:string seq; symbols:string seq; lang: {| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}; _global: {| dummy:string |}; time: {| timezoneOffset:int; useUTC:bool |}; chart: {| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}; title: {| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}; subtitle: {| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}; caption: {| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}; plotOptions: {| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}; labels: {| style: {| position:string; color:string |} |}; legend: {| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}; loading: {| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}; tooltip: {| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}; credits: {| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}; navigation: {| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}; exporting: {| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}; xAxis:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq; yAxis:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq; toolbar: {| itemStyle: {| color:string |} |}; rangeSelector: {| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}; navigator: {| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}; scrollbar: {| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}; series:{| name:string; data:int seq |} seq |}</code></summary>
    type Figure() =


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
        member this.series = Figure_Series()

        member this.Set (o:{| colors:string seq; symbols:string seq; lang: {| loading:string; months:string seq; shortMonths:string seq; weekdays:string seq; decimalPoint:string; numericSymbols:string seq; resetZoom:string; resetZoomTitle:string; thousandsSep:string; viewFullscreen:string; exitFullscreen:string; printChart:string; downloadPNG:string; downloadJPEG:string; downloadPDF:string; downloadSVG:string; contextButtonTitle:string |}; _global: {| dummy:string |}; time: {| timezoneOffset:int; useUTC:bool |}; chart: {| styledMode:bool; borderRadius:int; colorCount:int; defaultSeriesType:string; ignoreHiddenSeries:bool; spacing:int seq; resetZoomButton: {| theme: {| zIndex:int |}; position: {| align:string; x:int; y:int |} |}; width:float; height:float; borderColor:string; backgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int; id:string |}; stops:int seq seq |}; plotBorderColor:string; borderWidth:int; className:string; plotBackgroundColor:string; plotBorderWidth:int |}; title: {| style: {| color:string; fontSize:string; font:string; fill:string; width:string |}; text:string; align:string; margin:int; widthAdjust:int |}; subtitle: {| style: {| color:string; font:string; fill:string; width:string |}; text:string; align:string; widthAdjust:int |}; caption: {| style: {| color:string; fill:string; width:string |}; margin:int; text:string; align:string; verticalAlign:string |}; plotOptions: {| line: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; color:string |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; area: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; spline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string |}; areaspline: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |} |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; threshold:int |}; column: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; bar: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; x:int |}; cropThreshold:int; opacity:int; pointRange:float; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo:bool; brightness:int |}; select: {| animation: {| duration:int |}; color:string; borderColor:string |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; borderRadius:int; centerInCategory:bool; groupPadding:int; pointPadding:int; minPointLength:int; startFromThreshold:bool; threshold:int; borderColor:string |}; scatter: {| lineWidth:int; allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker: {| enabledThreshold:int; lineColor:string; lineWidth:int; radius:int; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; enabled:bool; radiusPlus:int; lineWidthPlus:int |}; select: {| fillColor:string; lineColor:string; lineWidth:int |} |}; enabled:bool |}; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |} |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; jitter: {| x:int; y:int |} |}; pie: {| allowPointSelect:bool; crisp:bool; showCheckbox:bool; animation: {| duration:int |}; events: {| dummy:string |}; marker:float; point: {| events: {| dummy:string |} |}; dataLabels: {| align:string; padding:int; style: {| fontSize:string; fontWeight:string; color:string; textOutline:string |}; verticalAlign:string; x:int; y:int; allowOverlap:bool; connectorPadding:int; connectorShape:string; crookDistance:string; distance:int; enabled:bool; softConnector:bool |}; cropThreshold:int; opacity:int; pointRange:int; softThreshold:bool; states: {| normal: {| animation:bool |}; hover: {| animation: {| duration:int |}; lineWidthPlus:int; marker: {| dummy:string |}; halo: {| size:int; opacity:int |}; brightness:int |}; select: {| animation: {| duration:int |} |}; inactive: {| animation: {| duration:int |}; opacity:int |} |}; stickyTracking:bool; turboThreshold:int; findNearestPointBy:string; center:float seq; clip:bool; colorByPoint:bool; ignoreHiddenPoint:bool; inactiveOtherPoints:bool; legendType:string; size:float; showInLegend:bool; slicedOffset:int; borderColor:string; borderWidth:int |}; candlestick: {| lineColor:string |} |}; labels: {| style: {| position:string; color:string |} |}; legend: {| enabled:bool; align:string; alignColumns:bool; layout:string; borderColor:string; borderRadius:int; navigation: {| activeColor:string; inactiveColor:string |}; itemStyle: {| color:string; cursor:string; fontSize:string; fontWeight:string; textOverflow:string; font:string |}; itemHoverStyle: {| color:string |}; itemHiddenStyle: {| color:string |}; shadow:bool; itemCheckboxStyle: {| position:string; width:string; height:string |}; squareSymbol:bool; symbolPadding:int; verticalAlign:string; x:int; y:int; title: {| style: {| fontWeight:string; color:string |} |}; backgroundColor:string |}; loading: {| labelStyle: {| fontWeight:string; position:string; top:string |}; style: {| position:string; backgroundColor:string; opacity:int; textAlign:string |} |}; tooltip: {| enabled:bool; animation:bool; borderRadius:int; dateTimeLabelFormats: {| millisecond:string; second:string; minute:string; hour:string; day:string; week:string; month:string; year:string |}; footerFormat:string; padding:int; snap:int; headerFormat:string; pointFormat:string; backgroundColor:string; borderWidth:int; shadow:bool; style: {| color:string; cursor:string; fontSize:string; whiteSpace:string |} |}; credits: {| enabled:bool; href:string; position: {| align:string; x:int; verticalAlign:string; y:int |}; style: {| cursor:string; color:string; fontSize:string; fill:string |}; text:string |}; navigation: {| buttonOptions: {| theme: {| padding:int; fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string |}; symbolSize:int; symbolX:int; symbolY:int; align:string; buttonSpacing:int; height:int; verticalAlign:string; width:int; symbolFill:string; symbolStroke:string; symbolStrokeWidth:int |}; menuStyle: {| border:string; background:string; padding:string |}; menuItemStyle: {| padding:string; color:string; background:string; fontSize:string; transition:string |}; menuItemHoverStyle: {| background:string; color:string |} |}; exporting: {| _type:string; url:string; printMaxWidth:int; scale:int; buttons: {| contextButton: {| className:string; menuClassName:string; symbol:string; titleKey:string; menuItems:string seq |} |}; menuItemDefinitions: {| viewFullscreen: {| textKey:string |}; printChart: {| textKey:string |}; separator: {| separator:bool |}; downloadPNG: {| textKey:string |}; downloadJPEG: {| textKey:string |}; downloadPDF: {| textKey:string |}; downloadSVG: {| textKey:string |} |} |}; xAxis:{| gridLineColor:string; gridLineWidth:int; labels: {| style: {| color:string |} |}; lineColor:string; tickColor:string; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int; isX:bool |} seq; yAxis:{| gridLineColor:string; labels: {| style: {| color:string |} |}; lineColor:string; minorTickInterval:float; tickColor:string; tickWidth:int; title: {| style: {| color:string; fontWeight:string; fontSize:string; fontFamily:string |}; text:string |}; index:int |} seq; toolbar: {| itemStyle: {| color:string |} |}; rangeSelector: {| buttonTheme: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string; fontWeight:string |}; states: {| hover: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |}; select: {| fill: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; stroke:string; style: {| color:string |} |} |} |}; inputStyle: {| backgroundColor:string; color:string |}; labelStyle: {| color:string |} |}; navigator: {| handles: {| backgroundColor:string; borderColor:string |}; outlineColor:string; maskFill:string; series: {| color:string; lineColor:string |} |}; scrollbar: {| barBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; barBorderColor:string; buttonArrowColor:string; buttonBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; buttonBorderColor:string; rifleColor:string; trackBackgroundColor: {| linearGradient: {| x1:int; y1:int; x2:int; y2:int |}; stops:int seq seq |}; trackBorderColor:string |}; series:{| name:string; data:int seq |} seq |}) =
            send "##JSON##"
