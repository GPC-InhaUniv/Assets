using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    
    abstract class Monster : Mover
    {
        enum enumMonster
        {
            Teemo,
            Yasuo,
            Masterei,
        }
        
        
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

        public Monster(Game game, Point location, int hitPoints)
            :base(game, location)
        {
            this.hitPoints = hitPoints;
            
        }

        public abstract void Move(Random random);

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        protected bool NearPlayer()
        {
            return Nearby(game.PlayerLocation, NearPlayerDistance);
        }

        protected enumDirection FindPlayerDirection(Point playerLocation)
        {
            enumDirection directionToMove;
            if (playerLocation.X > location.X + 10) directionToMove = enumDirection.Right; 
            else if (playerLocation.X < location.X - 10)  directionToMove = enumDirection.Left; 
            else if (playerLocation.Y < location.Y - 10)  directionToMove = enumDirection.Up; 
            else  directionToMove = enumDirection.Down; 

            return directionToMove;
        }
    }

    
}
