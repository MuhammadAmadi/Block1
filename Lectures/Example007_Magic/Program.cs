Console.Clear();

int xA = 40, yA = 1,
    xB = 1, yB = 30,
    xC = 80, yC = 30;

Console.SetCursorPosition(xA, yA);
Console.WriteLine("+");

Console.SetCursorPosition(xB, yB);
Console.WriteLine("+");

Console.SetCursorPosition(xC, yC);
Console.WriteLine("+");

int x = xA, y = yA, count = 0;

while (count < 10000)
{
    int what = new Random().Next(0,3);

    if (what == 0)
    {
        x = (x + xA)/2;
        y = (y + yA)/2;
    }
    if (what == 1)
    {
        x = (x + xB)/2;
        y = (y + yB)/2;
    }
    if (what == 2)
    {
        x = (x + xC)/2;
        y = (y + yC)/2;
    }
    count++;
    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
}
Console.SetCursorPosition(yA, yB);