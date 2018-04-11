using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    class Shot
    {
        private const int moveInterval = 20;
        private const int width = 5;
        private const int height = 15;
        private Point location;
        public Point Location { get { return location; } }
        private SolidBrush brushYellow;
        private SolidBrush brushRed;
        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            this.location = location;
            this.direction = direction;
            this.boundaries = boundaries;
            brushYellow = new SolidBrush(Color.Yellow);
            brushRed = new SolidBrush(Color.Red);
        }

        public void Draw(Graphics g)
        {
            if(direction.Equals(Direction.Up))
                g.FillRectangle(brushYellow, Location.X+24, Location.Y, width, height);
            else
                g.FillRectangle(brushRed, Location.X + 25, Location.Y+20, width, height);
        }

        public bool Move()
        {
            if(direction.Equals(Direction.Up))
            {
                if (location.Y > boundaries.Top)
                {
                    location.Y -= moveInterval;
                    return true;
                }
                else
                    return false;
            }
            else
            {
                if (location.Y <boundaries.Bottom)
                {
                    location.Y += moveInterval;
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
