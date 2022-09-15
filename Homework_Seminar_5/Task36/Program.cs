// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

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
int [] arr = GetArray(12, 0, 18);
Console.Write("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", arr));

int findSum(int[] arr2)
{
    int i = 1;
    int sum = 0;
    while (i < arr2.Length)
    {
        sum +=arr[i];
        i = i + 2;
    }
    return sum;
}

int result = findSum(arr);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях: {result}");







// Без методов:
// int [] array = new int[20];
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(0, 151);
// }
// Console.WriteLine("Сгенерирован массив: ");
// Console.WriteLine(string.Join(", ", array));
// int sum = 0;
// i = 1;
// while (i<array.Length)
// {
//     sum = sum + array[i];
//     i = i + 2;
// }
// Console.WriteLine($"Искомая сумма равна {sum}");
