// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int [,] GetRandomArray ()
{
    System.Console.WriteLine("Введите количество строк: ");
    int m = int.Parse(Console.ReadLine());

    System.Console.WriteLine("Введите количество столбцов: ");
    int n = int.Parse(Console.ReadLine());

    int [,] array = new int [m, n];
    int lengthM = array.GetLength(0);
    int lengthN = array.GetLength(1);
    for (int i = 0; i < lengthM; i++)
    {
        for (int j = 0; j < lengthN; j++)
        {
            array[i, j] = new Random().Next(0, 11); 
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    int lengthM = array.GetLength(0);
    int lengthN = array.GetLength(1);
    for (int i = 0; i < lengthM; i++)
    {
        for (int j = 0; j < lengthN; j++)
        {
            System.Console.Write($"{array[i, j]} "); 
        }
        System.Console.WriteLine();
    }
}

int [,] SortArray (int [,] array) // Сортировка пузырьком
{
    int lengthM = array.GetLength(0);
    int lengthN = array.GetLength(1);
    int min;
    for (int i = 0; i < lengthM; i ++)
    {
        for (int j = 0; j < lengthN; j++)
        {
            int tmp;
            for (int k = 0; k < lengthN - 1; k ++)
            {
                if (array [i, k] > array [i, k + 1])
                {
                    tmp = array [i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = tmp;
                }
            }
        }

    }
    return array;
}

var a = GetRandomArray();
PrintArray(a);
System.Console.WriteLine();

PrintArray(SortArray(a));

