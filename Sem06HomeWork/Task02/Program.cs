// int GetNumber(string message)
// {
//     Console.Write($"{message}: ");
//     int num = int.Parse(Console.ReadLine()!);
//     return num;
// }

// double[] GetCrossPoint(double b1, double k1, double b2, double k2)
// {
//     double[] crossPoint = new double[2];
//     crossPoint[0] = Math.Round(((b2 - b1) / (k1 - k2)), 1);
//     crossPoint[1] = Math.Round(((k1 * crossPoint[0] + b1)), 1);
//     return crossPoint;
// }

// Console.Clear();
// double pointB1 = GetNumber("Введите точку b1");
// double pointK1 = GetNumber("Введите точку k1");
// double pointB2 = GetNumber("Введите точку b2");
// double pointK2 = GetNumber("Введите точку k2");

// if (pointK1 == pointK2 && pointB1 == pointB2) {Console.WriteLine("Это один и тот же график");}
// if (pointK1 == 0 && pointK2 == 0) {Console.WriteLine("Графики не пересекаются");}
// else
//     Console.WriteLine($"Графики линейных функций пересекаются в точке {(string.Join("; ", GetCrossPoint(pointB1, pointK1, pointB2, pointK2)))}");

Console.Write("Введите несколько чисел через пробел: ");
int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
System.Console.WriteLine(string.Join(", ", numbers));
System.Console.WriteLine($"Количество положительных чисел = {positiveNumbers(numbers)}");

int positiveNumbers (int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}