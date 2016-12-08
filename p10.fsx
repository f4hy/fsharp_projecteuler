(*
Summation of primes
Problem 10
The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.

Find the sum of all the primes below two million.
*)

//Well I already wrote the important function for this

#load "factoring.fs"
open Factoring

// A simple sum wont work, since two million is already close to int32.MaxValue
// let answer = 2000000 |> PrimeSeive // |> Seq.sum

// Summing using 64bit integer is enough
let answer = 2000000 |> PrimeSeive |> Seq.fold (fun acc i -> acc+(int64 i)) 0L

printfn "Answer: %d" answer
