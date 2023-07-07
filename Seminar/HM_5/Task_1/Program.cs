// Задача 34: Задайте массив заполненный случайными положительными 
// трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


int [] array = new int [10]; 

int [] random_array (int [] a)
{
    int length = a.Length;
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(100, 1000);
    }
    return a;
}

void print_parity (int [] a)
{
    int length = a.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (a[i] % 2 == 0) count++;
        else continue;
    }
    System.Console.WriteLine($"Количесвто четных элементов в массиве: {count}");
}


int [] newArray = random_array(array);

var str = string.Join (", ", newArray);
System.Console.WriteLine(str);
print_parity (newArray);

