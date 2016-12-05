// Smallest multiple
// Problem 5
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

////////////////////////////////

// I believe this is just a LCM problem. find the LCM of all the numbers from 1 to 20

// LCM is simply taking the prime factors from both but not twice.

open Factoring

open Printing

let small_primes = PrimeSeive 200


exception MyError of string


let rec factors (b:int) (primes:int list) (lst:int list) =
    // base case is we found all or no more primes 
    if primes.IsEmpty then
        raise (MyError("Ran out of primes before done"))
    elif b = 1 then
        lst
    elif b % (primes.Head) = 0 then
        factors (b/primes.Head) (primes) ((primes.Head)::lst)
    else
        factors b (primes.Tail) lst


let prime_factors a = factors a small_primes []
    


let common_factors (x:int) (y:int) =
    let rec cfactors (A:int list) (B:int list) (acc:int list) = 
            match A, B with
            | [], [] -> acc
            | [], _ -> (B @ acc)
            | _, [] -> (A @ acc)
            | ah :: at, bh :: bt when ah > bh -> cfactors at B (ah::acc)
            | ah :: at, bh :: bt when ah < bh -> cfactors A bt (bh::acc)
            | ah :: at, bh :: bt when ah = bh -> cfactors at bt (ah::acc)
            | _ -> acc
    cfactors (prime_factors x) (prime_factors y) []

let LCM x y = List.fold (fun acc elm -> acc * elm) 1 (common_factors x y )

let answer = List.fold LCM 1 [2..20]

printfn "Answer: %d" answer
