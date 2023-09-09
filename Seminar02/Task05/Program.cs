// Напишите программу, которая принимает на вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

System.Console.Write("Введите певое число  : ");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число : ");
int secondNum = Convert.ToInt32(Console.ReadLine());

if (firstNum == secondNum * secondNum || secondNum == firstNum * firstNum)
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}