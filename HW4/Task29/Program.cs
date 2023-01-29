// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] arr = new int[8]; 

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)   
    {
        array[i] = new Random().Next(0, 100);  
        Console.Write($"{array[i]}, ");        
    }
    Console.Write("\b\b] ");
}
PrintArray(arr);
Console.WriteLine();
