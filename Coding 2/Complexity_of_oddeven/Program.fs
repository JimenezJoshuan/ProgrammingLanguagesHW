let rec oddeven = function
| [] -> []
| x::xs -> if x % 2 = 0 
           then oddeven xs @ [x]
           else x :: oddeven xs

(*The time complexity of this function should be O(n^2) due to
@ being O(n) and the recursive function not using tail recursion.
This means that with the @ being O(n) and the function running
O(n) as well, it will be O(n) * O(n) = O(n^2).
*)

