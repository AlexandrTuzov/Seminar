/*
Напишите программу, которая на вход принимает одно число (N),
а на выходе показывает все числа в промежутке от -N до N.
Например:
4 -> "-4,-3,-2,-1,0,1,2,3,4"
2 -> "-2,-1,0,1,2"
*/

Console.WriteLine("Введите число");
int namber = Convert.ToInt32(Console.ReadLine());
int count = -namber;
while (count <= namber)
{
    Console.Write($"{count}, ");
    count++;
}