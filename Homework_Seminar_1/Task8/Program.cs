// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число >=1");
int number = Convert.ToInt32(Console.ReadLine());

if (number >=2)
{
    int result = 2;
    while(result <= number)
    {
        Console.Write(result + " ");
        result = result + 2;
    }
}

if (number >0 && number<2)
{
    Console.WriteLine("От 1 до " + number + " нет четных чисел");
}
if (number < 1)
{
    Console.WriteLine("Нужно ввести число >= 1");
}
