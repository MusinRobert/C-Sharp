/*
Задача 64: Задайте значение N. 
Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

int SetNumber(string message)
{
    Console.WriteLine($"{message}");
    string strNum = Console.ReadLine();
    int num = 0;

    if (int.TryParse(strNum, out num))
    {
        return num;
    }

    System.Console.WriteLine("неверный формат");
    return SetNumber(message);
}

string PrintNumbers(int start, int stop = 1)
{
    if (start == stop)
    {
        return Convert.ToString(start);
    }
    return $"{start}, {PrintNumbers(start - 1, stop)}";
}

int SumNumbers(int start, int stop)
{
    if (stop == start)
    {
        return start;
    }
    return start + SumNumbers(start + 1, stop);
}

long Ackermann(long m, long n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return Ackermann(m - 1, 1);
    }
    else
    {
        return Ackermann(m - 1, Ackermann(m, n - 1));
    }
}

// Console.Clear();
// int start = SetNumber("Введите число N: ");
// Console.WriteLine(PrintNumbers(start));

/*
Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/

// Console.Clear();
// int start = SetNumber("Введите число M: ");
// int stop = SetNumber("Введите число N, которое больше M: ");
// Console.WriteLine($"M = {start}; N = {stop} сумма от M до N = {SumNumbers(start, stop)}");

/*
Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

Console.Clear();
int M = SetNumber("Введите число M: ");
int N = SetNumber("Введите число N: ");
Console.WriteLine(Ackermann(M, N));