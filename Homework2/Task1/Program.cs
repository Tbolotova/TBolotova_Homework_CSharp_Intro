// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. 
// (Проверка на трехзначность при вводе пользователем)
// 456 -> 5
// 782 -> 8
// 918 -> 1

bool isThreeDigit = false;

int number = 0;

//Получаем число и проверяем, является ли оно трехзначным

while(isThreeDigit == false){
    Console.Write("Please enter a three-digit number: ");
    number = int.Parse(Console.ReadLine()!);
    int check = number / 100;

    if(check > 0 && check < 10){
        isThreeDigit = true;
    }
}

int secondDigit = number / 10 % 10;

Console.WriteLine($"The second digit in {number} is {secondDigit}.");

