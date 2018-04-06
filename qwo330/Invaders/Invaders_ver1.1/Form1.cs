using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Form1 : Form
    {
        Game game;
        List<Keys> keysPressed = new List<Keys>();
        bool gameOver = false;

        int animaiontCell = 1;
        const int MaxCell = 4;

        public Form1()
        {
            InitializeComponent();
            Rectangle boundaries = new Rectangle(0, 0, 760, 600);
            Random random = new Random();

            game = new Game(boundaries, random);
            Console.WriteLine("X : " + Width + " Y : " + Height);

            animationTimer.Interval = 33;
            animationTimer.Start();

            gameTimer.Interval = 60;
            gameTimer.Start();
        }

        private void GameOver(object sender, KeyEventArgs e)
        {
            gameTimer.Stop();
            gameOver = true;
            Invalidate();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) Application.Exit();

            if (gameOver)
                if (e.KeyCode == Keys.S)
                {
                    //게임 초기화하고 재시작
                    return;
                }

            if (e.KeyCode == Keys.Space)
                game.FireShot();

            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void animationTimer_Tick_1(object sender, EventArgs e)
        {
            animaiontCell++;
            animaiontCell %= MaxCell + 1;
        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {
            game.Go();
            Refresh();
            //game.Draw(this.CreateGraphics(), animaiontCell);

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
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics, animaiontCell);
            Score.Text = "Score : " + game.Score.ToString();
            Life.Text = ":" + game.LivesLeft.ToString();
            Stage.Text = "Wave : " + game.Wave.ToString();
            //Refresh();
        }
    }
}
