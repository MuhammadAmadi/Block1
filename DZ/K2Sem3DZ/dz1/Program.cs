// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. 
// 14212 -> нет 
// 12821 -> да 
// 23432 -> да  

string Rever(string str)
{
    string result = String.Empty;
    for (int i = str.Length-1; i >=0; i--)
    {
        result = result + str[i];
    }
    return result;
}

Console.WriteLine("Введите число");
string str = Console.ReadLine() ?? String.Empty;
if (str.All(Char.IsDigit))
    if(str == Rever(str))
        Console.WriteLine("Является палиндромом");
    else
        Console.WriteLine("Неявляется палиндромом");
else
    Console.WriteLine("Ошибка!!! Введите только цифры");