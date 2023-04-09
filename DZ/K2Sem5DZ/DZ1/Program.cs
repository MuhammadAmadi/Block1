// Задача 34: Задайте массив заполненный случайными положительными трёхзначными
// числами. Напишите программу, которая покажет количество чётных чисел 
// в массиве.

// [345, 897, 568, 234] -> 2
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
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}

int lenght = Entry("Введите длину массива");
int[] arr = ArrRandom(lenght);
Console.Write($"[{string.Join(", ", arr)}]");
int count = 0;
for(int i = 0; i < arr.Length; i++)
{
    if(arr[i]%2==0)
        count++;
}
Console.WriteLine($" -> {count}");