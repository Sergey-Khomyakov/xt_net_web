using System;

namespace Training.Task2.Game
{
    class Player
    {
        public int PositionX {get; set; }
        public int PositionY { get; set; }

        private int _Health;

        public Player()
        {
            this._Health = 100;
        }
        public void Move(int x, int y) { }

        public void takeItem(int item) { }
    }
}
