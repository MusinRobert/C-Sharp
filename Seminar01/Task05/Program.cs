Console.WriteLine("Enter a number ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > 99 && num < 1000)
{
    int result = num % 10;
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("incorrect number!");
}