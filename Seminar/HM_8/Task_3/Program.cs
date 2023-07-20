// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.

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

int[,] MatrixMultiply(int[,] a, int[,] b)
    {       
 
        var matrixC = new int[a.GetLength(0), b.GetLength(1)];
 
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < b.GetLength(1); j++)
            {
                matrixC[i, j] = 0;
 
                for (int k = 0; k < a.GetLength(1); k++)
                {
                    matrixC[i, j] += a[i, k] * b[k, j];
                }
            }
        }
 
        return matrixC;
    }

System.Console.WriteLine("Введите размерность 1-ой матрицы: ");
int [,] matrixA = GetRandomArray();

System.Console.WriteLine("Введите размерность 2-ой матрицы: ");
int [,] matrixB = GetRandomArray();
int [,] resultMatrix = MatrixMultiply(matrixA, matrixB);

System.Console.WriteLine($"Результат умножения матриц: ");
PrintArray(resultMatrix);

