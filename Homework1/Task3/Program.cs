// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Please enter a number: ");
int number = int.Parse(Console.ReadLine()!);

int excess = number % 2;

if(excess == 0){
    Console.WriteLine($"Number {number} is even.");
} else {
    Console.WriteLine($"Number {number} is odd.");
}