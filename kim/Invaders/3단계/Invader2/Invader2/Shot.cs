using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Invader2
{
    class Shot
    {
        private const int MoveInterval = 20;
        private const int Width = 5;
        private const int Height = 15;

        private Point location;
        public Point Location { get { return location; }}
        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location,Direction direction, Rectangle boundaries)
        {
            this.location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.Bullet, location);
        }
        public bool Move()
        {
            switch(direction)
            {
                case Direction.Up:
                    location.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    location.Y += MoveInterval;
                    break;
            }
            if(location.Y <boundaries.Top || location.Y > boundaries.Bottom)
            {
                return false;

            }
            return true;
        }

    }
}

