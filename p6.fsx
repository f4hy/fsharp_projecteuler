// Sum square difference
// Problem 6
// The sum of the squares of the first ten natural numbers is,

// 12 + 22 + ... + 102 = 385
// The square of the sum of the first ten natural numbers is,

// (1 + 2 + ... + 10)2 = 552 = 3025
// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

////////////////

// This should be easy in a functional language

let nums = [1..100]

let sumofsquares x = List.fold (fun acc elm -> acc + elm*elm) 0 x
let squareofsums x = pown (List.sum x) 2

printfn "%d " (sumofsquares nums)
printfn "%d " (squareofsums nums)

let diffsos x = (squareofsums x) - (sumofsquares x)

let answer = diffsos nums

printfn "%d " answer


