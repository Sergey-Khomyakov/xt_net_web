using System;

namespace Training.Task2.Game
{
    abstract class Obstacles : Map
    {
        private int _X;
        private int _Y;

    }

    class Stones : Obstacles { }
    class Trees : Obstacles { }
}
