// Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе
// число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

System.Console.Write("Введите певое число больше  1: ");
int firstNum = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите второе число больше 1: ");
int secondNum = Convert.ToInt32(Console.ReadLine());

int result1 = firstNum % secondNum;
int result2 = secondNum % firstNum;

if (firstNum >= secondNum)
{
    if (result1 == 0)
    {
        System.Console.WriteLine("первое число кратно второму");
    }
    else
    {
        System.Console.WriteLine("первое число НЕ кратно второму, остаток " + result1);
    }
}
else
{
    if (result2 == 0)
    {
        System.Console.WriteLine("второе число кратно первому");
    }
    else
    {
        System.Console.WriteLine("второе число НЕ кратно первому, остаток " + result2);
    }
}