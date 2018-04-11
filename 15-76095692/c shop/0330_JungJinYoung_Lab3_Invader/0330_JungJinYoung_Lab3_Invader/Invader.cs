using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;

namespace _0330_JungJinYoung_Lab3_Invader
{
    
    class Invader
    {

        private const int HorizontalInterval = 10;//좌우측으로 이동하는 픽셀거리
        private const int VerticalInterval = 40;//하단으로 이동하는 픽셀 거리
        private Bitmap image;
        public Point Location { get; private set; }
        public ShipType InvaderType { get; private set; }
        public Rectangle Area { get { return new Rectangle(Location, image.Size); } }
        public int Score { get; private set; }
        
        public Invader(ShipType invaerType, Point location, int score)
        {
            this.InvaderType = invaerType;
            this.Location = location;
            this.Score = score;
            image = InvaderImage(0);
        }

        //추가 메소드들
        
        private Bitmap InvaderImage(int animationCell)
        {
            // 가져올 이미지 이름
            string imageName = string.Format("{0}{1}",InvaderType,animationCell+1);
            //Console.WriteLine(imageName);
            // 현재 실행 중인 어셈블리를 구해서
            Assembly thisAssembly = Assembly.GetExecutingAssembly();
            //Console.WriteLine(thisAssembly);
            // 리소스 관리자를 생성하고
            ResourceManager rm = new ResourceManager(Properties.Resources.ResourceManager.BaseName, thisAssembly);
            //Console.WriteLine(rm);
            // GetObject() 메서드로 그림을 가져와서 사용
            image = (Bitmap)(rm.GetObject(imageName));
            //Console.WriteLine(image);
            
            return image;
            //침입자를 그릴때 쓰는 메소드
            //애니메이션 셀에 근거해서 올바른 이미지를 설정해야 하므로
            //애니메이션 셀에 대한 특정 bitmap객체를 반환해야한다
            //다양하게 활용할 수 있고 특정 셀에 대한 올바른 bitmap을 반환한다.
        }
        //public void GetProperties()
        //{
        //    string stet;
        //    //ex1 = Properties.Resources.ResourceManager.BaseName+InvaderType+ani;
        //    Console.WriteLine(Properties.Resources.ResourceManager.BaseName);
        //}
        public void Draw(Graphics g, int animationCell)
        {
            //Console.WriteLine(InvaderImage(animationCell).Width);
            g.DrawImage(InvaderImage(animationCell), Location);
            
            //game객체가 제공한 graphics를 사용해서 게임화면 위에 침입자를 그린다
            //정확한 애니메이션 셀을 사용해서 우주선 이미지를 그려야한다.
        }

        public Point Move(Direction direction)
        {
            Point newLocation = Location;
            //Console.WriteLine(newLocation);
            switch (direction)
            {
                case Direction.Down:
                    {
                        newLocation.Y = newLocation.Y + VerticalInterval;
                        break;
                    }
                case Direction.Left:
                    {
                        newLocation.X = newLocation.X - HorizontalInterval;
                        break;
                    }
                case Direction.Right:
                    {
                        newLocation.X = newLocation.X + HorizontalInterval;
                        break;
                    }
            }
            //Console.WriteLine(newLocation);
            Location = newLocation;
            return Location;
            //열거형 방향을 전송해서 침입자들을 움직여야한다
            //좌우하단으로 움직이는/방향을 바꾸는건 game객체가 처리하고 있음으로 invader클래스는 신경쓰지 않아도 된다
            //특정방향으로 우주선을 움직이게 해야한다.
            //내 생각에는 direction으로 if(하단) loction+=VerticalInterval 인듯
        }
    }
}
