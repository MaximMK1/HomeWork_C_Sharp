// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
 if (num > 99 && num < 999) 
 {
    int num100 = num / 10;
    int num10 = num100 % 10;
    Console.Write ("Вторая цифра {0}", num10);
 }
else
 Console.Write ("Введено не трехзначное число");