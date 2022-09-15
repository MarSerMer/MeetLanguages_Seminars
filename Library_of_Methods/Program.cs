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
Console.Write("Сгенерирован массив: ");
Console.WriteLine(string.Join(", ", arr));


// СОЗДАЁМ НОВЫЙ МАССИВ, И ЕГО ЗАПОЛНЯЕТ ПОЛЬЗОВАТЕЛЬ

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
    bool FindingNumber = false; // ФЛАГ ОПУЩЕН
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == findNumber)
        {
            FindingNumber = true; // ЕСЛИ ХОТЬ ОДИН ЭЛЕМЕНТ НАЙДЁН, ФЛАГ ПОДНИМАЕТСЯ И БОЛЬШЕ УЖЕ НЕ ОПУСТИТСЯ!
        }
    }
    return FindingNumber;
}
bool result = FindingNumber(arr, number);
Console.WriteLine(result);

//ИЩЕМ ПОЛОЖИТЕЛЬНЫЕ ЧИСЛА В МАССИВЕ

int findPosNumbers(int[] arr)
{ int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

// ИЩЕМ ЧЁТНЫЕ ЧИСЛА В МАССИВЕ

int findEvenNumbered(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i]%2 ==0)
        {
            count++;
        }
    }
    return count;
}


// ИЩЕМ МАКСИМАЛЬНОЕ ЗНАЧЕНИЕ В МАССИВЕ
int findingMaxNumber(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }
    return max;
}
int arrayMax = findingMaxNumber(arr);
Console.WriteLine(arrayMax);

// ИЩЕМ МИНИМАЛЬНОЕ ЗНАЧЕНИЕ В МАССИВЕ
int findingMinNumber(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            min = arr[i];
        }
    }
    return min;
}

int arrayMin = findingMinNumber(arr);
Console.WriteLine(arrayMin);