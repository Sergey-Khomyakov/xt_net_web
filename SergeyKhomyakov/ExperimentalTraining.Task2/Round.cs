using System;

namespace ExperimentalTraining.Task2
{

    class Round
    {
        private double R { get; set; }
        private double X { get; set; }
        private double Y { get; set; }
        public Round(double x, double y, double r)
        {
            this.X = x;
            this.Y = y;
            this.R = r;  
        }
        private double Square
        {
            get
            {
                return Math.PI * R * R;
            }
        }
        private double Length 
        {
            get
            {
                return 2 * Math.PI * R;
            }
        }
        public void ShowRound()
        {
            Console.WriteLine("X = {0} Y = {1} R = {2}", X, Y, R);
            Console.WriteLine("Длина круга = {0:0.##}", Length);
            Console.WriteLine("Площадь круга = {0:0.##}", Square);
        }
    }
}
