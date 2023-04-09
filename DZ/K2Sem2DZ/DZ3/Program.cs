// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру дня недели");
int numDay = Convert.ToInt32(Console.ReadLine());
string[] day = { "Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье" };
if (numDay == 6 || numDay == 7) Console.WriteLine($"{day[numDay - 1]} выходной");
else if (numDay > 0 && numDay < 6) Console.WriteLine($"{day[numDay - 1]} будний день");
else Console.WriteLine("Ошибка! Введите число от 1 до 7");