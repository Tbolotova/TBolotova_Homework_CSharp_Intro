// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
//которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int firstDimension = new Random().Next(2, 6);
int secondDimension = new Random().Next(2, 6);
int thirdDimension = new Random().Next(2, 6);
int[,,] threeDimensionalArray = Get3DArray(firstDimension, secondDimension, thirdDimension);
Print3DArray(threeDimensionalArray);


//Method to get a 3D array
int[,,] Get3DArray(int firstDimension, int secondDimension, int thirdDimension){
    int[,,] arr = new int[firstDimension, secondDimension, thirdDimension];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                arr[i, j, k] = new Random().Next(10, 100);
                bool isInArray = IsElementInArray(arr, arr[i, j, k], i, j, k);
                while(isInArray){
                    arr[i, j, k] = new Random().Next(10, 100);
                    isInArray = IsElementInArray(arr, arr[i, j, k], i, j, k);
                }
            }
        }
    }
    return arr;
}

//Method for checking if array contains an element
bool IsElementInArray(int[,,] arr, int element, int firstIndex, int secondIndex, int thirdIndex){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if(arr[i, j, k] == element && (i != firstIndex && j != secondIndex && k != thirdIndex)) return true;
            }
        }
    }
    return false;
}

//Method to print the array in the console
void Print3DArray(int[,,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(2); j++)
        {
            for (int k = 0; k < arr.GetLength(1); k++)
            {
                Console.Write($"{arr[i, k, j]}({i}, {k}, {j}) ");
            }
            Console.WriteLine();
        }
    }
}


