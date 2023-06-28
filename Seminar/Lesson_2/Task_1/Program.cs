int a = 1567;
int b;
string c = "";
while (a != 0)
{
    b = a;
    b = b % 10;
    a = a / 10;
    c = ($"{c}{b}");
}
int d = int.Parse(c);
Console.WriteLine(d);