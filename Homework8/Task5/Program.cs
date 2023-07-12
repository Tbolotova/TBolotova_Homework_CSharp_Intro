// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

//работает с массивом любой размерности. Мне кажется, я вывихнула себе мозг))

int rowNum = 4;
int colNum = 4;

string[,] numbers = new string[rowNum, colNum];
spiralFillArray(numbers);
PrintArray(numbers);

//Method for filling array in a spiral
void spiralFillArray(string[,] arr){
    int topRow = 0;
    int leftCol = 0;
    int bottomRow = arr.GetLength(0) - 1;
    int rightCol = arr.GetLength(1) - 1;
    int currentValue = 1;
    int numCharInElement = CharsInElemnt(arr.GetLength(0), arr.GetLength(1));
    string direction = "right";
    while (leftCol <= rightCol && topRow <= bottomRow)
    {
        switch (direction)
        {
            case "right":
                for (int j = leftCol; j <= rightCol; j++)
                {
                    arr[topRow, j] = currentValue.ToString().PadLeft(numCharInElement, '0');
                    currentValue++;
                    direction = j == rightCol ? "down" : "right";
                }
                topRow++;
                break;
            case "down":
                for (int j = topRow; j <= bottomRow; j++)
                {
                    arr[j, rightCol] = currentValue.ToString().PadLeft(numCharInElement, '0');
                    currentValue++;
                    direction = j == bottomRow ? "left" : "down";
                }
                rightCol--;
                break;
            case "left":
                for (int j = rightCol; j >= leftCol; j--)
                {
                    arr[bottomRow, j] = currentValue.ToString().PadLeft(numCharInElement, '0');
                    currentValue++;
                    direction = j == leftCol ? "up" : "left";
                }
                bottomRow--;
                break;
            default:
                for (int j = bottomRow; j >= topRow; j--)
                {
                    arr[j, leftCol] = currentValue.ToString().PadLeft(numCharInElement, '0');
                    currentValue++;
                    direction = j == topRow ? "right" : "up";
                }
                leftCol++;
                break;
        }
    }
    
       
}

//Method for getting the number of chars in an element depending on the size of the array
int CharsInElemnt(int numRows, int numCols){
    int maxElement = numRows * numCols;
    return NumberOfDigits(maxElement);
}

int NumberOfDigits(int number){
    int numberOfDigits = 0;
    while(number > 0){
        number /= 10;
        numberOfDigits++;
    }
    return numberOfDigits;
}

//Method for printing an array in the console
void PrintArray(string[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}