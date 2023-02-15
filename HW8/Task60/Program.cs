// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int m = 2; //Кол-во строк трехмерного массива
int n = 2; //Кол-во столбцов трехмерного массива
int l = 2;  // //Кол-во глубин трехмерного массива

int[,,] array3D = new int[m,n,l];
int[] temporaryArray = new int[m*n*l]; // вспомогательный одномерный массив
                                       //с кол-вом элементов равное кол-ву элементов 3-х мерного

FillArray (temporaryArray); // заполняем одномерный массив 
// PrintArray(temporaryArray);
ArrayMix (temporaryArray); // перемешиваем одномерный массив 
// PrintArray(temporaryArray);
Fillarray3D(array3D); // заполняем 3-х мерный массив элементами одномерного
PrintArray3D(array3D); // выводим 3-х мерный массив

int[] FillArray (int[] Ar) 
{
    int step = 0;
    for (int i = 0; i < Ar.Length; i++)
    {
        Ar[i] = 10 + step;
        step = step + new Random().Next(7, 13);;
    }
    return Ar;
}

// void PrintArray(int[] Array)
// {
//     for (int i = 0; i < Array.Length; i++)
//     {
//         Console.Write($"{Array[i]}, ");
//     }
//     Console.WriteLine();
// }

int[] ArrayMix (int[] array)
{
    
    for (int i = 0; i < array.Length; i++)
    {
        int FixRandom = new Random().Next(0, array.Length);
        int temp = array[i];
        if (array[i] != array [FixRandom]) array[i] = array [FixRandom];
        array [FixRandom] = temp;
    }
    return array;
}

int[,,] Fillarray3D(int[,,] array)
{
    int indexTempArray = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i,j,k] = temporaryArray[indexTempArray];
                indexTempArray++;
            }
        }
    }
    return array;
}

void PrintArray3D(int[,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i,j,k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        }
    }
}