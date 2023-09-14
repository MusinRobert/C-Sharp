// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива. Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
// положительных чисел равна 29, сумма отрицательных равна -20.

int[] getRandomArray(int length, int min, int max)
{
    int[] array = new int[length];

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
int minSum = 0;
int maxSum = 0;
int sumElements(int[] array)
{
    int size = array.Length; 
    
    for (int i = 0; i < size; i++)
    {
        if (array[i] < 0)
        {
            minSum = minSum + array[i];
        }
        if (array[i] > 0)
        {
            maxSum = maxSum + array[i];
        }
    }   
    return minSum; 
    return maxSum;        
}

int[] array = getRandomArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));

int result = sumElements(array);
Console.WriteLine($"сумма положительных чисел = {minSum}");
Console.WriteLine($"сумма положительных чисел = {maxSum}");