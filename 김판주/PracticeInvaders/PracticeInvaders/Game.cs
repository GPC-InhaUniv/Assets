using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;

namespace PracticeInvaders
{
    public class Game
    {

        private int score = 0;
        private int livesLeft = 2;
        private int wave = 0;
        private int frameSkipped = 0;

        private Rectangle boundaries;
        private Random random = new Random();


        private Direction invaderDirection;
        private List<Invader> Invaders;

        private PlayerShip playerShip;
        private Stars stars;
        private Shot shot;


        private List<Shot> playerShots = new List<Shot>();
        private List<Shot> invaderShots;

        public Game(Rectangle boundaries)
        {
            playerShip = new PlayerShip(new Point(boundaries.Width/2 - 50, boundaries.Height - 50), boundaries, false);
            stars = new Stars(boundaries);
            stars.CreatStar();

            shot = new Shot(playerShip.Location, Direction.Up, boundaries);
            //playerShots.Add(new Shot(playerShip.Location, Direction.Up ,boundaries));
            
        }
         
        public event EventHandler GameOver;


        public void MovePlayer(Direction direction)
        {
            //폼의 키보드 타이머 이벤트 핸들러는 게이머의 우주선을 움직이게 만들어야 함
            // game객체는 direction 열거형을 매개변수로 갖는 두 라인 짜리 메소드를 사용해서 게이머가 살아 있는지 여부를 검사
            // playership.move()를 호출해서 우주선을 움직이게해야합니다.
            playerShip.Move(direction);
        }

        public void FireShot()
        {
            if(playerShots.Count < 2)
            playerShots.Add(new Shot(playerShip.Location, Direction.Up, boundaries));          
            //화면에 우주선이 쏜 총알이 두개이하로 남아있는지 검사
            //그렇다면 이 메소드는 적당한 위치에서 palyerShots 리스트에 새로운 총알 추가해야함
        }

        public void Go()
        {
            //if (playerShip.Alive == false)
            //    playerShip.Draw(g);

            for(int i=0; i < playerShots.Count; i++)
            {
                Shot shot = playerShots[i]; //리스트에서 하나 씩 꺼냄
                if (shot.Move())
                {
                    //폼 맨 끝에 닿을때까지 +20
                }
                else
                    playerShots.Remove(shot); //폼 끝에 닿으면 삭제

            }
                
           //alive속성을 사용해 플레이어가 죽었는지 확인
           //죽었다면 drawimage()를 사용해야함 --> 플레이어쉽에서 할거임...

                //총알을 움직이게 함

                //침입자들을 움직이게 함


                //명중했는지 검사
        }

        public void Twinkle()
        {
            stars.Twinkle(random);
        }

        public void Draw(Graphics g,int animationCell)
        {

            stars.Draw(g);
            //foreach (Invader invader in Invaders)
                //invader.Draw(g, animationCell);

            playerShip.Draw(g);

            foreach (Shot shot in playerShots)
                shot.Draw(g);
            //foreach (Shot shot in invaderShots)
            //    shot.Draw(g);

            //g.DrawImage(Properties.Resources.satellite1, 7, 30);
            //g.DrawImage(Properties.Resources.bug1, 7, 90);
            //g.DrawImage(Properties.Resources.flyingsaucer1, 7, 150);
            //g.DrawImage(Properties.Resources.spaceship1, 7, 200);
            //g.DrawImage(Properties.Resources.star1, 7, 250);

            //g.DrawImage(Properties.Resources.satellite1, 70, 30);
            //g.DrawImage(Properties.Resources.bug1, 70, 90);
            //g.DrawImage(Properties.Resources.flyingsaucer1, 70, 150);
            //g.DrawImage(Properties.Resources.spaceship1, 70, 200);
            //g.DrawImage(Properties.Resources.star1, 70, 250);

            //g.DrawImage(Properties.Resources.satellite1, 140, 30);
            //g.DrawImage(Properties.Resources.bug1, 140, 90);
            //g.DrawImage(Properties.Resources.flyingsaucer1, 140, 150);
            //g.DrawImage(Properties.Resources.spaceship1, 140, 200);
            //g.DrawImage(Properties.Resources.star1, 140, 250);

            //g.DrawImage(Properties.Resources.satellite1, 210, 30);
            //g.DrawImage(Properties.Resources.bug1, 210, 90);
            //g.DrawImage(Properties.Resources.flyingsaucer1, 210, 150);
            //g.DrawImage(Properties.Resources.spaceship1, 210, 200);
            //g.DrawImage(Properties.Resources.star1, 210, 250);

            //g.DrawImage(Properties.Resources.satellite1, 280, 30);
            //g.DrawImage(Properties.Resources.bug1, 280, 90);
            //g.DrawImage(Properties.Resources.flyingsaucer1, 280, 150);
            //g.DrawImage(Properties.Resources.spaceship1, 280, 200);
            //g.DrawImage(Properties.Resources.star1, 280, 250);

            //g.DrawImage(Properties.Resources.satellite1, 350, 30);
            //g.DrawImage(Properties.Resources.bug1, 350, 90);
            //g.DrawImage(Properties.Resources.flyingsaucer1, 350, 150);
            //g.DrawImage(Properties.Resources.spaceship1, 350, 200);
            //g.DrawImage(Properties.Resources.star1, 350, 250);

           

            //g.DrawImage(Properties.Resources.player, 846, 12);
            //g.DrawImage(Properties.Resources.player, 917, 12);
            //g.DrawImage(Properties.Resources.player, 775, 12);


            

            //배경을 검은색으로 채움 바운더리 이용
            
            

            // 그리고 각종객체들을 그림

            // 화면 왼쪽 상다넹는 점수를, 우측상단에는 우주선(목숨)을

            // if gameover = true일시 gameover란 글자 표시
        }




    }
}
