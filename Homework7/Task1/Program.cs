// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными(тип double) числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Please enter the number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

double[,] array = GetArrayDouble(rows, columns, 0.5, 10);
PrintArray(array);


//Method to fill array
double[,] GetArrayDouble(int m, int n, double minValue, double maxValue){
    double[,] arr = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double temp = new Random().NextDouble() * (maxValue - minValue) + minValue;
            arr[i, j] = Math.Round(temp, 1);
        }
    }
    return arr;
}

//Method to print array
void PrintArray(double[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}