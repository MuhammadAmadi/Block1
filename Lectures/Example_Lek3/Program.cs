void PrintArray(int[]array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectSort(int[] array)
{
    for(int i = 0; i < array.Length - 1; i++)
    {
        int minPos = i;
        for(int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[minPos]) minPos = j;
        }
        int temp = array[i];
        array[i] = array[minPos];
        array[minPos] = temp;
    }
}

int [] arr = {1,3,65,2,7,4,9,8,3,4,5,7,};
PrintArray(arr);
SelectSort(arr);
PrintArray(arr);