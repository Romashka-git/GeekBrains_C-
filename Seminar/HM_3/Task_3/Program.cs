// Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 4, 9. 
// 5 -> 1, 8, 27, 64, 125

int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}

double [] coub (int a)
{
    double [] list = new double [a];
    double length = 1;
    for (int i = 0; i < a; i++)
    {
        list [i] = Math.Pow(length, 3);
        // list [i] = length * length * length;
        length++;
    }
    return list;
}

void print (double [] res, int num)
{
    for (int i = 0; i < num; i++)
    {
        System.Console.Write($"{res[i]} ");
    }
}



int a = prompt_num("Введите число (N), а я выдам таблицу кубов чисел от 1 до N");
double [] result = coub(a);
print(result, a);