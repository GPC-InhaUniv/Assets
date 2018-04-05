using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
namespace Invader2
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }
    
    public partial class MainForm : Form
    {
        
        List<Keys> KeysPressed;
        Game game;
        Stars star;
        int animationCount;
        Random random;
        SoundPlayer backGroundMusic;
    
        private void MainForm_Load(object sender, EventArgs e)
        {
            // 초기화
            KeysPressed = new List<Keys>();
            game = new Game(new Rectangle(new Point(0, 0), this.Size));
            animationCount = 1;
            random = new Random();
            star = new Stars(random);
            //타이머 시작
            GameTimer.Start();
            AnimationTimer.Start();
            game.GameOver += new EventHandler(game_GameOver);
            backGroundMusic = new SoundPlayer(Properties.Resources.MainBGM);
            backGroundMusic.PlayLooping();
         

        }
       
        public void game_GameOver(object sender, EventArgs e)
        {
            if (e is GameOver)
            {
                GameOver player = e as GameOver;
                if(player.Life ==0)
                GameTimer.Stop();
               
            }
            
        }

        public MainForm()
        {
            InitializeComponent();
            //폼 크기 및 위치 변경
            this.Size = new Size(1100, 850);
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(350, 10);
            this.Show();
            DoubleBuffered = true;
            
        }
        
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (e.KeyCode == Keys.Space)
            {
                //공격 함수    
                game.PlayerShoting();
            }
            if(e.KeyCode == Keys.Enter)
            {
                if (game.PlayerLife > 0)
                {
                    game.CheckGameStart();
                    if (game.gameStartFlag == false)
                    {
                        GameTimer.Stop();
                    }
                    else
                        GameTimer.Start();
                }
            }
            if(e.KeyCode == Keys.R)
            {
                
                game.ReStart();
                GameTimer.Start();
                
            }
            if (KeysPressed.Contains(e.KeyCode))
            {
                KeysPressed.Remove(e.KeyCode);
            }
            KeysPressed.Add(e.KeyCode);
        }

        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeysPressed.Contains(e.KeyCode))
            {
                KeysPressed.Remove(e.KeyCode);
            }
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            
                game.Go();
                foreach (Keys key in KeysPressed)
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

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            animationCount++;
            if (animationCount > 4)
            {
                animationCount = 1;
                star.Twinkle(random);
            }
            game.Animation(animationCount);
           

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g);
            star.Draw(g,random);

        }
        
       
    }
}
