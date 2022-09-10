// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;

if (number >= 10000 &&  number < 100000)
    {
        int ReverseNumber = 0;
        for (int i = 1; i <=5; i++)
        {
            ReverseNumber = ReverseNumber*10 + number % 10;
            number = number / 10;
        }
        Console.WriteLine($"Перевернутое число: {ReverseNumber}");
        if (ReverseNumber == number1)
        {
            Console.WriteLine($"Число {number1} является палиндромом");
        }
        else Console.WriteLine($"Число {number1} не является палиндромом");
    }
else Console.WriteLine("Введено не пятизначное число");