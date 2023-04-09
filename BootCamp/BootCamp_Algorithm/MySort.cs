public static class MySort
{
    public static void Swap(ref int leftValue, ref int rightValue)
    {
        (rightValue, leftValue) = (leftValue, rightValue);
    }

    public static int[] BoobleSort(this int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            for (int j = 0; j < inputArray.Length - 1 - i; j++)
            {
                if (inputArray[j] > inputArray[j + 1])
                    Swap(ref inputArray[j], ref inputArray[j + 1]);
            }
        }
        return inputArray;
    }

    public static int[] SelectionSort(this int[] inputArray)
    {
        for (int i = 0; i < inputArray.Length - 1; i++)
        {
            int min = i;
            for (int j = i + 1; j < inputArray.Length; j++)
            {
                if (inputArray[j] < inputArray[min]) min = j;
            }
            Swap(ref inputArray[i], ref inputArray[min]);
        }
        return inputArray;
    }

    public static int[] CountingSort(this int[] inputArray)
    {
        int min = inputArray[0];
        int max = inputArray[0];
        foreach (int element in inputArray)
        {
            if (element > max) max = element;
            else if (element < min) min = element;
        }

        int correctionFactor = min != 0 ? -min : 0;
        max += correctionFactor;

        int[] count = new int[max + 1];
        for (int i = 0; i < inputArray.Length; i++)
        {
            count[inputArray[i] + correctionFactor]++;
        }
        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            for (int j = 0; j < count[i]; j++)
            {
                inputArray[index] = i - correctionFactor;
                index++;
            }
        }
        return inputArray;
    }

    public static void CountingSortDebag(this int[] inputArray)
    {
        Console.WriteLine("START");
        inputArray.ConvertToStringAndPrint("inputArray = ");
        int min = inputArray[0];
        int max = inputArray[0];
        int val = 0;
        Console.WriteLine("Поиск мин и макс");
        Console.WriteLine();
        foreach (int element in inputArray)
        {
            val++;
            Console.WriteLine($"\t==========Итерация {val}==========");
            Console.WriteLine($"\tmin = {min}\n\tmax = {max}");
            Console.WriteLine($"\tЗначение элемента {element}");
            if (element > max)
            {
                Console.WriteLine($"\t{element} > {max}");
                max = element;
            }
            else if (element < min)
            {
                Console.WriteLine($"\t{element} < {min}");
                min = element;
            }
            Console.WriteLine();
        }
        Console.WriteLine("\tПоиск мин и макс завершен");
        Console.WriteLine($"\tmin = {min}\n\tmax = {max}");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine("Поправка");
        int correctionFactor = 0;
        if (min != 0)
        {
            Console.WriteLine($"min = {min}\n{min} != 0");
            correctionFactor = -min;
            Console.WriteLine($"correctionFactor = {-min}");
        }
        else
        {
            Console.WriteLine($"min = {min}\n{min} == 0");
            Console.WriteLine($"correctionFactor = {min}");
        }
        Console.WriteLine($"max = {max} + {correctionFactor}");
        max += correctionFactor;
        Console.WriteLine($"min = {min}\nmax = {max}");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine($"объявляем массив Count длина массива max({max}) + 1");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        val = 0;
        int[] count = new int[max + 1];
        for (int i = 0; i < inputArray.Length; i++)
        {
            val++;
            Console.WriteLine($"\t==========Итерация {val}==========");
            count.ConvertToStringAndPrint("\tcount = ");
            Console.WriteLine("\t{");
            Console.WriteLine($"\t\tcount[inputArray[{i}] + {correctionFactor}] = {count[inputArray[i] + correctionFactor]}");
            Console.WriteLine($"\t\tcount[inputArray[{i}] + {correctionFactor}]++");
            Console.WriteLine($"\t\tcount[{inputArray[i]} + {correctionFactor}] = {count[inputArray[i] + correctionFactor]+1}");
            Console.WriteLine("\t}");
            Console.WriteLine($"\tcount[{inputArray[i] + correctionFactor}] = {count[inputArray[i] + correctionFactor]+1}");
            count[inputArray[i] + correctionFactor]++;
            Console.WriteLine();
        }
        count.ConvertToStringAndPrint("\tcount = ");
        Console.WriteLine();
        Console.WriteLine("=====================================");
        Console.WriteLine();
        Console.WriteLine("============Начинаем Сортировку===============\n");
        int index = 0;
        for (int i = 0; i < count.Length; i++)
        {
            Console.WriteLine($"\t========Итерация {i + 1} из {count.Length} Индекс i {i}========\n");
            inputArray.ConvertToStringAndPrint("\tinputArray = ");
            Console.Write($"\tj({0}) < count[{i}]({count[i]})");
            for (int j = 0; j < count[i]; j++)
            {
                Console.WriteLine(" ДА(true)");
                Console.WriteLine($"\t\t======Итерация {j + 1} Индекс j {j}======");
                inputArray.ConvertToStringAndPrint("\t\tinputArray = ");
                Console.WriteLine("\t\tinputArray[index] = i - correctionFactor");
                Console.WriteLine($"\t\tinputArray[{index}] = {i} - {correctionFactor}");
                Console.WriteLine($"\t\tinputArray[{index}] = {i- correctionFactor}\n");
                inputArray[index] = i - correctionFactor;
                index++;
                Console.Write($"\tj({j+1}) < count[{i}]({count[i]})");
            }
            Console.WriteLine(" НЕТ(false)\n");
        }
        inputArray.ConvertToStringAndPrint("inputArray = ");
        Console.WriteLine("END");
    }

}