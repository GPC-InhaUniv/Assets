using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    enum Direction
    {
        Left = 1,
        Right = 2,
        Up = 3,
        Down = 4
    }

    class Game
    {
        private int score = 0;
        public int Score
        {
            get => score;
        }
        private int livesLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;
        private int invaderFireFrame = 10;
        private int waveShowCount = 50;
        private bool waveChanged = false;
        private bool lifeRecovered = false;
        private int bossHP = 100;


        private Rectangle boundaries;
        private Font scoreFont = new Font("Arial", 16);
        private Font waveFont = new Font("Arial", 40);
        private Brush backGroundBrush = new SolidBrush(Color.Black);
        private Brush scoreFontBrush = new SolidBrush(Color.YellowGreen);
        private Brush waveFontBrush = new SolidBrush(Color.LightYellow);
        private Image playerImage = Properties.Resources.player;
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playership;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private Stars stars;

        public event EventHandler Gameover;

        public Game(Rectangle boundaries, Random random)
        {
            this.boundaries = boundaries;
            this.random = random;
            stars = new Stars(boundaries);
            playership = new PlayerShip(boundaries);
            invaders = new List<Invader>();
            playerShots = new List<Shot>();
            invaderShots = new List<Shot>();
            MakeNextWave();
            waveChanged = true;
        }

        public void Draw(Graphics g, int animationCell)
        {
            g.FillRectangle(backGroundBrush, boundaries);
            stars.Draw(g);
            playership.Draw(g);

            foreach(Invader invader in invaders)
            {
                invader.Draw(g, animationCell);
            }
            foreach (Shot playerShot in playerShots)
            {
                playerShot.Draw(g);
            }
            foreach (Shot invaderShot in invaderShots)
            {
                invaderShot.Draw(g);
            }
            g.DrawString("Score : " + score.ToString(), scoreFont, scoreFontBrush, 5, 7);
            if (livesLeft >= 1)
                g.DrawImage(playerImage, boundaries.Right - 60, boundaries.Top + 5);
            if (livesLeft >= 2)
                g.DrawImage(playerImage, boundaries.Right - 120, boundaries.Top + 5);
            if(waveChanged && waveShowCount % 4 <= 2)
            {
                if(wave <= 9)
                {
                    g.DrawString("Wave : " + wave, waveFont, waveFontBrush, boundaries.Width / 2 - 100, 400);
                }
                if(lifeRecovered)
                {
                    g.DrawString("Life Recovered!", waveFont, waveFontBrush, boundaries.Width / 2 - 180, 500);
                }
            }
        }

        public void Twinkle()
        {
            stars.Twinkle(random); 
        }

        public void MovePlayer(Direction direction)
        {
            if(playership.Alive)
            {
                playership.Move(direction);
            }
        }

        public bool FireShot()
        {
            if(playerShots.Count >= 15)
            {
                return false;
            }
            else
            {
                Point p = playership.Location;
                p.X += 25;
                playerShots.Add(new Shot(p, Direction.Up, boundaries, new SolidBrush(Color.Red)));
                return true;
            }
        }

        public bool Go()
        {
            if(!playership.Alive)
            {
                return false;
            }
            
            for (int i = 0; i < playerShots.Count; i++)
            {
                if (!playerShots[i].Move(Direction.Up))
                {
                    playerShots.RemoveAt(i);
                }
            }

            for (int i = 0; i < invaderShots.Count; i++)
            {
                if (!invaderShots[i].Move(Direction.Down))
                {
                    invaderShots.RemoveAt(i);
                }
            }

            MoveInvaders();
            ReturnFire();
            CheckForPlayerCollisions();
            CheckForInvaderCollisions();

            if(invaders.Count == 0)
            {
                if(MakeNextWave())
                {
                     Gameover(this, null);
                }
                waveChanged = true;
            }

            if(waveChanged)
            {
                waveShowCount--;
            }

            if(waveShowCount == 0)
            {
                waveShowCount = 50;
                waveChanged = false;
                lifeRecovered = false;
            }

            if(livesLeft < 0)
            {
                Gameover(this, null);
            }

            return true;
        }

        private bool MakeNextWave()
        {
            wave++;
            if (wave > 9)
            {
                return true;
            }
            else if(wave > 8)
            {
                invaders.Add(new Invader(Type.Boss, new Point(200, 100), 1000));
            }
            else
            {
                for (int i = 0; i < 30; i++)
                {
                    int col = i / 6 + 1;
                    int row = i % 6;
                    invaders.Add(new Invader((Type)col, new Point(250 + row * 60, col * 60), (6 - col) * 10));
                }
            }
            if(livesLeft < 2)
            {
                livesLeft = 2;
                lifeRecovered = true;
            }
            framesSkipped = 4 - wave;
            invaderDirection = Direction.Right;
            return false;
        }

        private void CheckForPlayerCollisions()
        {
            for(int i = invaderShots.Count - 1; i >= 0 ; i--)
            {
                if (NearBy(invaderShots[i], playership))
                {
                    invaderShots.RemoveAt(i);
                    livesLeft--;
                }
            }
            for(int i = 0; i < invaders.Count; i++)
            {
                if(invaders[i].Location.Y > boundaries.Height - 100)
                {
                    Gameover(this, null);
                }
            }
        }

        private void CheckForInvaderCollisions()
        {

            for (int i = playerShots.Count - 1; i >= 0; i--)
            {
                for(int j = invaders.Count - 1; j >= 0; j--)
                {
                    if (NearBy(playerShots[i], invaders[j]))
                    {
                        score += invaders[j].Score;
                        playerShots.RemoveAt(i);
                        if (invaders[j].InvaderType is Type.Boss)
                        {
                            if (bossHP != 1)
                            {
                                bossHP--;
                            }
                            else
                            {
                                invaders.RemoveAt(j);
                            }
                        }
                        else
                        {
                            invaders.RemoveAt(j);
                        }
                        i = playerShots.Count - 1;
                        j = invaders.Count - 1;
                        if (playerShots.Count == 0 || invaders.Count == 0)
                        {
                            return;
                        }
                    }
                }
            }
        }

        private void MoveInvaders()
        {
            if(framesSkipped > 0)
            {
                framesSkipped--;
            }
            else
            {
                framesSkipped = 4 - wave;
                if(wave == 9)
                {
                    return;
                }
                if(invaderDirection == Direction.Right)
                {
                    var invaderCollection =
                        from invader in invaders
                        where invader.Location.X > (boundaries.Width - 100)
                        select invader;

                    if(invaderCollection.Count() > 0)
                    {
                        invaderDirection = Direction.Left;
                        foreach (Invader invader in invaders)
                        {
                            invader.Move(Direction.Down);
                        }
                    }
                    else
                    {
                        foreach (Invader invader in invaders)
                        {
                            invader.Move(invaderDirection);
                        }
                    }
                  
                }

                else if (invaderDirection == Direction.Left)
                {
                    var invaderCollection =
                        from invader in invaders
                        where invader.Location.X < (boundaries.X + 100)
                        select invader;

                    if (invaderCollection.Count() > 0)
                    {
                        invaderDirection = Direction.Right;
                        foreach (Invader invader in invaders)
                        {
                            invader.Move(Direction.Down);
                        }
                    }
                    else
                    {
                        foreach (Invader invader in invaders)
                        {
                            invader.Move(invaderDirection);
                        }
                    }
                }
            }
        }

        private void ReturnFire()
        {
            if(wave != 9)
            {
                if (invaderFireFrame != 0)
                {
                    invaderFireFrame--;
                    return;
                }
                else
                {
                    invaderFireFrame = 10 - wave;
                }
                var invaderFireCollection =
                    from invader in invaders
                    group invader by invader.Location.X
                    into invaderGroups
                    orderby invaderGroups.Key
                    select invaderGroups;

                invaderShots.Add(new Shot(invaderFireCollection.ElementAt(random.Next(0, invaderFireCollection.Count())).Last().Location, Direction.Down, boundaries, new SolidBrush(Color.WhiteSmoke)));
            }
            else
            {
                invaderShots.Add(new Shot(new Point(random.Next(boundaries.X + 50, boundaries.Width - 50), random.Next(50, 100)), Direction.Down, boundaries, new SolidBrush(Color.WhiteSmoke)));
            }
        }

        private bool NearBy(Shot shot, object target)
        {
            if(target is PlayerShip)
            {
                if (((PlayerShip)target).Area.Contains(shot.Location))
                {
                    return true;
                }
            }

            if(target is Invader)
            {
                if (((Invader)target).Area.Contains(shot.Location))
                {
                    return true;
                }
            }

            return false;
        }


    }
}
