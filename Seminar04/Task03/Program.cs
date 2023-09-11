// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int GetNumber(string message)
{
    System.Console.WriteLine($"Введите число  {message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetFaktorial(int num)
{
    int fakt = 1;

    for (int i = 2; i <= num; i++)
    {
        fakt *= i;
    }
    return fakt;
}
int numA = GetNumber("A");
int fakt = GetFaktorial(numA);
System.Console.WriteLine(fakt);