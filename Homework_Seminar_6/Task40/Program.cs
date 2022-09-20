// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, 
// может ли существовать треугольник с сторонами такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Введите три числа и узнаете, может ли существовать треугольник с такими сторонами");
int number1 = ReadNumber("Число 1: ");
int number2 = ReadNumber("Число 2: ");
int number3 = ReadNumber("Число 3: ");
Console.WriteLine($"Вы ввели числа: {number1}, {number2}, {number3}");
if (number1 < number2 + number3 && number2 < number1 + number3 && number3 < number1 + number2)
{
    Console.WriteLine("Да, может");
}
else 
{
    Console.WriteLine("Нет, не может");
}