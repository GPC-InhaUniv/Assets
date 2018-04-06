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
        private Brush shotBrush;

        public Point Location { get; private set; }

        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, Direction direction, Rectangle boundaries, Brush brush)
        {
            Location = location;
            shotBrush = brush;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public void Draw(Graphics g)
        {
            g.FillRectangle(shotBrush, Location.X, Location.Y, 5, 10);
        }

        public bool Move(Direction direction)
        {
            Point point = Location;
            switch (direction)
            {
                case Direction.Up:
                    point.Y -= moveInterval;
                    Location = point;
                    break;
                case Direction.Down:
                    point.Y += moveInterval;
                    Location = point;
                    break;
            }
            if(Location.X > boundaries.Width || Location.Y > boundaries.Height || Location.X < 0 || Location.Y < 0)
            {
                return false;
            }
            return true;
        }
    }
}
