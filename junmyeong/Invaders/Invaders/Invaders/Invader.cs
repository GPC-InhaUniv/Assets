using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    enum ShipType
    {
        Explosion,
        Satellite,
        Bug,
        Flyingsaucer,
        Spaceship,
        Star,
    }
    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;
        private int explosionSell = 0;
        public int ExplosionSell { get { return explosionSell; } }
        
        private Bitmap image;

        private Point location;
        public Point Location { get { return location; }}

        public ShipType InvaderType { get; private set; }
        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }

        public int Score { get; private set; }

        public Invader(ShipType invaderType, Point location, int score, Rectangle boundaries)
        {
            this.InvaderType = invaderType;
            this.location = location;
            this.Score = score;
        }

        public void Move(Direction direction)
        {
            if (direction.Equals(Direction.Right))
            {
                location.X += HorizontalInterval;          
            }
            else if(direction.Equals(Direction.Left))
            {
                location.X -= HorizontalInterval;
            }
            else
            {
                location.Y += VerticalInterval;            
            }
        }

        public void Draw(Graphics g, int animationCell)
        {
            if (InvaderType == ShipType.Star)
            {
                switch(animationCell)
                {
                    case 1:
                        g.DrawImage(Properties.Resources.star1, Location);
                        
                        break;
                    case 2:
                        g.DrawImage(Properties.Resources.star2, Location);
                        break;
                    case 3:
                        g.DrawImage(Properties.Resources.star3, Location);
                        break;
                    default:
                        g.DrawImage(Properties.Resources.star4, Location);
                        break;
                }
                image = Properties.Resources.star1;
            }
            else if (InvaderType == ShipType.Spaceship)
            {
                switch (animationCell)
                {
                    case 1:
                        g.DrawImage(Properties.Resources.spaceship1, Location);
                        break;
                    case 2:
                        g.DrawImage(Properties.Resources.spaceship2, Location);
                        break;
                    case 3:
                        g.DrawImage(Properties.Resources.spaceship3, Location);
                        break;
                    default:
                        g.DrawImage(Properties.Resources.spaceship4, Location);
                        break;
                }
                image = Properties.Resources.spaceship1;
            }
            else if (InvaderType == ShipType.Flyingsaucer)
            {
                switch (animationCell)
                {
                    case 1:
                        g.DrawImage(Properties.Resources.flyingsaucer1, Location);
                        break;
                    case 2:
                        g.DrawImage(Properties.Resources.flyingsaucer2, Location);
                        break;
                    case 3:
                        g.DrawImage(Properties.Resources.flyingsaucer3, Location);
                        break;
                    default:
                        g.DrawImage(Properties.Resources.flyingsaucer4, Location);
                        break;
                }
                image = Properties.Resources.flyingsaucer1;
            }
            else if (InvaderType == ShipType.Bug)
            {
                switch (animationCell)
                {
                    case 1:
                        g.DrawImage(Properties.Resources.bug1, Location);
                        break;
                    case 2:
                        g.DrawImage(Properties.Resources.bug2, Location);
                        break;
                    case 3:
                        g.DrawImage(Properties.Resources.bug3, Location);
                        break;
                    default:
                        g.DrawImage(Properties.Resources.bug4, Location);
                        break;
                }
                image = Properties.Resources.bug1;
            }
            else if(InvaderType == ShipType.Satellite)
            {
                switch (animationCell)
                {
                    case 1:
                        g.DrawImage(Properties.Resources.satellite1, Location);
                        break;
                    case 2:
                        g.DrawImage(Properties.Resources.satellite2, Location);
                        break;
                    case 3:
                        g.DrawImage(Properties.Resources.satellite3, Location);
                        break;
                    default:
                        g.DrawImage(Properties.Resources.satellite4, Location);
                        break;
                }
                image = Properties.Resources.satellite1;
            }
            else
            {
                switch (explosionSell)
                {
                    case 1:
                        g.DrawImage(Properties.Resources.explosion1, Location.X, Location.Y, 45, 55);
                        explosionSell++;
                        break;
                    case 2:
                        g.DrawImage(Properties.Resources.explosion2,Location.X,Location.Y, 45, 55);
                        explosionSell++;
                        break;
                    case 3:
                        g.DrawImage(Properties.Resources.explosion3, Location.X, Location.Y, 45, 55);
                        explosionSell++;
                        break;
                    case 4:
                        g.DrawImage(Properties.Resources.explosion4, Location.X, Location.Y, 45, 55);
                        explosionSell++;
                        break;
                    default:
                        g.DrawImage(Properties.Resources.explosion5, Location.X, Location.Y, 45, 55);
                        explosionSell++;
                        break;
                }
            }
        }

    }
}
