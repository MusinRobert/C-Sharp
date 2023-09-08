Console.WriteLine("Введите номер дня недели");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if(dayNumber == 1)
{
    Console.WriteLine(dayNumber + " день недели - это Понедельник");
}
else if (dayNumber == 2)
{
    Console.WriteLine(dayNumber + " день недели - это Вторник");
}
else if (dayNumber == 3)
{
    Console.WriteLine(dayNumber + " день недели - это Среда");
}
else if (dayNumber == 4)
{
    Console.WriteLine(dayNumber + " день недели - это Четверг");
}
else if (dayNumber == 5)
{
    Console.WriteLine(dayNumber + " день недели - это Пятница");
}
else if (dayNumber == 6)
{
    Console.WriteLine(dayNumber + " день недели - это Суббота");
}
else if (dayNumber == 7)
{
    Console.WriteLine(dayNumber + " день недели - это Воскресенье");
}
else
{
    Console.WriteLine("Дней в неделе всего семь");
}