using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invader_Space_attack
{
 


    class Game
    {
        private int score = 0;
        private int livesLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;

        private Rectangle boundaries;

        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip PlayerShip;
        
        private List<Shot> PlayerShips;
        private List<Shot> invadersShots;

        private Stars stars;
        private List<Shot> PlayerShots;
        private List<Shot> invaderShots;

        public Point Location { get; }

        public event EventHandler GameOver;


        public Game(Rectangle boundaries)
        {
            PlayerShip = new PlayerShip(new Point(boundaries.Width/2 , boundaries.Height-50),boundaries);
            this.boundaries = boundaries;
        }


        public void Draw(Graphics g, int animationCell)  //이미지 생성 메소드
        {
            //stars.Draw(g);
            //foreach (Invader invader in invaders)
            //{
            //    invader.Draw(g, animationCell);
            //}
            PlayerShip.Draw(g);
            //foreach (Shot shot in PlayerShots)
            //{
            //    shot.Draw(g);
            //}
        }

        public void Twinkle()  //별 반짝 메소드
        {

        }

        public void MovePlayer(Direction direction) // 플에이어 무브 메소드
        {
            PlayerShip.Move(direction);
        }


        public void FireShot()  //총 발사 메소드
        {

        }

        public void Go()   //GO메소드
        {

        }


    }





}
