using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game , Point location)
        {
            this.game = game;
            this.location = location;
        }

        public bool NearBy(Point locationToCheck ,int distance)
        {
            //Math.Abs 절대값을 반환하는 기호  이게 없을경우  한쪽방향밖에 구분을 못함//
            if (Math.Abs(location.X - locationToCheck.X) < distance &&
                (Math.Abs(location.Y - locationToCheck.Y) < distance)) 
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public Point Move(MoveDirection direction ,Rectangle boundaries )
        {
            Point moveLocation = location;
            switch (direction)
            {

                // 포인트좌표  위로 올라가면 - 임  아래로 내려가면 +   좌로가면 -  우로가면 +//
                case MoveDirection.MoveUP:
                    if (moveLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        moveLocation.Y -= MoveInterval;

                    }
                    break;

                case MoveDirection.MoveDown:

                    if (moveLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        moveLocation.Y += MoveInterval;

                    }
                    break;

                case MoveDirection.MoveLeft:

                    if (moveLocation.X - MoveInterval >= boundaries.Left)
                    {
                        moveLocation.X -= MoveInterval;

                    }
                    break;

                case MoveDirection.MoveRight:

                    if (moveLocation.X + MoveInterval <= boundaries.Right)
                    {
                        moveLocation.X += MoveInterval;

                    }
                    break;
                default: break;
            }


            return moveLocation;
        }
    }
}
