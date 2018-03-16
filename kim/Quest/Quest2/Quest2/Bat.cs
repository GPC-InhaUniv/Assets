using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Bat : Enemy
    {
        Rectangle boundaries;
        public Bat(Game game, Point location) : base(game, location, 6)
        {
            
            boundaries = game.Boundaries;
        }
       

        public override void Move(Random random)
        {
            Direction NewDirection = (Direction)random.Next(4);
            


            /*
            switch (NewDirection)
            {
                case Direction.Up:
                    location.Y -= MoveInterval;

                    break;
                case Direction.Down:
                    location.Y += MoveInterval;
                    break;
                case Direction.Left:
                    location.X -= MoveInterval;
                    break;
                case Direction.Right:
                    location.Y += MoveInterval;
                    break;
                default:
                    break;

            }*/

            switch(NewDirection)
            {
                case Direction.Up:
                    if(location.Y - MoveInterval >= boundaries.Top)
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



        }

    }
}

