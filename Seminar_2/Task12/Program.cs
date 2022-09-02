// Задача 12: Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. 
// Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число (делимое)");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите первое число (делитель)");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number2 !=0)
{
int result = number1 % number2;
if (result == 0)
{
    Console.WriteLine($"Число {number1} делится на {number2} без остатка");
}
else
{
    Console.WriteLine($"Число {number1} делится на {number2} с остатком {result}");
}
}
else{
    Console.WriteLine("Нет, делить на 0 мы сегодня не будем...");
}