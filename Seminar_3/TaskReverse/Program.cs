// Доп. задание
// Написать метод для разворота массива, не используя память под дополнительный массив

int[] array = new int[7];
Random rand = new Random();
int index = 0;
while (index < array.Length)
{
    array[index] = rand.Next(1,10);
    index++;
}

Console.WriteLine("Получился массив: " + string.Join(", ", array));

index = 0;
int index2 = array.Length - 1;
int number = array[index2];
while (index < array.Length / 2)
{
number = array[index2];
array[index2] = array[index];
array[index] = number;
index++;
index2 = index2 - 1;
}
Console.WriteLine("Получился новый массив: " + string.Join(", ", array));

