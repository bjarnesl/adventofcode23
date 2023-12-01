open System.Text.RegularExpressions
let lines: string list = System.IO.File.ReadLines(path="resources\\01-e.csv") |> Seq.toList

let lastRx = Regex(@"(\d)(?!.*\d)")
let firstRx = Regex(@"^[^\d]*(\d)")
let totalSum = 0


let getValue (line: string) a:int =
     let firstVal =  firstRx.Match(line).Groups[1] .Value|> int
     let secondval = lastRx.Match(line).Groups[1] .Value|> int
     let localSum = (firstVal*10)+secondval
     let  sumtext= localSum|>string
     printfn "%A" sumtext
     a+localSum
   
let sum = List.fold (fun acc x -> getValue x acc) totalSum lines

printf "%A" sum
    //  let firstVal = digits.Groups[1] .Value|> int
    // let secondval = digits.Groups[2] .Value|> int

    // printfn  "%s" "Hello"






