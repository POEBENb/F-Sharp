// 16.1. Напишите функцию-предикат notDivisible: int * int -> bool, где notDivisible(n,m) возвращает true, 
//если число n -- делитель числа m.
let notDivisible (n, m) = m % n = 0 

// 6.2. Напишите функцию-предикат prime: int -> bool, где prime(n) возвращает true, если n -- простое число.
let prime n = 
  let rec c = function
    | (a, b) when (b > (a / 2)) -> true
    | (a, b) when (a % b = 0) -> false
    | (a, b) -> c (a, (b + 1))
  c(n,2)
