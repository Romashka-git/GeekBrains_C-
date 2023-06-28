int [] array = new int [10];


void FillArray (int [] collection)
{
    int n = collection.Length;
    for (int i = 0; i < n; i++)
    {
        collection[i] = new Random().Next(1, 10);
    }
}

void PrintArray (int [] collection_2)
{
    int n_2 = collection_2.Length;
    for (int i = 0; i < n_2; i++)
    {
        System.Console.WriteLine($"{i + 1} элемент массива - {collection_2[i]}");
    }
}

FillArray (array);
PrintArray (array);
int [] a = array;
System.Console.WriteLine(a);
System.Console.WriteLine(array);
System.Console.WriteLine(a[0]);
