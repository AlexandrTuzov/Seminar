/*
Напишите программу, которая принимает на вход координаты двух точек
и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/
  namespace Zadacha21
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координату x точки А");
            int x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y точки А");
            int y1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату z точки А");
            int z1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату x точки B");
            int x2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату y точки B");
            int y2=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату z точки B");
            int z2=Convert.ToInt32(Console.ReadLine());

            double segLen = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2 );
            Console.WriteLine($"Длина отрезка {segLen}");
        }

        static double Decision(double x1, double x2, double y1,
         double y2,  double z1, double z2)
        {
             return Math.Sqrt(Math.Pow((x2-x1),
              2) +  Math.Pow((y2-y1), 2) +  Math.Pow((z2-z1), 2));
        }
    }
}