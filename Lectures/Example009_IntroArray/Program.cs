void EnterArr (ref int[] arr, int lenght)
{
    int [] tempArr = arr;
    int count = 0;
    arr = new int [lenght + 1];
    while(count < tempArr.Length)
    {
        arr[count] = tempArr[count];
        count++;
    }
}

int Max(int[] arr)
{
    int 
    max = arr[0],
    count = 0;

    while(count < arr.Length)
    {
        if(max < arr[count]) max = arr[count];
        count++;
    }
    return max;
}

int [] arr = new int [1];
int index = 0,
max;
ConsoleKey consoleKey = ConsoleKey.Enter;

while (true)
{
    Console.WriteLine($"Введите число под индексом {index}");
    arr[index] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Нажмите Enter чтобы добавить еще одно число");
    consoleKey = Console.ReadKey().Key;
    Console.WriteLine();
    if (consoleKey == ConsoleKey.Enter)
        EnterArr(ref arr, arr.Length);
    else
        break;
    index++;
}

/*int count = 0;
while(count<arr.Length)
{
    Console.Write($"{arr[count]}, ");
    count++;
}*/
max = Max(arr);
Console.WriteLine(" ");
Console.Write($"Максимальное число {max}");