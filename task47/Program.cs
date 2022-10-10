/*
 Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/
Console.Write("Ввести количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Ввести количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] matr = new double[m,n];

FillArray(matr);

void FillArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        { 
            matrix[i,j] = new Random().NextDouble()*10; 
            Console.Write($"{matrix[i,j]:f2}  ");
        }
    Console.WriteLine();
    }
    
}