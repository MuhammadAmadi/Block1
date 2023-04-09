// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.WriteLine("Введите трехзначное число");
string str = Console.ReadLine() ?? string.Empty;
if (str.All(Char.IsDigit) && str.Length >= 3) Console.WriteLine($"Третья цифра {str[2]}");
else if (str.All(Char.IsDigit)) Console.WriteLine("Нет третьей цифры");
else Console.WriteLine("Ошибка!!! Введите только цифры!");