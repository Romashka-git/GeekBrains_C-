// Задача 55: Задайте двумерный массив. 
// Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.


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

int [,] RemixArray (int [,] array)
{
    int tmpNum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
    {
        tmpNum = array[0, i];
        array[0, i] = array[array.GetLength(0) - 1, i];
        array[array.GetLength(0) - 1, i] = tmpNum;
    }
    return array;
}



int [,] Array = GetRandomArray();
PrintArray(Array);
System.Console.WriteLine();
Array = RemixArray(Array);
PrintArray(Array);
System.Console.WriteLine();

var tmpElement = 0;
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < i; j++)
    {
        tmpElement = Array[i, j];
        Array [i, j] = Array [j, i];
        Array [j, i] = tmpElement;
    }
}

PrintArray(Array);