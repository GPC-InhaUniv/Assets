using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PracticeInvaders
{
    class Stars
    {
        public Point point;
        public Pen pen;

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
        Star star;


        public Stars(Rectangle boundaries)
        {
            this.boundaries = boundaries;
        }


        List<Star> stars = new List<Star>();

        Random random = new Random();

        Rectangle boundaries;

        Pen pentemp = new Pen(Color.White);

        Point temp = new Point();

        int temp2 = new int();

        public void CreatStar()
        {
            

            for (int i = 1; i < 300; i++)
            {
                temp.X = random.Next(boundaries.Left, boundaries.Right);
                temp.Y = random.Next(boundaries.Top, boundaries.Bottom);

                pentemp = RandomPen(random);
                stars.Add(new Star(temp, pentemp));
               
            }

        }
        
        public void Draw(Graphics g)
        {
            Size size = new Size(1, 1);
            g.FillRectangle(Brushes.Black, boundaries);

            foreach (Star star in stars)
            {
                pentemp = RandomPen(random);
                g.DrawRectangle(star.pen, new Rectangle(star.point,size ));               
            }
        }

        private Point GetRandomLocation(Random random) //아이템과 적의 위치를 새로운 레벨마다 랜덤값으로 하여 생성하게 해줌
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 2 - boundaries.Left / 15) * 30,
                boundaries.Top + random.Next(boundaries.Bottom / 2 - boundaries.Top / 15) * 30);
        }

        public void Twinkle(Random random)
        {
            for (int i = 1; i < 5; i++)
            {
                temp2 = random.Next(0,i);
                pentemp = RandomPen(random);

                temp.X = random.Next(boundaries.Left, boundaries.Right);
                temp.Y = random.Next(boundaries.Top, boundaries.Bottom);

                stars.RemoveAt(temp2);

                stars.Add(new Star(temp, pentemp));
            }
        }

        public Pen RandomPen(Random random)
        {
            int randomColor = random.Next(0, 4);
            switch (randomColor)
            {
                case 0:
                    star.pen = new Pen(Brushes.DeepSkyBlue);
                    break;
                case 1:
                    star.pen = new Pen(Brushes.White);
                    break;
                case 2:
                    star.pen = new Pen(Brushes.Red);
                    break;
                case 3:
                    star.pen = new Pen(Brushes.Yellow);
                    break;
                case 4:
                    star.pen = new Pen(Brushes.Green);
                    break;
                default: break;
            }
            return star.pen;
            // 이와 일치하는 pen 객체를 선택함으로써 다섯 색깔의 별 중 하나를 반환해야 합니다.
        }
    }
}
