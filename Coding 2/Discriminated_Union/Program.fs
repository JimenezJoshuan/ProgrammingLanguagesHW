open System

type Coordinates<'a> =
    | Tuple of first:'a * second:'a
    | Threeple of first:'a * second:'a * third:'a
    | Fourple of first:'a * second:'a * third:'a * fourth:'a

let intTwo = Tuple(1,2)
let floatThree = Threeple(1.0,2.0,3.0)
let stringFour = Fourple("This","World","Is","Awesome")

let f bFun (coordinate:Coordinates<'a>) =
    match coordinate with
    | Tuple(a,b) -> bFun a b
    | Threeple(a,b,c) -> bFun (bFun a b) c
    | Fourple(a,b,c,d) -> bFun (bFun (bFun a b) c) d

let plus1 = f (+) intTwo
let plus2 = f (+) floatThree
let plus3 = f (+) stringFour
let minus1 = f (-) intTwo
let minus2 = f (-) floatThree

printf "%d\n%f\n%s\n%d\n%f\n" plus1 plus2 plus3 minus1 minus2
