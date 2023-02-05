// Задайте массив целых чисел.
// Найдите разницу между максимальным и минимальным элементом массива.
//[3 7 22 2 78] -> 76

int[] arr = new int [new Random().Next(4, 10)];

int ArrMaxMinDiff (int[] array)
{
Console.Write("[");
for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1, 20);
    Console.Write($"{array[i]}, "); 
    }
int max = array[0];
int min = array[array.Length-1];
for (int i = 0; i < array.Length; i++)
    {
    if (array[i] > max) max = array[i];
    if (array[i] < min) min = array[i]; 
    }
int diff = max - min;
return diff;
}
Console.Write($"\b\b] -> {ArrMaxMinDiff (arr)}");