

int randomNumber = 54300067;  // new Random().Next(1, 10000000);
Console.WriteLine($"Рандомное число {randomNumber}");
int number = 0;
while ((randomNumber / 10) > 0)
{
    number = number*10 + (randomNumber % 10);
    randomNumber = randomNumber/10;
}
number = number*10 + randomNumber;
Console.WriteLine(number);



// ввести переменну count

// int count = 0; // Сколько цифр (знаков) в нашем числе
// while (num != 0) 
    //{
      //  num = num / 10; // Высчитываем количество знаков
      //  count++;
   // }