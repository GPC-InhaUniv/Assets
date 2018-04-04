using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Invader2
{
    class Game
    {
        private Rectangle boundaries;
        private PlayerShip Player;
        public InvaderFlyWeight ImageStorage;
        List<Invader> Invaders;
        public int AnimationCount;
        Direction Invaderdirect;

        List<Shot> PlayerBullet;
        List<Shot> InvaderBullet;

        Random random;

        int Life = 3;
        private int score;
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            Player = new PlayerShip(boundaries, Life);
            ImageStorage = new InvaderFlyWeight();
            Invaders = new List<Invader>();
            MakeInvader();
            Invaderdirect = Direction.Right;

            PlayerBullet = new List<Shot>();
            InvaderBullet = new List<Shot>();

            random = new Random();
        }
        private void MakeInvader()
        {
            //Star
            Invaders.Add(new Invader(new Point(100, 350), InvaderType.Star, this, 1));
            Invaders.Add(new Invader(new Point(200, 350), InvaderType.Star, this, 1));
            Invaders.Add(new Invader(new Point(300, 350), InvaderType.Star, this, 1));
            Invaders.Add(new Invader(new Point(400, 350), InvaderType.Star, this, 1));
            Invaders.Add(new Invader(new Point(500, 350), InvaderType.Star, this, 1));

            //spaceship
            Invaders.Add(new Invader(new Point(100, 250), InvaderType.SpaceShip, this, 0));
            Invaders.Add(new Invader(new Point(200, 250), InvaderType.SpaceShip, this, 0));
            Invaders.Add(new Invader(new Point(300, 250), InvaderType.SpaceShip, this, 0));
            Invaders.Add(new Invader(new Point(400, 250), InvaderType.SpaceShip, this, 0));
            Invaders.Add(new Invader(new Point(500, 250), InvaderType.SpaceShip, this, 0));

            //flyingsaucer
            Invaders.Add(new Invader(new Point(100, 150), InvaderType.Saucer, this, 0));
            Invaders.Add(new Invader(new Point(200, 150), InvaderType.Saucer, this, 0));
            Invaders.Add(new Invader(new Point(300, 150), InvaderType.Saucer, this, 0));
            Invaders.Add(new Invader(new Point(400, 150), InvaderType.Saucer, this, 0));
            Invaders.Add(new Invader(new Point(500, 150), InvaderType.Saucer, this, 0));

            //satellite
            Invaders.Add(new Invader(new Point(100, 50), InvaderType.Satellite, this, 0));
            Invaders.Add(new Invader(new Point(200, 50), InvaderType.Satellite, this, 0));
            Invaders.Add(new Invader(new Point(300, 50), InvaderType.Satellite, this, 0));
            Invaders.Add(new Invader(new Point(400, 50), InvaderType.Satellite, this, 0));
            Invaders.Add(new Invader(new Point(500, 50), InvaderType.Satellite, this, 0));





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
            if(Player.Life==0)
            using (Font Gameover = new Font("Arial", 40, FontStyle.Bold))
            {
                g.DrawString("Game Over", Gameover, Brushes.Red, 400, 350);
            }
        }

        public void MovePlayer(Direction direction)
        {
            Player.Move(direction);
        }

        public void Animation(int count)
        {
            AnimationCount = count;
        }
        int skipFram = 0;
        public void Go()
        {

            skipFram++;


            if (skipFram % 10 == 0)
            {
                foreach (Invader Enemy in Invaders)
                {
                   Enemy.Move(Invaderdirect);

                }
                ReturnFire();
                MoveInader();
                EndLine();
            }
            DamagebyPlayer();
            DamagebyInvader();
           // EndLine();
            for (int idx = 0; idx < PlayerBullet.Count; idx++)
            {
                if (!PlayerBullet[idx].Move())
                {
                    
                    PlayerBullet.RemoveAt(idx);
                }
            }

            for (int idx = 0; idx < InvaderBullet.Count; idx++)
            {
                if (!InvaderBullet[idx].Move())
                {
                    InvaderBullet.RemoveAt(idx);
                }
            }

        }

        private void MoveInader()
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

        private void EndLine()
        {
            var Direct = from v in Invaders
                         where v.Location.Y > boundaries.Height - 100
                         select v;

           
            if (Direct.Count() != 0)
            {
                // Console.WriteLine(Direct.Count());
                Player.Life = 0;
                EventGenerate();
            }
        }

        public void PlayerShoting()
        {
            if (PlayerBullet.Count < 2)
            {
                PlayerBullet.Add(new Shot(new Point(Player.Location.X + 27, Player.Location.Y - 20), Direction.Up, boundaries));
            }
        }

        public void InvadersShoting(Invader Enemy)
        {
            if (InvaderBullet.Count < 2)
            {
                InvaderBullet.Add(new Shot(new Point(Enemy.Location.X + 20, Enemy.Location.Y), Direction.Down, boundaries));
            }
        }

        public void DamagebyPlayer()
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
        
        public event EventHandler GameOver;
        


        public void DamagebyInvader()
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

