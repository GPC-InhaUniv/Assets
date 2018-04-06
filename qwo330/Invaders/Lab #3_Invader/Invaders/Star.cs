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
        struct Star
        {
            Point point;
            Pen pen;

            private Star(Point point, Pen pen)
            {
                this.point = point;
                this.pen = pen;
            }
        }

        Stars(Random random)
        {
            List<Star> stars = new List<Star>();
        }
    }
}