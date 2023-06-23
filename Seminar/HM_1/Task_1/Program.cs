// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдает, какое число большее, а какое меньшее.

int a, b, max;
a = int.Parse(Console.ReadLine());
b = int.Parse(Console.ReadLine());
max = a;
if (max < b)
{
    max = b;
}
Console.WriteLine($"Максимальное число: {max}");
