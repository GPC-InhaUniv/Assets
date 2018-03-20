using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
   
    abstract class Mover
    {
        

        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        

        public bool Nearby(Point LocationToCheck, int distance)
        {
            if (Math.Abs(location.X - LocationToCheck.X) < distance &&
                Math.Abs(location.Y = LocationToCheck.Y) < distance)
                return true;
            else
                return false;
        }

        
       

        public Point Move(enumDirection direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch(direction)
            {
                case enumDirection.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case enumDirection.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case enumDirection.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case enumDirection.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                
            }

            return newLocation;
        }


    }
    
}
