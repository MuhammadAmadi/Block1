Console.WriteLine("Input number");
int num = Convert.ToInt32(Console.ReadLine());

if(num % 7 == 0 && num % 23 == 0){
    Console.WriteLine("YES");
}
else{
     Console.WriteLine("NO");
}