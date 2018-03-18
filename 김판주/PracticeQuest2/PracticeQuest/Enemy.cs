using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuest
{
    abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 25;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        public bool Dead { get { if (hitPoints <= 0) return true; else return false; } }

        public Enemy(Game game, Point location, int hitPoints)
            : base(game, location) { this.hitPoints = hitPoints; }

        public abstract void Move(Random random);

        public void Hit(int maxDamge, Random random)
        {
            hitPoints -= random.Next(1, maxDamge);
        }

        protected bool NearPlayer()
        {
            return (Nearby(game.PlayerLocation, NearPlayerDistance)); //플레이어와 적의 위치를 계산 근처에 있는가?
        }

        protected Direction FindPlayerDirection(Point playerLocation) //
        {
            Direction directionToMove;
            if (playerLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playerLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playerLocation.Y < location.Y + 10)
                directionToMove = Direction.Up;
            else
                directionToMove = Direction.Down;
            return directionToMove;
        }
    }
}
