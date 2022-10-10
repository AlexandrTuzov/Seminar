/*
Напишите программу, которая на вход принимает позицию элемента в двумерном массиве
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
5 -> 9
индексы:
[0][1][2][3]
1 4 7 2
[4][5][6][7]
5 9 2 3
[8][9][10][11]
8 4 2 4
*/
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] array = new int[rows, columns];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i, j] = new Random().Next(0,100);
        }  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
       { 
         Console.Write($"{array[i,j]} ");          
       }
    Console.WriteLine();
}

Console.Write("Введите индекс строки: ");
int indexrows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите индекс столбца ");
int indexcolumns = Convert.ToInt32(Console.ReadLine());

if (indexrows > rows || indexcolumns > columns)
{
    Console.WriteLine("Такого элемента нет");
}
else
{
       Console.WriteLine(array[indexrows,indexcolumns]);
}
