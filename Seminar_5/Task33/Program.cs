// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да

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
 
// int [] array = {2, 3, 7, -12, 18, 45};
bool FindingNumber (int[] arr, int findNumber)
{
    bool FindingNumber = false;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            FindingNumber = true;
        }
    }
    return FindingNumber;
}

int NumberFromUser (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [] arr = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", arr));

int number = NumberFromUser("Введите искомое число");
bool result = FindingNumber(arr, number);
Console.WriteLine(result);

if (result == true)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}