using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invaders
{
    class Stars
    {
        List<Star> stars;
        Rectangle boundaries;

        struct Star
        {
            public Point point;
            public Pen pen;

            public Star(Point point, Random random)
            {
                this.point = point;
                this.pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            }
        }

        public Stars(Rectangle boundaries, Random random) // Pool 생성
        {
            stars = new List<Star>();
            this.boundaries = boundaries;
            Point p;

            for (int i = 0; i < 300; i++)
            {
                p = new Point(random.Next(boundaries.Width), random.Next(boundaries.Height));
                stars.Add(new Star(p, random));
            }
        }

        public void Draw(Graphics g, Random random)
        {
            Twinkle(random);
            for (int i = 0; i < stars.Count; i++)
            {
                int select = random.Next(stars.Count);
                Star star = stars[select];
                g.DrawLine(star.pen, star.point.X, star.point.Y, star.point.X+1, star.point.Y+1);
            }
            
        }

        public void Twinkle(Random random) // Pool에서 할당된 객체 가져오기
        {
            Star temp;
            for (int i = 0; i < 5; i++)
            {
                temp = stars[random.Next(stars.Count)];
                temp.pen = RandomPen(random);
                temp.point.X = random.Next(boundaries.Width);
                temp.point.Y = random.Next(boundaries.Height);
            }
        }

        public Pen RandomPen(Random random)
        {
            Pen pen = new Pen(Color.FromArgb(random.Next(256), random.Next(256), random.Next(256)));
            return pen;
        }
    }
}