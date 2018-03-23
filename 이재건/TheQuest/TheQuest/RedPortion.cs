using System;
using System.Drawing;

namespace TheQuest
{
    class RedPotion : Weapon, IPositionAble
    {
        private int increaseHealthPoint = 10;
        private int IncreasehealthPoint
        {
            get
            {
                return increaseHealthPoint;
            }
        }

        public RedPotion(Game game, Point location) : base(game, location, "redPortion")
        {

        }

        public void Used(Random random)
        {
            game.UsePotion(increaseHealthPoint, random);

        }


    }
}
