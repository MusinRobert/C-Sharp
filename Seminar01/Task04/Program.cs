Console.WriteLine("Введите число ");
int num = Convert.ToInt32(Console.ReadLine());
int numNeg = num * -1;
while (numNeg <= num)
{
    Console.Write(numNeg + ", ");
    numNeg++;
}