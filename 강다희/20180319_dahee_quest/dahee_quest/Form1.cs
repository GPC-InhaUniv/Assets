using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dahee_quest
{
    public partial class Form1 : Form
    {
        public Game game;
        public Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            UpdateCharacters();
        }

        public void UpdateCharacters()
        {
            playerBox.Location = game.PlayerLocation;
        }

        private void MoveUpButton_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Up);
            UpdateCharacters();
        }

        private void MoveDownButton_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Down);
            UpdateCharacters();
        }

        private void MoveLeftButton_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Left);
            UpdateCharacters();
        }

        private void MoveRightButton_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Right);
            UpdateCharacters();
        }
    }
}