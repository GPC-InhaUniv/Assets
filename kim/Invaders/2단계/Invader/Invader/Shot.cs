using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader
{
    class Shot
    {
        private const int MoveInterval = 20;
        private const int Width = 5;
        private const int Height = 15;

        public Point Location;

        private Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, Direction direction, Rectangle boundaries)
        {
            this.Location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }
        public void Draw(Graphics g)
        {
            g.DrawImage(Properties.Resources.Bullet, Location);

        }

        public bool Move()
        {
            switch(direction)
            {
                case Direction.Up:
                    Location.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    Location.Y += MoveInterval;
                    break;
            }
            if( Location.Y < boundaries.Top || Location.Y >boundaries.Bottom)
            {
                return false;
            }

            return true;
        }
    }
}
