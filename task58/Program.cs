/*
Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Write(" Количество  строк   матрицы 1: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write(" Количество столбцов матрицы 1: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write(" Количество столбцов матрицы 2: ");
int o = Convert.ToInt32(Console.ReadLine());


void FillArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      array[i, j] = new Random().Next(0,10);
    }
  }
   
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


int[,] matrix1 = new int[m, n];

FillArray(matrix1);
Console.WriteLine($"Матрица 1:");
PrintArray(matrix1);


int[,] matrix2 = new int[n, o];

FillArray(matrix2);
Console.WriteLine($"Матрица 2:");
PrintArray(matrix2);


int[,] resultMatrix = new int[m,o];


void MatrixMultiplication(int[,] matrix1, int[,] matrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int product = 0;
      for (int k = 0; k < matrix1.GetLength(1); k++)
      {
        product += matrix1[i,k] * matrix2[k,j];
      }
      resultMatrix[i,j] = product;
    }
  }
}


MatrixMultiplication(matrix1, matrix2, resultMatrix);
Console.WriteLine($"Произведение матриц:");
PrintArray(resultMatrix);