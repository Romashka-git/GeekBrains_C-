// Задача 19: Напишите программу, которая принимает 
// на вход пятизначное число и проверяет, является ли 
// оно палиндромом.

int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}

void def_if_pal (int a)
{
    if (a > 99999 || a < 10000)
    {
        Console.WriteLine("Это не пятизначное число");
    }
    else
    {
        int n_2 = 0;
        int result = 0;
        int n = a;

        while (n > 0)
        {
            n_2 = n % 10;
            result = result * 10 + n_2;
            n = n / 10;
        }
        Console.WriteLine(result);
        if (a == result)
        {
            Console.WriteLine("Это палиндром");
        }
        else
        {
            System.Console.WriteLine("Это не палиндром");
        }
    }
}



def_if_pal(prompt_num("Введите 5и значное число, а я скажу, является ли оно палиндромом"));
