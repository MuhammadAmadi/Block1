
Random rnd = new Random();
Console.CursorVisible = false;

while (true)
{
    Console.SetCursorPosition(
                left: rnd.Next(Console.WindowWidth),
                top: rnd.Next(Console.WindowHeight)
                 );
    Console.Write(rnd.Next(10));

    Console.SetCursorPosition(
                left: rnd.Next(Console.WindowWidth),
                top: rnd.Next(Console.WindowHeight)
                 );
    Console.Write(' ');
    
    Console.SetCursorPosition(
                left: rnd.Next(Console.WindowWidth),
                top: rnd.Next(Console.WindowHeight)
                 );
    Console.Write(' ');
    //Thread.Sleep(100);
}