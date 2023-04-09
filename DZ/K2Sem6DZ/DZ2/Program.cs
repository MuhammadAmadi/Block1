// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения 
// b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double Entry(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToDouble(Console.ReadLine());
}

double
b1 = Entry("Введите значение b1"),
k1 = Entry("Введите значение k1"),
b2 = Entry("Введите значение b2"),
k2 = Entry("Введите значение k2"),
x = 0,
y = 0;

if (k1 == k2 && b1 == b2) Console.WriteLine("Прямые совпадают");
else if (k1 == k2) Console.WriteLine("Прямые паррарельны");
else

{

    x = (b2 - b1) / (k1 - k2);

    y = k1 * x + b1;
}

Console.WriteLine($"точка пересечения двух прямых X {x}; Y {y}");