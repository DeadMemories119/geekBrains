// Задача 19
// Напишите программу, которая принимает на вход пятизначное число 
// и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Console.WriteLine("Input a 5-digit number to see if it's a palindrome.");
// int num = Convert.ToInt32(Console.ReadLine());

// bool isPalindrome(int number) 
// {
// int digitFive = number % 10;
// int digitFour = (number / 10) % 10;
// int digitOne = (number / 10000) % 10;
// int digitTwo = (number / 1000) % 10;

// if (digitFive == digitOne && digitFour == digitTwo) 
// {
//     Console.WriteLine("The number is a palindrome.");
//     return true;
// }
// else 
// {
//     Console.WriteLine("The number is not a palindrome.Try another one");
//     return false;
// }

// }

// isPalindrome(num);


// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


// double FindDistance(double x1, double x2, double y1, double y2, double z1, double z2)
// {
//     return Math.Round(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1,2)),2);
// }

// Console.WriteLine("input coordinate X for point A");
// double x1 = double.Parse(Console.ReadLine()?.Trim());
// Console.WriteLine("input coordinate Y for point A");
// double y1 = double.Parse(Console.ReadLine()?.Trim());
// Console.WriteLine("input coordinate Z for point A");
// double z1 = double.Parse(Console.ReadLine()?.Trim());
// Console.WriteLine("input coordinate X for point B");
// double x2 = double.Parse(Console.ReadLine()?.Trim());
// Console.WriteLine("input coordinate Y for point B");
// double y2 = double.Parse(Console.ReadLine()?.Trim());
// Console.WriteLine("input coordinate Z for point B");
// double z2 = double.Parse(Console.ReadLine()?.Trim());

// double distance = FindDistance(x1, x2, y1, y2, z1, z2);
// Console.WriteLine($"Distanse between A and B is {distance}");


// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// int Cube(int num)
// {
//     return (int)Math.Pow(num,3);
// }

// Console.WriteLine("Input a number");
// int num = Convert.ToInt32(Console.ReadLine());

// for (int i = 1; i <= num; i++)
// {
// int result = Cube(i);
// Console.WriteLine($"{num} -> {result}");
// }

