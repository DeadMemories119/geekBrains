// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// double maxValue = 10;
// double minValue = -10;

// double[,] Create2dArray(int rows, int columns)
// {
//     double[,] array = new double[rows, columns];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             double value = random.NextDouble() * (maxValue - minValue) + minValue;
//             array[i, j] = Math.Round(value, 1);
//         }

//     }
//     return array;
// }

// void print2DArray(double[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// while (true)
// {
//     Console.WriteLine("Enter row:");
//     string rowsInput = Console.ReadLine() ?? "";
//     Console.WriteLine("Enter column:");
//     string columnsInput = Console.ReadLine() ?? "";

//     if (int.TryParse(rowsInput, out int rows) &&
//         int.TryParse(columnsInput, out int columns))
//     {
//         print2DArray(Create2dArray(rows, columns));
//         break;
//     }

//     else
//     {
//         Console.WriteLine("Not a valid number. Try again.");
//     }
// }



// Задача 50. Напишите программу, которая на вход принимает
// позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 3 7 2 8 2 5
// 5 9 2 3 7 3 3
// 8 6 2 5 1 7 3
// 9 3 7 3 5 3 6
// 8 4 3 5 1 3 5
// (1,4) -> 4


// int[,] Create2dIntArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(1, 9);
//         }

//     }
//     return array;
// }


// void FindDigitInArray(int[,] array, int rowIndex, int columnIndex)
// {
//     int result = 0;
//     if (rowIndex >= array.GetLength(0) || columnIndex >= array.GetLength(1))
//     {
//         Console.WriteLine("The position you've enetered is out of range"
//         + " for this array. Please Try again.");
//     }

//     else
//     {
//         result = array[rowIndex, columnIndex];
//         Console.WriteLine($"The number located at ({rowIndex}, {columnIndex})"
//         + $" in the array is {result}.");
//     }
// }

// void Print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// int[,] newArray = Create2dIntArray(5, 5);

// Print2DArray(newArray);
// FindDigitInArray(newArray, 4, 4);


// Задача 52. Задайте двумерный массив из целых чисел.
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// int[,] Create2dIntArray(int rows, int columns)
// {
//     int[,] array = new int[rows, columns];
//     Random random = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             array[i, j] = random.Next(1, 9);
//         }

//     }
//     return array;
// }


// void FindAndPrintArithmeticMean(int[,] array)
// {
//     for (int rowIndex = 0; rowIndex < array.GetLength(0); rowIndex++)
//     {
//         int sum = 0;
//         double mean = 0;
//         for (int columnIndex = 0; columnIndex < array.GetLength(1); columnIndex++)
//         {
//             sum += array[rowIndex, columnIndex];
//             Console.Write(array[rowIndex, columnIndex] + " ");
//         }
//         mean = (double)sum / array.GetLength(0);
//         Console.Write($" -> Arithmetic mean of this row is {mean}");
//         Console.WriteLine();

//     }
// }


// FindAndPrintArithmeticMean(
//     Create2dIntArray(5, 5));