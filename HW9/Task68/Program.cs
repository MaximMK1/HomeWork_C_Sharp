// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите число M: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Akerman (int m, int n)
{
    if (m == 0)
    return (n + 1);

    if (m != 0 && n == 0)
    return Akerman (m - 1, 1);

    if (m > 0 && n > 0)
    {return Akerman (m - 1, Akerman(m, n - 1));}

    return Akerman(m, n);
}
Console.WriteLine($"Akerman({M},{N}) = {Akerman(M, N)}");
