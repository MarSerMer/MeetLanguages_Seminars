// ВВОД ЧИСЛА ПОЛЬЗОВАТЕЛЕМ

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

// ГЕНЕРИРУЕМ МАССИВ ИЗ СЛУЧАЙНЫХ ЧИСЕЛ ИЗ ЗАДАННОГО ПРОМЕЖУТКА

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
int [] arr = GetArray(12, -9, 9);
Console.WriteLine(string.Join(", ", arr));

СОЗДАЁМ НОВЫЙ МАССИВ, И ЕГО ЗАПОЛНЯЕТ ПОЛЬЗОВАТЕЛЬ
int [] array = new int [8];
int ZaprosChisel (string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = 1;
for (int i = 0; i < array.Length; i++)
{
    array[i] = ZaprosChisel("Введите число " + num);
    num = num + 1;
}
Console.WriteLine(string.Join(", ", array));

// ИЩЕМ ЧИСЛО В МАССИВЕ (ОТВЕТ ДА/НЕТ)
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
bool result = FindingNumber(arr, number);
Console.WriteLine(result);