
//Задача 3. Не используя рекурсию, выведите первые N чисел Фибоначчи. 
//[0, 1, 1, 2, 3, 5, 8, str13...]

// void PrintFibonachiNumber(int amountOfNumbers)
// {
//     if (amountOfNumbers < 0)
//         Console.WriteLine("Invalid number");

//     else if (amountOfNumbers == 0)
//         Console.Write("0");

//     else
//     {
//         Console.Write("0,1");
//         int currentNumber = 1;
//         int prevNumber = 0;

//         for (int i = 1; i <= amountOfNumbers; i++)
//         {
//             int nextNumber = currentNumber + prevNumber;
//             Console.Write($" ,{nextNumber}");

//             prevNumber = currentNumber;
//             currentNumber = nextNumber;
//         }

//     }

// }

// PrintFibonachiNumber(11);




// // Задача 41: Пользователь вводит с клавиатуры M чисел. 
// // Посчитайте, сколько чисел больше 0 ввёл пользователь.
// // 0, 7, 8, -2, -2 -> 2
// // 1, -7, 567, 89, 223-> 3

// double[] CreateUserDoubleArray(int length)
// {
//     double[] array = new double[length];

//     for (int i = 0; i < length; i++)
//     {
//         string input = Console.ReadLine();
//         if (!string.IsNullOrEmpty(input))
//         {
//             array[i] = double.Parse(input);
//         }
//         else
//         {
//             Console.WriteLine("Input cannot be null");
//             i--;
//         }
//     }

//     return array;
// }

// void CountNumbersOverZero(double[] array)
// {
//     int count = 0;
//     for (int i = 0; i < array.Length; i++)
//     {
//         if (array[i] > 0)
//             count++;
//     }
//     Console.Write($"There are {count} numbers over a zero in your array "
//     + $"[{string.Join(", ", array)}]");
// }

// CountNumbersOverZero(CreateUserDoubleArray(5));

// Задача 43: Напишите программу, которая найдёт точку пересечения 
// двух прямых,заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, b2 = 4, k1 = 5, k2 = 9 -> (-0,5; -0,5)

void FindLineIntersectionPoint()
{
    Console.WriteLine("Enter the values for b1, b2, k1, k2: ");
    string b1 = Console.ReadLine();
    string b2 = Console.ReadLine();
    string k1 = Console.ReadLine();
    string k2 = Console.ReadLine();

    if (!string.IsNullOrEmpty(b1) && !string.IsNullOrEmpty(b2) &&
        !string.IsNullOrEmpty(k1) && !string.IsNullOrEmpty(k2))

    {
        double x = (double.Parse(b2) - double.Parse(b1)) / (double.Parse(k1) - double.Parse(k2));
        double y1 = double.Parse(k1) * x + double.Parse(b1);
        double y2 = double.Parse(k2) * x + double.Parse(b2);
        Console.WriteLine($"The intersection point is ({y1:F2} ; {y2:F2})");
    }
    else
    {
        Console.WriteLine("Input cannot be null");
    }

}

FindLineIntersectionPoint();

