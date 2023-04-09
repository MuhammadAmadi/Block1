// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalNumbersSum(int m, int n)
{
    if(n == m)
    {
        return m;
    }

    return n + NaturalNumbersSum(m,n-1);  
}
Console.Write("Введите минимальное число ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное число ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write($"{NaturalNumbersSum(numberM,numberN)}");