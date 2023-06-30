// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Please enter how many numbers you want to enter: ");
int num = int.Parse(Console.ReadLine()!);
int[] numbers = GetNumbers(num);


Console.WriteLine($"The number of positive numbers in the array {String.Join(", ", numbers)} equals {GetPositiveCount(numbers)}");

int[] GetNumbers(int M)
{
    int[] arr = new int[M];
    Console.Write("Please enter the first number: ");
    for (int i = 0; i < M; i++)
    {
        arr[i] = int.Parse(Console.ReadLine()!);
        Console.Write("Please enter the next number: ");
    }
    return arr;
}

int GetPositiveCount(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        count += item > 0 ? 1 : 0;
    }
    return count;
}