// Напишите программу, которая принимает на вход координтаы точки (X и Y), причём X не равно нулю и Y не равно нулю
// и выдаёт номер четверти плоскости, в которой находится эта точка

Console.WriteLine("Введите координату x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine("Данная точка находится в первой четверти");
}
else if (x < 0 && y > 0)
    {
        Console.WriteLine("Данная точка находится во второй четверти");
    }
    else if (x < 0 && y < 0)
    {
        Console.WriteLine("Данная точка находится в третьей четверти");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Данная точка находится в четвертой четверти");
    }
    else Console.WriteLine("Введены неверные координаты");
    