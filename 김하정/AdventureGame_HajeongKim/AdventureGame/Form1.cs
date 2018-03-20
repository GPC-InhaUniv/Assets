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
    

    public partial class Form1 : Form
    {
         
        private Game game;

        private Random random = new Random();
         

        public Form1()
        {
            InitializeComponent();
        }

        public void UpdateChatacters()
        {
            Player.Location = game.PlayerLocation;
            playerHitPoints.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool ShowGhoul = false;
            int enemiexShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    bat.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiexShown++;
                    }
                    
                }
                else if (enemy is Ghost)
                {
                    ghost.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiexShown++;
                    }

                }
                else if (enemy is Ghoul)
                {
                    ghoul.Location = enemy.Location;
                    batHitPoints.Text = enemy.HitPoints.ToString();
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
            UpdateChatacters();
        }

         
    }
}
