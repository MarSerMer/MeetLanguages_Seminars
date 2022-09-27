// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 1 7 -> такого числа в массиве нет

int [,] GetMatrix (int NumberFrom = -10, int NumberBefore = 10)// указали значения по умолчанию для диапазонов
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
            Console.Write($"{matrix[i,j]}\t");
        }
        Console.WriteLine();
    }
}

int [,] myNiceMatrix = GetMatrix(-10,10);
PrintMatrix(myNiceMatrix);

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numberOfString = ReadNumber("Введите номер строки"); //здесь я подразумеваю ввод значений от 0
int numberOfColumn = ReadNumber("Введите номер столбца"); //здесь я подразумеваю ввод значений от 0

if (numberOfString<myNiceMatrix.GetLength(0) && numberOfColumn<myNiceMatrix.GetLength(1))
{
    Console.WriteLine(myNiceMatrix[numberOfString,numberOfColumn]);
}
else
{
    Console.WriteLine("В матрице нет такого элемента");
}
