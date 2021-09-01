open System

let f number =
  for i = 1 to number do
    printfn "%d" i
  
[<EntryPoint>]
let main argv =
  let a = Console.ReadLine() |> int
  f a
  0