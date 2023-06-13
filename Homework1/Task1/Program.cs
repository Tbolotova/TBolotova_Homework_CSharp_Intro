// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

//Я прочла условие и примеры, и у меня что-то не совпало) В условии написано, что нужно выдать, 
//какое больше и какое меньше. В примерах только максимум указан. Сделала по условию

Console.Write("Please enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

if(firstNumber > secondNumber)
{
    Console.WriteLine($"Number {firstNumber} is greater than number {secondNumber}");
}
else if(firstNumber < secondNumber)
{
    Console.WriteLine($"Number {secondNumber} is greater than number {firstNumber}");
}
else
{
    Console.WriteLine($"The numbers you entered are equal");
}