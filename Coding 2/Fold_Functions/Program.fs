let rec fold f a = function
| []    -> a
| x::xs -> fold f (f a x) xs

let rec foldBack f xs a =
    match xs with
    | []    -> a
    | y::ys -> f y (foldBack f ys a)

let flatten1 xs = fold (@) [] xs
    
let flatten2 xs = foldBack (@) xs []

(* Both flatten use @ which is O(n).
Fold uses tail recursion so it is O(n)
Foldback does not, so it is O(n^2)*)