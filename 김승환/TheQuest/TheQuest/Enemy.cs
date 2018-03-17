//Completed
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    public abstract class Enemy : Mover
    {
        private const int NearPlayerDistance = 10;
        private int hitPoints;
        public int HitPoints
        {
            get => hitPoints;
        }
        public bool Dead
        {
            get
            {
                if(hitPoints == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public Enemy(Game game, Point location, int hitPoints) : base(game, location)
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

        protected Direction FindPlayerDirection(Point playerLocation)
        {
            Direction directionToMove;
            if(playerLocation.X > location.X + 10)
            {
                directionToMove = Direction.Right;
            }
            else if(playerLocation.X < location.X - 10)
            {
                directionToMove = Direction.Left;
            }
            else if(playerLocation.Y > location.Y + 10)
            {
                directionToMove = Direction.Down;
            }
            else
            {
                directionToMove = Direction.Up;
            }
            return directionToMove;
        }
    }

    public class Bat : Enemy
    {
        public Bat(Game game, Point location) : base(game, location, 6)
        {

        }

        public override void Move(Random random)
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if(random.Next(1, 3) == 1)
            {
                location = Move(direction, game.Boundaries);
            }
            else
            {
                location = Move((Direction)random.Next(0, 4), game.Boundaries);
            }
            if(NearPlayer())
            {
                game.HitPlayer(2, random);
            }
        }
    }

    public class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8)
        {

        }

        public override void Move(Random random)
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if (random.Next(1, 4) == 1)
            {
                location = Move(direction, game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }

    public class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {

        }

        public override void Move(Random random)
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if (random.Next(1, 4) != 1)
            {
                location = Move(direction, game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }
}
