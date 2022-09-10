// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число > 0");
int number = Convert.ToInt32(Console.ReadLine());
double result = 1;
if (number == 1)
{
    Console.WriteLine(result);
}
else if (number>1)
    {
        for (int a = 1; a <= number; a++)
        {
            result = Math.Pow(a, 3);
            Console.Write( $"{result} ");
        }
    Console.WriteLine(" ");
    }
    else Console.WriteLine("Введено неверное число");