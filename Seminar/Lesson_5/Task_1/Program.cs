// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, 
// и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 


int [] a = new int [4] { -4, -8, 8, 2 };


void sort (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = -array[i];
        System.Console.WriteLine(array[i]);
    }
}

sort (a);