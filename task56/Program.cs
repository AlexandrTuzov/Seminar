/*
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке
и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = FillArray(rows, columns);

PrintArray(array);
Console.WriteLine();

int[,] FillArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(0,10);
        }

    }
    return result;
}


void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}


int SumRow(int[,] array, int i)
{
  int sumrow = array[i,0];
  for (int j = 1; j < array.GetLength(1); j++)
  {
    sumrow += array[i,j];
  }
  return sumrow;
}

int row = 0;
int minsumrow = SumRow(array, 0);

for (int i = 1; i < array.GetLength(0); i++)
{
  int sumrow1 = SumRow(array, i);
  if (sumrow1 < minsumrow)
  {
    minsumrow = sumrow1;
    row = i;
  }
}

Console.WriteLine($"Номер строки с наименьшей суммой элементов: {row+1}");
