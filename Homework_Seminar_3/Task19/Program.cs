// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number < 100000 && number >= 10000)
    {
        int num5 = number % 10;
        int num4 = (number/10) % 10;
        int num3 = (number/100) % 10;
        int num2 = (number/1000) % 10;
        int num1 = number/10000;
        Console.WriteLine($"1 число = {num1}, 2 число = {num2}, 3 число = {num3}, 4 число = {num4}, 5 число = {num5}");
        if (num1 == num5 && num2 == num4)
         {
            Console.WriteLine($"Число {number} является палиндромом");
         }
        else Console.WriteLine($"Число {number} не является палиндромом");
    }
else Console.WriteLine("Введено не пятизначное число");    