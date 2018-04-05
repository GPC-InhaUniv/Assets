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
        private Bitmap playerImage;
        private Rectangle boundaries;
        public int Life;
        public PlayerShip(Rectangle boundaries, int life)
        {
            this.boundaries = boundaries;
            location.X = boundaries.Width / 2 - 27;
            location.Y = boundaries.Height - 80;
            playerImage = Properties.Resources.player;
            Area = new Rectangle(location, playerImage.Size);
            Alive = true;
            this.Life = life;
        }
        public void Draw(Graphics g)
        {

            if (Life == 2)
                g.DrawImage(playerImage, new Rectangle(location.X, location.Y, playerImage.Width, playerImage.Height - 10));
            else if (Life == 1)
                g.DrawImage(playerImage, new Rectangle(location.X, location.Y, playerImage.Width, playerImage.Height - 20));
            else if (Life == 0)
            {
                g.DrawImage(playerImage, new Rectangle(location.X, location.Y, playerImage.Width, playerImage.Height - 30));
                g.DrawImage(Properties.Resources.Boom1, new Point(location.X-20,location.Y-50));
            }
            else
                g.DrawImage(playerImage, location);

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
