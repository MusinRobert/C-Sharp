// Напишите программу, которая принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int GetNumber(string message)
{
    Console.Write($"Введите координаты точки {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int numX1 = GetNumber("X1");
int numY1 = GetNumber("Y1");
int numX2 = GetNumber("X2");
int numY2 = GetNumber("Y2");

System.Console.WriteLine($"Первая точка: X1 = {numX1}; Y1 = {numY1}");
System.Console.WriteLine($"Вторая точка: X2 = {numX2}; Y2 = {numY2}");

int numX = numX2 - numX1;
int numY = numY2 - numY1;

double dist = Math.Sqrt(Math.Pow(numX, 2) + Math.Pow(numY, 2));

System.Console.WriteLine($"Расстояние между точками = {Math.Round(dist, 2)}");