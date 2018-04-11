using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace InvadersGame
{
    class Stars
    {
        private List<Star> stars;
        private Rectangle boundaries;

        public Stars(Random random, Rectangle boundaries)
        {
            this.boundaries = boundaries;
            stars = new List<Star>();
            for (int i = 1; i < 250; i++)
                AddStar(random);
        }

        public Graphics Draw(Graphics g, int animationCell)
        {
            Graphics starGraphics = g;
            foreach (Star Star in stars)
            {
                starGraphics.FillRectangle(Star.brush, Star.point.X, Star.point.Y, 1, 1);        // Rectangle 구조체에 의해 지정된 사각형의 내부를 채운다. brush: 채우기 특징
            }
            return starGraphics;
        }

        public void Twinkle(Random random)        // 반짝이는 메소드
        {
            stars.RemoveRange(0, 4);        // 리스트에서 요소의 범위를 제거한다.
            for (int i = 0; i < 4; i++)
                AddStar(random);
        }

        private void AddStar(Random random)       // 별 추가 메소드
        {
            int height = boundaries.Height;
            int width = boundaries.Width;
            Point location = new Point(random.Next(0, width), random.Next(0, height));
            Star newStar = new Star(location, Brushes.Yellow);        // 별 객체 생성. 위치와 색 브러쉬 지정
            stars.Add(newStar);
        }
    }
}
