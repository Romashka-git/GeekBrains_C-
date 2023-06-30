// Задача 10: Напишите программу, которая принимает на вход 
// трёхзначное число и на выходе показывает вторую цифру этого числа.

// string prompt (string text)
// {   
//    Console.WriteLine($"{text}");
//    return Console.ReadLine();
//}

int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}

int numUs;
numUs = prompt_num("Введите трехзначное число, а я покажу вторую цифру числа");
if (numUs < 100 || numUs > 999)
{
    Console.WriteLine("Неверно");
}
else
{
    int result = numUs / 10 % 10;
    Console.WriteLine(result);
}

