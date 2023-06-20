// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Please enter x coordinate for point A: ");
int x1 = int.Parse(Console.ReadLine()!);
Console.Write("Please enter y coordinate for point A: ");
int y1 = int.Parse(Console.ReadLine()!);
Console.Write("Please enter z coordinate for point A: ");
int z1 = int.Parse(Console.ReadLine()!);
Console.Write("Please enter x coordinate for point B: ");
int x2 = int.Parse(Console.ReadLine()!);
Console.Write("Please enter y coordinate for point B: ");
int y2 = int.Parse(Console.ReadLine()!);
Console.Write("Please enter z coordinate for point B: ");
int z2 = int.Parse(Console.ReadLine()!);

double distance = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2) + Math.Pow(z1 - z2, 2));

Console.WriteLine($"The distance between the points in 3d plane with coordinates A ({x1}, {y1}, {z1}) and B ({x2}, {y2}, {z2}) equals {distance:f2}.");