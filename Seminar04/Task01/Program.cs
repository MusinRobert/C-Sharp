// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; i++)
    {
        sum+= i; //sum = sum +1
    }
    return sum;
}
int numA = GetNumber("A");
int sum = GetSum(numA);
System.Console.WriteLine($" sum = {sum}");

