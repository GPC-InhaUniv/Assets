using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Invader
{
    public partial class Invader : Form
    {
        public Invader()
        {
            InitializeComponent();
        }

        public Game game;

        private List<Keys> KeysPressed = new List<Keys>(); //어떤 키가 눌려졌는지를 파악하기 위한 키 리스트+타이머

        private bool gameOver;

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) //q버튼을 누르면 게임이 종료됨.
                Application.Exit();

            if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                    Refresh();
                return;
            }
            if (e.KeyCode == Keys.Space)
                game.FireShot();
            if (KeysPressed.Contains(e.KeyCode))
                KeysPressed.Remove(e.KeyCode);
            KeysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeysPressed.Contains(e.KeyCode))
                KeysPressed.Remove(e.KeyCode); //키에서 손을 떼면 키를 리스트에서 삭제
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //Game.Twinkle();
            Refresh();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();
            foreach (Keys key in KeysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Game.Direction.Left);
                    return;
                }
                else if (key == Keys.Right)
                {
                    game.MovePlayer(Game.Direction.Right);
                    return;
                }
            }
        }

        private void Invader_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.FillRectangle(Brushes.Black, ClientRectangle);
        }
    }
}