module Printing

let rec plist lst =
    match lst with
        | head :: tail -> printf "%d " head; plist tail
        | [] -> printfn "\n"

let printn n lst =
    List.toSeq lst |> Seq.truncate n |> Seq.iter (printf "%A ") ; printfn ""

let print10 lst = printn 10 lst

let lprintn label n lst =
    printf "%s: " label; printn n lst

let lprint10 label lst =
    lprintn label 10 lst

let lpd label d = printf "%s: %d" label d 
