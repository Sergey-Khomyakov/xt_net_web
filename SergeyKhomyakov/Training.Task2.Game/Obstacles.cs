using System;

namespace Training.Task2.Game
{
    abstract class Obstacles : Map
    {
        public abstract int X { get; set; }
        public abstract int Y { get; set; }

    }

    class Stones : Obstacles
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public Stones() 
        {
            X = 5;
            Y = 6;
        }
    }
    class Trees : Obstacles
    {
        public override int X { get; set; }
        public override int Y { get; set; }

        public Trees() 
        {
            X = 10;
            Y = 29;
        }
    }
}
