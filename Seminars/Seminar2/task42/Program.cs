// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10

int number = 0;
string str = String.Empty;

Console.WriteLine("Введите десятичное число");
number = Convert.ToInt32(Console.ReadLine());

while ( number > 0)
{
    str = Convert.ToString(number%2) + str;
    number = number / 2;
    
}
Console.WriteLine(str);


