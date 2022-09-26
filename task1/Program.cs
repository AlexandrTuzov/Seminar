/*
Напишите программу, которая на вход принимает два числа и
проверяет, является ли первое число квадратом второго.
Например:
a = 25, b = 5 -> да
a = 2, b = 10 -> нет
a = 9, b = -3 -> да
a = -3, b = 9 -> нет
*/
Console.Write("Ввидите число A: ");
int namberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Ввидите число B: ");
int namberB = Convert.ToInt32(Console.ReadLine());
int square = namberB * namberB;
if (square == namberA)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
} 