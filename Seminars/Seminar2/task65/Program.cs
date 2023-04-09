// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void Natural(int m, int n)
{
    if(n<m)
    {
        return;
    }
    Natural(m,n-1);
    
    Console.Write($" {n}");
}
Console.Write("Введите число M ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N ");
int numberN = Convert.ToInt32(Console.ReadLine());
Natural(numberM,numberN);