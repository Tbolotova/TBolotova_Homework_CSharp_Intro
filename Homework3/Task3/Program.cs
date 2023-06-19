// Задача 23
// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

bool isPositive = false;
int number = 0;

while (isPositive == false)
{
    Console.Write("Please enter a positive number: ");
    number = int.Parse(Console.ReadLine()!);
    if (number > 0)
    {
        isPositive = true;
    }
}

for (int i = 1; i <= number; i++)
{
    int iCubic = Convert.ToInt32(Math.Pow(i, 3));
    Console.Write($"{iCubic} ");
}

