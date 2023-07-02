// Задача 21: Напишите программу, которая принимает 
// на вход координаты двух точек и находит расстояние между ними в 3D пространстве.


int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}
double distance (int x, int y, int z, int x_1, int y_1, int z_1)
{
    double result = Math.Sqrt( Math.Pow((x_1 - x), 2) + Math.Pow((y_1 - y), 2) + Math.Pow((z_1 - z), 2) );
    return result;
}

Console.WriteLine("Введите координаты трех точек,а я найду расстояние между ними в 3D пространстве");
int a = prompt_num("Введите x_1");
int a_1 = prompt_num("Введите x_2");
int b = prompt_num("Введите y_1");
int b_1 = prompt_num("Введите y_2");
int c = prompt_num("Введите z_1");
int c_1 = prompt_num("Введите z_2");

double result = distance(a, a_1, b, b_1, c, c_1);
Console.WriteLine(result);
