// Задача 38: Задайте массив целых двухзначных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**

Console.Write("Please enter the array size: ");

int size = int.Parse(Console.ReadLine()!);

int[] numbers = new int[size];
FillArray(numbers);

int diffMaxMin = MinMaxDiff(numbers);

Console.WriteLine($"The difference between the max and min elements of the array [{String.Join(", ", numbers)}] equals {diffMaxMin}");

void FillArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(0, 100);
    }
}

int FindMin(int[] arr)
{
    int min = arr[0];
    foreach (int el in arr)
    {
        min = el < min ? el : min;
    }
    return min;
}

int FindMax(int[] arr)
{
    int max = arr[0];
    foreach (int el in arr)
    {
        max = el > max ? el : max;
    }
    return max;
}


int MinMaxDiff(int[] arr)
{
    int diff = FindMax(arr) - FindMin(arr);
    return diff;
}