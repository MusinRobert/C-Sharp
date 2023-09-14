
// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 12 10

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

int[] schet(int[] array)
{
    int size = array.Length / 2; // size = 2
    if (array.Length % 2 == 1)
    {
        size++;  // size = 3
    }
    int[] sqrArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        sqrArray[i] = array[i] * array[array.Length - 1 - i];
    }
    if (array.Length % 2 == 1)
    {
        sqrArray[size - 1] = array[size - 1];
    }
    return sqrArray;
}

int[] array = getRandomArray(5, 0, 9);

Console.WriteLine(string.Join(", ", array));

int[] sqrArray = schet(array);

Console.WriteLine(string.Join(", ", sqrArray));