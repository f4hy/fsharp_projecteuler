// Euler problem #4
// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
//
// Find the largest palindrome made from the product of two 3-digit numbers

// First thought is to just find the range between 111*111 and
// 999*999, and count down til we find a planedrome
// but I am not sure all numbers in the range are divisible by just 3 digit numbers

// Trying all of them will require checking 1000*1000 which is probably possible

// To check palendroms we need to reverse strings
let Reverse (s:string) =
    new string(Array.rev (s.ToCharArray()))

// Use string reversal to check palindromes
let IsPalindrome x =
    let s = string x
    let n = s.Length
    s = Reverse s

// go through all 3 digit numbers and find all the palindromes
let all3x3pals = [ for i in 100..999 do for j in i..999 do if IsPalindrome (i*j) then yield i*j ]

printfn "Found %d palindromes" all3x3pals.Length

printfn "Answer: %d " (List.max all3x3pals)
