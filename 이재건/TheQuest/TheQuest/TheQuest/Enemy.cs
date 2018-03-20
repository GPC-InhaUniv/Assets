using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Enemy:Mover
    {
        private const int NearPlayerDistance = 50;
        private int hitPoints;
        public int Hitpoints { get { return hitPoints; } }
      
        public bool Dead
        {
            get
            {
                if (hitPoints <= 0)
                    return true;
                else return false;
            }
        }

        public Enemy(Game game, Point location,int hitPoints) :base(game,location)
        {
            this.hitPoints = hitPoints;

        }

        public abstract void Move(Random random);  //적들마다 움직이는 스타일이 다르기에 추상클래스 선언
        
        public void DamagedByPlayer(int maxDamage,Random random)
        {
            if (hitPoints >= 0)
            {
                game.HitImage.Location = new Point(this.location.X - 10, this.location.Y + 10);
                game.HitImage.Visible = true;
                hitPoints -= random.Next(1, maxDamage);
            }
            else
            {
                //dead
            }
        }

        protected bool NearPlayer()
        {
            return (NearbyObject(game.PlayerLocation, NearPlayerDistance));
        }

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMovePlayer;
            if (playerLocation.X > location.X + 10)
                directionToMovePlayer = Direction.Right;
            else if (playerLocation.Y > location.Y + 10)
                directionToMovePlayer = Direction.Down;
            else if (playerLocation.X < location.X - 10)
                directionToMovePlayer = Direction.Left;
            else directionToMovePlayer = Direction.Up;

            return directionToMovePlayer;
        }

        public void AttackPlayer(int maxDamage,Random random)
        {
            if (Dead == false)
                game.DamageToplayer(maxDamage, random);
        }

        
    }
}
