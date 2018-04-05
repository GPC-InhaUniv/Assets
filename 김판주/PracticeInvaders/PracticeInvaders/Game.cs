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

        private Random random;


        private Direction invaderDirection = new Direction();

        private List<Invader> Invaders;
        private Invader invader;
        private PlayerShip playerShip;
        private Stars stars;
        private Shot shot;


        private List<Shot> playerShots = new List<Shot>();
        private List<Shot> invaderShots = new List<Shot>();

        public event EventHandler GameOver;

        public int animationcell;

        public Game(Rectangle boundaries, int animationcell)
        {
            playerShip = new PlayerShip(new Point(boundaries.Width/2 - 50, boundaries.Height - 75), boundaries, true);

            this.animationcell = animationcell;

             //10점 매칭스코어해야함
             //Invader invader = new Invader(Invader.ShipType.Star, new Point(0, 0), 10, boundaries);
             Invaders = new List<Invader>();
              stars = new Stars(boundaries);
              stars.CreatStar();


              random = new Random();


            //shot = new Shot(playerShip.Location, Direction.Up, boundaries);

            //invaderShots.Add(new Shot(, Direction.Down, boundaries));

        }

        

        public void MovePlayer(Direction direction)
        {
            if(playerShip.Alive == true)
            {
                playerShip.Move(direction);
            }
            
        }

        public void FireShot()
        {
            if(playerShots.Count < 2)
            playerShots.Add(new Shot(new Point(playerShip.Location.X, playerShip.Location.Y), Direction.Up, boundaries));          
        }

        public void Go()
        {


            for(int i = 0; i < playerShots.Count; i++)
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
            //if (playerShip.Alive == false)
            //    playerShip.Draw(g);

            //침입자들을 움직이게 함

            //invader.Move(Direction.Down);

            //명중했는지 검사
        }

        public void Twinkle()
        {
            stars.Twinkle(random);
        }

        public void Draw(Graphics g,int animationCell)
        {
            stars.Draw(g);

            playerShip.Draw(g);

            foreach (Shot shot in playerShots)
                shot.Draw(g);

            foreach (Invader invader in Invaders)
                invader.Draw(g, animationCell);

           

            foreach (Shot shot in invaderShots)
               shot.Draw(g);

            using (Font font = new Font("Arial", 15, FontStyle.Bold))
            {
                g.DrawString("Score : " + score.ToString(),font,Brushes.White,new  Point(boundaries.X/2, boundaries.Y/2));
            }
            if(livesLeft >= 2)
            {
                g.DrawImage(Properties.Resources.Playerspaceship2, new Point(boundaries.X + 750, boundaries.Y));
                g.DrawImage(Properties.Resources.Playerspaceship2, new Point(boundaries.X + 830, boundaries.Y));

            }
            else if(livesLeft == 1)
            {
                g.DrawImage(Properties.Resources.Playerspaceship2, new Point(boundaries.X + 830, boundaries.Y));
            }


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

            // 화면 왼쪽 상단에는 점수를, 우측상단에는 우주선(목숨)을

            // if gameover = true일시 gameover란 글자 표시
        }
    }
}
