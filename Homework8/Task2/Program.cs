// Задача 57: Составить частотный словарь элементов двумерного массива. Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3

// 4, 6, 1

// 2, 1, 6

// 1 встречается 3 раза

// 2 встречается 2 раз

// 3 встречается 1 раз

// 4 встречается 1 раз

// 6 встречается 2 раза

int rows = new Random().Next(2, 6);
int columns = new Random().Next(2, 6);
int minValue = 0;
int maxValue = 9;

int[,] numbers = new int[rows, columns];
FillArray(numbers, minValue, maxValue);
PrintArray(numbers);
FrequencyOfElements(numbers, minValue, maxValue);



//Method for the frequency dictionary
void FrequencyOfElements(int[,] arr, int minValueInArray, int maxValueInArray){
    for (int i = minValueInArray; i <= maxValueInArray; i++)
    {
        int count = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                count += arr[j, k] == i ? 1 : 0;
            }
        }

        if (count != 0)
        {
            Console.WriteLine($"number {i} appears in array {count} times. ");
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