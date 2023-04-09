// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int Entry(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] Arr(int[] array)
{
    int[] arr = new int [array.Length/2+array.Length%2];
    for (int i = 0; i < array.Length / 2; i++)
    {
        arr[i] = array[i] * array[array.Length - 1 - i];
    }

    if (array.Length % 2 > 0)
    {
        arr[arr.Length - 1] = array[array.Length / 2];
    }


    return arr;
}

int[] ArrRandom(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(1, 99);
    }
    return arr;
}

int lenght = Entry($"Введите длину массива");
int[] arr = ArrRandom(lenght);
Console.Write($"[{string.Join(", ", arr)}]");
arr = Arr(arr);
Console.Write($" => [{string.Join(", ", arr)}]");