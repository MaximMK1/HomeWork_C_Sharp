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

FillArray(m, n);
PrintArray(FillArray(m, n));
SortArr(FillArray(m, n));
PrintArray(FillArray(m, n));

int[,] FillArray(int row, int col)
{
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 20);
        }
    }
    return array;
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

}

void SortArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1) - 1; j++)
        {
            int maxElement = j;

            for (int k = j + 1; k < arr.Length; k++)
            {
                if (arr[i, k] > arr[i, maxElement]) maxElement = k;
            }
            int temp = arr[i,j];
            arr[i,j] = arr[i, maxElement];
            arr[i, maxElement] = temp;
        }
    }
}

