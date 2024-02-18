// Функция печатает массив
void PrintArray(string[] array)
{
    Console.WriteLine($"[{string.Join(", ", array)}]");
}

// Функция возвращает новый массив в котором элементы с количеством знаков меньше или равно трем 
string[] FilterArray(string[] array)
{
    int arrayLength = array.Length;
    int n = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i].Length <= 3)
        {
            n += 1;
        }
    }
    string[] resultArray = new string[n];
    int i2 = 0;
    for (int i = 0; i < arrayLength; i++)
    {
        if (array[i].Length <= 3)
        {
            resultArray[i2] = array[i];
            i2 += 1;
        }
    }

    return resultArray;
}


string[] newArray = { "Hello", "world" };
PrintArray(newArray);
PrintArray(FilterArray(newArray));

