using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    public partial class Form1 : Form
    {
        private Game game;
        private Random random;
        public Form1()
        {
            InitializeComponent();
            Rectangle BackGround = new Rectangle(78, 57, 420, 155);

            game = new Game(BackGround);
            random = new Random();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btMoveUp_Click(object sender, EventArgs e)
        {
            game.MoveIsAll(Direction.Up);
            UpDateOfAll();
        }

        private void btMoveLeft_Click(object sender, EventArgs e)
        {
            game.MoveIsAll(Direction.Left);
            UpDateOfAll();
        }

        private void btMoveRight_Click(object sender, EventArgs e)
        {
            game.MoveIsAll(Direction.Right);
            UpDateOfAll();
        }

        private void btMoveDown_Click(object sender, EventArgs e)
        {
            game.MoveIsAll(Direction.Down);
            UpDateOfAll();
        }

        public void UpDateOfAll()
        {
            pbPlayer.Location = game.PlayerLocation;
            pbBat.Location = game.Monsters[0].Lcation;
            pbGhost.Location = game.Monsters[1].Lcation;
            pbGhoul.Location = game.Monsters[2].Lcation;
            if(game.Weapons[0].PickUpWeapon() == true)
            {
                pictureBox4.Visible = false;
            }
        }

        private void pbPlayer_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
        }

        private void btAttackDown_Click(object sender, EventArgs e)
        {

        }
    }
}
