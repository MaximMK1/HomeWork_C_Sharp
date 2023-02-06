// Задайте двумерный массив размером mxn,
//заполненный случайными вещественными числами.

Console.Write("Введите размер m ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите размер n ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] arr = new double[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1) ; j++)
    {
       arr[i,j] = Math.Round((new Random().NextDouble() * 10), 2); 
    }
}

Console.WriteLine("Массив с вещественными элементами");
PrintArr(arr);

void PrintArr(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1) ; j++)
        {
            Console.Write($"{array[i, j],7}");
        }
        Console.WriteLine();
    } 
}