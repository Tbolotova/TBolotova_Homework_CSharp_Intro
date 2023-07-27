// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int number = new Random().Next(1, 10);
Console.WriteLine($"The sequence from N to 0 for number {number}: ");
RecursiveNumbersFromNToZero(number);

//Recursive method to print numbers from n to 0
void RecursiveNumbersFromNToZero(int number){
    if(number == 1){
        Console.WriteLine(number);
    }
    else{
        Console.Write($"{number}, ");
        number--;
        RecursiveNumbersFromNToZero(number);
    }
}