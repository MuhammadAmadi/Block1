Console.WriteLine("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
int minus = -number;

while (minus <= number)
{
    Console.Write($"{minus}" );
    minus++;
}
