using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습3_Invader
{
     enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }
    class Game
    {
        private int score = 0;
        private int livaLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;

        public Graphics graphics;
        public Graphics graphics2;
        private Rectangle boundaries = new Rectangle(0, 0, 0, 0);
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        public PlayerShip playerShip;
        private List<Shot> playershots;
        private List<Shot> invaderShots;
        
        public bool gameOver { get; private set; }
        public event EventHandler GameOver;

        public Game()
        {
            //graphics = g;
            boundaries = new Rectangle(795, 473, 868, 564);
            playerShip = new PlayerShip(new Point(380, 475), boundaries);
            playershots = new List<Shot>();
            invaders = new List<Invader>();
            invaders.Add(new Invader(ShipType.Bug, new Point(125, 100), 10));
        }

        public void Draw(Graphics g)
        {
            playerShip.Draw(g);
            invaders[0].Draw(g);
            foreach(Shot playershot in playershots)
            {
                playershot.Draw(g);
            }
        }

        public void Twinkle()
        {

            // 별들을 반짝이게 함
        }

        public void MovePlayer(Direction direction)
        {
            if(direction == Direction.Left || direction == Direction.Right)
            {
                playerShip.Move(direction);
            }
            // 플레이어 우주선을 움직이게하는 메소드
        }

        public void FireShot()
        {
            if(playershots.Count < 2)
                playershots.Add(new Shot(playerShip.Location, boundaries));
            // 게이머가 침입자들을 향해 총을 발사하게 만듬.
        }

        public void Go()
        {
            for(int i = 0; i < playershots.Count; i++)
            {

                playershots[i].Move(Direction.Up);

                if(playershots[i].Move(Direction.Up))
                {
                }
                else
                    playershots.RemoveAt(i);
            }
            
            
            // Alive 속성을 사용해서 게이머가 죽었는지 검사함.
            // 총알을 움직이게 함.
            // 침입자들을 움직이게 함.
            // 명중했는지 검사함.
        }

        // 추가
        public void NextWave()
        {
            // 다음 부대 침입자들을 생성하는 메소드
        }

        public void CheckForPlayerCollisions()
        {
            // 게이머 우주선이 총을 맞았는지 검사하는 메소드
        }

        public void CheckForInvaderCollisions()
        {
            // 침입자가 총을 맞았는지 검사하는 메소드
        }

        public void MoveInvaders()
        {
            // 모든 침입자를 움직이게 하는 메소드
        }
        
        public void ReturnFire()
        {
            // 침입자들이 총을 발사하는 메소드
        }
    }
}
