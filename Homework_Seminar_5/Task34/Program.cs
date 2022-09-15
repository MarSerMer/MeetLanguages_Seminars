// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


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
int [] arr = GetArray(12, 100, 1000);
Console.Write("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", arr));

int findEvenNumbered(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 ==0)
        {
            count++;
        }
    }
    return count;
}

int otvet = findEvenNumbered(arr);
Console.WriteLine($"В данном массиве {otvet} чётных чисел");

// Без методов:
// int [] array = new int[10];
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(100, 1000);
// }
// Console.WriteLine("Сгенерирован массив: ");
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (i = 0; i < array.Length; i++)
// {
//     if (array[i]%2 == 0)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine($"В этом массиве чётных чисел: {count}");
