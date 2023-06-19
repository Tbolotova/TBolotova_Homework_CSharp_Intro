// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Please enter a 5-digit number: ");


//первый способ, через строки
string number = Console.ReadLine()!;

int length = number.Length;

int count = length / 2;

int matchCount = 0;

for (int i = 0; i < count; i++)
{
    if (number[i] == number[length - i - 1])
    {
        matchCount++;
    }
    else
    {
        break;
    }
}

if (matchCount == count)
{
    Console.WriteLine($"The number {number} is a palindrome.");
}
else
{
    Console.WriteLine($"The number {number} is not a palindrome.");
}

//второй способ, через инты

// int number = int.Parse(Console.ReadLine()!);

// //считаем количество цифр
// int numberOfDigits = Convert.ToInt32(Math.Floor(Math.Log10(number) + 1));

// int count = numberOfDigits / 2;

// int matchCount = 0;

// for (int i = 0; i < count; i++)
// {
//     int currentCompareLeft = number / Convert.ToInt32(Math.Pow(10, numberOfDigits - i - 1)) % 10;
//     Console.WriteLine(currentCompareLeft);
//     int currentCompareRight = number / Convert.ToInt32(Math.Pow(10, i)) % 10;
//     Console.WriteLine(currentCompareRight);

//     if(currentCompareLeft == currentCompareRight)
//     {
//         matchCount++;
//     }
//     else
//     {
//         break;
//     }
// }

// if(matchCount == count)
// {
//     Console.WriteLine($"The number {number} is a palindrome.");
// }
// else
// {
//     Console.WriteLine($"The number {number} is not a palindrome.");
// }