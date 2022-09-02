// 11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

Random rand = new Random();
int number = rand.Next(10, 100);
Console.WriteLine($"Сгенерировано случайное число {number}");
int digit3 = number%10;
int digit1 = number / 100;
int result = digit1*10 + digit3;
Console.WriteLine(result);
