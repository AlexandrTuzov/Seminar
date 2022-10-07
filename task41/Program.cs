/*
Пользователь вводит с клавиатуры M чисел.
Посчитайте, сколько чисел больше 0 ввёл пользователь.
Например:
0,7, 8, -2, -2 -> 2
-1, -7, 567, 89, 223-> 3
*/
Console.Write("Введите количество чисел: ");

int quantity = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[quantity];
    
int count = 0;

void FillNumbers (int[] array)
{
    Console.Write("Ведите числа: ");

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
               

        if (array[i] > 0) count++;  

    }
    
    if (count > 0) Console.WriteLine($"Положительные числа: {count}");
    else Console.WriteLine("Нет положительных чисел");

}

FillNumbers(arr);