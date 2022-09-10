// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!
int EnterAndReadNumber (string message) //попытка создать метод для ввода числа пользователем
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
int VozvedenieVStepen (int number, int stepen) //попытка создать метод для воздведения в степень
{
    int result = 1;
    for (int i = 1; i <= stepen; i++) //i=1, т.к. в условии указано, что число В натуральное. Нулей и отрицательных не будет
    {
        result = result*number;
    }
    return result;
}
int numberA = EnterAndReadNumber("Введите число А");
int numberB = EnterAndReadNumber("Введите число В, это натуральная степень и оно должно быть больше нуля");
if (numberB > 0)
{
    int otvet = VozvedenieVStepen(numberA, numberB);
    Console.WriteLine($"Число {numberA} в степени {numberB} равно {otvet}");
}
else Console.WriteLine("Введено неправильное число В. Введите число В больше нуля");