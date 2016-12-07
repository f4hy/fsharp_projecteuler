#load "factoring.fs"
#load "printing.fs"
open Factoring
open Printing
// I solved this using the sieve of Eratosthenes.
//
// It probably can be solved by direct search by dividing the number
// repeatedly by all values below sqrt(n) and finding whats left. But
// I wanted to try the Sieve as I was curious how to do it in a
// functional language. It also required me getting a data type from
// the library which was good to learn how to do

// I wrote the PrimeSieve in the factoring module

// let target = 13195L                  //Example number for the problem
let target = 600851475143L              //The number for the challenge


let isqrt x = x |> float |> sqrt |> int

let allprimes = target |> isqrt |> PrimeSeive

let Isfactor i = target % (int64 i) = 0L

let primefactors = allprimes |> Seq.filter Isfactor

printfn "Prime Factors: %A" primefactors

let answer = Seq.max primefactors

printfn "Answer: %d " answer
