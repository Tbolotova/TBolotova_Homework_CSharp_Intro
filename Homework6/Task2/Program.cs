// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

double b1 = GetUserInput("b1");
double k1 = GetUserInput("k1");
double b2 = GetUserInput("b2");
double k2 = GetUserInput("k2");

string result = k1 == k2 ? "does not exist, the lines are parallel" : $"has ({String.Join("; ", GetIntersectionCoord(b1, k1, b2, k2))}) coordinates";

Console.WriteLine($"The intersection point of a line described by equation y = {k1}x + {b1} and a line described by equation y = {k2}x + {b2} {result}.");


double GetUserInput(string variable)
{
    Console.Write($"Please enter a value for {variable}: ");
    return double.Parse(Console.ReadLine()!);
}

double[] GetIntersectionCoord(double b1, double k1, double b2, double k2)
{
    double xCoord = Math.Round((b2 - b1) / (k1 - k2), 2);
    double yCoord = Math.Round(k1 * xCoord + b1, 2);

    double[] coord = {xCoord, yCoord};

    return coord;
}