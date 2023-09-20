// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int GetNumber(string message)
{
    Console.Write($"{message}");
    int num = int.Parse(Console.ReadLine());
    return num;
} 

int[] GetRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int SumNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; )
    {
        sum += array[i];
        i+=2;
    }
    return sum;
   
}

Console.Clear();
int num = GetNumber("Введите количество элементов в массиве: ");
int[] array = GetRandomArray(num, -20, 20);
Console.WriteLine(string.Join(", ", array));

int result = SumNumbers(array);
System.Console.WriteLine($"Сумма элементов на нечетных позициях = {result}");