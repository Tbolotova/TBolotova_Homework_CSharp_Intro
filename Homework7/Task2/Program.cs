// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

Console.Write("Please enter the number of rows: ");
int rows = int.Parse(Console.ReadLine()!);

Console.Write("Please enter the number of columns: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] numbers = FillArray(rows, columns);

Console.Write("Please enter the element coordinates separated by a comma in the x, y format: ");
string coordsString = Console.ReadLine()!;
string[] coords = coordsString.Split(',');

GetElement(int.Parse(coords[0]), int.Parse(coords[1]), numbers);

//Method to return array element by coords
void GetElement(int rowNum, int colNum, int[,] array){
    if(rowNum > array.GetLength(0) || colNum > array.GetLength(1)){
        Console.WriteLine($"The element with coordinates ({rowNum}, {colNum}) does not exist in the array: ");
        PrintArray(array);
    }
    else{
        Console.WriteLine($"The element with coordinates ({rowNum}, {colNum}) in the array: ");
        PrintArray(array);
        Console.WriteLine($"equals {array[rowNum - 1, colNum - 1]}");
    }
}


//Method to fill array
int[,] FillArray(int rowNum, int colNum){
    int[,] arr = new int[rowNum, colNum];
    for (int i = 0; i < rowNum; i++)
    {
        for (int j = 0; j < colNum; j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
}

//Method to print array
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