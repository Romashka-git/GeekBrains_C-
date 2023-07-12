// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.


System.Console.WriteLine("Введите 1-ую сторону треугольника: ");
int a = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите 2-ую сторону треугольника: ");
int b = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите 3-ю сторону треугольника: ");
int c = int.Parse(Console.ReadLine());

if (a < (b + c) && b < (a + c) && c < (a + b))
{
    System.Console.WriteLine("Треугольник");
}
else System.Console.WriteLine("Не треугольник");

