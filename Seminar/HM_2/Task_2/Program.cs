// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.

int number_user = 2346325;

if (number_user < 100)
{
    Console.WriteLine("Третьей цифры нет");
}

else

{
    int num = number_user;
    int count = 0; // Сколько цифр (знаков) в нашем числе
    int diff; // Переменна, в которую войдет разница между количеством цифр в числе и 3 необходимой фирой (n - 3)
    int del = 1; // Число, из которого получится делитель;
    while (num != 0) 
    {
        num = num / 10; // Высчитываем количество знаков
        count++;
    }

    Console.WriteLine($"Количество цифр в числе: {count}");

    diff = (count - 3); 

    for (int i = 0; i < diff; i++)
    {
        del = del * 10;
    }

    int result = number_user / del % 10;
    Console.WriteLine($"3-я цифра: {result}");
}

