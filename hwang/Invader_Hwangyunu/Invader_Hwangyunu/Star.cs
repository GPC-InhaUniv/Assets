using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Invader_Hwangyunu
{
    class Stars
    {

        List<Star> star = new List<Star>();


        private struct Star
        {
            public Point point;
            public Pen pen;

            public Star(Point point , Pen pen)
            {
                this.point = point;
                this.pen = pen;

                for (int i = 0; i < 150; i++)
                {

                }
            }

        }


        
        public void Draw(Graphics g)
        {
            using (Font font = new Font("Arial", 30, FontStyle.Regular))
            {
                g.DrawString("*", font, Brushes.White, new Point(60, 60));
            }
        

        }
        public void Twinkle(Random random)
        {

        }
    }
}
