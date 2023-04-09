// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное 
// на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.WriteLine("Введите число");
int squere = 0, 
number = Convert.ToInt32(Console.ReadLine());
squere = number * number;
Console.WriteLine($"Квадрат числа {number} = {squere}");
