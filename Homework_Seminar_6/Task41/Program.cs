// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь. 
// Ввод чисел останавливается при помощи ввода стоп-слова "stop"
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 4

int count = 0;
bool result = true;

do
{
    Console.WriteLine("Вводите числа, пока не надоест. А когда надоест, введите stop");
    string? otPolzovatela = Console.ReadLine();

    result = int.TryParse(otPolzovatela, out int number);
        if (number > 0)
        {
            count++;
        }
}

while (result == true);

Console.WriteLine($"Пользователь ввёл {count} чисел больше 0");


