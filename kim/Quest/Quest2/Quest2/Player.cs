using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Player : Mover , IHitable
    {
        

        public Player(Game game , Point location) : base ( game,location)
        {
            hitPoints = 10;
        }
        //전투-------------------------------
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        public void Hit(int maxDamage,Random random)
        {

        }





        // 이동-------------------------------
        public void Move(Direction direction)
        {
           
            location = Move(direction, game.Boundaries);
            
        }
    }
}
