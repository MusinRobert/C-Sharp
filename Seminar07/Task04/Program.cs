// Задача 51: Задайте двумерный массив. Найдите сумму
// элементов, находящихся на главной диагонали (с индексами
// (0,0); (1;1) и т.д. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int SetNumber(string message)
{
    System.Console.Write($"Enter number {message}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int[,] GetMatrix(int rows, int columns, int minValue = 1, int maxValue = 100)
{
    int[,] matrix = new int[rows, columns];
    Random rand = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int l = 0; l < columns; l++)
        {
            matrix[i, l] = rand.Next(minValue, maxValue + 1);
        }
    }
    return matrix;
}
int GetSumMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (i == l) sum += matrix[i, l];
        }
    }
    return sum;
}
void PrintMatrix(int[,] matrix)
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int l = 0; l < matrix.GetLength(1); l++)
        {
            if (i == l)
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.Write($"{matrix[i, l]} ");
        }
        Console.WriteLine();
    }
}
int rows = SetNumber("m");
int columns = SetNumber("n");
int[,] matrix = GetMatrix(rows, columns, 1, 9);
PrintMatrix(matrix);
Console.WriteLine();
int sum = GetSumMatrix(matrix);
Console.WriteLine(sum);