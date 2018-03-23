using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        

        private Game game;
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            Bat1.Visible = false;
            Ghost1.Visible = false;
            Ghoul1.Visible = false;
            UpdateCharacters();
        }



        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(MoveDirection.MoveUP,random);
            UpdateCharacters();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(MoveDirection.MoveDown, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(MoveDirection.MoveLeft, random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(MoveDirection.MoveRight, random);

            UpdateCharacters();
        }

        private void AttackUP_Click(object sender, EventArgs e)
        {
            if (Bat1.Visible || Ghost1.Visible || Ghoul1.Visible)
            {
                game.Attack(MoveDirection.MoveUP, random);
            }

            UpdateCharacters();

        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            if (Bat1.Visible || Ghost1.Visible || Ghoul1.Visible)
            {
                game.Attack(MoveDirection.MoveDown, random);
            }
            UpdateCharacters();
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            if (Bat1.Visible || Ghost1.Visible || Ghoul1.Visible)
            {
                game.Attack(MoveDirection.MoveLeft, random);
            }
            UpdateCharacters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            if (Bat1.Visible || Ghost1.Visible || Ghoul1.Visible)
            {
                game.Attack(MoveDirection.MoveLeft, random);
            }
            UpdateCharacters();
        }


        public void UpdateCharacters()
        {
            Player1.Location = game.PlayerLocation;
            PlayerHitPoint.Text = game.PlayerHitPoints.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    Bat1.Location = enemy.Location;
                    BatHitPoint.Text = enemy.EnemiesLife.ToString();
                    if (enemy.EnemiesLife > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                    else
                    {
                        showBat = false;

                    }
                    if (showBat)
                    {
                        Bat1.Visible = true;
                    }
                    else
                    {
                        Bat1.Visible = false;
                    }
                }
                if (enemy is Ghost)
                {
                    Ghost1.Location = enemy.Location;
                    GhostHitPoint.Text = enemy.EnemiesLife.ToString();
                    if (enemy.EnemiesLife > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                    else
                    {
                        showGhost = false;

                    }
                    if (showGhost)
                    {
                        Ghost1.Visible = true;
                    }
                    else
                    {
                        Ghost1.Visible = false;
                    }
                }
                if (enemy is Ghoul)
                {
                    Ghoul1.Location = enemy.Location;
                    GhoulHitPoint.Text = enemy.EnemiesLife.ToString();
                    if (enemy.EnemiesLife > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                    else
                    {
                        showGhoul = false;
                    }
                    if (showGhoul)
                    {
                        Ghoul1.Visible = true;
                    }
                    else
                    {
                        Ghoul1.Visible = false;
                    }
                }
            }
            /*
            Sword1.Location = game.WeaponInRoom.Location;
            Bow1.Location = game.WeaponInRoom.Location;
            BluePotion1.Location = game.WeaponInRoom.Location;
            Mace1.Location = game.WeaponInRoom.Location;
            RedPotion1.Location = game.WeaponInRoom.Location;
            */
            Sword1.Visible = false;
            Bow1.Visible = false;
            RedPotion1.Visible = false;
            BluePotion1.Visible = false;
            Mace1.Visible = false;
            Bomb1.Visible = false;
            Shield1.Visible = false;

            Inventory1.Visible = false;
            Inventory2.Visible = false;
            Inventory3.Visible = false;
            Inventory4.Visible = false;
            Inventory5.Visible = false;
            Inventory6.Visible = false;
            Inventory7.Visible = false;



            Control weaponControl = null;

            foreach (Weapon weaponInRoom in game.WeaponInRoom)
            {
                switch (weaponInRoom.Name)
                {
                    case "Sword":
                        weaponControl = Sword1; break;
                    case "Bow":
                        weaponControl = Bow1; break;
                    case "Mace":
                        weaponControl = Mace1; break;
                    case "RedPotion":
                        weaponControl = RedPotion1; break;
                    case "BluePotion":
                        weaponControl = BluePotion1; break;
                    case "Bomb":
                        weaponControl = Bomb1; break;
                    case "Shield":
                        weaponControl = Bomb1; break;
                }

                weaponControl.Visible = true;

                weaponControl.Location = weaponInRoom.Location;

                if (weaponInRoom.PickedUp)
                {
                    weaponControl.Visible = false;

                }
                else
                {
                    weaponControl.Visible = true;
                }

                if (game.CheckPlayerInventory("Sword"))
                {
                    Inventory1.Visible = true;

                }

                if (game.CheckPlayerInventory("Bow"))
                {
                    Inventory3.Visible = true;

                }
                //if (!game.PlayerPotionUsed) {
                if (game.CheckPlayerInventory("BluePotion"))
                {
                    Inventory2.Visible = true;

                }
                if (game.CheckPlayerInventory("RedPotion"))
                {
                    Inventory4.Visible = true;
                }


                if (game.CheckPlayerInventory("Mace"))
                {
                    Inventory5.Visible = true;

                }
                if (game.CheckPlayerInventory("Bomb"))
                {
                    Inventory6.Visible = true;

                }
                if (game.CheckPlayerInventory("Shield"))
                {
                    Inventory7.Visible = true;

                }
            }
            /*
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = Sword1; break;
                case "Bow":
                    weaponControl = Bow1; break;
                case "Mace":
                    weaponControl = Mace1; break;
                case "RedPotion":
                    weaponControl = RedPotion1; break;
                case "BluePotion":
                    weaponControl = BluePotion1; break;
                case "Bomb":
                    weaponControl = Bomb1; break;

            }
            

            weaponControl.Visible = true;

            weaponControl.Location = game.WeaponInRoom.Location;
            

            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;

            }
            else
            {
                weaponControl.Visible = true;
            }

            if (game.CheckPlayerInventory("Sword"))
            {
                Inventory1.Visible = true;

            }

            if (game.CheckPlayerInventory("Bow"))
            {
                Inventory3.Visible = true;

            }
            //if (!game.PlayerPotionUsed) {
                if (game.CheckPlayerInventory("BluePotion"))
                {
                    Inventory2.Visible = true;

                }
                if (game.CheckPlayerInventory("RedPotion"))
                {
                    Inventory4.Visible = true;
                }

            
            if (game.CheckPlayerInventory("Mace"))
            {
                Inventory5.Visible = true;

            }
            if (game.CheckPlayerInventory("Bomb"))
            {
                Inventory6.Visible = true;

            }
            */

            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You died");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level");
                game.NewLevel(random);
                UpdateCharacters();
            }

        }

        private void Inventory1_Click(object sender, EventArgs e)
        {
            
            Inventory1.BorderStyle = BorderStyle.FixedSingle;
            Inventory2.BorderStyle = BorderStyle.None;
            Inventory3.BorderStyle = BorderStyle.None;
            Inventory4.BorderStyle = BorderStyle.None;
            Inventory5.BorderStyle = BorderStyle.None;
            Inventory6.BorderStyle = BorderStyle.None;
            Inventory7.BorderStyle = BorderStyle.None;

            game.Equip("Sword");
            
        }

        private void Inventory3_Click(object sender, EventArgs e)
        {
            Inventory1.BorderStyle = BorderStyle.None;
            Inventory2.BorderStyle = BorderStyle.None;
            Inventory3.BorderStyle = BorderStyle.FixedSingle;
            Inventory4.BorderStyle = BorderStyle.None;
            Inventory5.BorderStyle = BorderStyle.None;
            Inventory6.BorderStyle = BorderStyle.None;
            Inventory7.BorderStyle = BorderStyle.None;

            game.Equip("Bow");

        }

        private void Inventory5_Click_1(object sender, EventArgs e)
        {
            Inventory1.BorderStyle = BorderStyle.None;
            Inventory2.BorderStyle = BorderStyle.None;
            Inventory3.BorderStyle = BorderStyle.None;
            Inventory4.BorderStyle = BorderStyle.None;
            Inventory5.BorderStyle = BorderStyle.FixedSingle;
            Inventory6.BorderStyle = BorderStyle.None;
            Inventory7.BorderStyle = BorderStyle.None;

            game.Equip("Mace");

        }

        private void Inventory4_Click(object sender, EventArgs e)
        {
            Inventory1.BorderStyle = BorderStyle.None;
            Inventory2.BorderStyle = BorderStyle.None;
            Inventory3.BorderStyle = BorderStyle.None;
            Inventory4.BorderStyle = BorderStyle.FixedSingle;
            Inventory5.BorderStyle = BorderStyle.None;
            Inventory6.BorderStyle = BorderStyle.None;
            Inventory7.BorderStyle = BorderStyle.None;

            game.Equip("RedPotion");

        }

        private void Inventory2_Click(object sender, EventArgs e)
        {
            Inventory1.BorderStyle = BorderStyle.None;
            Inventory2.BorderStyle = BorderStyle.FixedSingle;
            Inventory3.BorderStyle = BorderStyle.None;
            Inventory4.BorderStyle = BorderStyle.None;
            Inventory5.BorderStyle = BorderStyle.None;
            Inventory6.BorderStyle = BorderStyle.None;
            Inventory7.BorderStyle = BorderStyle.None;

            game.Equip("BluePotion");

        }

        private void Inventory6_Click(object sender, EventArgs e)
        {
            Inventory1.BorderStyle = BorderStyle.None;
            Inventory2.BorderStyle = BorderStyle.None;
            Inventory3.BorderStyle = BorderStyle.None;
            Inventory4.BorderStyle = BorderStyle.None;
            Inventory5.BorderStyle = BorderStyle.None;
            Inventory6.BorderStyle = BorderStyle.FixedSingle;
            Inventory7.BorderStyle = BorderStyle.None;


            game.Equip("Bomb");
        }

        private void Inventory7_Click(object sender, EventArgs e)
        {
            Inventory1.BorderStyle = BorderStyle.None;
            Inventory2.BorderStyle = BorderStyle.None;
            Inventory3.BorderStyle = BorderStyle.None;
            Inventory4.BorderStyle = BorderStyle.None;
            Inventory5.BorderStyle = BorderStyle.None;
            Inventory6.BorderStyle = BorderStyle.None;
            Inventory7.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
