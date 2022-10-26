/*
Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/
Console.Write("Введите M: ");
int M = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

int size = (N - M) + 1;
int sum = 0;

int[] arr = new int[size];

SumArray(arr);

void SumArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
       array[i] = M;
       sum = sum + array[i];
       M++;
   }
}
Console.Write($"Сумма натуральных элементов в промежутке от M до N: {sum}");