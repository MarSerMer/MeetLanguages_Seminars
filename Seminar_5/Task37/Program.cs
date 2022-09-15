// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

// Генерировала новый массив. В итоге это сделано ниже с помощью метода
// int [] array = new int [10]; 
// Random rand = new Random();
// int i = 0;
// for (i = 0; i < array.Length; i++)
// {
//     array[i] = rand.Next(1,11);
// }
// Console.WriteLine(string.Join(" ,", array));

int [] GetArray ( int size, int NumberFrom, int NumberBefore)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr [i] = rand.Next(NumberFrom, NumberBefore + 1);
    }
    return arr;
}
int [] array = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", array));

int [] arrayNew = new int [array.Length/2];
int i = 0;
int t = array.Length - 1;
for (int j = 0; j < array.Length/2; j++)
{
    arrayNew[j] = array[i] * array[t];
    i = i + 1;
    t = t - 1;
}
Console.Write("Новый массив: ");
Console.WriteLine(string.Join(", ", arrayNew));
