using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    abstract class Enemy : Mover
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


        public Enemy(Game game, Point location, int damagePoints) : base(game, location) { this.hitPoints = damagePoints; }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        //플레이어의 방향을 파악한 다음  어느쪽으로 가야 플레이어 한테 가까이 갈 수 있는지를 알려준다.
        protected Direction FindDirection(Point playLocation)
        {
            Direction directionToMove;
            if (playLocation.X > location.X + 10)
                directionToMove = Direction.Right;
            else if (playLocation.X < location.X - 10)
                directionToMove = Direction.Left;
            else if (playLocation.Y < location.Y - 10)
                directionToMove = Direction.Up;
            else directionToMove = Direction.Down;
            return directionToMove;
        }

    }

}
