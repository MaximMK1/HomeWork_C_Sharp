// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.


Console.Write("Введите цифру: ");
int day = Convert.ToInt32(Console.ReadLine()); 

if (day >= 1 && day <=7) 
{
    if (day <=5)  Console.Write ("Будний день! Работаем!"); 
    else if (day >= 6 )  Console.Write ("Выходной! Отдыхаем!"); 
}
else
Console.Write("Введена неверная цифра");
