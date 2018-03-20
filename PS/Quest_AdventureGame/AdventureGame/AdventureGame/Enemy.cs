using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    public abstract class Enemy : GameObject, IHittable
    {
        private const int NearPlayerDistance = 25;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        public bool Dead
        {
            get
            {
                if (hitPoints <= 0) return true;
                else return false;
            }
        }

        public Enemy(GameView gameView, Point location, int hitPoints) : base (gameView, location) {
            this.hitPoints = hitPoints; }

        public abstract void Move(Random random);        

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove = CheckPlayerDirection(playerLocation);

            return directionToMove;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public Direction CheckPlayerDirection(Point playerLocation)
        {
            Direction direction;
            if (playerLocation.X > location.X + 10)
                direction = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                direction = Direction.Left;
            else if (playerLocation.Y < location.Y - 10)
                direction = Direction.Up;
            else
                direction = Direction.Down;
            return direction;
        }
        
    }
}
