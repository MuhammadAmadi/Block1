int Max(int arg1, int arg2, int arg3)
{
    int max = arg1;
    if (max < arg2) max = arg2;
    if (max < arg3) max = arg3;
    return max;
}

int 
a1 = 14,
b1 = 38,
c1 = 37,
a2 = 45,
b2 = 18,
c2 = 65,
a3 = 7,
b3 = 28,
c3 = 51,
max = Max(Max(a1,b1,c1),Max(a2,b2,c2),Max(a3,b3,c3));
Console.WriteLine(max);