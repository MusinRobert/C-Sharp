// Задача 30: Напишите программу, которая выводит массив из 8 элементов, 
// заполненный нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// int[] arr = new int [8];

// void PrintArray(int[] array)
// {
//     int count = array.Length;
//     for (int i = 0; i < count; i++)
//     {
//         System.Console.Write($"{array[i]}");
//     }
//     System.Console.WriteLine();
// }
// int[] GetRandom(int size)
// {
// int[] array = new int [size];
// Random Rand = new Random();
// for (int i = 0; i < size; i++)
// {
//     array [i] = Rand.Next(0,2);
// }
// return array;
// }
// PrintArray(GetRandom(8));

int[] FillArray(int size, int min = 0, int max = 1)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine(arr[i]);
    }
}

int[] arr = FillArray(8, 10, 100);
PrintArray(arr);