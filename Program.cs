// See https://aka.ms/new-console-template for more information
// Случайное число [10, 99];
//?..///////////////////////////
bool isParsed = int.TryParse(Console.ReadLine(), out int number);
// Random random = new Random();
// int number = random.Next(10, 100);
// int firstNumber = number / 10;
// int lastNumber = number % 10;

// Console.WriteLine(number);

//!..///////////////////////////
// Random random = new Random();
// int num = random.Next(100, 1000);

// Console.WriteLine(num);
// int thirdNum = num % 10;
// int firstNum = num / 100;
// Console.WriteLine($"{firstNum}{thirdNum}");
//?..///////////////////////////
// int firstNum = int.Parse(Console.ReadLine());
// int secondNum = int.Parse(Console.ReadLine());
// int result = firstNum % secondNum;
// if (result == 0)
// {
//     Console.WriteLine("Кратное");
// }
// else
// {
//     Console.WriteLine(result);
// }
//?..///////////////////////////
// 3. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 46 -> нет 161 -> да

// int num = int.Parse(Console.ReadLine());

// if (num % 7 == 0 & num % 23 == 0)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }
//?..///////////////////////////
// 4 Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да -4, 16 -> да 25, 5 -> да 8,9 -> нет

// int firstNum = int.Parse(Console.ReadLine());
// int secondNum = int.Parse(Console.ReadLine());
// if (firstNum * firstNum == secondNum | secondNum * secondNum == firstNum)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }