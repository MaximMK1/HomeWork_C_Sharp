// Напишите программу, которая принимает на вход координаты двух точек и
//  находит расстояние между ними в 3D пространстве.

Console.WriteLine("Введите координаты точки A: ");
Console.Write("x: ");
int Ax = int.Parse(Console.ReadLine());
Console.Write("y: ");
int Ay = int.Parse(Console.ReadLine());
Console.Write("z: ");
int Az = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
Console.Write("x: ");
int Bx = int.Parse(Console.ReadLine());
Console.Write("y: ");
int By = int.Parse(Console.ReadLine());
Console.Write("z: ");
int Bz = int.Parse(Console.ReadLine());

int diffX = Ax-Bx;
int diffY = Ay-By;
int diffZ = Az-Bz;  

double S = Math.Sqrt(Math.Pow(diffX, 2) + Math.Pow(diffY, 2) + Math.Pow(diffZ, 2));
Console.Write("Расстояние между точками равно {0}", Math.Round(S, 2));