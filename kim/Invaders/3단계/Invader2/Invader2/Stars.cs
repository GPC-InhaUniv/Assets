using System;
using System.Collections.Generic;

using System.Drawing;
namespace Invader2
{
    class Stars
    {

        List<Star> stars = new List<Star>();
        Dictionary<int, Brush> starColor = new Dictionary<int, Brush>();

        public Stars(Random random)
        {
            SettingColor();
            for (int i = 0; i < 300; i++)
            {
                stars.Add(new Star(new Point(random.Next(0, 1100), random.Next(0, 850))));
            }
        }
     
        public void Draw(Graphics g, Random random)
        {
                foreach (Star pt in stars)
                {
                    g.FillRectangle(starColor[random.Next(5)], new Rectangle(pt.Point.X, pt.Point.Y, 1, 1));
                }
        }

       

        private void SettingColor()
        {
            starColor.Add(0, Brushes.White);
            starColor.Add(1, Brushes.Red);
            starColor.Add(2, Brushes.Green);
            starColor.Add(3, Brushes.Aqua);
            starColor.Add(4, Brushes.Ivory);
        }

        public void Twinkle(Random random)
        {
            stars.RemoveRange(0, 5);
            for (int i = 0; i < 5; i++)
            {
                stars.Add(new Star(new Point(random.Next(0, 1100), random.Next(0, 850))));
            }
        }
    }
}
