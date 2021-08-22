using System;
using FigureLib;
namespace FigureUse
{
    class Program
    {
        static IFigure figure;
        static void Main(string[] args)
        {
            
            string name;
            Console.WriteLine("выберите фигуру\nt-треугольник\nc-круг");
            do
            {
                name = Console.ReadLine();
                Console.Clear();
                Console.WriteLine(name);
                Console.WriteLine("выберите фигуру\nt-треугольник\nc-круг");
            }
            while (name.ToLower() != "c" && name.ToLower() != "t");

            if(name.ToLower() == "c")
            {
                DrawCircle();
            }
            else
            {
                DrawTriangle();
            }
        }

        public static void DrawCircle()
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("рисуем круг");
                Console.WriteLine("введите радиус круга");
                
                try
                {
                    double rad = double.Parse(Console.ReadLine());
                    figure = new Circle(rad);
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }

            Console.WriteLine("площадь круга равна {0}", figure.GetSquare());

            Console.ReadKey();
        }

        public static void DrawTriangle()
        {
            double a, b, c;
            
            while(true)
            {
                Console.Clear();
                Console.WriteLine("рисуем треугольник");

                try
                {
                    Console.WriteLine("введите первую сторону");
                    a = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите вторую сторону");
                    b = double.Parse(Console.ReadLine());
                    Console.WriteLine("введите третью сторону");
                    c = double.Parse(Console.ReadLine());
                    figure = new Triangle(a, b, c);
                    break;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadKey();
                }
            }

            double square = figure.GetSquare();
            Console.WriteLine("площадь треугольника равна {0}", figure.GetSquare());
            if(((Triangle)figure).IsRectangular())
            {
                Console.WriteLine("треугольник то прямоугольный!!!!");
            }
            else
            {
                Console.WriteLine("треугольник самый обычный");
            }
            Console.ReadKey();
        }
    }
}
