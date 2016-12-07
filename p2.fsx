#load "printing.fs"
open Printing


let limit = 4000000

let fibsupto lim =
    let rec Fib x y =
        if y > lim then
            []
        else
            let current = y
            let next = x+y
            current :: Fib current next
    1 :: (Fib 1 1)

let fibs = fibsupto limit

plist fibs

let even x = (x % 2 = 0)

fibs |> List.filter even |> plist

fibs |> List.filter even |> List.sum |> printfn "Answer: %d "
