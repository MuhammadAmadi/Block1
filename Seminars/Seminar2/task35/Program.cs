// Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5
int Entry(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int ArrSearch(int[] arry)
{
    int count = 0;
    for(int i = 0; i < arry.Length; i++)
    {
        if(arry[i] > 9 && arry[i] < 100)
        {
            count++;
        }
    }
    return count;
}
int[] ArrRandom(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0,123);
    }
    return arr;
}

int lenght = Entry($"Введите длину массива");
int[] arr = ArrRandom(lenght);
Console.Write($"[{string.Join(", ", arr)}]");
int count = ArrSearch(arr);
Console.Write($" => {count}");