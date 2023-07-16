// Задача 52: Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.


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
System.Console.Clear();

for (int i = 0; i < lengthM; i++)
{
    for (int j = 0; j < lengthN; j++)
    {
        System.Console.Write($"{array[i, j]} "); 
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();

List<double> AverageArray = new List<double>();
double average = 0;
int summ = 0;
for (int i = 0; i < lengthN; i++)
{
    for (int j = 0; j < lengthM; j++)
    {
        summ += array[j, i];
        // System.Console.WriteLine(summ);
    }
    average = (double) summ / lengthM;
    AverageArray.Add(average);
    summ = 0;
}

double [] a = AverageArray.ToArray();

for (int i = 0; i < a.Length; i++)
{
    System.Console.WriteLine($"Среднее арифметическое {i + 1} столбца: {a[i]}");
}