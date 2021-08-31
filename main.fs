open System

let f x arr =
  let filter = 
    if x >= -100 && x <= 100 then
      Some x
    else
      None
  
  let foo =
    if List.length arr >= 100 then
      arr.[1..100]
    else
      arr
    
  let list = 
    match filter with
    | Some value -> List.filter (fun x -> x >= -100 && x <= 100 && x < value) foo
    | None -> List.Empty
  list
    
[<EntryPoint>]
let main argv =
  let s = Console.ReadLine() |> int
  let list =
    [
      let mutable read = true
      while read do
      let (success, value) = Console.ReadLine() |> Int32.TryParse
      if success then
        yield value
      else
        yield -1000
      read <- success
    ]
  
  let output = f s list
  for i in output do
    printfn "%d" i
  0