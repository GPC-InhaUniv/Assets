using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 실습3_Invader
{
    public partial class Form1 : Form
    {
        List<Keys> keysPressed = new List<Keys>();
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game();
            game.graphics2 = CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void DrawPaint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (game.gameOver)
                if (e.KeyCode == Keys.S)
                {
                    // 게임을 초기화하고 타이머를 재시작하는 코드 작성
                    return;
                }

            //if (e.KeyCode == Keys.Space)
            //    game.FireShot();

            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);

            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();

            foreach (Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    Invalidate();
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    Invalidate();
                    return;
                }
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            foreach (Keys key in keysPressed)
            {
                if(key == Keys.Space)
                {
                    game.FireShot();
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
