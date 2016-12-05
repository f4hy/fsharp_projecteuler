module Factoring

open System.Collections

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

