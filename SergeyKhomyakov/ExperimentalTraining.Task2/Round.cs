using System;

namespace ExperimentalTraining.Task2
{

    class Round
    {
        private double R;
        private double X;
        private double Y;
        public Round(double x, double y, double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;  
        }
        private double GetSquare() 
        {
            return Math.PI * R * R;
        }
        private double GetLength() 
        {
            return 2 * Math.PI * R;
        }
        public void ShowRound()
        {
            Console.WriteLine("X = {0} Y = {1} R = {2}", X, Y, R);
            Console.WriteLine("Длина круга = {0:0.##}", GetLength());
            Console.WriteLine("Площадь круга = {0:0.##}", GetSquare());
        }
    }
}
