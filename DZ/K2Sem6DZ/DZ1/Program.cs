// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

int Entry(string msg)
{
    Console.WriteLine(msg);
    return Convert.ToInt32(Console.ReadLine());
}

int[] ArrFill(int lenght)
{
    int[] arr = new int[lenght];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Entry($"Введите число в эелемент массива под индексом {i}");
    }
    return arr;
}

string ArrMinusPlus(int[] array, bool plus = true)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(plus) 
        {
            if(array[i] > 0) count++;
        }
        else if(array[i] < 0) count++;
    }
    return plus ? $"положительных чисел {count}" : $"отрицательных чисел {count}";
}


int lenght = Entry("Введите длину массива");
int[] arr = ArrFill(lenght);
lenght = Entry("Введите\n1 чтобы показать количество положительных чисел"+
               "\n0 чтобы показать количество отрицательных чисел");
bool plus = lenght > 0? true: false;
Console.Write($"[{string.Join(", ", arr)}] -> {ArrMinusPlus(arr, plus)}");