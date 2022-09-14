// Задача 33: Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да
int [] array = {6,7,19,345,3};
int i = 0;
Console.WriteLine("Введите число и я проверю, есть ли такое в массиве");
int number = Convert.ToInt32(Console.ReadLine());
// for (i = 0; i < array.Length; i++)
// {
//     if (array[i] == number)
//     {
//         Console.WriteLine("Yes");
//         break;
//     }
    
// }
string message = "otvet";
for (i=0; i<array.Length; i++)
{
    if (array[i] == number) message = "Yes";
}
if (message == "Yes")
{
    Console.WriteLine("Yes");
}
else 
{
    Console.WriteLine("No");
}