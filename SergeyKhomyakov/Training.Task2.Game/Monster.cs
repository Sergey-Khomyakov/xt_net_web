using System;

namespace Training.Task2.Game
{
    abstract class Monster : Map
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        private int _Damage;
        public abstract void Move(int x, int y);

    }
    class Bear : Monster
    {
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
    class Lion : Monster
    {
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
    class Wolf : Monster
    {
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
