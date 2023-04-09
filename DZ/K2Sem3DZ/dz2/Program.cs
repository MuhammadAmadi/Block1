// Задача №21
// Напишите программу, которая принимает на вход координаты двух точек и находит 
// расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7) -> 15,84
// A (7,-5,0); B (1,-1,9) -> 11,53

double Dist3D (double x,double y,double z)
{
    double result = Math.Sqrt(Math.Pow(x, 2)+ Math.Pow(y,2) + Math.Pow(z,2));
    return Math.Round(result, 2);
}

string[] str = {"X точки А","Y точки А","Z точки A","X точки B","Y точки B","Z точки B"};
double[] dot = new double[6];

for(int i = 0; i < dot.Length; i++)
{
    Console.WriteLine($"Введите координату {str[i]}");
    dot[i] = Convert.ToDouble(Console.ReadLine());
}

double dist = Dist3D(dot[0]-dot[3],dot[1]-dot[4],dot[2]-dot[5]);
Console.WriteLine($"Растояние = {dist}");