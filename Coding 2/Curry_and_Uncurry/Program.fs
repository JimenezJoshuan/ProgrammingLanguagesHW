open System

let uncurry f (a,b) = f a b
printfn "Uncurried : %d" (uncurry (+) (2,3))

let add (x,y) = x + y

let plus f x y = f (x,y)

let curry = plus add
printfn "Curried: %d" (curry 2 5)