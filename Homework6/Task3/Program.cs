// Доп.Задача Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1. (Решить можно, если хотите потренироваться)
// (Следующее число складывается из двух предыдущих)

// Если N = 5 -> 0 1 1 2 3

// Если N = 3 -> 0 1 1

// Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Please enter how many Fibonacci numbers you want to display: ");
int number = int.Parse(Console.ReadLine()!);

Console.WriteLine($"The Fibonacci sequence of {number} numbers is: {String.Join(" ", GetFibonacci(number))}");


int[] GetFibonacci(int number)
{
    int[] arr = new int[number];
    

    if(number == 1)
    {
        arr[0] = 0;
    }
    else
    {
        arr[0] = 0;
        arr[1] = 1;
        int currentFib = arr[1];
        int previousFib = arr[0];
        for (int i = 2; i < number; i++)
        {
            arr[i] = currentFib + previousFib;
            previousFib = currentFib;
            currentFib = arr[i];
        }
    }
    
    return arr;
}