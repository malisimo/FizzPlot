namespace FPlot

module StringUtils =
    open System
    
    let strRep (strFrom:string) (strTo:string) (str:string) =
        str.Replace(strFrom, strTo)

    let strJoin (strs:string seq) =
        String.Join(",", strs)