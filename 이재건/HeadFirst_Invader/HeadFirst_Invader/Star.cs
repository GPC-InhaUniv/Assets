using System.Drawing;
using System.Collections.Generic;
using System;

namespace HeadFirst_Invader
{
    class Stars : Objects
    {
        List<Star> stars;

        private struct Star
        {
            public Point point;
            public Pen randompen;

            public Star(Point point, Random random)
            {
                this.point = point;
                this.randompen = new Pen(Color.FromArgb(random.Next(0, 256), random.Next(0, 256), 0));


            }
        }

        public Stars(Random random, Rectangle boundaries)
        {
            stars = new List<Star>();
            Point temp = new Point();

            for (int i = 0; i < 300; i++)
            {
                temp.X = random.Next(boundaries.Left, boundaries.Right);
                temp.Y = random.Next(boundaries.Top, boundaries.Bottom);
                stars.Add(new Star(temp, random));
            }
        }

        public override void Draw(Graphics g)
        {
            for (int i = 0; i < stars.Count; i++)
                g.DrawLine(stars[i].randompen, stars[i].point.X, stars[i].point.Y, stars[i].point.X + i % 2, stars[i].point.Y + i % 2);
        }

        public override void Move(Direction direction)
        {
            throw new System.NotImplementedException();
        }

        public void AddandDelete(Random random, Rectangle boundaries)
        {
            Point temp = new Point();
            for (int i = 0; i < 5; i++)
            {
                temp.X = random.Next(boundaries.Left, boundaries.Right);
                temp.Y = random.Next(boundaries.Top, boundaries.Bottom);
                stars.RemoveAt(i);
                stars.Add(new Star(temp, random));
            }

        }
    }
}
