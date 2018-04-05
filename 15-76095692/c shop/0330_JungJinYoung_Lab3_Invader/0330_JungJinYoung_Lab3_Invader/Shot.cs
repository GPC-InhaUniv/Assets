using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0330_JungJinYoung_Lab3_Invader
{
    class Shot
    {

        private const int moveInterval = 20;
        private const int width = 5;
        private const int height = 15;

        public Point Location { get; private set; }
        public Pen Pen;
        public Size size;
        private Direction direction;
        private Rectangle bounderies;

        public Shot(Point location, Direction direction, Rectangle bounderies)
        {
            this.Location = location;
            this.direction = direction;
            this.bounderies = bounderies;
        }

        public void CreateBullet()
        {
            size = new Size(2, 4);
            Pen = new Pen(Color.Yellow);
            //Location.X = bounderies.Bottom;
        }
        public void Draw(Graphics g)
        {
            CreateBullet();
            g.DrawRectangle(Pen,new Rectangle(Location, size));
        }
        public void Move(bool hit)
        {
            Console.WriteLine("move");
            Point newLocation = new Point();
            newLocation = Location;
            switch (direction)
            {
                case Direction.Up:
                    {
                        Console.WriteLine("up");
                        if (!hit)
                        {
                            newLocation.Y += moveInterval;
                            Location = newLocation;
                        }
                        break;
                    }
                case Direction.Down:
                    {
                        if (!hit)
                        {
                            newLocation.Y -= moveInterval;
                            Location = newLocation;
                        }
                        break;
                    }
            }
            
        }
    }
}
