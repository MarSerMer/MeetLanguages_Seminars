// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// int[] array = new int[12];
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(-9,10);
// }
// Console.Write("Получился массив ");
// Console.WriteLine(string.Join(" ,", array));

// int sum1 = 0;
// int sum2 = 0;
// for (i = 0; i < array.Length; i++)
// {
// if (array[i] > 0)
//     {
//     sum1 = sum1 + array[i];
//     }
// else
//     {
//     sum2 = sum2 + array[i];
//     }
// }
// Console.WriteLine($"Сумма положительных чисел массива равна {sum1}");
// Console.WriteLine($"Сумма отрицательных чисел массива равна {sum2}");

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
Console.WriteLine(string.Join(", ", arr));

int GetPosSum (int[] arr)
{
    int sumPos = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            sumPos = sumPos + arr[i];
        }
    }
    return sumPos;
}

int GetOtrSum (int[] arr)
{
    int sumOtr = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0)
        {
            sumOtr = sumOtr + arr[i];
        }
    }
    return sumOtr;
}
int sum1 = GetPosSum(arr);
int sum2 = GetOtrSum(arr);

Console.WriteLine(sum1);
Console.WriteLine(sum2);