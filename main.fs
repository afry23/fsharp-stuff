open System

let tryParesInt (number:string) =
  let (success, value) = Int32.TryParse number
  if success then 
    if value >= 0 && value <= 10 then
      Some value 
    else None
  else
    None

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
  let arr = List.filter (fun x -> x >= 0 && x <= 10) items 
  printfn "%A" arr
  
  let output = f number arr
  for i in output do
    printfn "%d" i
  0