// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int inputNum()
{
    int count = 0;
    Console.WriteLine("Введите число");
    string str = Convert.ToString(Console.ReadLine()) ?? String.Empty;
    if (str.All(Char.IsDigit))
    {
        count = str.Length;
        return count;
    }
    else
    {
        Console.WriteLine("Вы не ввели число");
        return count;
    }
    
}

void show(int count)
{
    Console.WriteLine($"Вы ввели {count} цифр");
}

show(inputNum());
