using System;

namespace ExperimentalTraining.Task2
{
    internal class Ring : Round
    {
        private double interiorR;
        private double R;
        public Ring(double x, double y, double r, double InteriorR) : base(x, y, r)
        {
            this.interiorR = InteriorR;
            this.R = r;
        }

        public double InteriorR {
            
            get { return interiorR; }

            set {
                if (value < R && value > 0)
                {
                    interiorR = value;
                }               
            }
        }

        public override double GetLength() 
        {
            return 2 * Math.PI * (interiorR + R);
        }
        public override double GetSquare() 
        {
            return Math.PI * (Math.Pow(R, 2) - Math.Pow(interiorR, 2));
        }
        public override void ShowRound()
        {
            Console.WriteLine($"Внутренний радиус = {R}");
            base.ShowRound();
        }
    }
}
