// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int sum = N % 10;   // последнняя цифра числа
int n = N;

while (n / 10 > 0)
{
    n = n / 10; 
    sum = sum + n % 10;
}
Console.WriteLine($"Сумма цифр в числе {N} равна {sum}");