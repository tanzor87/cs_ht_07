// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.

int IntNumber(string message = "")
{
    if (message == "")
    {
        Console.WriteLine("Введите целое число: ");
    } 
    else
    {
        Console.WriteLine(message);
    }
    
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void ShowList(int numStart, int numEnd)
{
    if (numEnd == numStart - 1)
    {
        return;
    }
    ShowList(numStart, numEnd - 1);
    Console.Write(numEnd + " ");

}

int numberM = IntNumber("Введите начальное значение: ");
int numberN = IntNumber("Введите конечное значение: ");

ShowList(numberM, numberN);
