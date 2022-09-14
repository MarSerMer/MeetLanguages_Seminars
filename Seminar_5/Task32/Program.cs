// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] array = new int[4];
Random rand = new Random();
int i = 0;
for (i = 0; i < array.Length; i++)
{
    array[i] = rand.Next(-9,10);
}
Console.Write("Получился массив ");
Console.WriteLine(string.Join(" ,", array));

for (i=0; i < array.Length; i++)
{
    array[i] = array[i]*-1;
}
Console.Write("Новый массив ");
Console.WriteLine(string.Join(" ,", array));