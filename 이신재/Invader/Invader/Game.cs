using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Invader
{
    class Game
    {
        private int score = 0;
        private int liveLeft = 2;
        private int wave = 0;
        private int framesskipped = 0;

        private Point location;
        private Rectangle formArea;
        private Random random;

        private enumDirection invaderDirection;
        private enumDirection playerDirection;
        private List<Invader> invaders;

        private PlayerShip playerShip;
        private List<Shot> playerShots;
        private List<Shot> invaderShots;

        private int frame;

        private Stars stars;

        public Game(Rectangle formarea)
        {
           this.formArea = formarea;
            playerShip = new PlayerShip(formArea,
                new Point((formArea.Width / 2), (formArea.Height-40)));
            invaders = new List<Invader>();
            
        }

        public void Draw(Graphics g, int Frame)
        {
            g.FillRectangle(Brushes.Black, formArea);
            playerShip.Draw(g, location);

            foreach (Invader invader in invaders)
                invader.Draw(g, frame);

        }
        public void Twinkle()
        {

        }

        public void MovePlayer(enumDirection direction)
        {
            playerShip.Move(direction);
            
        }
        
        public void FireShot()
        {

        }

        public void Go()
            //게이머가 죽었는지 검사
            //총알을 움직이게 함
            //침입자들을 움직이게 함
            //명중했는지 검사
        {
            if(playerShip.Alive)
            {
                return;
            }
            else
            {
               
            }
        }
        

        
        public event EventHandler GameOver;
    }
}
