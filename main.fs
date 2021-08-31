open System

let tryParesInt (number:string) =
  let (success, value) = Int32.TryParse number
  if success then Some value else None

let f n arr =
  for item in arr do
    for i = 1 to n do
      printfn "%d" item
    
[<EntryPoint>]
let main argv =
  let input = Console.ReadLine() |> int
  let mutable read = true
  while read do
    let result = tryParesInt (Console.ReadLine())
    read <- match result with
            | Some _ -> true
            | _ -> false
  let times = 
    if input >= 0 && input <= 10 then input 
    else 0
  0