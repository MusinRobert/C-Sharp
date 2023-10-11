void PrintArray(int[,] matrix)
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

int[,] CreateIncreasingMatrix(int n, int m, int k)
{
    int[,] matrix = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matrix[i, j] = 1 + ((i + j) + (n * i)) * k;
        }
    }
    return matrix;
}

void PrintListAvr(double[] list)
{
    Console.WriteLine($"The averages in columns are:");
    for (int i = 0; i < list.Length; i++)
    {
        Console.Write(String.Format("{0:.00}", list[i]) + "\t");
    }
}

double[] FindAverageInColumns(int[,] matrix)
{
    double average = 0;
    double[] array = new double[matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        average = (double)sum / matrix.GetLength(0);
        array[i] = Math.Round(average, 2);
    }
    return array;
}

int SumNumbers(string num, int counter = 0)
{
    if (counter == num.Length - 1) return int.Parse(num[counter].ToString());
    return int.Parse(num[counter].ToString()) + SumNumbers(num, counter + 1);
}

int SetNumber(string message)
{
    Console.WriteLine($"{message}");
    string strNum = Console.ReadLine();
    int num = 0;

    if (int.TryParse(strNum, out num))
    {
        return num;
    }

    System.Console.WriteLine("неверный формат");
    return SetNumber(message);
}

int GetNumber(string message)
{
    Console.Write($"{message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
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

int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
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

void Remove(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        int temp = matrix[matrix.GetLength(0) - 1, i];
        matrix[matrix.GetLength(0) - 1, i] = matrix[0, i];
        matrix[0, i] = temp;
    }
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
    int[,] res = new int[m, n];
    for (int i = 0; i < n; i++)
        for (int j = 0; j < m; j++)
            res[j, n - i - 1] = array[i, j];
    return res;
}