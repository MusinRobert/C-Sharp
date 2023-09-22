// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Start();

void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("41) Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        System.Console.WriteLine("43) Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями: y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        System.Console.WriteLine("0) End");

        int numTask = SetNumber("task");

        switch (numTask)
        {
            case 0: return; break;

            case 41:
                Console.Clear();
                Console.Write("Введите несколько чисел через пробел: ");
                int[] numbers = Console.ReadLine()!.Split().Select(x => int.Parse(x)).ToArray();
                System.Console.WriteLine(string.Join(", ", numbers));
                System.Console.WriteLine($"Количество чисел больше нуля = {positiveNumbers(numbers)}");
                break;

            case 43:
                Console.Clear();
                double pointB1 = GetNumber("Введите точку b1");
                double pointK1 = GetNumber("Введите точку k1");
                double pointB2 = GetNumber("Введите точку b2");
                double pointK2 = GetNumber("Введите точку k2");

                if (pointK1 == pointK2 && pointB1 == pointB2) { Console.WriteLine("Это один и тот же график"); }
                if (pointK1 == 0 && pointK2 == 0) { Console.WriteLine("Графики не пересекаются"); }
                else
                    Console.WriteLine($"Графики линейных функций пересекаются в точке ({(string.Join("; ", GetCrossPoint(pointB1, pointK1, pointB2, pointK2)))})");
                break;

            default: System.Console.WriteLine("error"); break;
        }
    }
}

int positiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}

int SetNumber(string numberName)
{
    Console.Write($"Enter number {numberName}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

double[] GetCrossPoint(double b1, double k1, double b2, double k2)
{
    double[] crossPoint = new double[2];
    crossPoint[0] = Math.Round(((b2 - b1) / (k1 - k2)), 1);
    crossPoint[1] = Math.Round(((k1 * crossPoint[0] + b1)), 1);
    return crossPoint;
}

int GetNumber(string message)
{
    Console.Write($"{message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}