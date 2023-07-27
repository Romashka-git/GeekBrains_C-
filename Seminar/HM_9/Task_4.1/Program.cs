// Даны два положительных целых числа, представленных в виде строк. Необходимо получить сумму чисел, которые представлены этими строками. Причем полученная сумма должна быть преобразована в строку.
// Для решения этой задачи запрещено преобразовывать входные строки сразу напрямую в целое число при помощи встроенной функции. Необходимо сделать это самостоятельно.

// Пример 1:
// Входные значения: num1 = "11", num2 = "123"
// Результат: "134"

// Пример 2:
// Входные значения: num1="456", num2 = "77"
// Результат: "533"

// Пример 3:
// Входные значения: num1 = "0", num2 = "0"
// Результат: "0"

string num1 = "11"; 
string num2 = "123";

int ConvertNum (string str)
{
    int countLength = str.Length - 1;
    int result = 0;
    for (int i = 0; i < str.Length; i++)
    {
        if (char.IsNumber(str[i]))
            {
                result = result + (Convert.ToInt32(str[i].ToString()) * Convert.ToInt32(Math.Pow(10, countLength)));
                countLength--;
            }
    }
    return result;
}

string Summ (int a, int b)
{
    return Convert.ToString(a + b);
}

int number1 = ConvertNum(num1);
int number2 = ConvertNum(num2);

string resultSumm = Summ(number1, number2);
System.Console.WriteLine(resultSumm);
