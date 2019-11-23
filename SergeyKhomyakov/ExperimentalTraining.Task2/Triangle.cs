using System;

namespace ExperimentalTraining.Task2
{
    class Triangle
    {
        private double A { get; set; }
        private double B { get; set; }
        private double C { get; set; }
        
        public Triangle(double a, double b, double c)
        {
            this.A = a;
            this.B = b;
            this.C = c;
        }
        private double Perimeter
        {
            get
            {
                return A + B + C;
            }
        }
        private double Square
        {
            get
            {
                double perimeter = (A + B + C) / 2;
                return Math.Sqrt(perimeter * (perimeter - A) * (perimeter - B) * (perimeter - C));
            }
        }

        public void ShowTriangle()
        {
            Console.WriteLine("Сторона A = {0} B = {1} C = {2}", A, B, C);
            Console.WriteLine("Периметр треугольника = {0:0.##}", Perimeter);
            Console.WriteLine("Площадь треугольника = {0:0.##}", Square);
        }
    }
}
