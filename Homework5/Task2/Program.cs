// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Please enter the array size: ");

int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];

FillArray(numbers);

int sumOfOddIndexes = GetOddIndexSum(numbers);

Console.WriteLine($"The sum of the elements with odd indexes in the array [{String.Join(", ", numbers)}] equals {sumOfOddIndexes}");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(-100, 100);
    }
}

int GetOddIndexSum(int[] arr)
{
    int sum = 0;

    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }

    return sum;
}