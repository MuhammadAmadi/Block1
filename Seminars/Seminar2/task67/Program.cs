// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int Sum(int value)
{
    if(value == 0)
    {
        return 0;
    }
    return value % 10 + Sum(value/10);
}

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(Sum(number));