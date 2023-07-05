// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120



int multiply (int numUs)
{
    int temp = 1;
    for (int i = 1; i <= numUs; i++)
    {
        temp = temp * i;
    }
    return temp;
}

int result = (multiply(5));
Console.WriteLine(result);