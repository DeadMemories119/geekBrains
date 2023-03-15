
// int randomNumber = new Random().Next(10,100);

// int BiggestDigit(int num) 
// {
// int ed = num % 10;
// int dec = num / 10;

// if (ed>dec) return ed;
// else return dec;
// }

// int result = BiggestDigit(randomNumber);
// Console.WriteLine($"the biggest digit of {randomNumber} is {result}");

// int DeleteDigit(int num)
// {
// int sot = num / 100;
// int dec = num % 10;

// return sot * 10 + dec;
// }

// int randomNumber = new Random().Next(100,1000);
// int result = DeleteDigit(randomNumber);

// Console.WriteLine($"{randomNumber} -> {result} ");


// Задача 10: Напишите программу, которая принимает на вход трёхзначное
// число и на выходе показывает вторую цифру этого числа.
// 456 -> 5


// int FindMiddleNumber(int num)
// {
// int ed = num / 10;
// int middleNumber = ed % 10;

// return middleNumber;
// }

// int randomNumber = new Random().Next(100,1000);
// int result = FindMiddleNumber(randomNumber);

// Console.WriteLine($"the middle number of {randomNumber} is {result}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного
// числа или сообщает, что третьей цифры нет.


// int FindThirdNumber(int num)
// {
//     string strNumber = num.ToString();

//     if (strNumber.Length > 2) return int.Parse(strNumber[2].ToString());
//     else return -1;

// }

// int randomNumber = new Random().Next();
// int result = FindThirdNumber(randomNumber);
// Console.WriteLine($"the third digit of {randomNumber} is {result}");


// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую 
// день недели, и проверяет, является ли этот день выходным.

// Console.WriteLine("Input a number");
// int number = Convert.ToInt32(Console.ReadLine());

// bool checkWeekend (int num)
// {
// if (num > 7) 
// {
// Console.WriteLine("There are only 7 days in a week");
// return false;
// } 
// if (num > 5)
// {
//     Console.WriteLine($"{num}th day of a week is a weekend");
//     return true;
// }

// else 
// {
//     Console.WriteLine($"{num} day of a week is not a weekend");
// return false;
// }

// }

// checkWeekend(number);
