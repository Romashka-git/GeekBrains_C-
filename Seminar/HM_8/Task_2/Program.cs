// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов

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


int MinRow (int [,] array)
{
    int lengthM = array.GetLength(0);
    int lengthN = array.GetLength(1);
    int minRow = 0;
    int summ = 0;
    int minSumm = 0;
    for (int i = 0; i < lengthM; i++)
    {
        for (int j = 0; j < lengthN; j++)
        {
            minSumm = minSumm + array[i, j];
        }
    }
    
    
    for (int i = 0; i < lengthM; i++)
    {
        for (int j = 0; j < lengthN; j++)
        {
            summ = summ + array[i, j];
        }

        if (summ < minSumm)
        {
            minSumm = summ;
            minRow = i + 1;
        }
        summ = 0;
    }
    return minRow;
}

var a = GetRandomArray();
PrintArray(a);
Console.WriteLine();


int row = MinRow(a);
Console.Write($"Строка с наименьшей суммой элементов: {row}");