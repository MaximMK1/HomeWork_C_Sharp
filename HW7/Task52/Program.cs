// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) ; j++)
    {
       arr[i,j] = new Random().Next(0, 10); 
    }
}

PrintArr(arr);
void PrintArr(double[,] arry)
{
   for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1) ; j++)
        {
            Console.Write($"{arry[i, j],4}");
        }
        Console.WriteLine();
    } 
}

Console.Write($"Среднее арифметическое каждого столбца: ");
SredArith(arr);
void SredArith(double[,] array)
{
   
    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sredArith = 0;
        for (int i = 0; i < array.GetLength(0) ; i++)
        {
            sredArith = sredArith + array[i, j]/array.GetLength(0);
        }
        Console.Write($"{Math.Round(sredArith, 2)}, ");
    }
    Console.Write("\b\b ");
}