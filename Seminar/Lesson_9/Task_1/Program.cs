string a = "11";
List<string> b = new List<string>();

string c = string.Empty;
for (int i = 0; i < a.Length; i++)
{
    c = a[i].ToString();   
    b.Add(c);
}

foreach (var ig in b)
{
    Console.WriteLine(ig);
}