// Задача 25: Напишите цикл, который принимает на вход 
// два числа (A и B) и возводит число A в натуральную степень B.


int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}


void pow (int n)
{
    
    for (int i = 0; i < n; i++)
    {
        Console.WriteLine("Введите число А, которое нужно возвести в квадрат");
        int A = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите число, в которое нужно возвести число А");
        int B = int.Parse(Console.ReadLine());
        var result = Math.Pow(A, B);
        Console.WriteLine($"Число {A} в степени {B} равно {result}");
    }
}

int count = prompt_num("Введите количество раз, сколько нужно возвести возвести числа в степень числа");
pow(count);