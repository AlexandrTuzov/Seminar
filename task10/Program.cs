/*
Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа.
Например:
456 -> 5
782 -> 8
918 -> 1
*/
Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
while(number >= 100)
{
    number = number / 10;
}
if (number < 100)
{
    number = number % 10;
}
Console.WriteLine(number);