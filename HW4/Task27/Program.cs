// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.Write("Введите число N: ");
int N = Convert.ToInt32(Console.ReadLine());

int Sum (int num)
{
    int sum = num % 10;
    while (num / 10 > 0)
    {
        num = num / 10;
        sum = sum + num % 10;
    }
    return sum;
}       
Console.WriteLine($"Сумма цифр в числе {N} равна {Sum(N)}");