// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.


int[] CreateArray(string message = "Введите числа массива через запятую")
{
    Console.WriteLine(message);
    string input = Console.ReadLine();
    string[] arrayString = input.Split(",");
    int[] array = new int[arrayString.Length];
    for (int i = 0; i < arrayString.Length; i++)
    {
        array[i] = Convert.ToInt32(arrayString[i]);
    }
    return array;
}

void PrintArray(int[] array)
{
    Console.WriteLine($"[{String.Join(" ", array)}]");
}

void ReverseArrey(int[] array, int start = 0)
{
    int end = array.Length - 1 - start;
    if (start >= end)
    {
        return;
    }
    int temp = array[start];
    array[start] = array[end];
    array[end] = temp; 
    ReverseArrey(array, start + 1);
}


int[] newArray = CreateArray();
PrintArray(newArray);
ReverseArrey(newArray);
PrintArray(newArray);
