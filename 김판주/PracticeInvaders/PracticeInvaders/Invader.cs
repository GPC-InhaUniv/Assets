using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

namespace PracticeInvaders
{
    public class Invader
    {
        private const int HorizontalInterval = 10;
        private const int VerticalInterbal = 40;

      
        public Point Location { get; private set; }

        Point tempPoint = new Point();

        public ShipType InvaderType { get; private set; }

        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }

        public int Score { get; private set; }

        private Bitmap image;

        private int animationCell;

        public Invader(ShipType invaderType, Point location, int score, Rectangle Area, int animationCell)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = Score;
            this.animationCell = animationCell;
           // image = InvaderImage();

            //Bitmap image = new Bitmap(Properties.Resources.bug1);
        }


        public void Draw(Graphics g, int animationCell)
        {
            //정확한 애니메이션 셀을 사용해서 우주선 이미지를 그립니다.
            g.DrawImage(InvaderImage(animationCell,ShipType.Bug),Location);           
        }

        //private const int HorizontalInterval = 10;
        //private const int VerticalInterbal = 40;

        public Point Move(Direction direction)
        {
            //특정방향으로 우주선을 움직이게 합니다.
            switch (direction)
            {
                case Direction.Down:

                    tempPoint = new Point(Location.X - HorizontalInterval, Location.Y);

                    if (Location.X - HorizontalInterval >= Area.Left)
                        Location = tempPoint;
                    break;

                default: break;
            }

            return Location;
        }

        public Bitmap InvaderImage(int animationCell, ShipType Type)
        {
            if (Type == ShipType.Bug)
            {
                switch (animationCell)
                {
                    case 1:
                        image = Properties.Resources.bug1;
                        return image;

                    case 2:
                        image = Properties.Resources.bug2;
                        return image;

                    case 3:
                        image = Properties.Resources.bug3;
                        return image;

                    case 4:
                        image = Properties.Resources.bug4;
                        return image;
                    default:
                        image = Properties.Resources.bug1;
                        return image;


                }             
            }
            return image;
        }


        public enum ShipType
        {
            Bug,
            Saucer,
            Satellite,
            Spaceship,
            Star,
        }
    }
}
