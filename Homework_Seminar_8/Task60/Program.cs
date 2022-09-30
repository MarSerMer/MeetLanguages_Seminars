// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// массив размером 2 x 2 x 2
// 12(0,0,0) 22(0,0,1)
// 45(1,0,0) 53(1,0,1)

int[,,] TripleMatrix = new int[2,2,2];
Random rand = new Random();
int[] array = new int[8];

for (int i = 0; i <array.Length; i++)
{
    int number = rand.Next(10,100);
    if(array.Contains(number)) i--;
    else array[i] = number;
}
int count = 0;
for (int i = 0; i < 2; i++)
{
    for(int j = 0; j < 2; j++)
    {
        for (int f = 0; f < 2; f++)
        { 
            TripleMatrix[i,j,f] = array[count];
            count++;
            Console.WriteLine($"Элемент {i},{j},{f}  " + TripleMatrix[i,j,f]);
        }
    }
}