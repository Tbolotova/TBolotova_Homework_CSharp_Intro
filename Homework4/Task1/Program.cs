// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Write("Please enter number A: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Please enter number B: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.WriteLine($"Number {firstNumber} to power {secondNumber} equals {ToPow(firstNumber, secondNumber)}");

int ToPow(int a, int b)
{
    int result = a;
    for (int i = 2; i <= b; i++)
    {
        result = result * a;
    }

    return result;
}