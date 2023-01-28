// Задайте массив целых чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

int[] arr = new int [new Random().Next(4, 10)];

Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 20);
    Console.Write($"{arr[i]}, "); 
}

int max = arr[0];
int min = arr[arr.Length-1];
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max) max = arr[i];
    if (arr[i] < min) min = arr[i]; 
}
int diff = max - min;
Console.Write($"\b\b] -> {diff}");