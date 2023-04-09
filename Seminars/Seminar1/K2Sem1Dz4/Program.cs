// Задача 8
Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int count = 0;

while(count < number)
{
    count++;
    if (count%2 == 0) Console.Write($"{count} ");
}
