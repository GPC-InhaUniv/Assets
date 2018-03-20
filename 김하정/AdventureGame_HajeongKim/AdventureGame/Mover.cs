using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    abstract class Mover
    {
        //한턴에 얼마만큼 움직이는지 즉 한걸음.
        private const int MoveInterval = 10;
        
        protected Point location;
        public Point Location { get { return location; } }
        protected Game game;

         

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location;
        }


        //현재 포인트에서 주어진 포인트(매개변수)를 뺀 값이 거리 값(매개변수)보다 작다면 true이다.
        public bool Nearby(Point locationToCheck, int distance )
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
                return true;
            else
                return false;
            
        }


        //위에서 선언해준 이넘으로 움직임 메소드를 만들어 준다.
        //boundaries(던전의 바운더리)에 부딪히면 이동할 수 없음.
        //플레이어와 몬스터의 위치는 새로운 위치 - 한걸음 이다.
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                    {
                        newLocation.Y -= MoveInterval;
                    }
                    break;

                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                    {
                        newLocation.Y += MoveInterval;
                    }
                    break;
                case Direction.Left:
                    if (newLocation.X - MoveInterval >= boundaries.Left )
                    {
                        newLocation.X -= MoveInterval;
                    }
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                    {
                        newLocation.X += MoveInterval;
                    }
                    break;
                default: break;

            }
            return newLocation;
        }
    }
}
