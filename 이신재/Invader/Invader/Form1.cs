using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Invader
{
    public partial class invadergame : Form
    {

        List<Keys> keysPressed = new List<Keys>();
        private int Frame;

        Game game;
        public Rectangle boundaries { get { return this.ClientRectangle; } }

        public invadergame()
        {
            InitializeComponent();
            game = new Game(boundaries);
            gametimer.Interval = 30;
            animationtimer.Interval = 50;
            animationtimer.Start();
            gametimer.Start();
        }

        private void animationtimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            if (Frame < 4)
                for (int i = 0; i < 4; i++)
                    Frame++;

            else
                Frame = 0;
        }

        private void gametimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            foreach(Keys key in keysPressed)
            {
                if(key == Keys.Left)
                {
                    game.MovePlayer(enumDirection.Left);
                    return;
                }
                else if(key == Keys.Right)
                {
                    game.MovePlayer(enumDirection.Right);
                    return;
                }
            }
        }

        private void Form1_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            //if(gameOver)
            if (e.KeyCode == Keys.S)
            {
                Application.Restart();
                return;
            }
            if (e.KeyCode == Keys.Space)
            {
                game.FireShot();
            }
            
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
            keysPressed.Add(e.KeyCode);
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
                keysPressed.Remove(e.KeyCode);
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            
            game.Draw(g,Frame);
            //g.DrawImage(Properties.Resources.bug1, 50, 50);


        }

        
        //private bool gameOver()

    }
}
