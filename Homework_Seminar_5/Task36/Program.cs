// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
int [] array = new int[20];
Random rand = new Random();
int i = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0, 151);
}
Console.WriteLine("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", array));
int sum = 0;
i = 1;
while (i<array.Length)
{
    sum = sum + array[i];
    i = i + 2;
}
Console.WriteLine($"Искомая сумма равна {sum}");
