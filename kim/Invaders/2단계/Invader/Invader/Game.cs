using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace Invader
{
    class Game
    {
        private Rectangle boundaries;
        PlayerShip Player;
        List<Invader> Invaders;
        Random random;
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            Player = new PlayerShip(boundaries);
            Invaders = new List<Invader>();
            PlayerBullet = new List<Shot>();
            InvadersBullet = new List<Shot>();
            random = new Random();
            Invaders.Add(new Invader(new Point(100, 100)));
            Invaders.Add(new Invader(new Point(200, 100)));
            Invaders.Add(new Invader(new Point(300, 100)));
            Invaders.Add(new Invader(new Point(400, 100)));

        }
        public void MovePlayer(Direction direction)
        {
            Player.Move(direction);

        }

        public void AnimationTimer(int timer)
        {
            Count = timer;
        }
        int Count;
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.Black, new Rectangle(0, 0, 1152, 864));
            Player.Draw(g);
            foreach (Invader Enemy in Invaders)
            {
                Enemy.Draw(g, Count);
                
            }
            foreach (Shot test in PlayerBullet)
            {
                test.Draw(g);
            }
            foreach(Shot test in InvadersBullet)
            {
                test.Draw(g);
            }


        }

        Direction InvaderDirection = Direction.Right;
        int skipFrame = 0;
       
        public void Go()
        {
           
            skipFrame++;
            if (skipFrame == 10)
            {
                foreach (Invader Enemy in Invaders)
                {
                    Enemy.Move(InvaderDirection);
                    if (0 == random.Next(10))
                    {
                        InvadersShot(Enemy);
                    }
                }

                skipFrame = 0;
                MoveInvader();
            }
            
           for(int idx = 0; idx < PlayerBullet.Count;idx ++)
            {
               
                if (!PlayerBullet[idx].Move())
                {
                    PlayerBullet.RemoveAt(idx);
                }
            }
            for (int idx = 0; idx < InvadersBullet.Count; idx++)
            {
                if (!InvadersBullet[idx].Move())
                {
                    InvadersBullet.RemoveAt(idx);
                }
            }
            DamageInvader();
        }
        private void MoveInvader()
        {
            var Direct = from v in Invaders
                         where v.Location.X > boundaries.Right - 100 || v.Location.X < boundaries.Left + 100
                         select v;

            int count = 0;
            foreach (Invader i in Direct)
            {
                count++;

                if (count > 0)
                { 
                    if (InvaderDirection == Direction.Right)
                        InvaderDirection = Direction.Left;
                    else if (InvaderDirection == Direction.Left)
                        InvaderDirection = Direction.Right;
                    foreach (Invader Enemy in Invaders)
                    {
                        Enemy.MoveDown();
                        
                    }
                }
            }


        }
        public List<Shot> PlayerBullet;
        public void PlayerShot()
        {
            if (PlayerBullet.Count < 2)
            {
                PlayerBullet.Add(new Shot(new Point(Player.Location.X + 27, Player.Location.Y-20), Direction.Up, boundaries));
            }
           

        }
        public List<Shot> InvadersBullet;
        
        public void InvadersShot(Invader Enemy)
        {
           
            if (InvadersBullet.Count < 2)
            {
                InvadersBullet.Add(new Shot(new Point(Enemy.Location.X, Enemy.Location.Y), Direction.Down, boundaries));
            }
            
        }


        public void DamageInvader()
        {
            for(int idx =0; idx < Invaders.Count;idx++)
            {
                Rectangle collision = Invaders[idx].Area;
                if (PlayerBullet.Count > 0)
                    for(int bullet=0; bullet <PlayerBullet.Count;bullet++)
                    {
                        if(collision.Contains(PlayerBullet[bullet].Location))
                        {
                            Invaders.RemoveAt(idx);
                            PlayerBullet.RemoveAt(bullet);
                        }
                    }
            }
           
        }

    }
}
