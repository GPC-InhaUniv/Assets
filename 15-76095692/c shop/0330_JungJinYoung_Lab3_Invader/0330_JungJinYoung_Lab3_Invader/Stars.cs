using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0330_JungJinYoung_Lab3_Invader
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


        List<Star> stars;

        Rectangle boundaries;
        public Stars(Rectangle boundaries)
        {
            stars = new List<Star>();
            this.boundaries = boundaries;
        }

        //public void GetRectangle(Rectangle boundaries)
        //{
        //    Console.WriteLine(boundaries);
        //    this.boundaries = boundaries;
        //}
        public void CreateStar(int createNum)
        {
            
            Random random = new Random();
            for (int i = 0; i < createNum; i++)
            {
                stars.Add(new Star(GetRandomLocation(random), RandomPen(random)));
            }
        }
        public void CheckTheStars()
        {
            if (stars.Count()== 0)
            {
                CreateStar(300);
            }
        }
        
        public void Draw(Graphics g)
        {
            CheckTheStars();
            Size size = new Size(1, 1);
            foreach(Star star in stars)
            {
                g.DrawRectangle(star.pen,new Rectangle(star.point,size));
            }
        }

        public void Twinkle(Random random)
        {
            //리스트 안의 다섯개의 별을 골라 제거한 후 제거한 장소에서 새로운 다섯개의 별을 추가해야함
            CheckTheStars();
            stars.RemoveRange(0, 5);
            for (int i = 0; i < 5; i++)
            {
                stars.Add(new Star(GetRandomLocation(random), RandomPen(random)));
            }

        }

        private Point GetRandomLocation(Random random)//별을 리스트에 넣을때 랜덤한 위치를 줄꺼임
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 3 - boundaries.Left / 3) * 3,
                boundaries.Top + random.Next(boundaries.Bottom / 3 - boundaries.Top / 3) * 3);
        }

        public Pen RandomPen(Random random)//색을 렌덤하게 지정해줄꺼임
        {
            int starRandom = random.Next(0, 5);
            Pen pen;
            
            switch (starRandom)
            {
                case 1:
                    pen = new Pen(Color.White);
                    break;
                case 2:
                    pen = new Pen(Color.Aqua);
                    break;
                case 3:
                    pen = new Pen(Color.Cyan);
                    break;
                case 4:
                    pen = new Pen(Color.LightGreen);
                    break;
                default :
                    pen = new Pen(Color.SteelBlue);
                    break;
            }
            return pen;
        }
        
    }
}
