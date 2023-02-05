// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = new int [new Random().Next(4, 10)];

int Sum (int[] array)
{
int sum = 0;
Console.Write("[");
for (int i = 0; i < array.Length; i++)
    {
    array[i] = new Random().Next(1, 10);
    Console.Write($"{array[i]}, "); 
    if (i % 2 == 0) sum = sum + array[i];
    }
return sum;
}
Console.Write($"\b\b] -> {Sum(arr)}");
