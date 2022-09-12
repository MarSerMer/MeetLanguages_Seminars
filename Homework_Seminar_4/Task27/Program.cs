// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int EnterAndReadNumber (string message)
{
    Console.WriteLine("Введите число");
    return Convert.ToInt32(Console.ReadLine());
}
 int number = EnterAndReadNumber("Введите число и увидите сумму его цифр");
 int numberD = Math.Abs(number);
 int sum = 0;
while (numberD > 0)
{    
    sum = sum + numberD%10;
    numberD = numberD/10;
}

Console.WriteLine($"Сумма цифр числа {number} равна {sum}");