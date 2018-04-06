using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.IO;

namespace Invader
{
    public class Invaders
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterval = 40;

        private Bitmap image;

        public Point Location { get; private set; }

        public Rectangle Area
        {
            get
            {
                return new Rectangle(Location, image.Size);
            }
        }

        public int Score { get; private set; }

        public void Move(Game.Direction direction)
        {
        }

        public void Draw(Graphics g, int animationcCell)
        {
        }

        public enum ShipType
        {
            Bug,
            Saucer,
            Satellite,
            SpaceShop,
            Star,
        }
    }
}