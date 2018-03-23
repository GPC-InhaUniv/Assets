using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Util
{
    abstract class Mover
    {
        private const int MoveInterval = 10; // 한번에 이동할 거리
        protected Point location; // 위치 좌표
        protected Controller.Game game; // : base(game,location) 작성시 game 매개변수 지정
        public Point Location { get { return location; } }

        public enum Direction
        {
            UP,
            DOWN,
            LEFT,
            RIGHT,
        }

        public Mover(Controller.Game game, Point location) // Game 클래스에서 Mover 호출시 Mover 내에 값을 전달하기 위함
        {
            this.game = game;
            this.location = location;
        }

        public bool Nearby(Point locationToCheck,int distance)
        {
            if (Math.Abs(location.X - locationToCheck.X) < distance && Math.Abs(location.Y - locationToCheck.Y) < distance)
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
            Point NewLocation = location;
            switch(direction)
            {
                case Direction.UP:
                    if (NewLocation.Y - MoveInterval >= boundaries.Top)
                        NewLocation.Y -= MoveInterval;
                    break;

                case Direction.DOWN:
                    if (NewLocation.Y + MoveInterval <= boundaries.Bottom)
                        NewLocation.Y += MoveInterval;
                    break;

                case Direction.LEFT:
                    if (NewLocation.X - MoveInterval >= boundaries.Left)
                        NewLocation.X -= MoveInterval;
                    break;

                case Direction.RIGHT:
                    if (NewLocation.X + MoveInterval <= boundaries.Right)
                        NewLocation.X += MoveInterval;
                    break;
                default:break;
            }
            return NewLocation;
        }
    }
}
