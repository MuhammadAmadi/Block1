int rand = new Random().Next(100, 1000);
Console.WriteLine(rand);
int valueA = rand / 100;
int valueB = rand % 10;

rand = valueA * 10 + valueB;
Console.WriteLine(rand);
