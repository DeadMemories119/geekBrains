// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1 с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// void showNumbers(int fromNumber)
// {

//     if (fromNumber >= 1)
//     {
//         Console.Write(fromNumber + " ");
//         showNumbers(fromNumber - 1);

//     }

// }

// showNumbers(10);


// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


// int FindSumBetweenTwoNumbers(int fromNumber, int toNumber)
// {
//     if (fromNumber > toNumber)
//     {
//         Console.WriteLine("The first number must be lower than the second");
//         return 0;
//     }

//     int sum = fromNumber;
//     if (fromNumber < toNumber)
//     {
//        sum += FindSumBetweenTwoNumbers(fromNumber + 1, toNumber);
//     }

//     return sum;
// }

// int newNumber = FindSumBetweenTwoNumbers(1, 15);
// Console.WriteLine(newNumber);



// Задача 68: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


// int Ackermann(int firstNumber, int secondNumber)
// {
//     if (firstNumber == 0)
//     {
//         return secondNumber + 1;
//     }
//     else if (secondNumber == 0)
//     {
//         return Ackermann(firstNumber - 1, 1);
//     }
//     else
//     {
//         return Ackermann(firstNumber - 1, Ackermann(firstNumber, secondNumber - 1));
//     }
// }

// int newNumber = Ackermann(2,3);
// Console.WriteLine(newNumber);
