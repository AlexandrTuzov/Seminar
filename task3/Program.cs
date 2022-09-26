/*
Напишите программу, которая будет выдавать 
название дня недели по заданному номеру.
Например:
3 -> Среда
5 -> Пятница
*/
int namber = new Random().Next(1,8);

if (namber == 1) Console.WriteLine("Понедельник");
else if (namber == 2) Console.WriteLine("Вторник");
else if (namber == 3) Console.WriteLine("Среда");
else if (namber == 4) Console.WriteLine("Четверг");
else if (namber == 5) Console.WriteLine("Пятница");
else if (namber == 6) Console.WriteLine("Суббота");
else if (namber == 7) Console.WriteLine("Воскресенье");