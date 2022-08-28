//Вид 1
void Method1()
{
    Console.WriteLine("Автор ...");
}

Method1(); // Вызов метода

// Вид 2
void Method2(string msg);
{
    Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21(msg: "text", count: 4); // 4 количество раз выведет текст

//Вид 3

int Method3()
{
    return DataTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4

string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // Пустая строка

    while (i < count)
    {
        result += text;
        i++;
    }
    return result;
}
strint res = Method4(10, "asdf");
Consol.WriteLine(res);

string Method4(int count, string text)
{

    string result = string.Empty; // Пустая строка

    for (int i = 0; i < count; i++)
    {
        result += text;
    }
    return result;
}
strint res = Method4(10, "asdf");
Consol.WriteLine(res);

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine();
}
