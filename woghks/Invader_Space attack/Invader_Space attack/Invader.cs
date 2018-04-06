using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invader_Space_attack
{
    enum ShipType
    {
        Bug,
        Saucer,
        Satellite,
        Spaceship,
        Star,
    }

    
    class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;

        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }

        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }
        
        public int Score { get; private set; }

        public Invader (ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            image = InvaderImage (0);
        }


        public void Draw(Graphics g, int animationCell)
        {
            g.DrawImage(Properties.Resources.player, 50, 50);
        }


        private Bitmap InvaderImage(int animationCell)
        {
            return null;


        }
    }
}
