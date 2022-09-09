// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int number = ReadNumber("Введите число");

// int countNumbers(int a)
// { int count = 0; //число цифр = количество прокруток (=итераций) цикла
//     if (number == 0) count = 1;
//     while (a != 0)
//     {
//         a = a / 10;
//         count++;
//     }
//     return count;
// }

int countNumbers(int a)
{
    int count = 0;
    if (a == 0) count = 1;
    while (a > 0)
    {
        a = a / 10;
        count++;
    }
    return count;
}

// int result = countNumbers(number);
// Console.WriteLine(result);

int result = countNumbers(number);
Console.WriteLine(result);