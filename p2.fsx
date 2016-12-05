
let limit = 4000000

let rec Fib x y =
    if y > limit then
        []
    else
        let current = y
        let next = x+y
        current :: Fib current next

let fibs = 1 ::(Fib 1 1)

// let x = Fib 1 2
// printfn "%d " x

let rec plist lst =
    match lst with
        | head :: tail -> printf "%d " head; plist tail
        | [] -> printfn "\n"

plist fibs

let even x = (x % 2 = 0)

fibs |> List.filter even |> plist

fibs |> List.filter even |> List.sum |> printf "%d "
