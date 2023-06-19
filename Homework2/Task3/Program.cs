// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.(использовать И и ИЛИ)
// 6 -> да
// 7 -> да
// 1 -> нет

bool isWeekDay = false;
int weekDayNum = 0;

while (isWeekDay == false)
{
    Console.Write("Please enter the number of the weekday: ");
    weekDayNum = int.Parse(Console.ReadLine()!);
    if (weekDayNum < 1 || weekDayNum > 7)
    {
        Console.WriteLine($"The number {weekDayNum} is not a number of a weekday.");
    }
    else
    {
        isWeekDay = true;
    }
}

if (weekDayNum == 6 || weekDayNum == 7)
{
    Console.WriteLine($"Day {weekDayNum} of the week is the weekend! :D");
}
else
{
    Console.WriteLine($"Day {weekDayNum} of the week is a weekday. :(");
}