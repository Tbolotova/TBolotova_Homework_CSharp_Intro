// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int M = new Random().Next(1, 5);
int N = new Random().Next(5, 10);

Console.WriteLine($"The sum of numbers between {M} and {N} inclusive equals {RecursiveSumBetween(M, N)}");


int RecursiveSumBetween(int firstNum, int secondNum){
    if(firstNum == secondNum) return firstNum;
    return firstNum + RecursiveSumBetween(firstNum + 1, secondNum);;
}