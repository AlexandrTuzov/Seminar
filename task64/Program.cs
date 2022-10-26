/*
Задайте значение N. Напишите программу,
которая выведет все натуральные числа в промежутке от N до 1.
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/
Console.WriteLine("Введите N");
int numberN = Convert.ToInt32(Console.ReadLine());
void RangePrint(int N)
{
    if (N == 0)
    {
        return;
    }
    Console.Write($"{N},");
    RangePrint(N-1);
}
RangePrint(numberN);