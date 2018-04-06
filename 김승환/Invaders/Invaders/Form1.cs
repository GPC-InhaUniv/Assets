using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Invaders
{
    public partial class Form1 : Form
    {
        List<Keys> keysPressed = new List<Keys>();

        Game game;
        Random random;
        private bool gameOver = false;
        int animationCell = 0;
        int startFrame = 0;
        bool gameStarted = false;
        private SoundPlayer bgmPlayer = new SoundPlayer();
        private SoundPlayer firePlayer = new SoundPlayer();
        

        public Form1()
        {
            Paint += StartMenu;
            InitializeComponent();
            startTimer.Start();
            Stream streamSoundPlayer = Properties.Resources.spaceinvaders1;
            bgmPlayer.Stream = streamSoundPlayer;
            Stream streamfirePlayer = Properties.Resources.sfx_wpn_cannon1;
            firePlayer.Stream = streamfirePlayer;
            string dir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName.ToString() + @"\Resources\mazeOfMayonnaise.wav";
            axWindowsMediaPlayer1.PlayStateChange += new AxWMPLib._WMPOCXEvents_PlayStateChangeEventHandler(PlayLoop);
            axWindowsMediaPlayer1.settings.autoStart = false;
            axWindowsMediaPlayer1.URL = dir;
            axWindowsMediaPlayer1.settings.volume = 100;
            bgmPlayer.Play();
        }

        private void StartGame()
        {
            startTimer.Stop();
            gameStarted = true;
            random = new Random();
            game = new Game(ClientRectangle, random);
            game.Gameover += new EventHandler(Game_Gameover);
            Paint += Form1_Paint;
            Paint -= StartMenu;
            animationTimer.Start();
            gameTimer.Start();
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
        
        private void Game_Gameover(object sender, EventArgs e)
        {
            gameTimer.Stop();
            gameOver = true;
            Invalidate();
            MessageBox.Show("Your Score is " + game.Score + "\n\n If You Wanna retry Press S Key","Game Finished");
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g, animationCell);
        }

        private void StartMenu(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.DrawImage(Properties.Resources.space_invaders, 0, 0, ClientRectangle.Width, ClientRectangle.Height);
            if(startFrame == 1)
            g.DrawString("Press Enter Key to Start!", new Font("Arial", 20), new SolidBrush(Color.GreenYellow), 240, ClientRectangle.Height - 180);
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Q)
            {
                Application.Exit();
            }

            if(e.KeyCode == Keys.Enter)
            {
                if(!gameStarted)
                StartGame();
                bgmPlayer.Stop();
            }

            if(gameOver)
            {
                if(e.KeyCode == Keys.S)
                {
                    keysPressed.Clear();
                    gameOver = false;
                    game = new Game(ClientRectangle, random);
                    game.Gameover += new EventHandler(Game_Gameover);
                    gameTimer.Start();
                    return;
                }
            }

            if(e.KeyCode == Keys.X)
            {
                if (gameStarted)
                    if (game.FireShot())
                    {
                        firePlayer.Play();
                    }
            }

            if(keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            game.Twinkle();
            animationCell++;
            if(animationCell > 3)
            {
                animationCell = 0;
            }
            Refresh();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if(keysPressed.Count() >= 1)
            {
                switch(keysPressed[0])
                {
                    case Keys.Left:
                        game.MovePlayer(Direction.Left);
                        break;
                    case Keys.Right:
                        game.MovePlayer(Direction.Right);
                        break;
                }
            }
            game.Go();
        }

        private void startTimer_Tick(object sender, EventArgs e)
        {
            if (startFrame == 0)
            {
                startFrame++;
            }
            else
            {
                startFrame--;
            }
            Refresh();
        }
        
        private void PlayLoop(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            axWindowsMediaPlayer1.Ctlcontrols.play();
        }
    }
}
