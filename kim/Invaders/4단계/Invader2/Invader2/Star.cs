
using System.Drawing;
namespace Invader2
{
    struct Star
    {
        public Point Point;
        public Brush brush;
        public Star(Point point, Brush brush)
        {
            this.Point = point;
            this.brush = brush;
          
        }
    }
}
