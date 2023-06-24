// Задача 6: Напишите программу, которая на вход принимает число и выдает, 
// является ли число четным (делится ли оно на два без остатка)

int a;

Console.WriteLine("Введите число, а я скажу, четное оно или нет");
a = int.Parse(Console.ReadLine());
if (a % 2 == 0)
{
    Console.WriteLine("Четное");
}
else
{
    Console.WriteLine("Нечетное");
}

Console.WriteLine("Вы великолепны!");
