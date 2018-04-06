using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
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
        public void Twinkle(Random random)
        {

        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black); // 외곽선 색
            g.DrawRectangle(pen, new Rectangle(0, 0, 804, 764)); // 0,0 좌표에 804,764 크기의 사각형 생성
            g.FillRectangle(new SolidBrush(Color.Black), new Rectangle(0, 0, 804, 803));
        }
    }
}
