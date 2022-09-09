// Задача 24: Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А
// 7 -- 28
// 4 -- 10
// 8 -- 36

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumNumbersFrom1ToA(int a)
{
    if (a >= 1)
    {
        int sum = 0;
        for (int i = 1; i <= a; i++)
        {
            sum = sum + i;
            //sum +=i; - то же самое, что и команда выше
            
        }
        return sum;
    }
    else
    {
        Console.WriteLine("А должна быть не меньше 1");
        return -1; //сообщение для неправильной суммы
    }
 }

int number = ReadNumber("Введите число");
Console.WriteLine($"Число А равно {number}");

int sum = SumNumbersFrom1ToA(number);
Console.WriteLine($"Сумма чисел от 1 до {number} равно {sum}");