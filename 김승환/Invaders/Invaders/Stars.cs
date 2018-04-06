using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    class Stars
    {
        private struct Star
        {
            public Point point;
            public Pen pen;

            public Star(Point point, Pen pen)
            {
                this.point = point;
                this.pen = pen;
            }
        }

        private List<Star> StarList;
        Random random;
        Rectangle boundaries;

        public Stars(Rectangle boundaries)
        {
            this.boundaries = boundaries;

            StarList = new List<Star>();
            random = new Random();
            for (int i = 0; i < 300; i++)
            {
                Point p = new Point(random.Next(boundaries.Width), random.Next(boundaries.Height));
                Pen pen = SelectRandomPen();
                Star star = new Star(p, pen);
                StarList.Add(star);
            }
        }

        public void Draw(Graphics g)
        {
            for(int i = 0; i < StarList.Count; i++)
            {
                g.DrawRectangle(StarList[i].pen, StarList[i].point.X, StarList[i].point.Y, 1, 1);
            }
        }

        public void Twinkle(Random random)
        {
            /*StarList.RemoveRange(0, 5);
            for(int i = 0; i < 5; i++)
            {
                StarList.Add(new Star(new Point(random.Next(boundaries.Width), random.Next(boundaries.Height)), RandomPen()));
            }*/
            for (int i = 0; i < 300; i++)
            {
                StarList[i] = new Star(new Point(StarList[i].point.X, StarList[i].point.Y < boundaries.Height ? StarList[i].point.Y + 10 : 10), StarList[i].pen);
            }
        }

        public Pen SelectRandomPen()
        {
            Pen pen;
            switch(random.Next(1, 8))
            {
                case 1:
                    pen = new Pen(Color.Red);
                    break;
                case 2:
                    pen = new Pen(Color.Orange);
                    break;
                case 3:
                    pen = new Pen(Color.Yellow);
                    break;
                case 4:
                    pen = new Pen(Color.Green);
                    break;
                case 5:
                    pen = new Pen(Color.Blue);
                    break;
                default:
                    pen = new Pen(Color.White);
                    break;
            }
           
            return pen;
        }
    }
}
