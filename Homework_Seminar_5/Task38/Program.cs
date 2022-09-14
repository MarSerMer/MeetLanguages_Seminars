// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
float [] array = new float[15];
Random rand = new Random();
int i = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 101);
}
Console.WriteLine("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", array));
i = 0;
float max = array[0];
for (i = 0; i < array.Length; i++)
{if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine($"Максимальное число массива: {max}");

i = 0;
float min = 0;
if (array[0] == max)
{
    min = array[1];
    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
}
else
{   min = array[0];
    while (i < array.Length)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
        i++;
    }
}

Console.WriteLine($"Минимальное число массива: {min}");
float result = max - min;
Console.WriteLine($"Разница между ними: {result}");