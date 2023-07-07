// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое* элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Сумма всех цифр / их количество(это количество ваших строк)

int rows = new Random().Next(0, 6);
int columns = new Random().Next(0, 6);

int[,] numbers = new int[rows, columns];

FillArray(numbers);
double[] averages = averageByCol(numbers);
Console.WriteLine("The averages in each respective column of the array: ");
PrintArray(numbers);
Console.WriteLine($"equal {String.Join(", ", averages)}");



//Method to fill the array with numbers
void FillArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
}

//Method for printing an array in the console
void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}


//Method for calculating averages in an array by column
double[] averageByCol(int[,] arr){
    double[] averages = new double[arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(1); i++)
    {
        
        int sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            sum += arr[j, i];
        }
        averages[i] = (double)sum / (double)arr.GetLength(0);
    }
    return averages;
}