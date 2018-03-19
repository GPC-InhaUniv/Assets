using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheQuest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        private int hitPoints;
        public int HitPoints { get{ return hitPoints; } }
        //private string type;
        public bool Dead
        {
            get
            {
                if (hitPoints <= 0) return true;
                return false;
            }
        }
        
        public Enemy(Game game, Point location, int hitPoints)
            :base(game, location)
        {
            this.hitPoints = hitPoints;
        }

        public abstract bool Move(Random randomDirection);

        public abstract string Name { get; }

        public void Hit(int maxDamage, Random random) 
        {
            if(!Dead) hitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            // 공격 범위 내에 플레이어가 있으면 공격
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            // playerLocation.X > location.X + 10 // 책이랑 다름
            Direction directionToMove;

            if (location.X > playerLocation.X + 10) directionToMove = Direction.Left;
            else if (location.X < playerLocation.X - 10) directionToMove = Direction.Right;
            else if (location.Y > playerLocation.Y + 10) directionToMove = Direction.Up;
            else directionToMove = Direction.Down;

            return directionToMove;
        }
    }
}
