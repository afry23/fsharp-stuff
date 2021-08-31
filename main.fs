open System

let f n arr =
  seq {
    for item in arr do
      for i = 1 to n do
        yield item
  }
    
[<EntryPoint>]
let main argv =
  let input = Console.ReadLine() |> int
  let number = 
    if input >= 1 && input <= 100 then
      input
    else 
      0
  
  let mutable read = true
  let mutable values = []
  let items =
    [
      while read do
        let (success, value) = Console.ReadLine() |> Int32.TryParse
        if success then
          yield value
        else
          yield -1
        read <- success
    ]
    |> List.filter (fun x -> x >= 0 && x <= 10)
  printfn "%A" items
  
  let output = f number items
  for i in output do
    printfn "%d" i
  0