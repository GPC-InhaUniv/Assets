using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Form1 : Form
    {
        int animationSell = 0;
        bool gameOver = false;
        bool firstScreen = true;
        SoundPlayer soundPlayer;
        Game game;
        List<Keys> keysPressed = new List<Keys>();
        public Form1()
        {
            InitializeComponent();
            game = new Game(ClientRectangle);
            soundPlayer = new SoundPlayer(Properties.Resources.startMenu);   //첫 화면 음악
            soundPlayer.Play();
            game.GameOver += game_GameOver;
            animationTimer.Interval = 50;
            gameTimer.Interval = 30;        //타이머 간격
            animationTimer.Start();
        }

        private void game_GameOver(object sender, EventArgs e)          //게임오버 이벤트
        {
            if (e is GameOverEventArgs)
            {
                GameOverEventArgs gameOverEventArgs = e as GameOverEventArgs;
                if (gameOverEventArgs.PlayerHit() < 0)
                {
                    soundPlayer.Stop();
                    soundPlayer = new SoundPlayer(Properties.Resources.gameOver1);     
                    soundPlayer.Play();
                    gameOverLogo.Visible = true;
                    gameOver = true;
                    gameTimer.Stop();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && firstScreen == true)
            {
                game.NextWave();                                              //침입자들 30마리 생성
                gameTimer.Start();
                firstScreen = false;
                invaderLogo.Visible = false;
                soundPlayer.Stop();
                soundPlayer = new SoundPlayer(Properties.Resources.survival);     //전투사운드 돌입
                soundPlayer.Play();
            }
            if (e.KeyCode == Keys.Q)
                Application.Exit();
            if (e.KeyCode == Keys.S && gameOver == true)
            {
                soundPlayer.Stop();
                soundPlayer = new SoundPlayer(Properties.Resources.survival);
                soundPlayer.Play();
                gameOverLogo.Visible = false;
                game = new Game(ClientRectangle);
                game.GameOver += game_GameOver;
                game.NextWave();
                gameOver = false;
                animationTimer.Start();
                gameTimer.Start();
            }
            if (e.KeyCode == Keys.Space)
                game.FireShot();
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            if (animationSell == 5)
                animationSell = 0;         
            animationSell++;
            game.Twinkle();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            game.Go();
            foreach(Keys key in keysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                }
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            BackColor = Color.Black;
            game.Draw(e.Graphics, animationSell);

            if (firstScreen)
            {
                e.Graphics.DrawString("Press Enter Key", new Font("Arial", 35), new SolidBrush(Color.Yellow), ClientRectangle.Width / 2 - 180, ClientRectangle.Height / 2 + 90);
            }

            if (gameOver)
            {
                e.Graphics.DrawString("Q : Exit", new Font("Arial", 35), new SolidBrush(Color.Yellow), ClientRectangle.Width/5, ClientRectangle.Height/2);
                e.Graphics.DrawString("S : ReStart", new Font("Arial", 35), new SolidBrush(Color.Yellow), ClientRectangle.Width /2 + 60, ClientRectangle.Height / 2);
                e.Graphics.DrawString("Score : "+game.Score, new Font("Arial", 35), new SolidBrush(Color.Yellow), ClientRectangle.Width /2 - 130, ClientRectangle.Height /2 + 90);
            }
        }


        
    }
}
