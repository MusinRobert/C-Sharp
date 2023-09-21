// Задача 40: Напишите программу, которая принимает на вход три числа и
// проверяет, может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int GetNumber(string message)
{
    Console.Write($"{message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int a = GetNumber("Введите длину стороны a");
int b = GetNumber("Введите длину стороны b");
int c = GetNumber("Введите длину стороны c");

if (a + b <= c || a + c <= b || b + c <= a)
    Console.WriteLine("Это не треугольник!");
else if (a == b && b == c)
    Console.WriteLine("Это равносторонний треугольник!");
else if (a == b || a == c || b == c)
    Console.WriteLine("Это равнобедренный треугольник!");
else Console.WriteLine("Это треугольник.");