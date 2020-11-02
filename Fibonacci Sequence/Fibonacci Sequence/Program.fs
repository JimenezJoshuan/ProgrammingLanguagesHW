open System

[<EntryPoint>]
let main argv =
    let rec fib1 n =
        match n with
        |0-> 0
        |1 -> 1
        |n -> fib1(n - 1) + fib1(n - 2)

    let parse (s: string) =
        match (System.Int32.TryParse(s)) with
        | (true, value) -> value
        | (false, _) -> failwith "Invalid int"

    printfn"Enter a number and press enter:"

    let y = parse(System.Console.ReadLine())

    let x = fib1(y)

    printfn"The fibonnaci number for %i is: %i." y x

    0 // return an integer exit code