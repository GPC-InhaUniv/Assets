using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quest2
{
    public enum Direction
    {
        Up=0,
        Down,
        Left,
        Right,
        
    }
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Up_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up);
            UpdateCharacter();
        }

        private void left_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left);
            UpdateCharacter();
        }

        private void Down_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down);
            UpdateCharacter();
        }

        private void Right_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right);
            UpdateCharacter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            UpdateCharacter();
        }

        public void UpdateCharacter()
        {
            Player_Pic.Location = game.PlayerLocation;
        }
    }
}
