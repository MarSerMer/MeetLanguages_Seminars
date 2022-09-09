// Создать массив из 8 элементов, заполненный нулями и единицами в случайном порядке
int[] array = new int[8]; //создан массив на 8 элементов, сейчас он заполнен нулями
Random rand = new Random();
for (int i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(0,2);
}

Console.WriteLine(string.Join(", ", array));