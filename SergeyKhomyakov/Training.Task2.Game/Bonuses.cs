using System;

namespace Training.Task2.Game
{
    abstract class Bonuses : Map
    {
        private int _X;
        private int _Y;

    }

    class Apple : Bonuses { }
    class Cherry : Bonuses { }
}
