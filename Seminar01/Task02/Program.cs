Console.Write("Введите число №1: ");
// string strNum1 = Console.ReadLine();
// int num1 = int.Parse(strNum1);
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число №2: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2 * num2)
{
    Console.WriteLine("a = " + num1 + ", " + "b = " + num2 + " ->" + " первое число является квадратом второго");
}
else
{
    Console.WriteLine("a = " + num1 + ", " + "b = " + num2 + " ->" + " первое число НЕ является квадратом второго");
}
