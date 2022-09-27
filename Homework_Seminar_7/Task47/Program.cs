// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] CreateMatrix(int strings, int columns)
{
    double[,] NewMatrix = new double[strings, columns];
    Random rand = new Random();
    for (int i = 0; i < NewMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < NewMatrix.GetLength(1); j++)
        {
            NewMatrix[i, j] = rand.NextDouble() + rand.Next(-10,10);
            
        }
    }
    return NewMatrix;
}


int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMatrix (double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double number = matrix[i,j];
            Console.Write($"  {number:f1}");
        }
        Console.WriteLine();
    }
}

int Strings1 = ReadNumber("Введите количество строк");
int Columns1 = ReadNumber("Введите количество столбцов");

double [,] Matrix = CreateMatrix (Strings1, Columns1);
PrintMatrix(Matrix);