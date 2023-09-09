// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую
// цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Random rand = new Random(); // Объявляем переменную rand класса random
int num = rand.Next(100, 1000);
System.Console.WriteLine(num);

int num1 = num / 100;
int num2 = num % 10;
num1 = num1 * 10 + num2;
System.Console.WriteLine(num1);
