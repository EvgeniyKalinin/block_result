string[] GenArray(string[] array) 
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }
    }

    string[] array2 = new string[count];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        
        if (array[i].Length <= 3)
        {
            array2[j] = array[i];
            j++;
        }
    }
    return array2;
}


void PrintArray(string[] array)
{
    
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.Write(array[array.Length - 1] + "]");
    Console.WriteLine();
}


string[] array1 = { "hello", "2", "world", ":-)" };
//string[] array1 = { "1234", "1567", "-2", "computer science" };
//string[] array1 = { "Russia", "Denmark", "Kazan"};

string[] array2 = GenArray(array1);
Console.WriteLine();
Console.WriteLine("Заданый массив:");
PrintArray(array1);
Console.WriteLine();
Console.WriteLine("В массиве " + array2.Length + " элемент(a), длина которых меньше или равна 3 символам:" );
if (array2.Length > 0)
    {
    PrintArray(array2);
    }
Console.WriteLine();



