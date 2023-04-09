string [,] str = 
{
    {"Строка 0 столбец 0","Строка 0 столбец 1","Строка 0 столбец 2","Строка 0 столбец 3"},
    {"Строка 1 столбец 0","Строка 1 столбец 1","Строка 1 столбец 2","Строка 1 столбец 3"},
    {"Строка 2 столбец 0","Строка 2 столбец 1","Строка 2 столбец 2","Строка 2 столбец 3"},
    {"Строка 3 столбец 0","Строка 3 столбец 1","Строка 3 столбец 2","Строка 3 столбец 3"},
};
string text = "(1,2) (2,3)"
                .Replace("(","")
                .Replace(")","")
                ;
Console.WriteLine(text);



(int x, int y)[] data = text.Split(" ")
                .Select(symbol => symbol.Split(","))
                .Select(crd => (x: int.Parse(crd[0]), y: int.Parse(crd[1])))
                //.Where(u => u.x % 2 == 0)
                //.Select(dot => (dot.x * 10, dot.y))
                .ToArray();
for(int i = 0; i < data.Length; i++)
{
    Console.WriteLine(str[data[i].x,data[i].y]);
}

