// Задача 43. Напишите программу, которая найдёт 
// точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.

List<double> Func (double b1, double k1, double b2, double k2)
{
    List <double> f = new List<double>();
    double x = Math.Round((-b2 + b1)/(-k1 + k2), 2);
    double y = Math.Round((k2 * x + b2), 2);
    f.Add(x);
    f.Add(y);
    return f;
}
System.Console.WriteLine("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());

System.Console.WriteLine("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());

System.Console.Clear();

double [] result = Func(b1, k1, b2, k2).ToArray();

string print = string.Join(" ", result);
System.Console.WriteLine(print);



// for (int i = 0; i < result.Length; i++)
// {
//     System.Console.WriteLine($"{result[i]}");
// }

