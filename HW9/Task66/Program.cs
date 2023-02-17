// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30


Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = 0;
int SummElements(int m, int n)
{
    sum = sum + m;
    if (m == n) return sum;
    return (SummElements(m + 1, n));
}

Console.WriteLine($"{SummElements(M, N)}");
