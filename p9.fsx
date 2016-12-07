(*
Special Pythagorean triplet
Problem 9
A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,

a^2 + b^2 = c^2
For example, 32 + 42 = 9 + 16 = 25 = 52.

There exists exactly one Pythagorean triplet for which a + b + c = 1000.
Find the product abc.

*)

let istriplet a b c = (a*a + b*b = c*c) && a+b+c = 1000

let triplet = seq { for a in 1..999 do for b in a..999 do if istriplet a b (1000-a-b) then yield a, b, (1000-a-b) } |> Seq.exactlyOne

printfn "%A" triplet

let prodtriplet (a, b, c) = a*b*c

let answer = prodtriplet triplet

printfn "Answer: %d" answer
