// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.

// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}


int numM = ReadNumber("Введите число М");
int numN = ReadNumber("Введите число N");

int Ackermann (int m, int n)
{ int a = 0;
    if (m==0) 
    {
        return a = n+1;
    }
    else
    {
        if (m>0 && n==0)
        {
            return a = Ackermann(m-1, 1);
        }
        else
        {
            if (m>0 && n>0)
            {
                return a = Ackermann(m-1, Ackermann(m,n-1));
            }
            else
            {
                return 0;
            }
        }
        }
    

}
int result = Ackermann(numM,numN);
Console.WriteLine(result);