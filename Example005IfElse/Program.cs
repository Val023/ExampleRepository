Console.WriteLine("Введите имя пользователя ");
string username = Console.ReadLine();

if (username.ToLower() == "родион")
{
    Console.WriteLine("Хорошего дня, любимый!");
}
else
{
    Console.Write("Хорошего дня, ");
    Console.WriteLine(username);
}