// Задача №21. Работа в группах
// Напишите программу, которая принимает на вход координаты двух точек и находит 
//расстояние между ними в 2D пространстве.

// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

double Distance (double xA, double yA, double xB, double yB)
{
    double result = Math.Round(Math.Sqrt(Math.Pow((xA - xB), 2)+ Math.Pow((yA - yB),2)),2);
    return result;
}

string[] str = {"X точки А","Y точки А","X точки B","Y точки B"};
double[] input = new double[4];
for(int i = 0; i < input.Length; i++)
{
    Console.WriteLine($"Введите координаты {str[i]}");
    input[i] = Convert.ToDouble(Console.ReadLine());
}
Console.WriteLine($"Растояние = {Distance(input[0],input[1],input[2],input[3])}");