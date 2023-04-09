// Задача 45: Напишите программу, которая будет создавать копию заданного массива 
// с помощью поэлементного копирования.

int[] ArrayWithRandom(int length)
{
    int[] arr = new int[length];
    Random rnd = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(1, 10);
    }
    return arr;
}
int[] ArrayCopy(int[] array)
{
    int[] arr = new int[array.Length];
    for(int i = 0; i < arr.Length; i++)
    {
        arr[i] = array[i];
    }
    return arr;
}

Console.WriteLine("Введите длину массива");
int length = Convert.ToInt32(Console.ReadLine());

int[] arr = ArrayWithRandom(length);
Console.Write($" => [{string.Join(", ", arr)}]");
int[] arr2 = ArrayCopy(arr);
Console.WriteLine();
Console.Write($" => [{string.Join(", ", arr2)}]");