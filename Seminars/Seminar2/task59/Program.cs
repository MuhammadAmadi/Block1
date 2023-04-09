// Задача 59: Задайте двумерный массив из целых чисел. Напишите программу,
// которая удалит строку и столбец, на пересечении которых расположен наименьший элемент массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Наименьший элемент - 1, на выходе получим 
// следующий массив:
// 9 4 2
// 2 2 6
// 3 4 7


int[,] ArrayWithRandom(int row, int column)
{
    int[,] arr = new int[row, column];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }

    }
    return arr;
}



int[,] Rewrite(int[,] matrix)
{
    int[,] newArr = new int[matrix.GetLength(0) - 1, matrix.GetLength(1) - 1];
    int min = matrix[0, 0];;
    int indexMinX = 0;
    int indexMinY = 0;

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            if (matrix[i, j] < min)
            {
                min = matrix[i, j];
                indexMinX = i;
                indexMinY = j;
            }
        }
    }
    for (int i = 0, k = 0; i < newArr.GetLength(0); i++, k++)
    {
        for (int j = 0, l = 0; j < newArr.GetLength(1); j++, l++)
        {
            if (l == indexMinY) l++;
            newArr[i, j] = matrix[k, l];
        }
        if (k == indexMinX) k++;
    }
    return newArr;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write(matrix[i, j] + " ");
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