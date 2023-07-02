// Напишите программу, которая по заданному номеру четверти, 
// показывает диапазон возможных координат точек в этой четверти (x и y).

int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}
void xy (int a)
{
    if (a == 1)
    {
        Console.WriteLine("Диапазон от 0 до х и y");
    }
    else if (a == 2)
    {
        Console.WriteLine("Диапазон от 0 до -х и y");
    }
     else if (a == 3)
    {
        Console.WriteLine("Диапазон от 0 до -х и -y");
    }
     else if (a == 4)
    {
        Console.WriteLine("Диапазон от 0 до х и -y");
    }
    else
    {
        Console.WriteLine("Неверный диапазон");
    }
}

xy(prompt_num("Введите номер четверти окружности, а я покажу диапазон возможных координат"));
