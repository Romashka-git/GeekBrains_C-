// Напишите программу, которая на вход принимает число (N), 
// а на выходе показывает все чётные числа от 1 до N

int a, count;
Console.WriteLine("Введите число, а я покажу все четные числа от 1 до N");
a = int.Parse(Console.ReadLine());
count = a;

for (int i = 1; i <= count; i++)

{
    if (i % 2 == 0)
    {
        Console.Write($"{i} ");
    }
}
