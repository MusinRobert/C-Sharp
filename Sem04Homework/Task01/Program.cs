// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int GetNumber(string message)
{
    System.Console.Write($"Введите  {message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetDegNum(int num, int deg)
{
    int res = 1;
    for (int i = 0; i < deg; i++)
    {
       res *= num;
    }
    return res;
}

int numA = GetNumber("число A: ");
int numB = GetNumber("степень числа: ");
int result = GetDegNum(numA, numB);
System.Console.WriteLine($"{numA} в степени {numB} = {result}");