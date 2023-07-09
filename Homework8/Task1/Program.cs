// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);

int[,] numbers = new int[rows, columns];
FillArray(numbers);
Console.WriteLine($"The array of {rows} rows and {columns} columns: ");
PrintArray(numbers);
SortRowsDescending(numbers);
Console.WriteLine("with the rows sorted in descending order is: ");
PrintArray(numbers);


//Method for sorting each row in descending order
void SortRowsDescending(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int[] currentRow = GetRow(arr, i);
        ArrayBubbleSortDescending(currentRow);
        PasteRow(arr, currentRow, i);
    }
}

//Method for sorting a single dimension array of ints in descending order
void ArrayBubbleSortDescending(int[] arr){
    bool isReplaced = true;
    while(isReplaced == true){
        isReplaced = false;
        for (int i = 1; i < arr.Length; i++)
        {
            if(arr[i] > arr[i - 1]){
                int temp = arr[i];
                arr[i] = arr[i - 1];
                arr[i - 1] = temp;
                isReplaced = true;
            }
        }
    }
}

//Method to get a row from a 2d array
int[] GetRow(int[,] arr, int rowNum){
    int[] output = new int[arr.GetLength(1)];
    for (int i = 0; i < output.Length; i++)
    {
        output[i] = arr[rowNum, i];
    }
    return output;
}

//A method to paste the sorted row back into the 2d array
void PasteRow(int[,] arr, int[] sortedRow, int rowNum){
    for (int i = 0; i < sortedRow.Length; i++)
    {
        arr[rowNum, i] = sortedRow[i];
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