using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    class Stars
    {
        Point location;
        List<Star> starsList = new List<Star>();
        Rectangle rectangle;
        private struct Star
        {
            public Point point;
            public Pen pen;
            
            public Star(Point point, Pen pen)
            {
                this.point = point;
                this.pen = pen;
            }

            public void PenChange(Pen penColor)
            {
                pen = penColor;         
            }
        }

        public void Draw(Graphics g)
        {
            foreach(Star star in starsList)
            {
                g.DrawRectangle(star.pen, rectangle = new Rectangle(star.point.X, star.point.Y, 1, 1));
            }
        }

        public void Twinkle(Random random)
        {
            if (starsList.Count == 0)
            {
                for (int i = 0; i < 200; i++)
                {
                    location.X = random.Next(10, 730);
                    location.Y = random.Next(10, 810);
                    starsList.Add(new Star(location, randomPen(random)));
                }
            }
            else
            {
                for(int i = 0; i < 10; i ++)
                {
                    location.X = random.Next(10, 730);
                    location.Y = random.Next(10, 810);
                    int index = random.Next(0, 200);
                    starsList[index] =  new Star(location, randomPen(random));
                }
            }
        }

        public Pen randomPen(Random random)
        {
            int penColor = random.Next(0, 6);
            switch(penColor)
            {
                case 0:
                    return Pens.SkyBlue;
                case 1:
                    return Pens.PaleGreen;
                case 2:
                    return Pens.Orange;
                case 3:
                    return Pens.Violet;
                case 4:
                    return Pens.White;
                default :
                    return Pens.Purple;
            }
        }
    }
}
