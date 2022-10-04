// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numM = ReadNumber("Введите число М");
int numN = ReadNumber("Введите число N");

int SumNumbersFromMtoN(int m, int n)
{
    int sum = 0;
    if (n < m)
    {
        return sum;
    }
    else
    {
        return (n + SumNumbersFromMtoN(m, n - 1));
    }
}
int s = 0;
if (numN > numM)
{
    s = SumNumbersFromMtoN(numM, numN);
}
else
{
    if (numN < numM)
    {
        s = SumNumbersFromMtoN(numN, numM);
    }
    else
    {
        s = 0;
    }
}
Console.WriteLine(s);