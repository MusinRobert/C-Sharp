// Задача 45: Напишите программу, которая будет создавать копию
// заданного массива с помощью поэлементного копирования.

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] getNewMas(int[] arr)
{
    int[] array = new int[arr.Length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = arr[i];
    }
    return array;
}

int[] Choto = getRandomArray(10, -100, 100);
Console.WriteLine(string.Join(" ", Choto));
int[] ChotoToto = getNewMas(Choto);
Console.WriteLine(string.Join(" ", ChotoToto));
