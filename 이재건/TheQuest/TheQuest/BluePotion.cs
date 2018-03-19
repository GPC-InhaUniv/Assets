using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public BluePotion(Game game,Point location):base(game,location,"bluePotion")
        {

        }

        public void Used()
        {
            if (game.CheckPlayerInventory("BluePotion"))
                Console.WriteLine("물약사용");
                    
        }

        public void Attack()
        {
            Used();
        }
    }
}
