using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Q3_Invader
{
    class Stars
    {
        private Random random;

        public void Draw(Graphics g, int animationCell)
        {

        }

        public void Move(Direction direction)
        {

        }

        public void RandomPen()
        {

        }

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
    }
}
