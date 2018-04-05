using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invader
{
    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }

    public partial class Form1 : Form
    {
        List<Keys> keysPressed;
        Game game;

        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(10, 10);
            this.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            keysPressed = new List<Keys>();
            game = new Game(new Rectangle(0, 0, 1080, 800));



        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q)
                Application.Exit();

            if (e.KeyCode == Keys.Space)
            {
                //공격 함수
            }

            if (keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
            keysPressed.Add(e.KeyCode);


        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keysPressed.Contains(e.KeyCode))
            {
                keysPressed.Remove(e.KeyCode);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g);
            GameTimer.Start();
           
        }

        private void GameTimer_Tick(object sender, EventArgs e)
        {
           foreach(Keys key in keysPressed)
            {
                if(key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    Invalidate();
                    return;
                }
                else if(key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    Invalidate();
                    return;
                }
            }
        }
    }
}
