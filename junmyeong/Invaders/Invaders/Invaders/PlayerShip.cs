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
        private Bitmap image;
        private Rectangle boundaries;
        private Point location;
        public Point Location { get { return location; } }
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location.X -20,Location.Y,image.Width,image.Height);
            }
        }
        public bool Alive = true;

        public PlayerShip(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            location.X = 330;
            location.Y = 810;
            image = Properties.Resources.player;
        }

        public void Draw(Graphics g)
        {
            if (!Alive)
            {
                g.DrawImage(Properties.Resources.explosion1,new Rectangle(Location.X,Location.Y,70,50));
            }else
            {
                g.DrawImage(Properties.Resources.player, Location);
            }
        }

        public void Move(Direction direction)
        {
            if (direction == Direction.Left)
            {
                if (boundaries.Left < location.X)
                    location.X -= 15;
                else
                    location.X = boundaries.Left;
            }
            else
                if (boundaries.Right - 55 > location.X)
                    location.X += 15;
                else
                    location.X = boundaries.Right-55;
        }
    }
}
