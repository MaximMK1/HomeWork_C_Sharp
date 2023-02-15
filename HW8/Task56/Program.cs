// // Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт
//  номер строки с наименьшей суммой элементов: 1 строка

Console.Write("Задайте кол-во строк массива:  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Задайте кол-во столбцов массива:  ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];
int[] ArrSumElements = new int[m];

FillArray(array);
PrintArray(array);
RowSumElements(array, ArrSumElements);

int[,] FillArray(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            arry[i, j] = new Random().Next(1, 10);
        }
    }
    return arry;
}

void PrintArray(int[,] Array)
{
    Console.WriteLine($"Массив: ");
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

void RowSumElements(int[,] Array, int[] ArrSum)
{
    Console.Write($"Суммы элементов каждой строки: ");
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        int sum =0;
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            sum = sum + Array[i,j];
        }
        ArrSum[i] = sum;
        Console.Write($"{sum}, ");
    }
    Console.Write("\b\b ");
    Console.WriteLine();
}


// string[] sumElementsString = Console.ReadLine().Split(' ');
// int[] sumElements = new int[sumElementsString.Length];
// for(int i = 0 ; i <= sumElementsString.Length; i++)
//     {
//     sumElements[i] = int.Parse(sumElementsString[i]);
//     }
// // int[] numbers = Array.ConvertAll(numbersString, s => int.Parse(s));
// // for (int i = 0; i < numbers.Length; ++i)
// //     numbers[i] = int.Parse(numbers[i]);
// Console.Write($"{string.Join(", ", sumElements)}");

int minIndex = 0;
for (int i = 0; i < ArrSumElements.Length; i++)
{
    if (ArrSumElements[i] < ArrSumElements[minIndex]) minIndex = i;

}
Console.Write($"Номер строки с наименьшей суммой элементов: {minIndex + 1} строка");