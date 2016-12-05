module Printing

let rec plist lst =
    match lst with
        | head :: tail -> printf "%d " head; plist tail
        | [] -> printfn "\n"

let labellist s lst = printf "%s"; plist lst

let print = printfn "%d"
