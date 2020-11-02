open System

let rec lastElement = function
|[] -> None
|[x] -> Some(x)
|x::xs -> lastElement xs

let last xs =
    let last = lastElement xs
    if last = None then printf "Invalid Input\n" 
    else printf "The last element of %A is %A\n" xs last.Value

last []
last ["cat"]
last [1;2;3;4;5]
    