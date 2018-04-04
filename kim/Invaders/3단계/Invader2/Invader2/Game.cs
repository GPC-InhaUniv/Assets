using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;

namespace Invader2
{
    class Game
    {
        //필드
        private Rectangle boundaries;
        private PlayerShip Player;
        
        public FlyWeight ImageStorage;
        
        List<Invader> Invaders;
        public int AnimationCount;
        Direction Invaderdirect;

        List<Shot> PlayerBullet;
        List<Shot> InvaderBullet;

        Random random;

        private int life;
        private int score;
        private int wave;
        private int ammo;
        private int skipFram;

        //생성자 - 초기화
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            life = 3;
            wave = 1;
            skipFram = 0;
            ammo = 2;
            Player = new PlayerShip(boundaries, life);
            ImageStorage = new FlyWeight();        
            Invaders = new List<Invader>();
            MakeInvader();
            Invaderdirect = Direction.Right;
            PlayerBullet = new List<Shot>();
            InvaderBullet = new List<Shot>();

            random = new Random();
            
           
        }

        //침입자 생성
        private void MakeInvader()
        {
            //Star
            Invaders.Add(new Invader(new Point(100, 350), InvaderType.Star, this));
            Invaders.Add(new Invader(new Point(200, 350), InvaderType.Star, this));
            Invaders.Add(new Invader(new Point(300, 350), InvaderType.Star, this));
            Invaders.Add(new Invader(new Point(400, 350), InvaderType.Star, this));
            Invaders.Add(new Invader(new Point(500, 350), InvaderType.Star, this));

            //spaceship
            Invaders.Add(new Invader(new Point(100, 250), InvaderType.SpaceShip, this));
            Invaders.Add(new Invader(new Point(200, 250), InvaderType.SpaceShip, this));
            Invaders.Add(new Invader(new Point(300, 250), InvaderType.SpaceShip, this));
            Invaders.Add(new Invader(new Point(400, 250), InvaderType.SpaceShip, this));
            Invaders.Add(new Invader(new Point(500, 250), InvaderType.SpaceShip, this));

            //flyingsaucer
            Invaders.Add(new Invader(new Point(100, 150), InvaderType.Saucer, this));
            Invaders.Add(new Invader(new Point(200, 150), InvaderType.Saucer, this));
            Invaders.Add(new Invader(new Point(300, 150), InvaderType.Saucer, this));
            Invaders.Add(new Invader(new Point(400, 150), InvaderType.Saucer, this));
            Invaders.Add(new Invader(new Point(500, 150), InvaderType.Saucer, this));

            //satellite
            Invaders.Add(new Invader(new Point(100, 50), InvaderType.Satellite, this));
            Invaders.Add(new Invader(new Point(200, 50), InvaderType.Satellite, this));
            Invaders.Add(new Invader(new Point(300, 50), InvaderType.Satellite, this));
            Invaders.Add(new Invader(new Point(400, 50), InvaderType.Satellite, this));
            Invaders.Add(new Invader(new Point(500, 50), InvaderType.Satellite, this));


        }

        
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Black, boundaries);
            Player.Draw(g);
            foreach (Shot Bullet in PlayerBullet)
            {
                Bullet.Draw(g);
            }
            foreach (Shot Bullet in InvaderBullet)
            {
                Bullet.Draw(g);
            }
            foreach (Invader Enemy in Invaders)
            {
                Enemy.Draw(g, AnimationCount);

            }
            using (Font Score = new Font("Arial", 24, FontStyle.Bold))
            {
                g.DrawString("SCORE : " + score.ToString(), Score, Brushes.Red, 0, 0);
            }
            using (Font Wave = new Font("Arial", 24, FontStyle.Bold))
            {
                g.DrawString("Wave : " + wave.ToString(), Wave, Brushes.Ivory, 400, 0);
            }
            if (Player.Life==0)
            using (Font Gameover = new Font("Arial", 40, FontStyle.Bold))
            {
                g.DrawString("Game Over", Gameover, Brushes.Red, 400, 350);
            }
            using (Font Life = new Font("Arial", 24, FontStyle.Bold))
            {
                g.DrawString("Life : "+Player.Life.ToString(), Life, Brushes.Red, 950, 0);
            }
            using (Font Ammo = new Font("Arial", 24, FontStyle.Bold))
            {
                g.DrawString("Ammo : " + (ammo-PlayerBullet.Count).ToString(), Ammo, Brushes.Green, 850, 750);
            }

        }

       
      
        public void Go()
        {
            skipFram++;
            if (wave == 15)
                wave = 14;
            if (skipFram % (15-wave) == 0 )
            {
                foreach (Invader Enemy in Invaders)
                {
                   Enemy.Move(Invaderdirect);

                }
                ReturnFire();
                MoveInvader();
                EndLine();
              
            }
            DamageToPlayer();
            DamageToInvader();
           
            
                for (int idx = 0; idx < PlayerBullet.Count; idx++)
                {
                    if (!PlayerBullet[idx].Move(0))
                    {

                        PlayerBullet.RemoveAt(idx);
                    }
                }
            if (skipFram % 5 == 0)
            {
                for (int idx = 0; idx < InvaderBullet.Count; idx++)
                {
                    if (!InvaderBullet[idx].Move(AnimationCount))
                    {
                        InvaderBullet.RemoveAt(idx);
                    }
                }
            }
            LevelUp();

        }

        // 웨이브 종료시
        public void LevelUp()
        {
            if (Invaders.Count == 0)
            {
                wave++;
                Player.Life++;
                MakeInvader();
                skipFram = 0;
                if (wave % 3 == 0)
                    ammo++;
            }
        }

        public void Animation(int count)
        {
            AnimationCount = count;
        }

        //플레이어, 침입자 이동 , 최하단 검사
        public void MovePlayer(Direction direction)
        {
            Player.Move(direction);
        }

    
        private void MoveInvader()
        {
            var Direct = from v in Invaders
                         where v.Location.X > boundaries.Right - 150 || v.Location.X < boundaries.Left + 100
                         select v;
            if (Direct.Count() != 0)
            {
                if (Invaderdirect == Direction.Right)
                    Invaderdirect = Direction.Left;
                else if (Invaderdirect == Direction.Left)
                    Invaderdirect = Direction.Right;
                foreach (Invader Enemy in Invaders)
                {
                    Enemy.MoveDown();
                }

            }
        }

        public void EndLine()
        {
            var Direct = from v in Invaders
                         where v.Location.Y > boundaries.Height - 100
                         select v;

           
            if (Direct.Count() != 0)
            {
                Player.Life = 0;
                EventGenerate();
            }
        }


        //플레이어, 침입자 총알 관리
        public void PlayerShoting()
        {
            if (PlayerBullet.Count < ammo)
            {
                PlayerBullet.Add(new Shot(new Point(Player.Location.X + 27, Player.Location.Y - 20), Direction.Up, boundaries,this));
            }
        }

        private void InvadersShoting(Invader Enemy)
        {
            if (InvaderBullet.Count < 2 + wave -1)
            {
                InvaderBullet.Add(new Shot(new Point(Enemy.Location.X + 20, Enemy.Location.Y), Direction.Down, boundaries,this));
            }
        }

        //플레이어 , 침입자의 피격 판정

        private void DamageToInvader()
        {
            for (int idx = 0; idx < Invaders.Count; idx++)
            {
                Rectangle Collision = Invaders[idx].Area;
                if (PlayerBullet.Count > 0)
                {
                    for (int Bullet = 0; Bullet < PlayerBullet.Count; Bullet++)
                    {
                        if (Collision.Contains(PlayerBullet[Bullet].Location))
                        {
                            score += Invaders[idx].Score;
                            Invaders.RemoveAt(idx);
                            
                            PlayerBullet.RemoveAt(Bullet);
                        }
                    }
                }
            }
        }
        
        private void DamageToPlayer()
        {
            Rectangle Collision = Player.Area;
            if (InvaderBullet.Count > 0)
            {
                for (int Bullet = 0; Bullet < InvaderBullet.Count; Bullet++)
                {
                    if (Collision.Contains(InvaderBullet[Bullet].Location))
                    {
                        Player.Life--;
                        
                        EventGenerate();
                        InvaderBullet.RemoveAt(Bullet);
                        
                    }
                }
            }
        }
      
       //최하단 침입자 확인후 공격

        private void ReturnFire()
        {
            var Shoting = from v in Invaders
                          group v by v.Location.X
                                  into First
                          orderby First.Key descending
                          select First;
            if (Shoting.Count() != 0)
            {
                foreach (var GroupX in Shoting)
                {
                    int min = 0;
                    foreach (Invader Invaderslist in GroupX)
                    {  
                        min = Invaderslist.First(min);
                        if (random.Next(10) == 0)
                        {
                            if (Invaderslist.Location.Y == min)
                            {
                                InvadersShoting(Invaderslist);
                            }
                        }
                    }
                }
            }
        }

        //게임 오버 이벤트
        public event EventHandler GameOver;


        public void EventGenerate()
        {
            GameOver Generate = new GameOver(Player.Life);
            this.GameOverEvent(Generate);
        }
        public void GameOverEvent(GameOver e)
        {

            EventHandler gameover = GameOver;
            if (gameover != null)
            {
                gameover(this, e);
            }
        }

        




        




    }
}

