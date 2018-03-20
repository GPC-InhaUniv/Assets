using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    abstract class Mover
    {
        private const int MovePixel = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point targetLocation, int distance)
        {
            if (Math.Abs(location.X - targetLocation.X) < distance
                && Math.Abs(location.Y - targetLocation.Y) < distance) return true;
            return false;
        }

        public Point Move(Direction dir, Rectangle boundaries)
        {
            switch (dir)
            {
                case Direction.extendedUp:
                case Direction.Up:
                    if((location.Y - MovePixel) >= boundaries.Top)
                        location.Y -= MovePixel;
                    break;

                case Direction.Down:
                    if ((location.Y + MovePixel) <= boundaries.Bottom)
                        location.Y += MovePixel;
                    break;
                case Direction.extendedLeft:
                case Direction.Left:
                    if ((location.X - MovePixel) >= boundaries.Left)
                        location.X -= MovePixel;
                    break;

                case Direction.extendedRight:
                case Direction.Right:
                    if ((location.X + MovePixel) <= boundaries.Right)
                        location.X += MovePixel;
                    break;
                default: break;
            }
            return location;
        }
    }
}
