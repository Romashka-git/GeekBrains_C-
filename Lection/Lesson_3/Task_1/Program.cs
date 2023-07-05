void Method2 (string msg, int a)
{
    int i = 0;
    while (i < a)
    {
        System.Console.WriteLine(msg);
        i++;
    }
}

int a ()
{
    return DateTime.Now.Year;
}

string Method3 (string text, int count)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

Method2(msg: "Привет", a: 2);
// Console.WriteLine(a());

int time = a();
System.Console.WriteLine(time);
string txt = Method3 ("hello", 5);
System.Console.WriteLine(txt);