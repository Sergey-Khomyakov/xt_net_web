using System;

namespace Training.Task2
{
    class Round
    {
        private double _r;
        private double _x;
        private double _y;
        public Round(double x, double y, double r)
        {
            this._x = x;
            this._y = y;
            this._r = r;            
        }
        public double R 
        {
            get 
            {
                return _r;
            }
            set
            {
                if (value > 0)
                {
                    _r = value;
                }
                else 
                {
                    throw new ArgumentException("Radius cannot be negative !!!");
                }
            }
        }
        public virtual double GetSquare() => Math.PI * _r * _r;
        public virtual double GetLength() => 2 * Math.PI * _r;
        public virtual void ShowRound()
        {
            Console.WriteLine("X = {0} Y = {1} R = {2}", _x, _y, _r);
            Console.WriteLine("Длина круга = {0:0.##}", GetLength());
            Console.WriteLine("Площадь круга = {0:0.##}", GetSquare());
        }
    }
}
