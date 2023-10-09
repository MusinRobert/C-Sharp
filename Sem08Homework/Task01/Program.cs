/*
Задача 54: Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int GetNumber(string message)
{
    Console.Write($"{message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 9)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}

int[,,] GetCubeArray(int rows, int columns, int layers, int minValue = 10, int maxValue = 99)
{
    int[,,] cube = new int[rows, columns, layers];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < layers; k++)
            {
                cube[i, j, k] = rand.Next(minValue, maxValue + 1);
            }
        }
    }
    return cube;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void PrintCubeArray(int[,,] cube)
{
    for (int k = 0; k < cube.GetLength(2); k++)
    {
        for (int i = 0; i < cube.GetLength(0); i++)
        {
            for (int j = 0; j < cube.GetLength(1); j++)
            {
                Console.Write($"{cube[i, j, k]}({i},{j},{k})\t");
                // Console.Write($"{cube[i, j, k]}\t"); // Если нужен трехмерный массив без индексов
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

int[,] SortLines(int[,] matrix)
{
    int m = matrix.GetLength(0);
    int n = matrix.GetLength(1);
    for (int l = 0; l < matrix.GetLength(1); l++)
    {
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n - 1; j++)
            {
                if (matrix[i, j] > matrix[i, j + 1])
                {
                    int temp = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = temp;
                }
            }
        }
    }
    return matrix;
}

int[] SumLineMatrix(int[,] matrix)
{
    int[] array = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        array[i] = sum;
    }
    return array;
}

int MinValueArray(int[] array)
{
    int result = array[0];
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (result > array[i])
        {
            result = array[i];
            index = i;
        }
    }
    return index;
}

int[,] RotateArray(int[,] array)
{
    int n = array.GetLength(0), m = array.GetLength(1);
    int[,] res = new int[m,n];
    for(int i = 0; i<n;i++)
        for (int j = 0; j < m; j++)
            res[j, n - i - 1] = array[i, j];
    return res;
}

// Console.Clear();
// int rows = GetNumber("m");
// int columns = GetNumber("n");
// int[,] array = GetMatrix(rows, columns);
// PrintMatrix(array);
// System.Console.WriteLine();
// int[,] sortMatrix = SortLines(array);
// PrintMatrix(sortMatrix);

/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов. 
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
*/

// Console.Clear();
// int rows = GetNumber("m");
// int columns = GetNumber("n");
// int[,] array = GetMatrix(rows, columns);
// PrintMatrix(array);
// System.Console.WriteLine();
// int[] arr = SumLineMatrix(array);
// // System.Console.WriteLine(string.Join(", ", arr)); // Проверочно выводит суммы элементов по строкам
// int index = MinValueArray(arr);
// Console.WriteLine($"Наименьшая сумма элементов находится в {index + 1} строке");

/*
Задача 60. ...Сформируйте трёхмерный массив . Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/


// Console.Clear();
// int rows = GetNumber("l");
// int columns = GetNumber("m");
// int layers = GetNumber("n");
// int[,,] cubeArray = GetCubeArray(rows, columns, layers);
// PrintCubeArray(cubeArray);

/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
1  2  3  4
12 13 14 5
11 16 15 6
10  9  8 7
*/

