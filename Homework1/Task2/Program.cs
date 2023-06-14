// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Please enter the first number: ");
int firstNumber = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the second number: ");
int secondNumber = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the third number: ");
int thirdNumber = int.Parse(Console.ReadLine()!);

int max = firstNumber;

if(max < secondNumber){
    max = secondNumber;
}

if(max < thirdNumber){
    max = thirdNumber;
} 

Console.WriteLine($"The max number is {max}");