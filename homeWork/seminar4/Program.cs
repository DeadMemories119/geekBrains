// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Console.Write("Enter the base number: ");
// double baseNumber = double.Parse(Console.ReadLine() ?? "0");

// Console.Write("Enter the exponent: ");
// int exponent = int.Parse(Console.ReadLine() ?? "0");

// double result = 1;

// for (int i = 0; i < exponent; i++)
// {
//     result *= baseNumber;
// }

// Console.WriteLine("{0} to the power of {1} is {2}", baseNumber, exponent, result);


// Задача 27: Напишите программу, которая принимает на вход число 
// и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12


// int sumOfNumbers()
// {
//     Console.WriteLine("Input the base number: ");
//     string baseNumber = Console.ReadLine();

//     int result = 0;
//     for (int i = 0; i < baseNumber.Length; i++)
//     {
//         result += int.Parse(baseNumber[i].ToString());
//     }
//     return result;

// }

// Console.WriteLine(sumOfNumbers());



//     // Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
//     // и выводит их на экран.
//     // 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//     // 6, 1, 33 -> [6, 1, 33]


// int[] GetArrayOfInt(int size)
// {
//     Console.WriteLine($"Write down {size} numbers to creat your own array");
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         Console.WriteLine($"input your {i + 1} number:");
//         int newNumber = Convert.ToInt32(Console.ReadLine());
//         array[i] = newNumber;
//     }

//     return array;

// }

// // void PrintArray(int[] array)
// // {
// //     Console.Write("Your array is [");
// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         Console.Write(array[i]);
// //         if (i != array.Length - 1)
// //         {
// //             Console.Write(", ");
// //         }
// //     }
// //     Console.Write("]");
// // }

// void PrintArray(int[] array)
// {
//     Console.WriteLine($"Your array is [{string.Join(", ", array)}]");
// }
// PrintArray(GetArrayOfInt(8));