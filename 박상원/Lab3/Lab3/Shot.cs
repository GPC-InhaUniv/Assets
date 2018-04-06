using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Lab3
{
    class Shot
    {
        private const int moveInterval = 10; // 총알 속도
        private const int width = 10;
        private const int height = 15;

        private Point location; // 총알 좌표
        public Point Location { get { return location; } }

        private PlayerShip.Direction direction;
        private Rectangle boundaries;

        public Shot(Point location, PlayerShip.Direction direction, Rectangle boundaries) // 총알 좌표, 방향, 피격 판정 범위
        {
            this.location = location;
            this.direction = direction;
            this.boundaries = boundaries;
        }

        public void PlayerShotDraw(Graphics g)
        {
            Pen pen = new Pen(Color.Pink);
            Size size = new Size(width, height);
            g.DrawRectangle(pen, new Rectangle(location, size));
        }

        public bool Move(PlayerShip.Direction direction)
        {
            switch(direction)
            {
                case PlayerShip.Direction.Up:
                    if(location.Y>boundaries.Top)
                    {
                        location.Y -= moveInterval;
                    }
                    else if(location.Y<=boundaries.Top)
                    {
                        return false;
                    }
                    break;
                case PlayerShip.Direction.Down:
                    if(location.Y<boundaries.Bottom)
                    {
                        location.Y += moveInterval;
                    }
                    else if(location.Y>boundaries.Bottom)
                    {
                        return false;
                    }
                    break;
            }
            return true;
        }
    }
}
