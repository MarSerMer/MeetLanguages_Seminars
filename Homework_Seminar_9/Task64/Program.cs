// Задача 64: Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void PrintNumbersFromNto1(int number)
{
    if (number == 0)
    {
        return;
    }
    else
    {
        
        Console.Write($"{number}, ");
        PrintNumbersFromNto1(number - 1);
    }
}

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}



int num = ReadNumber("Введите число");
PrintNumbersFromNto1(num);

Console.WriteLine(" ");