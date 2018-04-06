using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Game game;

        List<Keys> keyPressed = new List<Keys>();

        // 폼에 화면을 그려주는 부분
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            game.Draw(g);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(new Point(0,0),this.Size));
            this.DoubleBuffered = true;
        }

        // keyDown 키보드를 누르고 있는 동안 작동
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                // 작동됨.
                Application.Exit();
            }

            if(e.KeyCode==Keys.Z)
            {
                game.FireShot();
            }

            // 저장된 키를 제거하고 다시 추가함으로써
            // 현재 키가 리스트에 있는 마지막(가장 최신) 키가 됩니다.
            if (keyPressed.Contains(e.KeyCode))
            {
                keyPressed.Remove(e.KeyCode);
            }

            keyPressed.Add(e.KeyCode);
        }

        // keyUp 키보드 버튼에서 손을 떼면 작동
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (keyPressed.Contains(e.KeyCode))
            {
                keyPressed.Remove(e.KeyCode);
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();
            game.Go();
            foreach (Keys key in keyPressed)
            {
                if(key==Keys.Left)
                {
                    game.MovePlayer(PlayerShip.Direction.Left);
                    return;
                }
                else if(key==Keys.Right)
                {
                    game.MovePlayer(PlayerShip.Direction.Right);
                    return;
                }
            }
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}
