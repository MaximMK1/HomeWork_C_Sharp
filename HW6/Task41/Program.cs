// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите число 1:  ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2:  ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3:  ");
int c = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 4:  ");
int d = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 5:  ");
int e = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 6:  ");
int f = Convert.ToInt32(Console.ReadLine());

int[] arr = {a,b,c,d,e,f};

int PosNumArr(int[] array)
{
    int count =0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
return count;
}

Console.Write($"Среди введенных чисел  {string.Join(", ", arr)}  положительных {PosNumArr(arr)}");