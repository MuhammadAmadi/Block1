Console.WriteLine("Введите имя пользователя");
string userName = Console.ReadLine() ?? "Безымянный";

if(userName.ToLower() == "Маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.Write(userName);
}
