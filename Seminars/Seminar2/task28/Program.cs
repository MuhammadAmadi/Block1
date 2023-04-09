// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int Sum(int number)
{
    int sum = 1;
    for(int i = 1; i <= number; i++)
    {
        sum*=i;
    }
    return sum;
}

Console.Write("Введите число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Произведение чисел от 1 до N = {Sum(A)}");