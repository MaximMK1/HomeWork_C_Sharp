// Задача 58: Задайте две матрицы.
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int m = new Random().Next(3, 5); //кол-во строк 1 матрицы
int n = new Random().Next(3, 5); //кол-во столбцов 1 матрицы и кол-во строк 2 матрицы
int k = new Random().Next(3, 5); // кол-во столбцов 2 матрицы

int [,] matrix1 = new int [m, n];
int [,] matrix2 = new int [n, k];
int [,] resultMatrix = new int [m, k]; //результирующая матрица с правильным кол-вом строк и столбцов

FillArray(matrix1);
FillArray(matrix2);
Console.WriteLine("Матрица 1");
PrintArray(matrix1);
Console.WriteLine("Матрица 2");
PrintArray(matrix2);
MatrixMultiple(matrix1, matrix2, resultMatrix);
Console.WriteLine("Результирующая матрица");
PrintArray(resultMatrix);

int[,] FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 5);
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
            Console.Write($"{Array[i, j],5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MatrixMultiple(int[,] matr1, int[,] matr2, int[,] resultMatr)
{
    for (int i = 0; i < resultMatr.GetLength(0); i++)
        {
            for (int j = 0; j < resultMatr.GetLength(1); j++)
            {
                resultMatr[i, j] = 0;
                for (int n = 0; n < matr1.GetLength(1); n++)
                {
                    resultMatr[i, j] = resultMatr[i, j] + (matr1[i, n] * matr2[n, j]);
                }
            }
        }
    return resultMatr;
}