// Задача 35: Задайте одномерный массив из 123 случайных чисел в диапазоне [0, 150]. 
// Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

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
int [] arr = GetArray(123, 0, 150);
Console.Write("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", arr));

int countingNumbers(int[] arrM)
{
    int count = 0;
    for (int i = 0; i < arrM.Length; i++)
    {
        if (arrM[i] >=10 && arrM[i]<=99)
        {
            count++;
        }
    }
    return count;
}
int result = countingNumbers(arr);
Console.WriteLine($"В данном массиве {result} чисел из промежутка [10,99]");



// Без методов:
// int [] array = new int[123];
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 151);
// }
// Console.WriteLine("Сгенерирован массив: ");
// Console.WriteLine(string.Join(", ", array));
// int count = 0;
// for (i=0; i<array.Length; i++)
// {
//     if (array[i]>=10 && array[i]<=99)
//     {
//         count = count + 1;
//     }
// }
// Console.WriteLine($"Искомое количество элементов: {count}");