using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습3_Invader
{
    class PlayerShip
    {
        public Point Location;
        public Rectangle Area;
        public bool Alive;
        private Bitmap playerBitmap;
        public PlayerShip(Point location, Rectangle boundaries)
        {
            this.Area = boundaries;
            this.Location = location;
            this.Alive = true;
            playerBitmap = new Bitmap(Properties.Resources.player);
        }

        public void Draw(Graphics g)
        {
            //Size size = Properties.Resources.player.Size;

            if (!Alive)
            {
                g.DrawImage(playerBitmap, Location);
            }

            else
            {
                g.DrawImage(playerBitmap, Location);
            }
        }

        public void Move(Direction direction)
        {
            Point location = Location;
            switch (direction)
            {
                case Direction.Left:
                    if (Location.X > 0)
                    {
                        Location.X -= 10;
                        break;
                    }
                    else
                    {
                        Location.X -= 0;
                        break;
                    }

                case Direction.Right:
                    if (Location.X < Area.X)
                    {
                        Location.X += 10;
                        break;
                    }
                    else
                    {
                        location.X = 668;
                        break;
                    }
            }
        }
    }
}
