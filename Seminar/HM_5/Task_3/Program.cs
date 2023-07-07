// Задача 38: Задайте массив вещественных чисел. 
//    Найдите разницу между максимальным и минимальным элементов массива.
 

double [] random_array (double [] a)
{
    int length = a.Length;
    for (int i = 0; i < length; i++)
    {
        a[i] = Math.Round(((new Random().NextDouble()) * 10), 2);
    }
    return a;
}

double diff (double [] a)
{
    double min = 0;
    double max = 0;
    double result;
    int length = a.Length;

    if (a[0] > a[1]) 
    {
        max = a[0];
        min = a[1];
    }
    else 
    {
        max = a[1];
        min = a[0];
    }
    

    for (int i = 2; i < length; i++)
    {
        if (a[i] > min)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
            else continue;
        }
        else min = a[i];
    }
    System.Console.WriteLine($"Минимальное число в массиве: {min}");
    System.Console.WriteLine($"Максимальное число в массиве: {max}");
    result = Math.Round((max - min), 2);
    return result;
}

double [] array = new double [5];
double [] newArray = random_array(array);

var str = string.Join (", ", newArray);
System.Console.WriteLine(str);

double ArrayDif = diff(newArray);
System.Console.WriteLine($"Разница между максимальным и минимальным числами массива: {ArrayDif}");