// Obtenez des informations sur F# via http://fsharp.net
module Bowling.Code

open System

let (|Strike|_|) rolls =
    match rolls with
    | 10 :: first :: second :: [] -> Some(first + second, [])
    | 10 :: (first :: second :: _ as t) -> Some(first + second, t)
    | _ -> None

let (|Spare|_|) rolls =
    match rolls with
    | first :: second :: bonus :: []  when first + second = 10 -> Some(bonus, [])
    | first :: second :: (bonus :: _ as t) when first + second = 10 -> Some(bonus, t)
    | _ -> None

let (|Frame|_|) rolls =
    match rolls with
    | first :: second :: tail -> Some(first, second, tail)
    | _ -> None

let (|End|_|) rolls =
    match rolls with
    | [] -> Some()
    | _ -> None

let rec score rolls = 
    match rolls with 
    | Strike(bonus, tail) -> 10 + bonus + score tail
    | Spare(bonus, tail) -> 10 + bonus + score tail
    | Frame(first, second, tail) -> first + second + score tail
    | End -> 0
    | _ -> raise (new Exception ("invalid score !")) 
