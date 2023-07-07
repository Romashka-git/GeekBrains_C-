// Задача 36: Задайте одномерный массив, 
// заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int [] array = new int [5]; 

int [] random_array (int [] a)
{
    int length = a.Length;
    for (int i = 0; i < length; i++)
    {
        a[i] = new Random().Next(-5, 10);
    }
    return a;
}


int summUnParity (int [] a)
{
    int length = a.Length;
    int summ = 0;

    for (int i = 0; i < length; i++)
    {
        if (i % 2 != 0) summ += a[i];
        else continue;
    }
    return summ;
}


int [] newArray = random_array(array);

var str = string.Join (", ", newArray);
System.Console.WriteLine(str);

int summ_result = summUnParity(newArray);
System.Console.WriteLine($"Сумма чисел на нечетных позициях: {summ_result}");

