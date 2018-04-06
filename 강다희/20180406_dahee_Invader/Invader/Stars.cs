using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invader
{
    public class Stars
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

        public void Draw(Graphics g)
        {
        }
    }
}