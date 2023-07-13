// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользовател


string N = "q"; // символ для выхода из цикла
string usN = String.Empty; // оператор выхода из цикла
int numUs = 0;
List<int> nums = new List<int>();
int count = 0;
int count0 = 0;

System.Console.WriteLine("Введите числа, а я посчитаю, сколько числе больше 0");

while (N != usN)
{
    System.Console.WriteLine($"Введите {count + 1} число: ");
    numUs = int.Parse(Console.ReadLine());
    if ( numUs > 0) count0++;
    nums.Add(numUs);
    count++;
    System.Console.WriteLine("Введите 'q', если хотите выйти или любой другой символ, чтобы продолжить");
    usN = Console.ReadLine().ToLower();
}

string result = string.Join(" ", nums.ToArray());
System.Console.WriteLine(result);
System.Console.WriteLine($"Количество чисел больше нуля: {count0}");


