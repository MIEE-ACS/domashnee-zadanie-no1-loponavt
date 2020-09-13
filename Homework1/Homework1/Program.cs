using System;

namespace Homework1
{
    class Program
    {
        static void Main()
        {
            Console.Write("Введите координаты первой вершины через enter: ");
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            Console.Write("Введите координаты второй вершины через enter: ");
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double a1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.Write("Введите координаты третьей вершины через enter: ");
            double x3 = double.Parse(Console.ReadLine());
            double y3 = double.Parse(Console.ReadLine());
            double a2 = Math.Sqrt(Math.Pow((x2 - x3), 2) + Math.Pow((y2 - y3), 2));
            double a3 = Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2));
            double периметр = a1 + a2 + a3;
            Console.WriteLine($"Периметр треугольника равен: {периметр:0.00}\n");
            double полумериметр = периметр / 2;
            double площадь = Math.Sqrt(полумериметр * (полумериметр - a1) * (полумериметр - a2) * (полумериметр - a3));
            Console.WriteLine($"Площадь треугольника равна: {площадь:0.00}\n");
        }
    }
}
