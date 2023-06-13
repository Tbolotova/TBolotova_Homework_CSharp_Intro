// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Максимум 100000)
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int number = new Random().Next(0, 100000);

//получаем число разрядов в числе
int numberOfDigits = Convert.ToInt32(Math.Floor(Math.Log10(number) + 1));

if (numberOfDigits < 3)
{
    Console.WriteLine($"The number {number} has less than 3 digits.");
}
else
{
    //определяем, на что нужно поделить, чтобы получить трехзначное число
    int divider = Convert.ToInt32(Math.Pow(10, (numberOfDigits - 3)));
    int thirdDigit = number / divider % 10;
    Console.WriteLine($"The third digit in {number} is {thirdDigit}.");
}