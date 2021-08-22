using System;

namespace FigureLib
{
    /// <summary>
    /// круг
    /// имеет площадь
    /// </summary>
    public class Circle : IFigure
    {
        /// <summary>
        /// радиус круга
        /// </summary>
        private double _radius;

        public double Radius
        {
            get
            {
                return this._radius;
            }
            set
            {
                if (value <= 0) throw new Exception("радиус должен быть положительным!");
                this._radius = value;
            }
        }


        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public double GetSquare()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
