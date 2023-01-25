// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num <= 99999) 
{
   int ind0 = num / 10000; 
   int ind1 = ((num / 1000) % 10);
   int ind3 = ((num % 100) / 10);  
   if (ind0 == num % 10 && ind1 == ind3)
   {
    Console.WriteLine($"Число {num} является палиндромом");
   } 
   else
   Console.WriteLine($"Число {num} не является палиндромом");
}
else Console.WriteLine("Введено неверное число");


