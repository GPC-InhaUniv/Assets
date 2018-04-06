using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace 실습3_Invader
{
    class Shot
    {
        private const int MoveInterval = 10;
        private const int Width = 5;
        private const int Heigth = 15;

        public Point Location;
        
        //private Direction direction;
        private Rectangle boundaries;
        private Pen pen;
        private Image image;

        public Shot(Point location, Rectangle boundaries)
        {
            this.Location = location;
            this.boundaries = boundaries;
            this.pen = new Pen(Color.Red, Width);
        }

        public void Draw(Graphics g)
        {
            g.DrawRectangle(pen, Location.X + 24, Location.Y, 5, 15);
        }

        public bool Move(Direction direction)
        {
            bool boolen = true;
            Point location = Location;

            if (location.Y > 0 && direction == Direction.Up)
            {
                location.Y -= MoveInterval;
                boolen = true;
            }

            else if (location.Y > -10)
            {
                boolen = false;
            }

            Location = location;
            return boolen;
        }
    }
}