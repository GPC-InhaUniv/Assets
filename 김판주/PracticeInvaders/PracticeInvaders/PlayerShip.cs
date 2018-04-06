using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PracticeInvaders
{
    public class PlayerShip
    {
        public Point Location { get; private set; }
       
        public Rectangle Area { get; private set; }
        public bool Alive { get; private set; }


        private int deadShipHeight;

        private const int MoveInterval = 10;

        Point tempPoint = new Point();

        public PlayerShip(Point location, Rectangle area, bool alive)
        {
            this.Area = area;
            this.Location = location;
            this.Alive = alive;
        }
        

        public void Draw(Graphics g)
        {
            if (!Alive)
            {         
                //deadShipHeight 필드를 재설정하고 우주선을 그림
               
            }
            else
            {
                //deadShipHeight 필드를 검사 //만약 이 값이 0보다 크면 1씩 줄이고 drawimage를 사용해서 우주선을 약간 납작하게 그리세요.
                g.DrawImage(Properties.Resources.Playerspaceship2, Location); //입력 받을 수 있는 값으로...
            }
        }

        public Point Move(Direction direction)
        {
            
            switch (direction)
            {
                case Direction.Left:
                    tempPoint = new Point(Location.X - MoveInterval, Location.Y);
                    if (Location.X - MoveInterval >= Area.Left)
                        Location = tempPoint;
                    break;
                case Direction.Right:
                    tempPoint = new Point(Location.X + MoveInterval, Location.Y);
                    if (Location.X + MoveInterval <= Area.Right - 50 )
                    Location = tempPoint;
                    break;

                default: break;
            }
            return Location;
        }

    }
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
        None,
    }
}
