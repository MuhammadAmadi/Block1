//Задача 2
Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
    Console.WriteLine($"Число {numberA} больше числа {numberB}");
else if (numberA < numberB)
    Console.WriteLine($"Число {numberA} меньше числа {numberB}");
else
    Console.WriteLine($"Число {numberA} равна числу {numberB}");