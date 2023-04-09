public static class ArrayMath
{
    public static int BadGetSum(this int[] array, int m = 3)
    {
        
        int max = 0, temp = 0;
        for (int i = 0; i <= array.Length - m; i++)
        {
            temp = 0;
            for (int j = i; j < i + m; j++)
            {
                temp += array[j];
            }
            if (temp > max) max = temp;
        }
        return max;
    }

    public static int GoodGetSum(this int[] array, int m = 3)
    {
        
        int max = 0, temp = 0;
        for(int i = 0; i < m; i++) max += array[i];
        temp = max;
        for(int i = 1; i <= array.Length - m; i++)
        {
            temp = temp - array[i-1] + array[i + m - 1];
            if(temp > max) max = temp;
        }
        return max;
    }
}