using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdventureGame
{


    public partial class Form1 : Form   //다 GAME 클래스에서 가져온다
    {

        private Game game;


        private Random random = new Random();

       

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateCharacters()
        {
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool ShowGhoul = false;
            int enemiexShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat )
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiexShown++;
                    }

                }
                if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    ghostHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiexShown++;
                    }

                }
                if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    ghoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        ShowGhoul = true;
                        enemiexShown++;
                    }

                }
            }

        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void button1_Click(object sender, EventArgs e)//Top
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void button2_Click(object sender, EventArgs e)//Right
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void button3_Click(object sender, EventArgs e)//Left
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void button4_Click(object sender, EventArgs e)//Down
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void button5_Click(object sender, EventArgs e)//up
        {
            game.Attack(Direction.Up, random);
            UpdateCharacters();
                
        }

        private void button7_Click(object sender, EventArgs e)//left
        {
            game.Attack(Direction.Left, random);
            UpdateCharacters();

        }

        private void button6_Click(object sender, EventArgs e)//right
        {
            game.Attack(Direction.Right, random);
            UpdateCharacters();
        }

        private void button8_Click(object sender, EventArgs e)//down
        {
            game.Attack(Direction.Down, random);
            UpdateCharacters();

        }
    }
}
