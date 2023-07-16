// Задача 47: Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
System.Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine());

double [,] array = new double [m, n];
int length_m = array.GetLength(0);
int length_n = array.GetLength(1);

for (int i = 0; i < length_m; i++)
{
    for (int j = 0; j < length_n; j++)
    {
        array[i, j] = Math.Round((new Random().NextDouble() * 100), 2); 
    }
}
System.Console.Clear();

for (int i = 0; i < length_m; i++)
{
    for (int j = 0; j < length_n; j++)
    {
        System.Console.Write($"{array[i, j]} "); 
    }
    System.Console.WriteLine();
}