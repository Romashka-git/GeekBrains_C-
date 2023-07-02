// Написать программу, что принимает число на ввод и выводит квадрат этого числа

Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());
int result = number * number;
Console.WriteLine($"Квадрат числа {number} равен {result}");