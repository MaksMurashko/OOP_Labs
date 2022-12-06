using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    public class Trapezoid
    {
        public double x1, x2, x3, x4, y1, y2, y3, y4,Side1,Side2,Side3,Side4,
        h;//Высота трапеции
        bool flag;//переменная для определения какие стороны-основания,а какие боковые;

        public Trapezoid(double x1, double x2, double x3, double x4, double y1, double y2, double y3, double y4)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.x3 = x3;
            this.x4 = x4;
            this.y1 = y1;
            this.y2 = y2;
            this.y3 = y3;
            this.y4 = y4;
        }
        public bool IsReal()
        {
            //Четырёхугольник-трапеция,если две стороны параллельны,а две другие нет
            //Два вектора параллельны,если cos угла между ними равен 1
            double cos1=(Math.Abs((x2 - x1)) * Math.Abs((x3 - x4)) + Math.Abs(y1 - y2) * Math.Abs(y3 - y4)) / (Math.Sqrt(Math.Pow(Math.Abs(x2-x1),2) + Math.Pow(Math.Abs(y2 - y1), 2)) * Math.Sqrt(Math.Pow(Math.Abs(x3 - x4), 2) + Math.Pow(Math.Abs(y3 - y4), 2)));
            double cos2 =(Math.Abs((x4 - x1)) * Math.Abs((x3 - x2)) + Math.Abs(y4 - y1) * Math.Abs(y3 - y2)) / (Math.Sqrt(Math.Pow(Math.Abs(x4 - x1), 2) + Math.Pow(Math.Abs(y4 - y1), 2)) * Math.Sqrt(Math.Pow(Math.Abs(x3 - x2), 2) + Math.Pow(Math.Abs(y3 - y2), 2)));
            if (cos1 == 1 && cos2 != 1)
            {
                h = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2) - Math.Pow((Math.Abs(x4-x1)),2));
                flag = true;
                return true;
            }
            else if (cos1 != 1 && cos2 == 1) 
            {
                h = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2) - Math.Pow((Math.Abs(x3 - x4)), 2));
                return true;
            }
            else
            {
                return false;
            }
        }
        public double[] GetSides()
        {
            Side1 = (double)(Math.Sqrt(Math.Pow(x1-x2,2)+ Math.Pow(y1 - y2,2)));
            Side2 = (double)(Math.Sqrt(Math.Pow(x2 - x3,2)+ Math.Pow(y2 - y3, 2)));
            Side3 = (double)(Math.Sqrt(Math.Pow(x3 - x4,2)+ Math.Pow(y3 - y4, 2)));
            Side4 = (double)(Math.Sqrt(Math.Pow(x4 - x1,2)+ Math.Pow(y4 - y1, 2)));
            double[] sides = {Side1,Side2,Side3,Side4};
            return sides;
        }
        public double GetPerimeter()
        {
            return Side1 + Side2 + Side3 + Side4;
        }
        public double GetSquare()
        {
            if (flag)
            {
                return (0.5 * h * (Side1+Side3));//полусумма оснований на высоту
            }
            else {
                return (0.5 * h * (Side4 + Side2));
            }
        }
    }
}