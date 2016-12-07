(*
10001st prime
Problem 7

By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.

What is the 10 001st prime number?

*)

// I already wrote a sieve of Eratosthenes for problem 3 (unnecessarily)
// Just use that to solve this one

#load "factoring.fs"
#load "printing.fs"

open Factoring
open Printing

// The seive requires a starting large value, so lets just increase it until we have enough

let smallprimes = PrimeSeive 200 |> Seq.toList

// Check the example
printfn "6th prime is %d" (smallprimes.Item(5))


// Solveable if we just pick a large enough starting point
// let primes = PrimeSeive 1000000
// printfn "%d" primes.Length
// printfn "%d" (primes.Item(5))
// printfn "%d" (primes.Item(10000))

//But lets solve this dynmatically, no "magic numbers"

let getNthPrime n =
    //Increase until we have enough
    let rec genNprimes (i:int) : (int list) =
        let ps = PrimeSeive i |> Seq.toList
        printfn "Finding primes up to %d" i
        if ps.Length > n then
            ps
        else
            genNprimes (i<<<2)
    let primes = genNprimes (n<<<2)
    primes.Item(n)

let answer = getNthPrime 10000

printfn "Answer %d" answer
