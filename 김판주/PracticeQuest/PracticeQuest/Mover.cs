using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuest
{
    abstract class Mover
    {
        private const int MoveInterval = 10;
      
        public Point Location { get { return location; } }
        protected Game game;
        protected Point location;

        public Mover(Game game, Point location)
        {
            this.game = game;
            this.location = location; //오른쪽은 클래스내 필드 변수 = 왼쪽은 생성자 매개변수
        }

        public bool Nearby(Point locationToCheck, int distance) 
        {//Point와 Location 사이의 거리 - 함수 매개변수distance = x는 distance 값보다 작은가?
            if(Math.Abs(location.X - locationToCheck.X) < distance && (Math.Abs(location.Y - locationToCheck.Y)< distance))
            { //Abs 8비트 부호의 절대값 반환
                return true;
            }
            else
            {
                return false;
            }
        }
        public Point Move(Direction direction, Rectangle boundaries)
        {
            Point newLocation = location;
            switch (direction)
            {
                case Direction.Up:
                    if (newLocation.Y - MoveInterval >= boundaries.Top)
                        newLocation.Y -= MoveInterval;
                    break;
                case Direction.Down:
                    if (newLocation.Y + MoveInterval <= boundaries.Bottom)
                        newLocation.Y += MoveInterval;
                    break;
                case Direction.Left:
                    if(newLocation.X - MoveInterval >= boundaries.Left)
                        newLocation.X -= MoveInterval;
                    break;
                case Direction.Right:
                    if (newLocation.X + MoveInterval <= boundaries.Right)
                        newLocation.X += MoveInterval;
                    break;
                default: break;
            }
            return newLocation;
        }
    }
    enum Direction
    {
        Up,
        Down,
        Left,
        Right,

        NONE,
        

    }
}
