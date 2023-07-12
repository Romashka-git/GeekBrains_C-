// Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8


int [] Fib (int a)
{
    int [] F = new int [a]; 

    F [0] = 0;
    F [1] = 1;
    int length = F.Length;

    for (int i = 2; i < length; i++)
    {
        F [i] = F [i - 1] + F [i - 2];
    }
    return F;
}


System.Console.WriteLine("Введите размерность массива: ");
int N = int.Parse(Console.ReadLine());

int [] result = Fib (N);

var result_2 = string.Join (" ", result);
System.Console.WriteLine(result_2);

