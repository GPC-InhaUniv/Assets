using System.Collections.Generic;
using System.Drawing;


namespace HeadFirst_Invader
{
    class PlayerHp
    {
        List<Image> hpImageList;

        public Point Location;

        Game game;

        public PlayerHp(Game game)
        {
            this.game = game;
            string path = @"images\player0.png";
            hpImageList = new List<Image>();
            Location.X = game.Boundaries.Width / 2 - 100;
            Location.Y = game.Boundaries.Top;


            hpImageList.Add(Image.FromFile(path));


        }

        public void Draw(Graphics g)
        {
            int interval = 80;
            Point temp = Location;
            for (int i = 0; i <= game.LiveLeft; i++)
            {

                g.DrawImage(hpImageList[0], temp);
                temp.X += interval;

            }

        }
    }
}
