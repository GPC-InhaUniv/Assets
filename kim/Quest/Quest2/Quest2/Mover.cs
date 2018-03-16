using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    abstract class Mover
    {
        protected const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
            
        {
            this.game = game;
            this.location = location;
            
        }

        public Point Move(Direction direction, Rectangle boundaries)
        {
            
            Point newLocation = location;

            switch(direction)
            {
                case Direction.Up:
                    if(newLocation.Y - MoveInterval>= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if(newLocation.X -MoveInterval >= boundaries.Left)
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default:
                    break;
                   
            }


            return newLocation;
        }

        public bool Nearby(Point locationToCheck, int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
                return true;
            else
                return false;
        }
        public bool Nearby(Point Enemylocation, Point target, int radius)
        {
            if (Math.Abs(target.X - Enemylocation.X) < radius && Math.Abs(target.Y - Enemylocation.Y) <radius)
                return true;
            else
                return false;
        }
        public bool Nearby(Point Enemylocation, Direction direction, int radius)
        {
            switch(direction)
            {
                case Direction.Up:
                    if (location.Y - Enemylocation.Y > 0 && location.Y - Enemylocation.Y < radius)
                    {
                        return true;
                    }
                    return false;

                 
                case Direction.Down:
                    if (location.Y - Enemylocation.Y < 0 && location.Y - Enemylocation.Y > - radius)
                    {
                        return true;
                    }
                    return false;
                  
                  
                case Direction.Left:
                    if(location.X -Enemylocation.X > 0 && location.X - Enemylocation.X <radius)
                    {
                        return true;
                    }
                    return false;
                   
                case Direction.Right:
                    if(location.X - Enemylocation.X < 0 && location.X - Enemylocation.X > -radius)
                    {
                        return true;
                    }
                    return false;
                   

                default:
                    return false;
                  
            }
          
        }
    }
}
