/// <summary>
/// Это класс отвечающий за создание массива
/// </summary>
public static class CreateArray
{
    /// <summary>
    /// Метод создание массива
    /// </summary>
    /// <param name = "length">Количество элементов</param>
    /// <returns> новый массив </returns>
    public static int[] Create(this int length)
    {
        return new int[length];
    }
    /// <summary>
    /// Лепит массив в строку
    /// </summary>
    /// <param name = "array">Массив</param>
    /// <returns> Строку с представлением массива </returns>
    public static string ConvertToStringAndPrint(this int[] array, string arg = "")
    {
        string str = $"{arg}[{string.Join(" ", array)}]";
        Console.WriteLine(str);
        return str;
    }
    /// <summary>
    /// Заполняет рандомно массив 
    /// </summary>
    /// <param name = "array">Массив</param>
    /// <param name = "min">Нижняя граница диапазона</param>
    /// <param name = "max">Верхняя граница диапазона</param>
    /// <param name = "seed">чтобы рандомно получить одни и те же числа</param>
    /// <returns> Заполненный случайными числами массив </returns>
    public static int [] FillRandom(this int[] array, int min = 0, int max = 10,int seed = 0)
    {
        Random random = seed == 0? new Random(): new Random(seed); 
        return array.Select(item => random.Next(min, max)).ToArray();
    }
}