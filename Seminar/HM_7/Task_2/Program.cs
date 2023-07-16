// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


System.Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double [,] array = new double [m, n];
int lengthM = array.GetLength(0);
int lengthN = array.GetLength(1);

for (int i = 0; i < lengthM; i++)
{
    for (int j = 0; j < lengthN; j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble() * 100), 2); 
    }
}
System.Console.Clear();

for (int i = 0; i < lengthM; i++)
{
    for (int j = 0; j < lengthN; j++)
    {
        System.Console.Write($"{array[i, j]} "); 
    }
    System.Console.WriteLine();
}

System.Console.WriteLine("Введите позиции элемента, а я покажу значение элемента в матрице. Номер строки: ");
int userM = int.Parse(Console.ReadLine());

System.Console.WriteLine("Номер столбца: ");
int userN = int.Parse(Console.ReadLine());

System.Console.WriteLine(array[userM - 1, userN - 1]);