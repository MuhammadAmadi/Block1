Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
// int num1 = new  Random().Next(100,1000);
// int num2 = new  Random().Next(1,100);

if (num1 % num2 == 0)
{
    Console.WriteLine($"{num1} кратно {num2}");
}
else
{

    Console.WriteLine($"{num1} и {num2} некратны, остаток: {num1 % num2}");
}