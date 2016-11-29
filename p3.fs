open System.Collections
// I solved this using the sieve of Eratosthenes.
//
// It probably can be solved by direct search by dividing the number
// repeatedly by all values below sqrt(n) and finding whats left. But
// I wanted to try the Sieve as I was curious how to do it in a
// functional language. It also required me getting a data type from
// the library which was good to learn how to do


// let target = 13195L                  //Example number for the problem
let target = 600851475143L              //The number for the challenge

let rec plist lst =
    match lst with
        | head :: tail -> printf "%d " head; plist tail
        | [] -> printfn "\n"

let int_sqrt x = x |> float |> sqrt |> int

let sqrtt = int_sqrt target

let PrimeSeive max =
    // Mark all numbers up to the max as candidates
    let mutable ba = new BitArray(max+1 , true);
    // For all numbers if its a prime mark all its multipules off the list
    for i in 2..max do
        if ba.Get(i) then
            // start at twice the prime and iterate by it to makr multipules 
            for m in i*2..i..max do
                ba.Set(m, false)
                
    [ for i in 2..max do if ba.Get(i) then yield i ]

let allprimes = target |> int_sqrt |> PrimeSeive 

// plist allprimes

let Isfactor i = target % (int64 i) = 0L

let primefactors = allprimes |> List.filter Isfactor

printfn "Prime Factors:"
plist primefactors

let answer = List.max primefactors

printfn "Answer: %d \n" answer

