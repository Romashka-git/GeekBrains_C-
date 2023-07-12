// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.WriteLine("Введите число ");
int dec = int.Parse(Console.ReadLine());

int binary = 0;
int tempDec = dec;

if (dec % 2 == 1)  binary = 1;

int count = 0;

for (int i = 0; dec > 1; i++)
{
    for (int j = 0; tempDec > 1; j++)
    {
        tempDec /= 2;
        count++;
    }
    binary = binary + Pow(10, count);
    System.Console.WriteLine(binary);
    dec = dec - Pow(2, count); // ???
    System.Console.WriteLine(dec);
    count = 0;
    tempDec = dec;
}
Console.WriteLine(binary);




int Pow(int a, int b)
{
    int c = a;
    for (int i = 1; i < b; i++)
    {
        c *= a;
    }
    return c;
}