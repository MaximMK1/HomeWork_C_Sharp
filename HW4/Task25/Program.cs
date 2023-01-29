// Напишите цикл, который принимает на вход два числа (A и B) и
// возводит число A в натуральную степень B.

Console.Write("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());
// int x = A;
if (B > 0) 
{
int X (int x, int y)
   {
   int num = x;
   for (int i = 2; i <= y; i++)
      {
        x = x * num;
      }
   return x;
   }   
   Console.WriteLine($"Число {A} в степени {B} равно {X(A, B)} ");
} 
else Console.WriteLine($"Число {B} не натуральное");