// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. 
// Данные вводятся с консоли пользователем
int [] array = new int [8];
int ZaprosChisel (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = 1;
for (int i = 0; i < array.Length; i++)
{
    array[i] = ZaprosChisel("Введите число " + num);
    num = num + 1;
}
Console.WriteLine(string.Join(", ", array));