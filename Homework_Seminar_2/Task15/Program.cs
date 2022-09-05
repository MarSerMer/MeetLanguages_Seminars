// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите номер дня недели и узнаете, выходной этот день или нет");
int dayNumber = Convert.ToInt32(Console.ReadLine());
if (dayNumber >=1 && dayNumber <=5)
{
    Console.WriteLine("Нет, этот день рабочий");
}
    else 
    {if (dayNumber == 6 || dayNumber == 7)
    {
        Console.WriteLine("Да, этот день выходной");
    }
    else 
    {
        Console.WriteLine("Это не номер дня недели. Введите число от 1 до 7");
    }
    }