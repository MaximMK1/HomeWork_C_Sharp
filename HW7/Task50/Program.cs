// Напишите программу, которая на вход принимает позиции элемента
// в двумерном массиве, и возвращает значение этого элемента или же
// что такого элемента нет.


Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите номер строки элемента: ");
int elementRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца элемента: ");
int elementCol = Convert.ToInt32(Console.ReadLine());

int[,] arr = new int[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) ; j++)
    {
       arr[i,j] = new Random().Next(-9, 10); 
    }
}

PrintArr(arr);
void PrintArr(int[,] arry)
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

int SearchElement(int[,] array, int row, int col)
{
   int element = 0; 
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            if (i==row && j==col) element = array[i, j]; 
        }
    } 
    return element;
}
if (SearchElement(arr, elementRow, elementCol) != 0)
{Console.Write($"Элемент есть: {SearchElement(arr, elementRow, elementCol)}");}
else
{Console.Write("Такого элемента нет");}
