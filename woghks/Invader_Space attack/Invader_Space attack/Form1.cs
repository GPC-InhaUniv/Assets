using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Invader_Space_attack
{
    public partial class Form1 : Form
    {
        private Game game;

        Rectangle boundaries;


        int animationCell = 0;
        List<Keys> keysPressed = new List<Keys>();

        

        public Form1()
        {
            InitializeComponent();
            gameTimer.Interval = 10;
            gameTimer.Start();
            game = new Game(ClientRectangle);
        }
        

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationCell++;
            if (animationCell > 4)
                animationCell = 0;

        }

        private void Form1_Paint(object sender, PaintEventArgs e)  //paint 이벤트
        {
            Graphics g = e.Graphics;
            game.Draw(g,animationCell);
            
        }


        public bool gameOver { get; private set; }



        private void Form1_KeyDown(object sender, KeyEventArgs e) //Q누르면 종료
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (gameOver)
                if (e.KeyCode == Keys.S)
                {
                    return;
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
            {
                keysPressed.Remove(e.KeyCode);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();

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

            Invalidate();
        }

        
    }
}   enum Direction
    {
        Left,
        Right,
        UP,
        Down,
    }
