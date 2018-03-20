using System;
using System.Drawing;

namespace TheQuest
{
    class BluePotion : Weapon, IPositionAble
    {
        private int increaseHealthPoint = 5;
        private int IncreasehealthPoint
        {
            get
            {
                return increaseHealthPoint;
            }
        }

        public BluePotion(Game game,Point location):base(game,location,"bluePortion")
        {

        }

        public void Used(Random random)
        {
            game.UsePotion(increaseHealthPoint,random);
                    
        }

       
    }
}
