// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке 
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int [,] GetMatrix (int NumberFrom = 0, int NumberBefore = 10)// указали значения по умолчанию для диапазонов
{
    int[,] matrix = new int[3,4];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
        matrix [i,j] = rand.Next(NumberFrom, NumberBefore + 1);
        }
    }
    return matrix;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }
        Console.WriteLine();
    }
}


int [,] matr = GetMatrix(0, 10);
Console.WriteLine("Сгенерирован массив:");
PrintMatrix(matr);

int[] SumOfLines (int [,] matrix)
{
    int f = matrix.GetLength(0);
    int [] arrayOfSums = new int[f];
    
    for (int i = 0; i < matrix.GetLength(0); i++)
    {int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        sum +=matrix[i,j];
    
    arrayOfSums[i] = sum;
    }
    return arrayOfSums;
}

int[] array = SumOfLines(matr);
Console.WriteLine(" ");
//Console.WriteLine(string.Join(", ", array));

int findingMinNumber(int[] arr)
{
    int min = arr[0];
    int minI = 0;
    int i = 0;
    for (i = 0; i < arr.Length; i++)
    {
        if (arr[i] < min)
        {
            minI = i;
        }
    }
    return minI;
}
int MinSumLine = findingMinNumber(array);
Console.WriteLine($"Минимальная сумма элементов в строке номер {MinSumLine}"); //нумерация строк начинается с 0
