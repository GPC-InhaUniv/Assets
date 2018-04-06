using System.Drawing;

namespace Invaders
{
    class Invader
    {
        private const int HorizontalInterval = 10; // X
        private const int VerticalInterval = 40; // Y

        private Bitmap image;

        private Point location;
        public Point Location { get { return location; } set { location = value; } }

        public ShipType InvaderType { get; private set; }

        public Rectangle Area { get { return new Rectangle(location, image.Size); } }
        private Rectangle boundaries;

        public int Score { get { return (int)InvaderType; } }

        public Invader(ShipType invaderType, Point location, Rectangle boundaries)
        {
            this.InvaderType = invaderType;
            this.location = location;
            this.boundaries = boundaries;
            image = Properties.Resources.bug1;
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                case Direction.Left:
                    if (location.X - HorizontalInterval > 0) location.X -= HorizontalInterval;
                    break;
                case Direction.Right:
                    if (location.X + HorizontalInterval < boundaries.Width - 70) location.X += HorizontalInterval;
                    break;
                case Direction.Down:
                    location.Y += VerticalInterval;
                    break;
            }
        }

        public void Draw(Graphics g, int animationCell)
        {
            InvaderImage(animationCell);
            if (image != null)
            {
                image = new Bitmap(image, new Size(50, 40));
                g.DrawImage(image, location);
            }
        }

        private void InvaderImage(int animationCell)
        {
            switch (InvaderType)
            {
                case ShipType.Bug:
                    switch (animationCell)
                    {
                        case 1: image = Properties.Resources.bug1; break;
                        case 2: image = Properties.Resources.bug2; break;
                        case 3: image = Properties.Resources.bug3; break;
                        case 4: image = Properties.Resources.bug4; break;
                        default: break;
                    }
                    break;
                case ShipType.Satellite:
                    switch (animationCell)
                    {
                        case 1: image = Properties.Resources.satellite1; break;
                        case 2: image = Properties.Resources.satellite2; break;
                        case 3: image = Properties.Resources.satellite3; break;
                        case 4: image = Properties.Resources.satellite4; break;
                        default: break;
                    }
                    break;
                case ShipType.Saucer:
                    switch (animationCell)
                    {
                        case 1: image = Properties.Resources.flyingsaucer1; break;
                        case 2: image = Properties.Resources.flyingsaucer2; break;
                        case 3: image = Properties.Resources.flyingsaucer3; break;
                        case 4: image = Properties.Resources.flyingsaucer4; break;
                        default: break;
                    }
                    break;
                case ShipType.Spaceship:
                    switch (animationCell)
                    {
                        case 1: image = Properties.Resources.spaceship1; break;
                        case 2: image = Properties.Resources.spaceship2; break;
                        case 3: image = Properties.Resources.spaceship3; break;
                        case 4: image = Properties.Resources.spaceship4; break;
                        default: break;
                    }
                    break;
                case ShipType.Star:
                    switch (animationCell)
                    {
                        case 1: image = Properties.Resources.star1; break;
                        case 2: image = Properties.Resources.star2; break;
                        case 3: image = Properties.Resources.star3; break;
                        case 4: image = Properties.Resources.star4; break;
                        default: break;
                    }
                    break;
            }
        }
    }
}
