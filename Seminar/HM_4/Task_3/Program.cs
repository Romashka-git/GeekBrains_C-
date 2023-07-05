// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] Random (int [] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        a [i] = new Random().Next(0, 50);
    }
    return a;
}
void Print (int [] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a [i]} ");
    }
}


int [] a = new int [5];

int [] newlist = Random(a);
Print(newlist);


