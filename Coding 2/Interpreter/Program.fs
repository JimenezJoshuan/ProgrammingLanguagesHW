type Exp =
    Num of int
  | Neg of Exp
  | Sum of Exp * Exp
  | Diff of Exp * Exp
  | Prod of Exp * Exp
  | Quot of Exp * Exp

let rec evaluate = function
| Num n -> Some n
| Neg e -> match evaluate e with
           | None -> None
           | Some n -> Some -n
| Sum(e,e2) -> match (evaluate e,evaluate e2) with
                  | _,None -> None
                  | None,_ -> None
                  | (Some n,Some n2) -> Some (n + n2)
| Diff(e,e2) -> match (evaluate e,evaluate e2) with
                  | _,None -> None
                  | None,_ -> None
                  | (Some n,Some n2) -> Some (n - n2)
| Prod(e,e2) -> match (evaluate e,evaluate e2) with
                    | _,None -> None
                    | None,_ -> None
                    | (Some n,Some n2) -> Some (n * n2)  
| Quot(e,e2) -> match (evaluate e,evaluate e2) with
                  | Some n, Some 0 -> None
                  | _,None -> None
                  | None,_ -> None
                  | (Some n,Some n2) -> Some (n / n2) 

let test = evaluate (Prod(Num 3, Diff(Num 5, Num 1)))

let test2 = evaluate (Diff(Num 3, Quot(Num 5, Prod(Num 7, Num 0))))

printf "%A" test
printf "%A" test2