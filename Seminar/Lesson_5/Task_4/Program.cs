// Задача 37: Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21




int size = int.Parse(Console.ReadLine());
int size_b = 0;
if (size % 2 == 0)
{
    size_b = size / 2;
}
else
{
    size_b = (size / 2) + 1;
}

int [] a = new int [size];
int [] b = new int [size_b];

for (int i = 0; i < size; i++)
{
    a [i] = i + 1;
}

for (int i = 0; i < size / 2; i++)
{
    b [i] = a[i] * a [size -1 - i];
}
if (size % 2 != 0) 
{
    b[size_b - 1] = a[size / 2];
}


for (int i = 0; i < b.Length; i++)
{
    System.Console.WriteLine(b[i]);
}



