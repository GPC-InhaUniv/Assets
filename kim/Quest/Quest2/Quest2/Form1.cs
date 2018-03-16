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
    public enum WeaponNames
    {
        Sword,
        Bow,
        Mace,
    }
    public partial class Form1 : Form
    {
        Game game;
        Random random;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Up_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up,random);
            UpdateCharacter();
        }

        private void left_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacter();
        }

        private void Down_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacter();
        }

        private void Right_move_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel();
            random = new Random();
            UpdateCharacter();
        }

        public void UpdateCharacter()
        {
            Player_Pic.Location = game.PlayerLocation;
           foreach(Enemy enemy in game.Enemies)
            {
                if(enemy is Bat)
                {
                    Bat_Pic.Location = enemy.Location;

                }
            }
        }
    }
}
