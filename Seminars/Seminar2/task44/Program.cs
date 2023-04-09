// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. 
// Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int fib0 = 0, fib1 = 1, temp;
string str = "0 1";
for(int i = 2; i < N; i++)
{
    temp = fib0 + fib1;
    fib0 = fib1;
    fib1 = temp;
    str = str + " " +Convert.ToString(temp);
}
Console.WriteLine(str);