// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию
//  элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

Console.Write("Задайте кол-во строк массива:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте кол-во столбцов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
PrintArray(array);
SortArr(array);
PrintArray(array);

int[,] FillArray(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            arry[i, j] = new Random().Next(1, 20);
        }
    }
    return arry;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i, j],4}");
        }
        Console.WriteLine();
    }
Console.WriteLine();
}

void SortArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1)-1; j++)
        {
            int maxPosition = j;

            for (int k = j + 1; k < arr.GetLength(1); k++)
            {
                if (arr[i, k] > arr[i, maxPosition]) maxPosition = k;
            }
            int temp = arr[i,j];
            arr[i,j] = arr[i, maxPosition];
            arr[i, maxPosition] = temp;
        }
    }
}

