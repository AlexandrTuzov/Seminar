/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/
Console.WriteLine();
int rowsX = ConvertToInt(" Введите X: ");
int rowsY = ConvertToInt(" Введите Y: ");
int rowsZ = ConvertToInt(" Введите Z: ");
Console.WriteLine();

int[,,] userArray = new int[rowsX, rowsY, rowsZ];
NewRandomArray(userArray);
PrintIndexArrayElements(userArray);
Console.WriteLine();

int ConvertToInt(string input)
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}

void PrintIndexArrayElements (int[,,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int k = 0; k < array.GetLength(2); k++)
      {
        Console.WriteLine( $"{array[i,j,k]} ({i}, {j}, {k})");
      }
    }
  }
}

void NewRandomArray(int[,,] array)
{
  int[] num = new int[array.GetLength(0) * array.GetLength(1) * array.GetLength(2)];
  int number = 0;
  for (int i = 0; i < num.GetLength(0); i++)
  {
    num[i] = new Random().Next(10, 100);
    number = num[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (num[i] == num[j])
        {
          num[i] = new Random().Next(10, 100);
          j = 0;
          number = num[i];
        }
          number = num[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array.GetLength(0); x++)
  {
    for (int y = 0; y < array.GetLength(1); y++)
    {
      for (int z = 0; z < array.GetLength(2); z++)
      {
        array[x, y, z] = num[count];
        count++;
      }
    }
  }
} 
