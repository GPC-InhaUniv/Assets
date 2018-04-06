using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3_Invader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Keys> keysPressed = new List<Keys>();
        Game game = new Game();
        PlayerShip playerShip;
         
 
        private void animationTimer_Tick(object sender, EventArgs e)
        {
          
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
             
            foreach (Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }

                game.Go();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            //if (gameOver)
            if (e.KeyCode == Keys.S)
            {


                //게임을 초기화 하고 타이머를 재 시작하는 코드
                return;
            }

            if (e.KeyCode == Keys.Space)
                game.FireShot();
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);

            if (e.KeyCode == Keys.Left)
            {
                game.MovePlayer(Direction.Left);

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //시각적인 모든 것은 여기서 발생된다.
            
        }
    }

    
}
