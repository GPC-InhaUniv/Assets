using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 실습3_Invader
{
    enum ShipType
    {
        Bug,
        Sauacr,
        Satellite,
        Spaceship,
        Star,
    }

    class Invader
    {
        private const int HorizontalInterval = 10;      // 수평 간격
        private const int VerticalInterval = 40;        // 수직 간격

        private List<Bitmap> bitmaps;

        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }
        public Rectangle Area;
        public int Score { get; private set; }

        public Invader(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            this.bitmaps = InvaderImage();
        }

        public void Draw(Graphics g/*, int animationCell*/)
        {
            Point location = Location;
            for(int i = 0; i < bitmaps.Count; i++)
            {
                g.DrawImage(bitmaps[i], location.X, Location.Y);
                g.DrawImage(bitmaps[i], location.X + 75, location.Y);
                g.DrawImage(bitmaps[i], location.X + 125, location.Y);
                g.DrawImage(bitmaps[i], location.X + 175, location.Y);
                g.DrawImage(bitmaps[i], location.X + 225, location.Y);
            }
        }

        public void Move(Direction direction)
        {
            switch (direction)
            {
                   
            }
        }

        public List<Bitmap> InvaderImage()
        {
            List<Bitmap> bitmaps = new List<Bitmap>();
            switch (InvaderType)
            {
                case ShipType.Bug:
                    bitmaps.Add(new Bitmap(Properties.Resources.bug1));
                    bitmaps.Add(new Bitmap(Properties.Resources.bug2));
                    bitmaps.Add(new Bitmap(Properties.Resources.bug3));
                    bitmaps.Add(new Bitmap(Properties.Resources.bug4));
                    break;
                case ShipType.Satellite:
                    bitmaps.Add(new Bitmap(Properties.Resources.satellite1));
                    bitmaps.Add(new Bitmap(Properties.Resources.satellite2));
                    bitmaps.Add(new Bitmap(Properties.Resources.satellite3));
                    bitmaps.Add(new Bitmap(Properties.Resources.satellite3));
                    break;
                case ShipType.Sauacr:
                    bitmaps.Add(new Bitmap(Properties.Resources.flyingsaucer1));
                    bitmaps.Add(new Bitmap(Properties.Resources.flyingsaucer2));
                    bitmaps.Add(new Bitmap(Properties.Resources.flyingsaucer3));
                    bitmaps.Add(new Bitmap(Properties.Resources.flyingsaucer4));
                    break;
                case ShipType.Spaceship:
                    bitmaps.Add(new Bitmap(Properties.Resources.spaceship1));
                    bitmaps.Add(new Bitmap(Properties.Resources.spaceship2));
                    bitmaps.Add(new Bitmap(Properties.Resources.spaceship3));
                    bitmaps.Add(new Bitmap(Properties.Resources.spaceship4));
                    break;
                case ShipType.Star:
                    bitmaps.Add(new Bitmap(Properties.Resources.star1));
                    bitmaps.Add(new Bitmap(Properties.Resources.star2));
                    bitmaps.Add(new Bitmap(Properties.Resources.star3));
                    bitmaps.Add(new Bitmap(Properties.Resources.star4));
                    break;
            }

            return bitmaps;
        }
    }
}
