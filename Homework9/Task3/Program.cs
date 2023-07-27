// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. Выполнить с помощью рекурсии.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int m = new Random().Next(0, 4);
int n = new Random().Next(0, 4);

Console.WriteLine($"Ackermann's function at m = {m} and n = {n} equals {Ackermann(m, n)}");


int Ackermann(int m, int n){
    if(m == 0) return n + 1;
    if(n == 0) return Ackermann(m - 1, 1);
    return Ackermann(m - 1, Ackermann(m, n - 1));
}