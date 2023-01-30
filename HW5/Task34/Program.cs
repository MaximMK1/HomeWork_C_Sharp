// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] arr = new int [new Random().Next(4, 10)];

int Num (int[] array)
{
int count = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write($"{array[i]}, "); 
    if (array[i] % 2 == 0) count++;
}
return count;
}
Console.Write($"\b\b] -> {Num(arr)}");