using System;

namespace ExperimentalTraining.Task2
{
    class Triangle
    {
        private double A;
        private double B;
        private double C;
        
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        private double GetPerimeter() 
        {
            return A + B + C;
        }
        private double GetSquare() 
        {
                double perimeter = (A + B + C) / 2;
                return Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
        }

        public void ShowTriangle()
        {
            Console.WriteLine("Сторона A = {0} B = {1} C = {2}", A, B, C);
            Console.WriteLine("Периметр треугольника = {0:0.##}", GetPerimeter());
            Console.WriteLine("Площадь треугольника = {0:0.##}", GetSquare());
        }
    }
}
