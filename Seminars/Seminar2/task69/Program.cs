// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int Step(int a, int n)
{
    if(n == 0)
    {
        return 1;
    }
    return a * Step(a, n-1);
}

Console.Write("Введите число ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень ");
int numberN = Convert.ToInt32(Console.ReadLine());
Console.Write(Step(numberA, numberN));