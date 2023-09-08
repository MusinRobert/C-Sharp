// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter first number: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int secondNum = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int thirdNum = Convert.ToInt32(Console.ReadLine());

int max = firstNum;
if (secondNum > max)
{
    max = secondNum;
    if (thirdNum > max)
    {
        max = thirdNum;
    }
else if (thirdNum > max)
    {
        max = thirdNum;
    }    
}
Console.WriteLine("max = " + max);