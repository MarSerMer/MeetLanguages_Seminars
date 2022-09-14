// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21
int [] array = new int [10];
Random rand = new Random();
int i = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(1,11);
}
Console.WriteLine(string.Join(" ,", array));
int [] arrayNew = new int [array.Length/2];
i = 0;
int t = array.Length - 1;
for (int j = 0; j < array.Length/2; j++)
{
    arrayNew[j] = array[i] * array[t];
    i = i + 1;
    t = t - 1;
}
Console.Write("Новый массив: ");
Console.WriteLine(string.Join(", ", arrayNew));
