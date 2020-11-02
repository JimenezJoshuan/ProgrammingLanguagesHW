open System

//Problem 5
let rec inner xs ys =
    if List.length xs <> List.length ys then failwith "Lists are different length."
    else match xs,ys with
         |[],[] -> 0I
         |x::xs, y::ys -> let addHeads = (x * y)
                          addHeads + (inner xs ys)

let rec innertail add xs ys =
    if List.length xs <> List.length ys then failwith "Lists are different length."
    else match xs,ys with
    |[],[] -> add + 0I
    |x::xs, y::ys -> let addHeads = add + (x * y)
                     innertail addHeads xs ys

let trial5 = innertail 0I [1I..50000I] [50001I..100000I]

printf "%A\n\n\n" trial5

//Problem 6
let product xs ys = innertail 0I xs ys

let rec transpose = function
| []::_ -> []
| xs -> List.map List.head xs :: transpose (List.map List.tail xs)


let multiply (xs, ys) =
    zs = transpose ys
    let rec matrixmult = function
    |[],[] -> []
    |x::xs, zs -> let matrix = List.map (product x) zs
                  let tail = matrixmult(xs, zs)
                  matrix::tail

let trial6 = multiply ([[1I;2I;3I];[4I;5I;6I]], [[0I;1I];[3I;2I];[1I;2I]])

printf "%A\n\n\n" trial6