// Выполнить бинарный поиск в массиве




int prompt_num (string text)
{   
    Console.WriteLine($"{text}");
    return int.Parse(Console.ReadLine());
}


int [] sort (int [] array)
{
    int temp;
    for (int i = 0; i < array.Length - 1; i++) // array.Length - 1 т.к. последнее число в данном массиве уже не с чем будет сравнивать. Сравнение будет во влоенном массиве
    {
        for (int j = i + 1; j < array.Length; j++)
        {
            
            if (array[i] > array[j])
            {
                temp = array[i];
                array [i] = array [j];
                array [j] = temp;
            }
            else
            {
                continue;
            }
        } 
    }
    return array;
}


int find (int [] a, int b)
{
    int start = 0;
    int end = a.Length;
    
    for (int i = 0; i < a.Length; i++)
    {
        int mid = (start + end) / 2;
        if (b > a[mid])
        {
            System.Console.WriteLine("Ищем в правой половине");
            start = mid + 1;
        }
        else if (b < a[mid])
        {
            System.Console.WriteLine("Ищем в левой половине");
            end = mid - 1;
        }
        else if (b == a[mid])
        {
            System.Console.WriteLine("Нашли");
            return 1;
        }
        else
        {
            System.Console.WriteLine("Не нашли");
            return -1;
        }
    }
    return b;
}

int [] Array3 = new int [] { 5, 3, 11, 56, 23, 78, 97 };
int [] result = sort (Array3);

int numUs = prompt_num("Введите искомое число, а я найду его в массиве: ");
for (int b = 0; b < result.Length; b++)
    {
        System.Console.Write($"{result [b]} ");
    }
    System.Console.WriteLine();



int bin = find(result, numUs);

// если вводить число, которого нет - ищет пока не закончится счетчик и else не отрабатывает. Например число 54
// Не понимаю, как побороть