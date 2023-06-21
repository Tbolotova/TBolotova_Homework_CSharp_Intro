// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Please enter a number: ");

string numberString = Console.ReadLine()!;

int length = numberString.Length;

Console.WriteLine($"The sum of the digits of {numberString} equals {SumOfDigits(numberString, length)}");

int SumOfDigits(string numberString, int length)
{
    int sum = 0;
    for (int i = 0; i < length; i++)
    {
        sum += Convert.ToInt32(Char.GetNumericValue(numberString[i]));
    }

    return sum;
}