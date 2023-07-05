// Задача 27: Напишите программу, 
// которая принимает на вход число и выдаёт сумму цифр в числе.

int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}

int sum (int a)
{
    int del = a;
    int summ = 0;
    int res;
    for (int n = a; n > 0; n /= 10)
    {
         res = del % 10;
         summ = summ + res;
         del = del / 10;
    }
    return summ;
}

int pr = prompt_num("Введите число, а я посчитаю сумму цифр в числе");

int result = sum(pr);
System.Console.WriteLine($"Сумма равна {result}");