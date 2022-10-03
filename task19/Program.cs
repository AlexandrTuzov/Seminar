/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/
Console.WriteLine("Введите число");
string numberX =  Console.ReadLine();
Console.WriteLine(numberX);
char[] antinambrX = numberX.ToCharArray();
Array.Reverse(antinambrX);
string finalnuberX = new string(antinambrX);
if (numberX == finalnuberX)
{
    Console.WriteLine("Палиндром");
}
else
{
    Console.WriteLine("Не палиндром");
}