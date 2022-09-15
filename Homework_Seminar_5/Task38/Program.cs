// Задача 38: Задайте массив вещественных (на самом деле там натуральных) чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

int [] GetArray ( int size, int NumberFrom, int NumberBefore)
{
    int[] array = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        array [i] = rand.Next(NumberFrom, NumberBefore + 1);
    }
    return array;
}
int [] arr = GetArray(12, -9, 9);
Console.Write("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", arr));

int findingMaxNumber(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
int arrayMax = findingMaxNumber(arr);
Console.WriteLine(arrayMax);

int findingMinNumber(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

int arrayMin = findingMinNumber(arr);
Console.WriteLine(arrayMin);
int result = arrayMax - arrayMin;
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {result}");










// До уточнения условия и без методов:

// float [] array = new float[15];
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 101);
// }
// Console.WriteLine("Сгенерирован массив: ");
// Console.WriteLine(string.Join(", ", array));
// i = 0;
// float max = array[0];
// for (i = 0; i < array.Length; i++)
// {if (array[i] > max)
//     {
//         max = array[i];
//     }
// }
// Console.WriteLine($"Максимальное число массива: {max}");

// i = 0;
// float min = 0;
// if (array[0] == max)
// {
//     min = array[1];
//     while (i < array.Length)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//         i++;
//     }
// }
// else
// {   min = array[0];
//     while (i < array.Length)
//     {
//         if (array[i] < min)
//         {
//             min = array[i];
//         }
//         i++;
//     }
// }

// Console.WriteLine($"Минимальное число массива: {min}");
// float result = max - min;
// Console.WriteLine($"Разница между ними: {result}");