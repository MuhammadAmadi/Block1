// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число");
string? str = Console.ReadLine() ?? string.Empty;
if (str.All(Char.IsDigit) && str.Length == 3) Console.WriteLine($"Вторая цифра {str[1]}");
else if (str.All(Char.IsDigit)) Console.WriteLine("Вы ввели не трехзначную цифру");
else Console.WriteLine("Ошибка!!! Введите только цифры!");