// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] arr = new int[8]; 

Console.Write("[ ");

for (int i = 0; i < arr.Length; i++)   
    {
        arr[i] = new Random().Next(0, 100);  
        Console.Write($"{arr[i]}, ");        
    }
    Console.Write("\b\b ] ");

