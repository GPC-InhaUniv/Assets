using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp12
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }
        public bool Dead { get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }
        public Enemy(Game game, Point location, int hitPoints)  
            : base (game, location) { this.hitPoints = hitPoints; }

        public abstract void Move (Random random);

        public void Hit (int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        //protected bool NearPlayer()
        //{
        //    return (NearPlayer (game.PlayerLocation, NearPlayerDistance));
        //}

        //protected Direction FindPlayerDirection (Point PlayerLocation)
        //{
        //    Direction directionToMove;
        //    if (PlayerLocation.X > location.X + 10)
        //        directionToMove = Direction.Right;

        //}
    }

}
