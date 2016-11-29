// First attempt
let under1000 = [ 1..999 ]

let div_by_3_or_5 x =
    if x % 5 = 0 then true
    elif x % 3 = 0 then true
    else false

let l = List.filter div_by_3_or_5 under1000


let plist = List.iter (fun x -> printf "%d " x)

plist l

let answer = List.sum l

printfn "\nAnswer: %d" answer

// Now lets try to improve that

// Simpler div by fuction
let div_by_3_or_5p x = (x % 5 = 0) || (x % 3 = 0)
// make the filter a function
let filter3or5 = List.filter div_by_3_or_5p
// Pipe the functions for the answer
under1000 |> filter3or5 |> List.sum |> printfn "\nAnswer: %d"


