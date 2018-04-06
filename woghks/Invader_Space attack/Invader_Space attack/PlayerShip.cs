using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader_Space_attack
{
    class PlayerShip
    {
        private Point location;
        public Point Location { get { return location; } }
        public Rectangle Area { get; private set; }
        public bool Alive { get; private set; }
        private const int moveinterval = 10;
        Point temp = new Point();


        public PlayerShip(Point Location, Rectangle Area)
        {
            this.location = Location;
            this.Area = Area;

        }

        public Point Move(Direction direction)
        {

            switch (direction)
            {

                case Direction.Left:
                    temp = new Point(Location.X - moveinterval, Location.Y);
                    if (Area.Left < Location.X - moveinterval)

                        location = temp;
                    break;

                case Direction.Right:
                    temp = new Point(Location.X + moveinterval, Location.Y);
                    if (Area.Right - 45 > Location.X + moveinterval)

                        location = temp;
                    break;

                default: break;
            }
            return location;

        }

        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.player, Location);

        }
    }

}
