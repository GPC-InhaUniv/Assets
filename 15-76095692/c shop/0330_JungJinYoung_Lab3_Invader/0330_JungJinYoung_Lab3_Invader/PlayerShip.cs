using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0330_JungJinYoung_Lab3_Invader
{
    class Playership
    {
        public Point Location;
        //public Point location { get { return location; } }
        private Rectangle Area;
        private bool Alive;
        private int deadShipHeight;


        public Playership(Point location)
        {
            this.Location = location;
        }
        

        public Point Move(Direction direction, int moveSpeed,Rectangle boundaries)
        {
            switch (direction)
            {
                case Direction.Left:
                    {
                        if(Location.X - moveSpeed >= boundaries.Left)
                        {
                            Location.X -= moveSpeed;
                        }
                        break;
                    }
                case Direction.Right:
                    {
                        if(Location.X + moveSpeed <= boundaries.Right-55)
                        Location.X += moveSpeed;
                        break;
                    }
            }
            return Location;
        }

        internal void Draw(Graphics g)
        {
            if (!Alive)
            {
                deadShipHeight = 5;
                g.DrawImage(Properties.Resources.player,Location);
                //deadshipHeight 필드를 재설정하고 우주선을 그리세요.
            }
            else
            {
                //for(int i=0; i < 5; i++)
                //{
                //    //deadShipHeight
                //    g.DrawImage(Properties.Resources.player, Location);
                //}
                
                //deadShipHeight 필드를 검사하세요 만약 이 값이 0보다 크면 1씩 줄이고
                //DrawImage()를 사용해서 우주선을 약간 납작하게 그리세요
            }
        }
    }
}
