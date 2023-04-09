// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12

int Sum(int number)
{
    int sum = default, sign = 1;
    if (number < 0)
        sign = -sign;

    number = Math.Abs(number);
    while (number > 9)
    {
        sum = sum + number % 10;
        number = number / 10;
    }
    sum = sum + sign * number % 10;

    return sum;
}

int Entry(string msg)
{
    while (true)
    {
        try
        {
            Console.Write(msg);
            return Convert.ToInt32(Console.ReadLine()); ;
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода, введите цифры");
            continue;
        }
    }
}
int number = Entry("Введите число");
Console.WriteLine($"Сумма цифр {Sum(number)}");
