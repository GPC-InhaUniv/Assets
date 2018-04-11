using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace InvadersGame
{
    class Invader
    {
        private const int horizontalInterval = 10;
        private const int verticalInterval = 40;

        private Bitmap image;         // Bitmap 클래스. 캡슐화를 비트맵의 픽셀 데이터 그래픽 이미지와 그 특성으로 구성.
        private Bitmap[] imageArray;

        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }
        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }
        public int Score { get; private set; }

        public Invader(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = score;
            image = InvaderImage(0);        // 0번 인베이더이미지 대입
        }

        public void Move(Direction direction)        // 움직이는 메소드
        {
            switch (direction)
            {
                case Direction.Right:
                    Location = new Point((Location.X + horizontalInterval), Location.Y);
                    break;
                case Direction.Left:
                    Location = new Point((Location.X - horizontalInterval), Location.Y);
                    break;
                case Direction.Down:
                    Location = new Point(Location.X, (Location.Y + verticalInterval));
                    break;
            }
        }

        public Graphics Draw(Graphics g, int animationCell)     // 그래픽 객체와 애니메이션셀을 매개변수로 받는 그리는 메소드
        {
            Graphics invaderGraphics = g;
            
            g.DrawImage(InvaderImage(animationCell), Location);            
            
            return invaderGraphics;
        }

        private Bitmap InvaderImage(int animationCell)
        {
            imageArray = new Bitmap[4];        // 비트맵 객체가 들어갈 4개짜리 배열 생성
            switch (InvaderType)
            {
                case ShipType.Bug:
                    imageArray[0] = Properties.Resources.bug1;        // 리소스의 bug1이미지를 imageArray 배열의 첫번째칸에 넣는다.
                    imageArray[1] = Properties.Resources.bug2;
                    imageArray[2] = Properties.Resources.bug3;
                    imageArray[3] = Properties.Resources.bug4;
                    break;
                case ShipType.Satellite:
                    imageArray[0] = Properties.Resources.satellite1;
                    imageArray[1] = Properties.Resources.satellite2;
                    imageArray[2] = Properties.Resources.satellite3;
                    imageArray[3] = Properties.Resources.satellite4;
                    break;
                case ShipType.Saucer:
                    imageArray[0] = Properties.Resources.flyingsaucer1;
                    imageArray[1] = Properties.Resources.flyingsaucer2;
                    imageArray[2] = Properties.Resources.flyingsaucer3;
                    imageArray[3] = Properties.Resources.flyingsaucer4;
                    break;
                case ShipType.Spaceship:
                    imageArray[0] = Properties.Resources.spaceship1;
                    imageArray[1] = Properties.Resources.spaceship2;
                    imageArray[2] = Properties.Resources.spaceship3;
                    imageArray[3] = Properties.Resources.spaceship4;
                    break;
                case ShipType.Star:
                    imageArray[0] = Properties.Resources.star1;
                    imageArray[1] = Properties.Resources.star2;
                    imageArray[2] = Properties.Resources.star3;
                    imageArray[3] = Properties.Resources.star4;
                    break;
            }
            return imageArray[animationCell];
        }
    }
}
