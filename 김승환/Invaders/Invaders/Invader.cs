using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    public enum Type
    {
        Bug = 1,
        Saucer = 2,
        Satellite = 3,
        Spaceship = 4,
        Star = 5,
        Boss = 6
    }

    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;

        public Point Location { get; private set; }
        public Type InvaderType { get; private set; }
        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }

        public int Score { get; private set; }

        public Invader(Type invaderType, Point location, int score)
        {
            InvaderType = invaderType;
            Location = location;
            Score = score;
        }

        public void Move(Direction direction)
        {
            Point p = Location;
            switch(direction)
            {
                case Direction.Left:
                    p.X -= HorizontalInterval;
                    Location = p;
                    break;
                case Direction.Right:
                    p = Location;
                    p.X += HorizontalInterval;
                    Location = p;
                    break;
                case Direction.Up:
                    p = Location;
                    p.Y -= VerticalInterval;
                    Location = p;
                    break;
                case Direction.Down:
                    p = Location;
                    p.Y += VerticalInterval;
                    Location = p;
                    break;
            }
        }

        public void Draw(Graphics g, int animationCell)
        {
            image = InvaderImage(animationCell);
            g.DrawImage(image, Location);
        }

        private Bitmap InvaderImage(int animationCell)
        {
            return InvaderFactory.getInvaderImage(InvaderType, animationCell);
         }

    }
}
