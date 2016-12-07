// Smallest multiple
// Problem 5
// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.

// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?

////////////////////////////////

// I believe this is just a LCM problem. find the LCM of all the numbers from 1 to 20

// LCM is simply taking the prime factors from both but not twice.
#load "factoring.fs"
open Factoring

let smallprimes = PrimeSeive 200 |> Seq.toList

exception MyException of string


let rec factors (b:int) (primes:int list) (lst:int list) =
    // base case is we found all or no more primes
    if primes.IsEmpty then
        raise (MyException("Ran out of primes before done"))
    elif b = 1 then
        lst
    elif b % (primes.Head) = 0 then
        factors (b/primes.Head) (primes) ((primes.Head)::lst)
    else
        factors b (primes.Tail) lst


let primefactors a = factors a smallprimes []

let commonfactors (x:int) (y:int) =
    let rec cfactors (A:int list) (B:int list) (acc:int list) =
            match A, B with
            | [], [] -> acc
            | [], _ -> (B @ acc)
            | _, [] -> (A @ acc)
            | ah :: at, bh :: bt when ah > bh -> cfactors at B (ah::acc)
            | ah :: at, bh :: bt when ah < bh -> cfactors A bt (bh::acc)
            | ah :: at, bh :: bt when ah = bh -> cfactors at bt (ah::acc)
            | _ -> acc
    cfactors (primefactors x) (primefactors y) []

let LCM x y = List.fold ( * ) 1 (commonfactors x y )

let answer = List.fold LCM 1 [2..20]

printfn "Answer method 1: %d" answer

// LCM can be computed using GCD if we don't want to use factoring.

let rec gcd x y =
    match y with
        | 0 -> x
        | _ -> (gcd y (x % y))

let LCMnew a b =
    match b with
        | 0 -> 0
        | _ -> (a*b)/ (gcd a b )

let answer2 = List.fold LCMnew 1 [2..20]

printfn "Answer method 2: %d" answer
