// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет 
// количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


// int[] GetRandomIntArray(int arrayLength, int minValue, int maxValue)
// {
//     int[] array = new int[arrayLength];

//     for (int i = 0; i < arrayLength; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }

//     return array;
// }

// void PrintEvenNumbersCount(int[] array)
// {
//     int evenNumbersCount = 0;

//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             evenNumbersCount++;
//         }
//     }

    // Console.WriteLine($"There are {evenNumbersCount} even numbers in " +
    //                  $"[{string.Join(", ", array)}]");

// }


// PrintEvenNumbersCount(GetRandomIntArray(4, 99, 1000));


// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


// int[] GetRandomIntArray(int arrayLength, int minValue, int maxValue)
// {
//     int[] array = new int[arrayLength];

//     for (int i = 0; i < arrayLength; i++)
//     {
//         array[i] = new Random().Next(minValue, maxValue);
//     }

//     return array;
// }

// void PrintSumOfEvenNumbers(int[] array)
// {
//     int sum = 0;

//     for (int i = 0; i < array.Length;i++)
//     {
//         if (array[i] % 2 == 0)
//         {
//             sum += array[i];
//         }
//     }
//     Console.WriteLine("The sum of even numbers in " +
//                       $"[{string.Join(", ", array)}] is {sum}");

// }

// PrintSumOfEvenNumbers(GetRandomIntArray(4, 0, 100));


// Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// double[] GetRandomDoubleArray(int arrayLength, double minValue, double maxValue)
// {
//     double[] array = new double[arrayLength];
//     Random random = new Random();

//     for (int i = 0; i < arrayLength; i++)
//     {
//         double randomDoubleValue = minValue + (random.NextDouble() * (maxValue - minValue));
//         array[i] = Math.Round(randomDoubleValue, 2);
//     }
//     return array;
// }

// // void PrintMinMaxDifference(double[] array)
// // {
// //     double maxValue = array[0];
// //     double minValue = array[0];

// //     for (int i = 0; i < array.Length; i++)
// //     {
// //         if (array[i] < minValue)
// //         {
// //             minValue = array[i];
// //         }
// //         else if (array[i] > maxValue)
// //         {
// //             maxValue = array[i];
// //         }
// //     }

// void PrintMinMaxDifference(double[] array)
// {
// double minValue = array[0];
// double maxValue = array[0];

// foreach (double value in array)
// {
//     if (value < minValue)
//     {
//         minValue = value;
//     }
//     if (value > maxValue)
//     {
//         maxValue = value;
//     }
// }

//     double difference = maxValue - minValue;

//     Console.WriteLine($"The difference between max value ({maxValue}) and " +
//     $"min value ({minValue}) in [{string.Join(", ", array)}] is {difference}");

// }


// PrintMinMaxDifference(GetRandomDoubleArray(4, 0, 100));
