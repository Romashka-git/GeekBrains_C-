// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}

void ifDays (int arg)
{
    if (arg == 7 || arg == 6)
    {
        Console.WriteLine("Этот день выходной. Ура");
    }
    else if (arg < 0 || arg > 7)
    {
        Console.WriteLine("День недели от 1 до 7");
    }
    else if (!(arg is int)) //не работает - не понимаю, как это сделать
    {
        Console.WriteLine("Это не число");
    }
    else
    {
        Console.WriteLine("Этот день - будний день");
    } 
}


int n = 7; 
int i;
int [] days = new int [n];
for (i = 0; i < 7; i++)
{
    days[i] = i + 1;
}

int numUs = prompt_num("Введите номер дня недели, а я назову, является ли этот день выходным");
ifDays(numUs);

