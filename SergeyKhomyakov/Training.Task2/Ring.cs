using System;

namespace Training.Task2
{
    internal class Ring : Round
    {
        private double _interiorR;
        private double _r;
        public Ring(double x, double y, double r, double InteriorR) : base(x, y, r)
        {
            this._interiorR = InteriorR;
            this._r = r;
        }

        public double InteriorR {
            
            get { return _interiorR; }

            set {
                if (value < _r && value > 0)
                {
                    _interiorR = value;
                }
                else 
                {
                    throw new ArgumentException("Inner radius cannot be greater than outer !!!");
                }              
            }
        }

        public override double GetLength() => 2 * Math.PI * (_interiorR + _r);
        public override double GetSquare() => Math.PI * (Math.Pow(_r, 2) - Math.Pow(_interiorR, 2));
        public override void ShowRound()
        {
            Console.WriteLine($"Inner radius = {_r}");
            base.ShowRound();
        }
    }
}
