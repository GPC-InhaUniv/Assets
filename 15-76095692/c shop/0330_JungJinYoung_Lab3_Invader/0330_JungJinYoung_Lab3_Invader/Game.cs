using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace _0330_JungJinYoung_Lab3_Invader
{
    
    public class Game
    {
        private int score = 0;
        private int livesLeft = 2;
        private int wave = 0;
        private int framesSkiepped = 0;//초반 침입자들을 느리게 움직이게 하는 필드
        
        private Rectangle boundaries;
        public Rectangle Bounderies
        {
            get
            {
                return boundaries;
            }
        }
        private Random random;

        private Direction invaderDirction;
        private List<Invader> invaders;

        private Playership playerShip;
        private List<Shot> playerShot;
        private List<Shot> invaderShot;

        private Stars star;


        public event EventHandler GameOver;//게임객체는 게이머가 죽으면 이벤트를 발생시키고 폼에서 이벤트 핸들러 메소드를 작성해 game객체의 gameover이벤트와 연결시킴



        public Game(Rectangle boundaries)
        {
            random = new Random();
            this.boundaries = boundaries;
            invaders = new List<Invader>();

            invaderShot = new List<Shot>();
            playerShot = new List<Shot>();
            star = new Stars(boundaries);

            Point plyaerPoint = new Point(boundaries.Width / 2-20, boundaries.Bottom-50);
            playerShip = new Playership(plyaerPoint);
            playerShot.Add(new Shot(plyaerPoint, Direction.Up, boundaries));


        }

        public void Draw(Graphics g, int animationCell)
        {

            //graphice객체와 애니메이션셀 (0~3)을 나타내는 정수, 이 두개를 매개 변수로 받고 - 받음
            //폼전체를 채우는 사각형을 그리고 별, 침입자, 우주선, 총알을 그린뒤에 왼쪽상단에 점수, 우측상단에는 우주선
            
            g.FillRectangle(Brushes.Black, boundaries);
            star.Draw(g);

            foreach (Invader invader in invaders)
            {
                invader.Draw(g, animationCell);
            }

            playerShip.Draw(g);
            foreach (Shot shot in playerShot)
                shot.Draw(g);
            //foreach (Shot shot in invaderShot)
            //    shot.Draw(g);


            //    게임오버일경우 화면 중간에 노란색의 game over 글자 출력.

        }

        public void CreateInvader()
        {
            Point InvaderPoint = new Point();

            for (int i=0; i<6;i++)
            {
                InvaderPoint.X = 80*i+20;
                invaders.Add(new Invader(ShipType.satellite, InvaderPoint, 40));
            }
            InvaderPoint.Y += 70;
            for (int i = 0; i < 6; i++)
            {
                InvaderPoint.X = 80 * i + 20;
                invaders.Add(new Invader(ShipType.bug, InvaderPoint, 40));
            }
            InvaderPoint.Y += 70;
            for (int i = 0; i < 6; i++)
            {
                InvaderPoint.X = 80 * i + 20;
                invaders.Add(new Invader(ShipType.flyingsaucer, InvaderPoint, 40));
            }
            InvaderPoint.Y += 70;
            for (int i = 0; i < 6; i++)
            {
                InvaderPoint.X = 80 * i + 20;
                invaders.Add(new Invader(ShipType.spaceship, InvaderPoint, 40));
            }
            InvaderPoint.Y += 70;
            for (int i = 0; i < 6; i++)
            {
                InvaderPoint.X = 80 * i + 20;
                invaders.Add(new Invader(ShipType.star, InvaderPoint, 40));
            }
        }

        public void Twinkle()
        {
            star.Twinkle(random);
        }

        public void FireShot()
        {
            Console.WriteLine("fireshot");
            bool hit = new bool();
            //화면에서 두개 이하로 총알이 남았는지 검사하고 적당한 위치에서 playerShots리스트에 새로운 총알을 추가해줘야한다.
            foreach (Shot playerShots in playerShot)
            {
                Console.WriteLine("fireshot foreach");
                playerShots.Move(hit);
            }
        }

        bool down = false;
        public void Go()
        {
            MoveInvader();//인베이더가 움직일 방향을 정해줌
            if (down == true)
            {
                foreach (Invader invader in invaders)
                {
                    invader.Move(Direction.Down);
                    down = false;
                }
            }
            else
            {
                foreach (Invader invader in invaders)
                {
                    invader.Move(invaderDirction);
                }
            }
            

            /*폼은 초당 10~30번 game 객체의 go를 호출한다
             * alive 속성을 사용해서 게임머가 죽었는지 확인한다
             * 게임이 끝났으면 폼은 stop() 메소드를 가진 애니메이션 타이머를 정지시킨다
             * go()는 우주선이 다시 살아날때까지 어떤일도 하지 않고 반환만 할것.
             * 
             * 모든 총알은 갱신되야한다 게임은 두개의 list<shot>객체에 대해 루프를 돌려 각 shot의 move()메소드를 호출해야하고
             * 만약 shot의 move()메소드가 false를 반환하면 총알이 화면 끝으로 사라진다는 의미이며 총알은 리스트에서 삭제해야한다.
             * 
             * 그리고난 뒤 게임은 가각의 침입자들을 움직이고 총을 발사하게 한다.
             * 
             * 마지막으로 총알이 명중했는지 검사한다. 먼저 총알 하나가 침입자 위로 지나갔는지 그리고 두개의 list<>에서 제거되었는지
             * 그 뒤 우주선이 총을 맞았는지 검사한다. invader에 area 라는 rectangle 속성과
             * playership 클래스를 추가해서 우주선 위로 총알이 지나가는지 검사하는데 contains()메소드를 사용한다.
             */
            bool Alive;
            
        }

        public void MoveInvader()
        {
            foreach (Invader invader in invaders)
            {
                if (invader.Location.X < boundaries.Left + 10 && invaderDirction == Direction.Left)//왼쪽 벽에 부딛치면 방향을 바꿔줌
                {
                    down = true;
                    invaderDirction = Direction.Right;
                    Console.WriteLine("왼쪽 벽에 부딛침");
                }
                if (invader.Location.X > boundaries.Right - 60 && invaderDirction == Direction.Right)//오른쪽 벽에 부딛치면 방향을 바꿔줌
                {
                    down = true;
                    invaderDirction = Direction.Left;
                    Console.WriteLine("오른쪽 벽에 부딛침");
                }
            }
        }

        public void MovePlayer(Direction direction)//, Point moveSpeed
        {
            //영거형을 매개변수로 갖고 두라인짜리 메소드. 를 가지고 플레이어가 살아있는지 여부를 검사하고 playerShip.Move()를 호출하여 우주선을 움직인다
            
            int moveSpeed = 15;
            playerShip.Move(direction,moveSpeed,boundaries);
        }
    }
}
