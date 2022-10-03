/*
Напишите программу, в которой пользователь задает длину массива,
элементы которого задаются в диапазоне [1,99] и выводит на экран .
5 -> [1, 2, 5, 7, 19]
3 -> [6, 1, 33]
*/
int[] CreateArray()

{
    Console.Write("Введите число элементов массива:");
    int number = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите минимальное число:");
    int minnumber = Convert.ToInt32(Console.ReadLine());

    Console.Write("Введите максимальное число:");
    int maxnumber = Convert.ToInt32(Console.ReadLine());

        int[] array = new int[number];

        for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(minnumber , maxnumber+1);
        }

    Console.WriteLine(String.Join(",", array));

    return array;
}

CreateArray();