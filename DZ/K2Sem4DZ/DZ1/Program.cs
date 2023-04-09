// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int Rank(int[] arr)
{
    int result = 1;
    for (int i = 0; i < arr[1]; i++)
    {
        result = result * arr[0];
    }
    return result;
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

string[] str = { "A", "B" };
int[] arr = new int[str.Length];
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = Entry($"Введите число {str[i]} ");
}

if (arr[1] < 0)
{
    Console.Write($"Ошибка!!! число B неможет быть меньше нуля");
}
else
{
    Console.WriteLine(Rank(arr));
}