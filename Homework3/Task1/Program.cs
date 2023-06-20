// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

bool isFiveDigit = false;
string number = null!;

while (isFiveDigit == false)
{
    Console.Write("Please enter a 5-digit number: ");
    number = Console.ReadLine()!;
    if (number.Length == 5)
    {
        isFiveDigit = true;
    }
}

//первый способ, через строки
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

// //второй способ, через инты

// int numberInt = int.Parse(number);

// //считаем количество цифр
// int numberOfDigits = Convert.ToInt32(Math.Floor(Math.Log10(numberInt) + 1));

// int count = numberOfDigits / 2;

// int matchCount = 0;

// for (int i = 0; i < count; i++)
// {
//     //определяем цифры, которые должны совпасть на данной итерации цикла
//     int currentCompareLeft = numberInt / Convert.ToInt32(Math.Pow(10, numberOfDigits - i - 1)) % 10;
//     int currentCompareRight = numberInt / Convert.ToInt32(Math.Pow(10, i)) % 10;

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