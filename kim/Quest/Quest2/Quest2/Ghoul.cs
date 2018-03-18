using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Quest2
{
    class Ghoul : Enemy
    {
        Rectangle boundaries;
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {
            maxDamage = 4;
            boundaries = game.Boundaries;
        }


        public override void Move(Random random)
        {
            Direction NewDirection;
           

            int AI = random.Next(3);


            if (AI % 3 != 0)
            {

                NewDirection = FindPlayerDirection();
            }
            else
            {
                NewDirection = Direction.Stop;
            }
            switch (NewDirection)
            {
                case Direction.Up:
                    if (location.Y - MoveInterval >= boundaries.Top)
                    {
                        location.Y -= MoveInterval;
                    }

                    break;
                case Direction.Down:
                    if (location.Y + MoveInterval <= boundaries.Bottom)
                    {
                        location.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (location.X - MoveInterval >= boundaries.Left)
                    {
                        location.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (location.X + MoveInterval <= boundaries.Right)
                    {
                        location.X += MoveInterval;
                    }
                    break;
                default:
                    break;
            }


            if (NearPlayer())
            {
                game.GiveDamageToPlayer(maxDamage, random);
            }

        }
    }
}
