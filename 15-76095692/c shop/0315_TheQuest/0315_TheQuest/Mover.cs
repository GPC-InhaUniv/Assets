using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0315_TheQuest
{
    public enum Direction
    {
        Up,Down,Left,Right
    }
    public abstract class Mover
    {
        private const int MoveInterval = 10;//기본 이동거리
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }

        //nearby()
        public bool Nearby(Point locationToCheck,int distance)
        {
            if(Math.Abs(location.X - locationToCheck.X)<distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public Point Move(Direction direction,Rectangle boundaries)
        {
            //Move()메소드에서는 주어진 방향으로 한 걸음을 걸어갑니다.
            //외곽경계에 막혀서 그 자리로 이동 할 수 없으면 원래위치를, 움직일 수 있으면 새로 이동한 위치를 반환한다.
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    {
                        if(newLocation.Y-MoveInterval >=boundaries.Top)
                        {
                            newLocation.Y -= MoveInterval;
                        }break;
                    }
                case Direction.Down:
                    {
                        if(newLocation.Y + MoveInterval <= boundaries.Bottom)
                        {
                            newLocation.Y += MoveInterval;
                        }
                    }break;
                case Direction.Right:
                    {
                        if(newLocation.X + MoveInterval <= boundaries.Right)
                        {
                            newLocation.X += MoveInterval;
                        }
                    }break;
                case Direction.Left:
                    {
                        if(newLocation.X - MoveInterval >= boundaries.Left)
                        {
                            newLocation.X -= MoveInterval;
                        }
                    }break;

            }
            return newLocation;
        }
    }
}
