// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает 
// вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число, а я покажу вам его вторую цифру:");
int number = Convert.ToInt32(Console.ReadLine());
double numberModule = Math.Abs(number);
if (numberModule > 99 && numberModule < 1000)
{
    double result = (numberModule % 100 - numberModule % 10) / 10;
    Console.WriteLine($"Вторая цифра этого числа: {result}");
}
else 
{
    Console.WriteLine("Введите именно трехначное число");
}