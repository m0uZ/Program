Console.Write("Введите ваше имя: ");
string username = Console.ReadLine();

if(username.ToLower() == "миша")
{
    Console.WriteLine("Здарова Мишаня!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
