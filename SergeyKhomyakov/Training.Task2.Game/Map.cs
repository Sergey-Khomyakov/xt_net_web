using System;

namespace Training.Task2.Game
{
    class Map
    {
        private int _Width;
        private int _Height;

        public Map()
        {
            _Width = 1000;
            _Height = 500;
        }
        public Map(Player player, Monster monster, Bonuses bonuses, Obstacles obstacles)
        {

        }
        public virtual void Motion() { }
        public virtual void Position() { }

    }
}
