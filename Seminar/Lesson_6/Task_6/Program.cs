// Есть массив. Написать программу, которая скажет какие числа сколько раз повторяются.
// Через dictionary в C#

Dictionary<int, string> dict = new Dictionary<int, string>()
{
    [2] = "Tom",
    [5] = "Bob"
};


var dic_4 = new Dictionary<int, string>(dict);

foreach (var person in dic_4)
{
    Console.WriteLine($"{person.Key} {person.Value}");
}

System.Console.WriteLine();

var dic_5 = new Dictionary<int, string>(dic_4)
{
    [7] = "Roma",
    [9] = "Tom"
};

foreach (var i in dic_5)
{
    Console.WriteLine($"{i.Key} {i.Value}");
}

var name = dic_5.Values.First();
var name_2 = dic_5[2];
System.Console.WriteLine(name);
System.Console.WriteLine(name_2);
var key = dic_5.Keys.First();
System.Console.WriteLine(key);

dic_5[2] = "Dmitriy";
name_2 = dic_5[2];
System.Console.WriteLine(name_2);




int [] list = new int [] { 3, 6, 8, 9, 10, 11, 12, 13, 14, 3, 3, 8, 10, 11, 11, 7, 6};

Dictionary<int, int> nums = new Dictionary<int, int>();

int length = list.Length;
for (int i = 0; i < length; i++)
{
    if ( nums.ContainsKey(list[i]) )
    {
        nums[list[i]] = nums[list[i]] + 1;
    }
    else 
    {
        nums.Add(list[i], 1);
    }
}

foreach (var i in nums)
{
    System.Console.WriteLine($"Key: {i.Key} Value: {i.Value}");
}