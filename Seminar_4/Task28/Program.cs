// Задача 28: Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNumber("Please enter a number");

int Proizvedenie(int a)
{
    int proiz = 1;
    int i = 1;
    while (i <= a)
    {
    proiz = proiz * i;
    i++;
    }
    return proiz;
}

int result = Proizvedenie(number);
Console.WriteLine($"Произведение чисел от 1 до {number} равно {result}");