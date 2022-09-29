/*
Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]
*/
void printArray(int[] incomingArray)
{
    Console.Write("[");
    for (int i = 0; i < incomingArray.Length; i++)
    {
        Console.Write(incomingArray[i]);
        if (i < incomingArray.Length - 1)
        {
            Console.Write(",");
        }
    }
    Console.WriteLine("]");
}

Console.WriteLine();
Console.Write("Введите размер массива:\t");
int elementsArr = Convert.ToInt32(Console.ReadLine());
int [] arr1 = new int[elementsArr];
//int i = 0;
for (int i = 0; i < arr1.Length; i++)
{
      Console.Write($"Введите число {i + 1}:\t"); 
      arr1[i] = Convert.ToInt32(Console.ReadLine()); 
}

for (int i = 0; i < elementsArr; i++)
{
    arr1[i] *= -1;
}
printArray(arr1);



// int maxValue1 = arr1.Max<int>();
// Console.Write($"Ответ: {maxValue1} максимальное из этих {i} чисел");
