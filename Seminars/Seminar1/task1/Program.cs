
Console.WriteLine("Введи число 1");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи число 2");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA == numberB * numberB)
{
    Console.WriteLine($"Число {numberA} является квадратом числа {numberB}");
}
else
{
    Console.WriteLine($"Число {numberA} не является квадратом числа {numberB}");
}
