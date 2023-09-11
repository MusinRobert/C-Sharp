// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 452 -> 3
// 82 -> 2
// 9012 -> 4

int num = GetNumber("");
int i = 0;
int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}
for ( ; num > 0; num = num/10)
{
    i++;
}
System.Console.WriteLine("Количество цифр в числе " + i);