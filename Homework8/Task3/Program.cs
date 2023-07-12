// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int rowsFirst = new Random().Next(1, 6);
int columnsFirst = new Random().Next(1, 6);
int rowsSecond = columnsFirst;
int columnsSecond = new Random().Next(1, 6);;
int minValue = 0;
int maxValue = 9;

int[,] firstMatrix = new int[rowsFirst, columnsFirst];
int[,] secondMatrix = new int[rowsSecond, columnsSecond];
FillArray(firstMatrix, minValue, maxValue);
FillArray(secondMatrix, minValue, maxValue);
int[,] product = MultiplyMatrices(firstMatrix, secondMatrix);
PrintArray(firstMatrix);
Console.WriteLine("x");
PrintArray(secondMatrix);
Console.WriteLine("=");
PrintArray(product);

//Method for multiplying matrices
int[,] MultiplyMatrices(int[,] firstMatrix, int[,] secondMatrix){
    int resultMatrixRowNum = firstMatrix.GetLength(0);
    int resultMatrixColNum = secondMatrix.GetLength(1);
    int[,] resultMatrix = new int[resultMatrixRowNum, resultMatrixColNum];

    for (int i = 0; i < resultMatrixRowNum; i++)
    {
        for (int j = 0; j < resultMatrixColNum; j++)
        {
            //Going through each element in the first matrix's i-row and multiplying 
            //it by each element in the second matrix in j-column
            for (int k = 0; k < firstMatrix.GetLength(1); k++)
            {
                resultMatrix[i, j] += firstMatrix[i, k] * secondMatrix[k, j];
            }
        }
    }
    return resultMatrix;
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

//Method to fill the array with numbers
void FillArray(int[,] arr, int min, int max){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(min, max + 1);
        }
    }
}