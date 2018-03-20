using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right
    }
    abstract class Mover
    {
        protected Game game;            // 맵 이탈 방지를 위해 사용
        private Point location;         // 좌표를 받아서 움직인다.
        public Point Lcation
        {
            get { return location; }
            set
            {
                location = value;
            }
        }

        public Mover(Point location, Game game)
        {
            this.location = location;
            this.game = game;
        }

        public bool Nearby(Point MonsterOrPlayerlocation, int distance)
        {
            if (this.location.X - location.X <= distance)    
                return true;
            else if (this.location.Y - location.Y <= distance)
                return true;
            else
                return false;
        }

        // 방향키를 누른 방향으로 발생한 난수만큼 이동한다.
        // 맵 범위를 벗어나게되면 나가지 못하게 한다. (충돌체크)
        public void Move(Direction direction, Rectangle rectangle)
        {
            Point Moverlocation = location;
            Random random = new Random();
            int rand = random.Next(1,10);

            switch (direction)
            {
                case Direction.Up:
                    if (Moverlocation.Y - rand >= rectangle.Top)
                        Moverlocation.Y -= rand;
                    break;
                case Direction.Down:
                    if (Moverlocation.Y + rand <= rectangle.Bottom)
                        Moverlocation.Y += rand;
                    break;
                case Direction.Left:
                    if (Moverlocation.X - rand >= rectangle.Left)
                        Moverlocation.X -= rand;
                    break;
                case Direction.Right:
                    if (Moverlocation.X + rand <= rectangle.Right)
                        Moverlocation.X += rand;
                    break;
            }
            location = Moverlocation;
        }
    }
}
