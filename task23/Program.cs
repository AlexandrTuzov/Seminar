/*
Напишите программу, которая принимает на вход число (N)
и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
class Program
    {
        static void Main(string[] args)
        {
          Console.Write("Введите число: ");
          int number = Convert.ToInt32(Console.ReadLine());

          int[] massiv = new int[number+1];
          Cube(massiv);
          Vivod(massiv);

        }

        static void Cube(int[] cube)
        {
           int counter = 0;
           int length = cube.Length;
           while (counter <  length)
           {
                  cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));
                  counter++;
           }
         }

         static void Vivod(int[] massiv)
         {
            int count = massiv.Length;
            int index = 1;
            while(index < count)
                  {
                  Console.Write(massiv[index]+ " ");
                  index++;
                  }
         }
    }