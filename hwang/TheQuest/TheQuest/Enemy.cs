using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Enemy : Mover
    {

        private const int NearPlayerDistance = 25;
        private int enemiesLife;
        public int EnemiesLife { get { return enemiesLife; } }

        public bool Dead
        {
            get
            {
                if (enemiesLife <= 0)
                {
                    return true;
                }
                else return false;
            }
        }

        public Enemy(Game game, Point location,int enemiesLife) 
            : base(game, location)
        {
            this.enemiesLife = enemiesLife;
        }

        public abstract void Move(Random random);

        public void Damaged(int maxDamage , Random random)
        {
            enemiesLife -= random.Next(1, maxDamage);
            if (enemiesLife <= 0)
            {
                enemiesLife = 0;
            }
        }
        public bool NearPlayer()
        {
            return (NearBy(game.PlayerLocation, NearPlayerDistance));
        }
        public MoveDirection FindPlayer(Point playerLocation)
        {
            MoveDirection directionToMove;

            if(playerLocation.X >location.X + 10)
            {
                directionToMove = MoveDirection.MoveRight;
            }
            else if (playerLocation.X > location.X - 10)
            {
                directionToMove = MoveDirection.MoveLeft;
            }
            else if (playerLocation.Y > location.Y + 10)
            {
                directionToMove = MoveDirection.MoveDown;
            }
            else 
            {
                directionToMove = MoveDirection.MoveUP;
            }
            return directionToMove;
        }

    }
}
