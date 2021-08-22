using System;
using System.Collections.Generic;
using System.Text;

namespace FigureLib
{
    /// <summary>
    /// треугольник по трем сторонам
    /// имеет площадь и проверку на прямоугольность
    /// </summary>
    public class Triangle : IFigure
    {
        private double _a, _b, _c;

        public double A
        {
            get
            {
                return _a;
            }
        }

        public double B
        {
            get
            {
                return _b;
            }
        }

        public double C
        {
            get
            {
                return _c;
            }
        }

        public Triangle(double a, double b, double c)
        {
            if (a > 0 && b > 0 && c > 0)
            {
                if (isTriangle(a, b, c))
                {
                    _a = a;
                    _b = b;
                    _c = c;
                }
                else
                {
                    throw new Exception("из данных длин сторон невозможно составить треугольник");
                }
            }
            else
            {
                throw new Exception("стороны должны быть положительные");
            }
        }

        /// <summary>
        /// площадь треугольника по формуле Герона
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            double p = getPHalf();
            return Math.Sqrt(p * (p - _a) * (p - _b) * (p - _c));
        }

        /// <summary>
        /// прямоугольный ли треугольник
        /// </summary>
        /// <returns></returns>
        public bool IsRectangular()
        {
            //попытался сократить код, создавая из сторон и сортируя массив, последний элемент и будет предполагаемой гипотенузой
            double[] lengths = new[] { _a, _b, _c };
            Array.Sort(lengths);
            if (lengths[2] * lengths[2] == (lengths[1] * lengths[1] + lengths[0] * lengths[0]))
                return true;
            return false;
        }

        private bool isTriangle(double a, double b, double c)
        {
            double[] lengths = new[] { a, b, c };
            Array.Sort(lengths);

            if (lengths[2] < lengths[1] + lengths[0])
                return true;
            return false;
        }
        /// <summary>
        /// полупериметр
        /// </summary>
        private double getPHalf()
        {
            return (_a + _b + _c) / 2;
        }
    }
}
