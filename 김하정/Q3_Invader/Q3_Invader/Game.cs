using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Q3_Invader
{
    class Game
    {
        private int score = 0;
        private int liveLeft = 2;
        private int wave = 0;
        private int framesSkipped = 0;
        private Rectangle boundaries;
        private Random random;

        private Direction invaderDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip = new PlayerShip();
        private List<Shot> playerShots;
        private List<Shot> InvaderShots;

        private Stars stars;

        public event EventHandler GameOver;


        public void Draw(Graphics g, int animationCell)
        {
            return;
        }

        public void Twinkle()
        {
            return;
        }

        public void MovePlayer(Direction direction)
        {

            playerShip.Move(direction);

        }

        public void FireShot()
        {
            return;
        }

        public void Go()
        {
            return;
        }

        public void NextWave()
        {
            return;
        }

        private void CheckForPlayerCollisions()
        {
            return;
        }

        private void CheckForInvaderCollisions()
        {
            return;
        }
        private void MoveInvaders()
        {
            return;
        }
        private void ReturnFire()
        {
            return;
        }


    }
}
