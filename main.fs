open System

let f arr =
  let foo =
    arr
    |> List.filter (fun x -> x)
  foo
  
[<EntryPoint>]
let main argv =
  let list =
    [
      let mutable read = true
      while read do
        let (success, value) = Console.ReadLine() |> Int32.TryParse
        if success then
          yield Some value
        else
          yield None
        read <- success
    ]
    |> List.choose id
  printfn "%A" list
  
  let output = f list
  for i in output do
    printfn "%d" i
  0