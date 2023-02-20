// Вид 1 Ничего не принимает, что-то делает
void Method1()
{
    Console.WriteLine($"Автор Линьков Роман");
}

// Method1(); //Вызов метода

// Вид 2  Принимает что то, что-то делает
void Method2(string msg)
{
    Console.WriteLine(msg);
}
//Method2("Текст1 сообщения"); //Вызов метода

void Method21(string msg, int count)
{
    int i=0;
    while (i<count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
// Method21(count: 3,msg: "Текст1 сообщения" );


// Ничего не принимает, что то возвращает
int Method3()
{
    return DateTime.Now.Year;
}
// int year = Method3();
// Method21(Convert.ToString(year), 4);

// Вид 4 Что то принимает и возвращает
string Method4(int count, string c)
{
    int i=0;
    string result=string.Empty;
    while (i<count)
    {
        result = result + c;
        i++;
    }
    return(result);
}
Method2(Method4(4, "-Метод4-"));
Console.WriteLine();


string Method5(int count, string c)
{
    string result=string.Empty;
    for (int i=0; i<count; i++)
    {
        result = result + c;
    }
    return(result);
}
Method2(Method5(5, "-Метод5-"));
Console.WriteLine();
