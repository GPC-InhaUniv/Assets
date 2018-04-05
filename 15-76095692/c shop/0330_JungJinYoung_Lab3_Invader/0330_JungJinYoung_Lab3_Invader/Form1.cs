using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _0330_JungJinYoung_Lab3_Invader
{
    public enum Direction
    {
        Left,
        Right,
        Up,
        Down,
    }
    public enum ShipType
    {
        bug,
        flyingsaucer,
        satellite,
        spaceship,
        star,
    }

    public partial class Form1 : Form
    {
        private Game game;
        public int animationCell;
        public bool animation;

        public Form1()
        {
            
            InitializeComponent();
            game = new Game(ClientRectangle);

            game.CreateInvader();
            //ClientRectangle
        }
        

        

        List<Keys> KeysPressed = new List<Keys>();
        private bool gameOver;//게임오버 이벤트를 만들어줘야한다 기억할것!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (KeysPressed.Contains(e.KeyCode))
            {
                KeysPressed.Remove(e.KeyCode);
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Q) Application.Exit();

            if (gameOver)
            {
                if (e.KeyCode == Keys.S)
                {
                    return;
                }
            }
            if (e.KeyCode == Keys.Space)
            {
                game.FireShot();
            }
            if (KeysPressed.Contains(e.KeyCode))
            {
                KeysPressed.Remove(e.KeyCode);
            }
            KeysPressed.Add(e.KeyCode);
        }

        

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            game.Go();
            foreach (Keys key in KeysPressed)
            {
                if (key == Keys.Left)
                {
                    game.MovePlayer(Direction.Left);
                    return;
                }
                if(key == Keys.Right)
                {
                    game.MovePlayer(Direction.Right);
                    return;
                }
                if(key == Keys.Space)
                {
                    game.FireShot();
                }
            }
            //Refresh();
        }


        public Rectangle GetClientRectangle()
        {
            Rectangle bounderies = this.ClientRectangle;
            return bounderies;
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g, animationCell);
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            //Console.WriteLine("game.Twinkle();");
            if (animationCell == 3)
            {
                animation = false;
            }
            if (animationCell == 0)
            {
                animation = true;
            }
            if (animation)
            {
                animationCell++;
            }
            if (!animation)
            {
                animationCell--;
            }
            game.Twinkle();
            Refresh();
        }
        
    }
}
