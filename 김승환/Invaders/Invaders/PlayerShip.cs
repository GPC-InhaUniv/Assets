using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    class PlayerShip
    {
        private const int HorizontalInterval = 10;

        public Point Location { get; private set; }
        public bool Alive { get; private set; }

        private Image playerImage = Properties.Resources.player;
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, playerImage.Size);
            }
        }
        private Rectangle boundaries;

        public PlayerShip(Rectangle boundaries)
        {
            Alive = true;
            this.boundaries = boundaries;
            Point p = new Point(boundaries.Width / 2, boundaries.Bottom - 40);
            Location = p;
        }

        public void Draw(Graphics g)
        {
            g.DrawImage(playerImage, Location);
        }

        public void Move(Direction direction)
        {
            Point p = Location;
            switch(direction)
            {
                case Direction.Left:
                    if(Location.X > 0)
                    {
                        p.X -= HorizontalInterval;
                        Location = p;
                    }
                    break;
                case Direction.Right:
                    if (Location.X + 60 < boundaries.Width)
                    {
                        p.X += HorizontalInterval;
                        Location = p;
                    }
                    break;

            }
        }
    }
}
