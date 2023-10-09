// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

string GetNumber(string message)
{
    Console.Write($"{message}: ");
    string num = Console.ReadLine()!;
    return num;
}

int SumNumbers(string num, int counter = 0)
{
    if (counter == num.Length - 1) return int.Parse(num[counter].ToString());
    return int.Parse(num[counter].ToString()) + SumNumbers(num, counter + 1); 
}

Console.WriteLine(SumNumbers(GetNumber("Введите число: ")));