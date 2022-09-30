// Задача 62. Заполните спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 1 2 3 4
// 12 13 14 5
// 11 16 15 6
// 10 9 8 7

int[,] Matrix = new int[4,4];
int number = 1;
for (int j = 0; j < Matrix.GetLength(1); j++) //первый ряд, слева направо
{
Matrix[0,j] = number;
number++;
}
for (int i = 1; i < Matrix.GetLength(0); i++) //последний столбец, сверху вниз
{
    Matrix[i, Matrix.GetLength(1)-1] = number;
    number++;
}


for (int j = 2; j >=0; j--)//нижняя строка, справа налево
{
    Matrix[3,j] = number;
    number++;
}

for (int i = 2; i > 0; i--)
{
    Matrix[i,0] = number;
    number++;
}

for (int j = 1; j < 3; j++)
{
    Matrix[1,j] = number;
    number++;
}

for (int j = 2; j > 0; j--)
{
    Matrix[2,j] = number;
    number++;
}

void PrintMatrix (int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]}    ");
        }
        Console.WriteLine();
    }
}

PrintMatrix(Matrix);