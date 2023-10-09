// Задача 55: Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

// int SetNumber(string message)
// {
//     Console.Write($"Enter number {message}: ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     return num;
// }

// int[,] GetMatrix(int rows, int columns, int minValue = 10, int maxValue = 99)
// {
//     int[,] matrix = new int[rows, columns];
//     Random rand = new Random();
//     for (int i = 0; i < rows; i++)
//     {
//         for (int j = 0; j < columns; j++)
//         {
//             matrix[i, j] = rand.Next(minValue, maxValue + 1);
//         }
//     }
//     return matrix;
// }

// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// void PrintMatrixRev(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[j, i]}\t");
//         }
//         Console.WriteLine();
//     }
// }

// Console.Clear();
// int rows = SetNumber("m");
// int columns = SetNumber("n");
// int[,] array = GetMatrix(rows, columns);
// PrintMatrix(array);
// System.Console.WriteLine();
// if (rows == columns)
// {
//     PrintMatrixRev(array);
// }
// else System.Console.WriteLine("Error");

int[,] GetMatrix(int rows = 4, int columns = 4, int min = 0, int max = 10)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            Console.Write($"{matrix[i, l]}\t");
        }
        Console.WriteLine();
    }
}

void Rotate(int[,] matrix)
{

    int[,] res = new int[matrix.GetLength(1), matrix.GetLength(0)];
    if (matrix.GetLength(1) == matrix.GetLength(0))
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                res[i, j] = matrix[j, i];
                res[j, i] = matrix[i, j];
            }
        }
        PrintMatrix(res);
    }
    else
    {
        Console.WriteLine("Матрицу нельзя перевернуть");
    }
}

int[,] matrix = GetMatrix();
PrintMatrix(matrix);
Console.WriteLine();
Rotate(matrix);
