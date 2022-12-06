using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, x3, x4, y1, y2, y3, y4;
            Console.WriteLine("Введите значения x и y для всех вершин трапеции в порядке обхода слева направо:");
            Console.WriteLine("x1:");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y1:");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x2:");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y2:");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x3:");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y3:");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("x4:");
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("y4:");
            y4 = Convert.ToDouble(Console.ReadLine());
            Figure.Trapezoid t = new Figure.Trapezoid(x1, x2, x3, x4, y1, y2, y3, y4);
            double[] sides = t.GetSides();
            if (t.IsReal())
            {
                Console.WriteLine("Такая фигура существует.");
                Console.WriteLine("Высота:" + t.h);
                Console.WriteLine("Площадь:" + t.GetSquare());
                Console.WriteLine("Периметр:" + t.GetPerimeter());
                Console.WriteLine("Cтороны:");
                for (int i = 0; i < sides.Length; i++)
                {
                    Console.WriteLine(sides[i]);
                }
            }
            else
            {
                Console.WriteLine("Такая фигура не может существовать!");
            }

            Console.ReadKey();
        }
    }
}
