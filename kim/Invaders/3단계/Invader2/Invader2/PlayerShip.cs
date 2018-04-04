using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Invader2
{
    class PlayerShip
    {
        private const int MoveLen = 10;
        private Point location;
        public Point Location { get { return location; } }
        public Rectangle Area;
        public bool Alive { get; private set; }
        private Bitmap PlayerImage;
        private Rectangle boundaries;
        public int Life;
        public PlayerShip(Rectangle boundaries, int Life)
        {
            this.boundaries = boundaries;
            location.X = boundaries.Width / 2 - 27;
            location.Y = boundaries.Height - 80;
            PlayerImage = Properties.Resources.player;
            Area = new Rectangle(location, PlayerImage.Size);
            Alive = true;
            this.Life = Life;
        }
        public void Draw(Graphics g)
        {

            if (Life == 2)
                g.DrawImage(PlayerImage, new Rectangle(location.X, location.Y, PlayerImage.Width, PlayerImage.Height - 10));
            else if (Life == 1)
                g.DrawImage(PlayerImage, new Rectangle(location.X, location.Y, PlayerImage.Width, PlayerImage.Height - 20));
            else if( Life == 0)
                g.DrawImage(PlayerImage, new Rectangle(location.X, location.Y, PlayerImage.Width, PlayerImage.Height - 30));
            else
                g.DrawImage(PlayerImage, location);

        }

        public void Move(Direction direction)
        {
            if (Alive)
            {
                switch (direction)
                {
                    case Direction.Left:
                        if (boundaries.Left + 50 < this.location.X)
                        {
                            location.X -= MoveLen;
                            Area.Location = location;
                        }
                        break;
                    case Direction.Right:
                        if (boundaries.Right - 120 > this.location.X)
                        {
                            location.X += MoveLen;
                            Area.Location = location;
                        }
                        break;
                }
            }
        }

    }
}
