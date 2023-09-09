// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно
// одновременно 7 и 23

System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num % 7 == 0 && num % 23 == 0)
{
    System.Console.WriteLine("Число кратно 7 и 23");
}
else
{
    System.Console.WriteLine("Число не кратно 23 и 7");
}