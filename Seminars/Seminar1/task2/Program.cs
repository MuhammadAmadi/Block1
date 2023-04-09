string [] day = {"Понедельник", "Вторник", "Среда", "Четверг", "Пятница", "Суббота", "Воскресенье"};
Console.WriteLine("Введите номер дня недели");
int numberDay = Convert.ToInt32(Console.ReadLine());

if (numberDay > 0 && numberDay <= 7)
{
    Console.WriteLine(day[numberDay - 1]);
}
else
{
    Console.WriteLine("В неделе только 7 дней, введите число от 1 до 7");
}

