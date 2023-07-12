

int [,] GetMatrix (int a, int b)
{

    int [,] Matrix = new int [a, b];

    for (int i = 0; i < Matrix.GetLength(0); i++)
    {
        for (int j = 0; j < Matrix.GetLength(1); j++)
        {
            // Console.Write($"{Matrix [i, j]}");
            Matrix [i, j] = new Random().Next(0, 11);
        }
        
    }
    return Matrix;
}

void PrintMatrix (int [,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($"{matr [i, j]} ");
        }
        System.Console.WriteLine();
    }
}



System.Console.WriteLine("Введите количество строк в матрице: ");
int GetNum_1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов в матрице: ");
int GetNum_2 = int.Parse(Console.ReadLine());


int [,] result = GetMatrix (GetNum_1 , GetNum_2);
PrintMatrix (result);
System.Console.WriteLine(result [2, 4]);