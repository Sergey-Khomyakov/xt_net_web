using System;

namespace Training.Task2.Game
{
    class Map
    {
        private int _Width;
        private int _Height;
        private Player _player;
        private Monster _monster;
        private Bonuses _bonuses;
        private Obstacles _obstacles;

        public Map()
        {
            _Width = 1000;
            _Height = 500;
        }
        public Map(Player player, Monster monster, Bonuses bonuses, Obstacles obstacles)
        {
            _player = player;
            _monster = monster;
            _bonuses = bonuses;
            _obstacles = obstacles;
        }

    }
}
