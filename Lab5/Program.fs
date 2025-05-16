// Функции с каррированием
let add x y = x + y
let subtract x y = x - y
let multiply x y = x * y
let divide x y = x / y  // Будет исключение при делении на 0

// Специализированные функции через каррирование
let addFive = add 5       // addFive y = 5 + y
let multiplyByThree = multiply 3  // multiplyByThree y = 3 * y

// Рекурсивный факториал
let rec factorial n =
    if n < 0 then invalidArg "n" "Факториал отрицательного числа не определен"
    elif n = 0 then 1
    else n * factorial (n - 1)

[<EntryPoint>]
let main argv =
    // Тестирование функций
    printfn "5 + 3 = %d" (add 5 3)
    printfn "10 - 4 = %d" (subtract 10 4)
    printfn "7 * 6 = %d" (multiply 7 6)
    printfn "15 / 5 = %d" (divide 15 5)
    
    // Использование специализированных функций
    printfn "addFive 10 = %d" (addFive 10)
    printfn "multiplyByThree 7 = %d" (multiplyByThree 7)
    
    // Тестирование факториала
    printfn "Факториал 5 = %d" (factorial 5)
    0  // Код возврата