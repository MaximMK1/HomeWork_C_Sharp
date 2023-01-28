// Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] arr = new int [new Random().Next(4, 10)];
int sum = 0;
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{
    arr[i] = new Random().Next(1, 50);
    Console.Write($"{arr[i]}, "); 
    if (i % 2 == 0) sum = sum + arr[i];
}
Console.Write($"\b\b] -> {sum}");
