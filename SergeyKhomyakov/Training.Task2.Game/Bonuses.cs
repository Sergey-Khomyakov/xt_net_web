using System;

namespace Training.Task2.Game
{
    abstract class Bonuses : Map
    {
        public abstract int X { get; set; }
        public abstract int Y { get; set; }

    }

    class Apple : Bonuses
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public Apple() 
        {
            X = 12;
            Y = 30;
        }
    }
    class Cherry : Bonuses
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public Cherry() 
        {
            X = 55;
            Y = 33;
        }
    }
}
