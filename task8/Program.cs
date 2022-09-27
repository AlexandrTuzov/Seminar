/*
Напишите программу, которая на вход 
принимает число (N), а на выходе 
показывает все чётные числа от 1 до N.
Например:
5 -> 2,4
8 -> 2,4,6,8
*/
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int x = 2; x < N+1; x++ )       
if  (x % 2==0)            
Console.Write($"{x},");