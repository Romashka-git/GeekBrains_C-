// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да




bool search (int [] array, int num)
{
    bool n = false;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            n = true;
            return n;
        }
    }
    return n;
}


int [] a = new int [] { 6, 7, 19, 345, 3 };

int numUs = int.Parse(Console.ReadLine());
var result = search(a, numUs);
System.Console.WriteLine(result);