// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0
int Entry(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrRandom(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-999, 1000);
    }
    return arr;
}

int lenght = Entry("Введите длину массива");
int[] arr = ArrRandom(lenght);
Console.Write($"[{string.Join(", ", arr)}]");

int sum = 0;
for(int i = 1; i < arr.Length; i+=2)
{
    sum += arr[i];
}
Console.WriteLine($" -> {sum}");