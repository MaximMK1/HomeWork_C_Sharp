// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

int[,] array = new int [4,4];
int m = 0;

for (int i = 0; i < array.GetLength(0); i++)
{   
    if (i == 1) 
    {
     for (int x = 0; x < array.GetLength(0); x++)
        {
        for (int y = 0; y < array.GetLength(1) ; y++)
            {
            Console.Write($"{array[x, y],4}");
            }
         Console.WriteLine(); 
        }
    // break;
    } 


    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i,j] = m + 1;
        m = m + 1;

        if (j == array.GetLength(1) -1) 
        {
            for (int k = 1; k < 4; k++)
            {
            array[k,j] = m + 1;
            m = m + 1;

            if(k == 3)
                {
                    for (int l = 2; l > -1; l-- )
                    {
                        array[k,l] = m + 1;
                        m = m + 1;

                        if (l == 0) 
                        {
                            for (int n = 2; n >= 1; n--)
                            {
                                array[n,l] = m + 1;
                                m = m + 1;

                                if (n == 1)
                                {
                                    for (int p = 1; p <= 2; p++)
                                    {
                                         array[n,p] = m + 1;
                                         m = m + 1;

                                         if (p==2)
                                         {
                                            for (int s = 2; s >= 1; s--)
                                            {
                                                array[p,s] = m + 1;
                                                m = m + 1;
                                            }
                                         }
                                    }
                                }
                            }
                        }
                    
                    }
                }
            }
        }
    }
}
