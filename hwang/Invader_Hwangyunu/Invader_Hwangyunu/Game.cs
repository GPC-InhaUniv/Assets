using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

    

namespace Invader_Hwangyunu
{
    enum Direction
    {
        Left,
        Right,
        Up,
        Down
    }


    class Game
    {
        private int score = 0;
        private int livesLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;

        private bool moveDown = false;


        private Rectangle boundaries;
        public Rectangle Boudaries { get{ return boundaries; } }
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        public PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private Stars stars;

        private Point location;

        public Game(Rectangle boundaries,Random random, List<Invader> invaders, List<Shot> Shot,Stars stars)
        {
            this.boundaries = boundaries;
            this.random = random;
            this.invaders = invaders;
            this.playerShots = Shot;
            this.invaderShots = Shot;
            this.stars = stars;
            playerShip = new PlayerShip(new Point(boundaries.Left + 220, boundaries.Top + 440),this);


            invaderDirection = Direction.Left;
        }


        public void Draw(Graphics g, int animationCell)
        {
            stars.Draw(g);
            playerShip.Draw(g);

            foreach (Invader invader in invaders)
                invader.Draw(g, animationCell);
            foreach (Shot shot in playerShots)
            {
                shot.Draw(g);
            }
            
            foreach (Shot shot in invaderShots)
                shot.Draw(g);
        }

        private void MoveInvader()
        {
            for (int i = 0; i < invaders.Count; i++)
            {
                invaders[i].Move(invaderDirection);

            }
            for (int i = 0; i < invaders.Count; i++)
            {
                if(invaderDirection == Direction.Left && invaders[i].InvaderLocation.X<=boundaries.Left)
                {
                    invaderDirection = Direction.Down;
                    break;
                }
                else if (invaderDirection == Direction.Down && invaders[i].InvaderLocation.X <= boundaries.Left)
                {
                    invaderDirection = Direction.Right;
                    break;
                }

                else if (invaderDirection == Direction.Right && invaders[i].InvaderLocation.X >= boundaries.Right - 50)
                {
                    invaderDirection = Direction.Down;
                    break;
                }
                else if (invaderDirection == Direction.Down && invaders[i].InvaderLocation.X >= boundaries.Right - 50)

                {
                    invaderDirection = Direction.Left;
                    break;
                }

            }
        

         
            
        }



        public void Twinkle()
        {

        }
        public void MovePlayer(Direction direction)
        {
            playerShip.Move(direction);
        }
        public void FireShot()
        {
     
                playerShots.Add(new Shot(new Point(boundaries.Left + 220, boundaries.Top + 440), Direction.Up, boundaries,this));
                //playerShots.Add(new Shot(playerShip.PlayerLocation, Direction.Up, boundaries));
            
          

        }
        public void Go()
        {
            MoveInvader();
            foreach (Shot shot in playerShots)
                shot.Move();
        }

        public void NewWave()
        {
            wave++;
            switch (wave)
            {
                case 1: CreateStage();
                    break;

                default: break;
            }
        }


        public void CreateStage()
        {
            
            for (int i = 100; i < 400; i+=50)
            {
                invaders.Add(new Invader(ShipType.Star, new Point(boundaries.Left + i, boundaries.Top + 250), 10));
                invaders.Add(new Invader(ShipType.SpaceShip, new Point(boundaries.Left + i, boundaries.Top + 200), 20));
                invaders.Add(new Invader(ShipType.Saucer, new Point(boundaries.Left + i, boundaries.Top + 150), 30));
                invaders.Add(new Invader(ShipType.Bug, new Point(boundaries.Left + i, boundaries.Top + 100), 40));
                invaders.Add(new Invader(ShipType.Satellite, new Point(boundaries.Left + i, boundaries.Top + 50), 50));

            }
            
        }
    }

}
