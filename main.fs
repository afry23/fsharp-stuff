open System

let f n arr =
  for item in arr do
    for i = 1 to n do
      printfn "%d" item
    
[<EntryPoint>]
let main argv =
  let input = Console.ReadLine() |> int
  let mutable read = ""
  read <- Console.ReadLine()
  while read <> "" do
    read <- Console.ReadLine()
  let times = 
    if input >= 0 && input <= 10 then input 
    else 0
  0