// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2;
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


Console.Write("Введите значение b1:  ");
int k1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k1:  ");
int b1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение b2:  ");
int k2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите значение k2:  ");
int b2 = Convert.ToInt32(Console.ReadLine());

// int x;
// int y;

double PointX(int k1, int b1, int k2, int b2) 
{
    // double y;
    double x = (b2-b1)/(k1-k2); 
    // y = a1 * x + a2;
    // return x;
    //  double y = a1 * x + a2;
    //  double y2 = c1 * x + c2;
    //  y1 = y2;
     return x;
}
Console.Write(PointX(b1, k1, b2, k2));