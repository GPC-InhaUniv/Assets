using System.Drawing;

namespace Invaders
{
    class PlayerShip
    {
        public const int Interval = 20;

        Bitmap image;
        public Rectangle Area { get { return new Rectangle(location, image.Size); } }
        private Rectangle boundaries;

        public bool Alive = false;
        private Point location;
        public Point Location { get { return location; } set { location = value; } }

        public void Draw(Graphics g)
        {
            if(!Alive)
            {
                image = Properties.Resources.player;
                image = new Bitmap(image, new Size(50, 40));
            }
            else
            {
                image = new Bitmap(image, new Size(image.Width, image.Height - 1));
                if (image.Height < 2) Alive = false;
            }
            g.DrawImage(image, location);
        }

        public void Move(Direction direction)
        {
            switch(direction)
            {
                case Direction.Left:
                    if (location.X - Interval > 0) location.X -= Interval;
                    break;
                case Direction.Right:
                    if (location.X + Interval < boundaries.Width - 70) location.X += Interval;
                    break;
            }
        }

        public PlayerShip(Point location, Rectangle boundaries)
        {
            this.location = location;
            this.boundaries = boundaries;
        }
    }
}
