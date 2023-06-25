// Написать программу, что принимает число на ввод и выводит квадрат этого числа

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

if (number <= 10)
{
    Console.WriteLine("Надо было больше 10");
}
else
{
    int result = number * number;
    Console.WriteLine($"Квадрат числа {number} равен {result}");   
}
