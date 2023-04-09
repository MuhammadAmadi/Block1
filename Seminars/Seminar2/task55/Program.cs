// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];
    
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = new Random().Next(1, 10);
        }
        
    }
    return arr;
}

int [,] Rewrite(int[,] matrix)
{
    int[,] arrRotation = new int [matrix.GetLength(1), matrix.GetLength(0)];
    for(int i = 0; i<arrRotation.GetLength(0); i++)
    {
        for(int j = 0; j < arrRotation.GetLength(1); j++)
        {
            arrRotation[i,j] = matrix[j,i];
        }
    }
    return arrRotation;
}
void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i,j] + " ");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int row = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int column = Convert.ToInt32(Console.ReadLine());
int[,] matrix = ArrayWithRandom(row, column);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(Rewrite(matrix));