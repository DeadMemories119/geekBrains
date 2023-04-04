// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
// --------------------------------------------------------

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


// int[,] ArrangeArrayInDescendingOrder(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int[] row = new int[array.GetLength(1)];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             row[j] = array[i, j];
//         }
//         Array.Sort(row, (a, b) => -1 * a.CompareTo(b));

//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = row[j];
//         }

//     }

//     return array;
// }



// void Print2DIntArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }


// int[,] newArray = Create2dIntArray(5, 5);

// Print2DIntArray(newArray);

// ArrangeArrayInDescendingOrder(newArray);

// Print2DIntArray(newArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
// номер строки с наименьшей суммой элементов: 1 строка
// --------------------------------------------------------


// int[,] Create2dIntRectangularArray(int rows, int columns)
// {
//     if (rows == columns)
//     {
//         Console.WriteLine("Array must be rectangular shape");
//     }

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

// void FindMinimalRowInArray(int[,] array)
// {
//     int minRow = 0;
//     int minSum = int.MaxValue;

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int sum = 0;
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             sum += array[i, j];
//         }
//         if (sum < minSum)
//         {
//             minSum = sum;
//             minRow = i + 1;
//         }
//     }

//     Console.WriteLine($"Row with the smallest sum in the array is: #{minRow}");
// }

// void Print2DIntArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// int[,] myArray = Create2dIntRectangularArray(5, 6);
// Print2DIntArray(myArray);
// FindMinimalRowInArray(myArray);

// Задача 58: Задайте две матрицы. Напишите программу, 
// которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
// --------------------------------------------------------

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4. 
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


// int[,] CreateSpiralArray(int size, int start)
// {

//     int[,] spiral = new int[size, size];
//     int rowStart = 0, rowEnd = size - 1, colStart = 0, colEnd = size - 1;
//     int counter = start;

//     while (rowStart <= rowEnd && colStart <= colEnd)
//     {

//         for (int i = colStart; i <= colEnd; i++)
//         {
//             spiral[rowStart, i] = counter++;
//         }
//         rowStart++;


//         for (int i = rowStart; i <= rowEnd; i++)
//         {
//             spiral[i, colEnd] = counter++;
//         }
//         colEnd--;

//         if (rowStart <= rowEnd)
//         {
//             for (int i = colEnd; i >= colStart; i--)
//             {
//                 spiral[rowEnd, i] = counter++;
//             }
//             rowEnd--;
//         }

//         if (colStart <= colEnd)
//         {
//             for (int i = rowEnd; i >= rowStart; i--)
//             {
//                 spiral[i, colStart] = counter++;
//             }
//             colStart++;
//         }
//     }

//     return spiral;

// }

// void print2DArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write("{0:D2} ", array[i, j]);
//         }
//         Console.WriteLine();
//     }


// }

// int[,] newArray = CreateSpiralArray(4, 1);
// print2DArray(newArray);