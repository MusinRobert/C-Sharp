// Задача 63: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от 1 до N.
// N = 5 -> "1, 2, 3, 4, 5"
// N = 6 -> "1, 2, 3, 4, 5, 6"

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

string PrintNumbers(int start, int stop)
{
    if (start == stop)
    {
        return Convert.ToString(start);
    }
    string str = Convert.ToString(start) + " " + PrintNumbers(start + 1, stop);
    return str;
}

int start = 1;
int stop = SetNumber("Введите число N: ");

Console.WriteLine(PrintNumbers(start, stop));