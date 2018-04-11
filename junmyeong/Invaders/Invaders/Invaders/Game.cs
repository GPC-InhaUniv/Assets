using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Invaders
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down,
    }
    class Game
    {
        
        private Point point;         
        private int score = 0;
        public int Score { get { return score; } }
        private int livesLeft = 2;                   //목숨 이미지 갯수
        private int wave = 0;                        //탄 조절
        private int invaderMoveNum = 0;              //인베이더 방향조절
        private Rectangle boundaries;
        private Random random;
        private List<Invader> invaders;
        private List<Invader> invadersExplosion;
        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;
        private Stars stars;
        private GameOverEventArgs GameOverEvent;        //이벤트
        public event EventHandler GameOver;

        public void PlayerGameOver(GameOverEventArgs e)
        {
            EventHandler gameOver = GameOver;
            if (gameOver != null)
                gameOver(this, e);
        }

        public Game(Rectangle boundaries)
        {
            invaders = new List<Invader>();
            invadersExplosion = new List<Invader>();
            playerShip = new PlayerShip(boundaries);
            random = new Random();
            stars = new Stars();
            playerShots = new List<Shot>();
            invaderShots = new List<Shot>();
            this.boundaries = boundaries;
            GameOverEvent = new GameOverEventArgs();
        }

        public void NextWave()
        {
            point.Y = 300;
            for(int i = 0; i <5; i++)
            {
                point.X = 175;
                for(int j = 0; j < 6; j ++)
                {
                    
                    if (i == 0)
                        invaders.Add(new Invader(ShipType.Star, point, 10,boundaries));
                    else if(i == 1)
                        invaders.Add(new Invader(ShipType.Spaceship, point, 20, boundaries));
                    else if(i == 2)
                        invaders.Add(new Invader(ShipType.Flyingsaucer, point, 30, boundaries));
                    else if(i == 3)
                        invaders.Add(new Invader(ShipType.Bug, point, 40, boundaries));
                    else
                        invaders.Add(new Invader(ShipType.Satellite, point, 50, boundaries));
                    point.X += 65;
                }
                point.Y -= 60;
            }
           
        }

        public void Draw(Graphics g , int animationCell)
        {
            if(invaders.Count != 0)
            {
                g.DrawString("Score : " + score.ToString(), new Font("Arial", 20), new SolidBrush(Color.Yellow), point.X = 0, point.Y = 0);
                switch (livesLeft)
                {
                    case 2:
                        g.DrawImage(Properties.Resources.player, point.X = 690, point.Y = 10, 54, 33);
                        g.DrawImage(Properties.Resources.player, point.X = 630, point.Y = 10, 54, 33);
                        break;
                    case 1:
                        g.DrawImage(Properties.Resources.player, point.X = 690, point.Y = 10, 54, 33);
                        break;
                    default:
                        break;
                }
            }
            for (int i = 0; i < invaders.Count; i++)
                invaders[i].Draw(g, animationCell);
            for (int i = 0; i < invadersExplosion.Count; i++)
            {
                invadersExplosion[i].Draw(g, animationCell);
                if (invadersExplosion[i].ExplosionSell > 5)
                    invadersExplosion.Remove(invadersExplosion[i]);
            }
            playerShip.Draw(g);
            stars.Draw(g);
            if(playerShots != null)
                for(int i = 0; i <playerShots.Count; i ++)
                {
                    playerShots[i].Draw(g);
                }
            if (invaderShots != null)
                for (int i = 0; i < invaderShots.Count; i++)
                {
                    invaderShots[i].Draw(g);
                }
        }
        
        public void Twinkle()
        {
            stars.Twinkle(random);
        }

        public void MovePlayer(Direction direction)
        {
            playerShip.Move(direction);
        }

        public void FireShot()
        {
            if (playerShots.Count() < 3)
                playerShots.Add(new Shot(playerShip.Location, Direction.Up, boundaries));
        }

        public void Go()
        {
            CheckForPlayerCollisions();                        //Player 충돌여부
            CheckForInvaderCollisions();                       //Invader 충돌여부
            for (int i = 0; i < playerShots.Count; i++)
            {
                if (!playerShots[i].Move())
                    playerShots.Remove(playerShots[i]);     
            }     
            MoveInvader();
            ReturnFire();
            for ( int i = 0; i < invaderShots.Count(); i ++)
            {
                if (!invaderShots[i].Move())
                    invaderShots.Remove(invaderShots[i]);
            }
            if (invaders.Count == 0)                       //스테이지 클리어 시
            {
                NextWave();
                GameOverEvent = new GameOverEventArgs();
                livesLeft = 2;
            }
        }

        public void MoveInvader()
        {
           
            for (int i = 0; i < invaders.Count; i++)
            {
                if (invaderMoveNum == 0)
                    invaders[i].Move(Direction.Right);
                else
                    invaders[i].Move(Direction.Left);
            }

            var downNum =
                from invader in invaders
                where (invader.Location.X >= boundaries.Right -55 || invader.Location.X <= boundaries.Left)
                select invader;

            if (downNum.Count() != 0)
            {
                for (int i = 0; i < invaders.Count; i++)
                {
                    invaders[i].Move(Direction.Down);
                }
                if (invaderMoveNum == 0)
                    invaderMoveNum = 1;
                else
                    invaderMoveNum = 0;
            }
        }
        
        public void ReturnFire()
        {
            var shotInvader =
                from invader in invaders
                group invader by invader.Location.X
                into locationXGroups
                orderby locationXGroups.Key
                select locationXGroups;
            int limit = random.Next(shotInvader.Count());

            foreach(var invader in shotInvader)
            {
                if(limit != 0)
                {
                    limit--;
                    continue;
                }
                if (invaderShots.Count() < wave + 1)
                {
                    invaderShots.Add(new Shot(invader.First().Location, Direction.Down, boundaries));
                    break;
                }   
               
            }
            var horizontal =
                from invader in invaders
                group invader by invader.Location.Y
                into locationYGroups
                orderby locationYGroups.Key
                select locationYGroups;
            switch(horizontal.Count())
            {
                case 4:
                    wave = 1;
                    break;
                case 3:
                    wave = 2;
                    break;
                case 2:
                    wave = 3;
                    break;
                case 1:
                    wave = 4;
                    break;
                default:
                    wave = 0;
                    break;
            }
        }

        public void CheckForInvaderCollisions()
        {
            for (int i = playerShots.Count() -1; i >= 0; i --)
            {
                var collisionInvader =
                from invader in invaders
                where invader.Area.Contains(playerShots[i].Location) 
                select invader;
                if (collisionInvader.Count() !=0)
                {
                    List<Invader> collisionInvaders = (List<Invader>)collisionInvader.ToList();
                    for (int j = 0; j < collisionInvader.Count(); j++)
                    {
                        invadersExplosion.Add(new Invader(ShipType.Explosion,collisionInvaders[j].Location,0,boundaries));
                        score += collisionInvaders[j].Score;
                        invaders.Remove(collisionInvaders[j]);
                    }
                    playerShots.Remove(playerShots[i]);
                }
            }
                var collisionBottom =
                from invader in invaders
                where invader.Location.Y >= boundaries.Bottom -2
                select invader;
            if (collisionBottom.Count() != 0)
                {
               
                    for (int j = 0; j <= livesLeft;)
                    {
                        livesLeft--;
                        PlayerGameOver(GameOverEvent);
                    }
                }
        }

        public void CheckForPlayerCollisions()
        {
            for (int i = invaderShots.Count() - 1; i >= 0; i--)
            {
                if (playerShip.Area.Contains(invaderShots[i].Location))
                {
                    invaderShots.Remove(invaderShots[i]);
                    livesLeft--;
                    if (livesLeft < 0)
                        playerShip.Alive = false;
                    PlayerGameOver(GameOverEvent);
                }
            }
            for(int i = 0; i < invaders.Count; i++)
            {
                var collisionPlayer =
                from invader in invaders
                where playerShip.Area.Contains(invaders[i].Location)
                select invader;
                if(collisionPlayer.Count() != 0)
                {
                    for (int j = 0; j <= livesLeft;)
                    {
                        livesLeft--;
                        PlayerGameOver(GameOverEvent);
                    } 
                }
            }
        }
    }
}
