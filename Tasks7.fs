open System

//7.1.1. Напишите рекурсивную функцию fibo: int -> int, где fibo(n) вычисляет n-е число Фибоначчи (n >= 0, fibo(0)=0, fibo(1)=1, ...). 
//Последовательность Фибоначчи начинается с двух значений 0,1, а n-й элемент равен сумме n-1 - го и n-2 - го элементов: 0,1,1,2,3,5,8,13,...

let rec fibo = function
 | 0 -> 0
 | 1 | 2 -> 1
 | n -> fibo(n-1)+fibo(n-2) 
 
 

//7.1.2. Напишите рекурсивную функцию sum: int -> int, где sum(n) вычисляет сумму первых n чисел ряда 1 + 2 + 3 + ... + n-1 + n

let rec sum = function
  | 0 -> 0
  | n -> n + sum(n - 1)
  

//7.1.3. Напишите рекурсивную функцию sum2: int * int -> int, где sum2(m, n) вычисляет сумму m + m+1 + ... + m+(n-1) + m+n, где m >= 0 и n >= 0. 
//Используйте шаблоны (m,0) и (m,n).

let rec sum2 = function
  | (m, 0) -> m
  | (m, n) -> m + n + sum2(m, n - 1)
