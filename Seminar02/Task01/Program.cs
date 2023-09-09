//  Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

Random rand = new Random(); // Объявляем переменную rand класса random
int num = rand.Next(10, 100);
//24
int num1 = num / 10; //2
int num2 = num % 10;

System.Console.WriteLine(num);

if (num1 > num2)
{
    Console.WriteLine(num1);
}
else
{
    Console.WriteLine(num2);
}