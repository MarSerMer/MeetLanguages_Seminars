// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Итак, у нас тут два уравнения задают прямые. ");
Console.WriteLine("Задайте коэффициенты этих уравнений и узнайте координаты точки пересечения этих прямых.");
Console.WriteLine("Первое уравнение вида y = k1 * x + b1.");
double k1 = ReadNumber("Введите k1"); //a
double b1 = ReadNumber("Введите b1"); //c
Console.WriteLine("Второе уравнение вида y = k2 * x + b2.");
double k2 = ReadNumber("Введите k2"); //b
double b2 = ReadNumber("Введите b2"); //d

if (k1 == k2 && b1 == b2)
{
Console.WriteLine("Вы везунчик, эти прямые полностью совпадают!");
}
else 
{
    if (k1 == k2)
    {
        Console.WriteLine("Эти прямые параллельны, и точек пересечения у них нет. Может, это и к лучшему.");
    }
    else
    {
        double x = (b2-b1)/(k1-k2);
        double y = k1*x + b1;
        Console.WriteLine($"Эти прямые пересекаются в точке с координатами ({x} ; {y} ).");
    }
}