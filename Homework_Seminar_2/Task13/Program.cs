// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число, а я покажу вам его третью цифру");
int number = Convert.ToInt32(Console.ReadLine());
int numberModule = Math.Abs (number);
int count = 1;
if (numberModule < 100)
    {
    Console.WriteLine("В этом числе нет третьей цифры");
    }
else
    {
        if (numberModule < 1000)
        {
            int resultFigure = numberModule % 10;
            Console.WriteLine($"Третья цифра этого числа: {resultFigure}");
        }
        else 
        {
            while (numberModule >= 10)
            {
                numberModule = numberModule / 10;
                count = count + 1;
            }            
            numberModule = Math.Abs (number);
            int delitel = Convert.ToInt32(Math.Pow(10, (count - 3)));
            int resultFigure = (numberModule / delitel) % 10;
            Console.WriteLine($"Третья цифра этого числа: {resultFigure}");
        }
    }