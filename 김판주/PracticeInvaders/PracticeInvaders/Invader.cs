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

        private Bitmap image;

        public Point Location { get; private set; }

        public ShipType InvaderType { get; private set; }

        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }

        public int Score { get; private set; }



        public Invader(ShipType invaderType, Point location, int score)
        {
            this.InvaderType = invaderType;
            this.Location = location;
            this.Score = Score;

            image = InvaderImage(0);
        }


        public void Draw(Graphics g, int animationCell)
        {
            //정확한 애니메이션 셀을 사용해서 우주선 이미지를 그립니다.
            
            
        }
        public void Move(Direction direction)
        {
            //특정방향으로 우주선을 움직이게 합니다
        }

        private Bitmap InvaderImage(int animationCell)
        {
            return image;
            //다양하게 활용하며, 특정 셀에 대한 올바른 비트맵을 반환
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
