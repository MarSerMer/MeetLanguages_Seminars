// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int [,] GetMatrix (int sizeStrings, int sizeColumns, int NumberFrom = 0, int NumberBefore = 10)// указали значения по умолчанию для диапазонов
{
    int[,] matrix = new int[sizeStrings,sizeColumns];
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

int [,] matr = GetMatrix(10, 4);
PrintMatrix(matr);

void GetArithmeticMeanOfColumns (int [,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    { double columnSum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            columnSum = columnSum + matrix[i,j];
            
        }
        Console.WriteLine($"Сумма зачений в столбце {j} равна {columnSum}");
        double ArithmeticMean = columnSum/matrix.GetLength(0);
        Console.WriteLine($"Среднее арифметическое зачений в столбце {j} равно {ArithmeticMean:f2}");
    }
}

GetArithmeticMeanOfColumns(matr);