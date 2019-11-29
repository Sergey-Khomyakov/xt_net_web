using System;

namespace Training.Task2.Game
{
    abstract class Monster : Map
    {
        public abstract int PositionX { get; set; }
        public abstract int PositionY { get; set; }

        public abstract void Move(int x, int y);

    }
    class Bear : Monster
    {
        private int _health;
        public Bear() 
        {
           _health = 500;
        }

        public override int PositionX { get; set; }
        public override int PositionY { get; set; }

        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
    class Lion : Monster
    {
        private int _health;
        public Lion() 
        {
            _health = 300;
        }
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
    class Wolf : Monster
    {
        private int _health;

        public Wolf() 
        {
            _health = 200;
        }
        public override int PositionX { get; set; }
        public override int PositionY { get; set; }
        public override void Move(int x, int y)
        {
            throw new NotImplementedException();
        }
    }
}
