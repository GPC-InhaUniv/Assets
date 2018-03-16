using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    abstract class Enemy : Mover , IHitable
    {
       
        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
        {
            this.hitPoints = hitPoints;
        }

        //전투-------------------------------
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        public void Hit(int maxDamage, Random random)
        {

        }
        //이동-------------------------------
        public abstract void Move(Random random);
        

    }
}
