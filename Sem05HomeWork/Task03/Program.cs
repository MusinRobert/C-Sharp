// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int GetNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine());
    return num;
}

double[] GetRandomArray(int length, double min, double max)
{
    double[] array = new double[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round((new Random().NextDouble() * 100), 2);
    }
    return array;
}

double SearchDif(double[] array)
{
    int size = array.Length;
    double max = array[0];
    double min = array[0];
    for (int i = 1; i < size; i++)
    {
        if (array[i] > max) { max = array[i]; }
        if (array[i] < min) { min = array[i]; }
    }
    double dif = max - min;
    return dif;
}
Console.Clear();
int num = GetNumber("Введите количество элементов в массиве: ");
double[] array = GetRandomArray(num, -20, 20);
Console.WriteLine("[" + string.Join("; ", array) +"]");

double subtraction = Math.Round((SearchDif(array)), 2);
System.Console.WriteLine($"Разница между максимальным и минимальным числом = {subtraction}");