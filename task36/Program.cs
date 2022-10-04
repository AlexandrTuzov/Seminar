/*
 Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/

Console.WriteLine("Введите длину массива: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());
int[] userArray = new int[arrayLength];


for (int i = 0; i < userArray.Length; i++)
{
    userArray[i] = new Random().Next(1, 11);
}


void getPrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]);
        if(i < array.Length -1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}


int getSumArrayElementsOddPosition(int[] array)
{
    int summ = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        summ += array[i];
    }
    return summ;
}


getPrintArray(userArray);
int sumNumber = getSumArrayElementsOddPosition(userArray);
Console.WriteLine($"Сумма чисел с нечетным индексом в массиве = {sumNumber}");