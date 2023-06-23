// Задача 4: Напишите программу, которая принимает на вход 
// три числа и выдает максимальное из этих чисел.

int max;
Console.WriteLine("Введите колличество вводимых чисел");
int n = int.Parse(Console.ReadLine());
int[] nums = new int [n];

for (int i = 0; i < n; i++)
{
    Console.WriteLine("Введите число");
    int a = int.Parse(Console.ReadLine());
    nums[i] = a;
}
max = nums[0];
for (int i = 0; i < n; i++)
{
    if (nums[i] > max)
    {
        max = nums[i];
    }
    else 
    {
        max = max;
    }
} 
Console.WriteLine($"Максимальное число {max}");