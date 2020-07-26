namespace FizzPlot

module internal StringUtils =
    open System
    
    /// Replace all occurrences of a string with another
    let strRep (strFrom:string) (strTo:string) (str:string) =
        str.Replace(strFrom, strTo)

    /// Join a sequence of strings into a single string, with each separated by a comma
    let strJoin (strs:string seq) =
        String.Join(",", strs)