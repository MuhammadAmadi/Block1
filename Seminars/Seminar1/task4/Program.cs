// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите 3 значное число!");
int value = Convert.ToInt32(Console.ReadLine());
if (value > 99 && value < 1000)
{
    Console.WriteLine($"Вы ввели {value} последняя цифра {value%10}");
}
else
{
    Console.WriteLine($"Введи 3 значное число");
}

