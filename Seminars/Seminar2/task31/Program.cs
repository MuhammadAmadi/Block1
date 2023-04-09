// Задача 31: Задайте массив из N элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
//сумма отрицательных равна -20.

int[] ArrRand(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-9, 10);
    }
    return arr;
}

int Entry(string msg)
{
    while (true)
    {
        try
        {
            Console.WriteLine(msg);
            return Convert.ToInt32(Console.ReadLine());
        }
        catch (Exception)
        {
            Console.WriteLine("Ошибка ввода, введите цифры");
            continue;
        }
    }
}

int lenght = Entry("Введите длину массива");
int[] array = ArrRand(lenght);
int sumPositive = 0,
    sumNegative = 0;

for(int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
        sumPositive += array[i];
    else
        sumNegative += array[i];

}