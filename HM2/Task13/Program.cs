// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine()); 
if (num > 99 ) 
{
    while (num > 999) 
   {
    num = num / 10;
   }
num = num % 10;
Console.Write ("Третья цифра {0}", num);
}
else
Console.Write("Третьей цифры нет");
