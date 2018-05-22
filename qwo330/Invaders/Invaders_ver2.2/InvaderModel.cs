using System.Drawing;

namespace Invaders
{
    class InvaderModel // FlyWeight Parttern
    {
        private const int HorizontalInterval = 40;
        private const int VerticalInterval = 10;

        private Bitmap image;
        public Bitmap Image { get { return image; } set { image = value; } }

        public Rectangle boundaries;

        public InvaderModel(Rectangle boundaries)
        {
            this.boundaries = boundaries;
        }

        public void Move(Direction direction, Point location)
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

        public void Draw(Graphics g, ShipType invaderType, int animationCell, Point location)
        {
            InvaderImage(invaderType, animationCell);
            if (image != null)
            {
                image = new Bitmap(image, new Size(50, 40));
                g.DrawImage(image, location);
            }
        }

        public void InvaderImage(ShipType invaderType, int animationCell)
        {
            switch (invaderType)
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