// Задача 2: Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.

int Ackermann(int n, int m)
{
    if (n == 0)
    {
        return m + 1;
    }
    else if  (m == 0)
    {
        return Ackermann(n - 1, 1);
    }
    else 
    {
        return Ackermann(n-1, Ackermann(n, m - 1));
    }
}

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

int numberN = IntNumber();
int numberM = IntNumber();

Console.WriteLine($"Функция Аккермана при n = {numberN} и m = {numberM} равна: {Ackermann(numberN, numberM)}");

