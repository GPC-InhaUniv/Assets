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
    public partial class Dungeon : Form
    {
        public Dungeon()
        {
            InitializeComponent();
        }
        
        private GameView gameView;
        private GameManager gameManager;
        private Random random = new Random();
        private void Dungeon_Load(object sender, EventArgs e)
        {
            gameView = new GameView(new Rectangle(78, 57, 420, 155));
            gameView.NewLevel(random);
            UpdateCharacters();
        }
        
        public void UpdateCharacters()
        {
            pbPlayer.Location = gameView.PlayerLocation;
            lblPlayerHitPoints.Text = gameManager.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            //


            foreach (Enemy enemy in gameView.Enemies)
            {
                if (enemy is Bat)
                {
                    pbBat.Location = enemy.Location;
                    lblBatHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                
                if ( enemy is Ghost)
                {
                    pbGhost.Location = enemy.Location;
                    lblGhostHitPoints.Text = enemy.HitPoints.ToString();
                    if(enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }

                if (enemy is Ghoul)
                {
                    pbGhoul.Location = enemy.Location;
                    lblGhoulHitPoints.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
                
            }

            pbSword.Visible = false;
            pbBow.Visible = false;
            pbMace.Visible = false;
            pbRedPotion.Visible = false;
            pbBluePotion.Visible = false;
                        
            Control itemControl = null;
            switch (gameView.ItemInRoom.Name)
            {
                case "Sword" :
                    itemControl = null;
                    break;
                case "Bow":
                    itemControl = null;
                    break;
                case "Mace":
                    itemControl = null;
                    break;
                case "RedPotion":
                    itemControl = null;
                    break;
                case "BluePotion":
                    itemControl = null;
                    break;
                default:
                    break;
            }

            itemControl.Location = gameView.ItemInRoom.Location;
            if (gameView.ItemInRoom.PickedUp)
            {
                itemControl.Visible = false;
            }
            else
            {
                itemControl.Visible = true;
            }
            if(gameManager.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                gameView.NewLevel(random);
                UpdateCharacters();
            }
            
        }               
        
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            gameView.Move(Direction.Up, random);
            UpdateCharacters();
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            gameView.Move(Direction.Down, random);
            UpdateCharacters();
        }
        
        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            gameView.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            gameView.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void btnAttackUp_Click(object sender, EventArgs e)
        {
            gameView.Use(Direction.Up, random);
            UpdateCharacters();
        }

        private void btnAttackDown_Click(object sender, EventArgs e)
        {
            gameView.Use(Direction.Down, random);
            UpdateCharacters();
        }

        private void btnAttackLeft_Click(object sender, EventArgs e)
        {
            gameView.Use(Direction.Left, random);
            UpdateCharacters();
        }

        private void btnAttackRight_Click(object sender, EventArgs e)
        {
            gameView.Use(Direction.Right, random);
            UpdateCharacters();
        }
        
        private void pbInventorySword_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory("Sword"))
            {
                //
            }

            gameManager.EquipItem("Sword");
            pbInventorySword.BorderStyle = BorderStyle.FixedSingle;
            pbInventoryBow.BorderStyle = BorderStyle.None;
            pbInventoryMace.BorderStyle = BorderStyle.None;
            pbInventoryRedPotion.BorderStyle = BorderStyle.None;
            pbInventoryBluePotion.BorderStyle = BorderStyle.None;
        }

        private void pbInventoryBow_Click(object sender, EventArgs e)
        {
            
        }

        private void pbInventoryMace_Click(object sender, EventArgs e)
        {
            
        }

        private void pbInventoryRedPotion_Click(object sender, EventArgs e)
        {
            
        }

        private void pbInventoryBluePotion_Click(object sender, EventArgs e)
        {

        }
    }
}
