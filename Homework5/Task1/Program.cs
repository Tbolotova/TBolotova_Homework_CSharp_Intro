// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Please enter the array size: ");

int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];

FillArray(numbers);

int numberOfEven = GetEven(numbers);

Console.WriteLine($"The number of even elements in the array [{String.Join(", ", numbers)}] equals {numberOfEven}");


void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
}

int GetEven(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        count += el % 2 == 0 ? 1 : 0;
    }
    return count;
}