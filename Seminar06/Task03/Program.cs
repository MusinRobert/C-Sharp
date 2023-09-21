// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

int GetNumber(string message)
{
    Console.Write($"Введите число {message}: ");
    int num = int.Parse(Console.ReadLine());
    return num;
}

int[] DecimalToBinary(int number)
{
    int[] array = new int[32];
    for (int i = 0; number != 0; i++)
    {
        array[array.Length - 1 - i] = number % 2;
        number = number / 2;
    }
    return array;
}

int num = GetNumber("Для перевода в десятичную систему"); 
int[] array = DecimalToBinary(num); 
Console.WriteLine(string.Join(" ", array));
