namespace FPlot

module Common =   
    type ElementType =
        | ElementString
        | ElementFloat
        | ElementInt
        | ElementBool

    // type FigureElement = {
    //     Json:string
    //     ElementType:ElementType
    // } with
    //     static member fromJson s t =
    //         { Json = s; ElementType = t }
    type IFigureElement =
        abstract member GetJson : unit -> string
        abstract member GetElementType : unit -> ElementType