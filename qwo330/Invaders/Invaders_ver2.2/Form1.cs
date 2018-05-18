using System;
using System.Drawing;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Form1 : Form
    {
        Game game;
        //List<Keys> keysPressed = new List<Keys>();
        bool gameOver = false;

        int animaiontCell = 1;
        const int MaxCell = 4;

        public Form1()
        {
            InitializeComponent();
            Rectangle boundaries = new Rectangle(0, 0, Width, Height);
            Random random = new Random();

            game = new Game(boundaries, random);
            game.GameOver += new EventHandler(GameOver);

            gameOverr.Location = new Point(Width / 5, Height / 3);
            gameOverr.Visible = false;

            Score.Location = new Point(5, 10);
            Stage.Location = new Point(Width / 2 - 120, 10);
            lifeImg.Location = new Point(Width - 100, 5);
            Life.Location = new Point(Width - 60, 10);

            animationTimer.Interval = 33;
            animationTimer.Start();

            gameTimer.Interval = 33;
            gameTimer.Start();
        }

        private void GameOver(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameOver = true;
            gameOverr.Visible = true;
        }

        private void ReStart()
        {
            game.TryAgain();
            gameTimer.Start();
            gameOver = false;
            gameOverr.Visible = false;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) Application.Exit();

            if (gameOver)
                if (e.KeyCode == Keys.S)
                {
                    //게임 초기화하고 재시작
                    ReStart();
                    return;
                }

            if (e.KeyCode == Keys.Space)
                game.FireShot();

            //if (keysPressed.Contains(e.KeyCode))
            //    keysPressed.Remove(e.KeyCode);
            //keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            //if (keysPressed.Contains(e.KeyCode))
            //    keysPressed.Remove(e.KeyCode);
        }

        private void animationTimer_Tick_1(object sender, EventArgs e)
        {
            //Refresh();
            Invalidate();
            animaiontCell++;
            animaiontCell %= MaxCell + 1;
        }

        private void gameTimer_Tick_1(object sender, EventArgs e)
        {
            //Refresh();
            Invalidate();
            game.Go();

            if (mousePosition.X - game.GetPlayerLocation().X - 25 > AdjustmentValue)
                game.MovePlayer(Direction.Right);
            else if (mousePosition.X - game.GetPlayerLocation().X - 25 < -AdjustmentValue)
                game.MovePlayer(Direction.Left);


            //foreach (Keys key in keysPressed)
            //{
            //    if (key == Keys.Left)
            //    {
            //        game.MovePlayer(Direction.Left);
            //        return;
            //    }
            //    else if (key == Keys.Right)
            //    {
            //        game.MovePlayer(Direction.Right);
            //        return;
            //    }
            //}
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            game.Draw(e.Graphics, animaiontCell);
            Score.Text = "Score : " + game.Score.ToString();
            Life.Text = ": " + game.LivesLeft.ToString();
            Stage.Text = "Wave : " + game.Wave.ToString();
        }

        /* ==========  마우스 조작_미완 ============*/
        private const int AdjustmentValue = 10;
        private Point mousePosition;

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            mousePosition = e.Location;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            game.FireShot();
        }
    }
}
