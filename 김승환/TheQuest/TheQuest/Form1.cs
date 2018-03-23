using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            UpdateCharacters();
            KeyPreview = true;
        }

        public void UpdateCharacters()
        {
            DoubleBuffered = true;

            pictureBoxPlayer.Location = game.PlayerLocation;
            labelPlayerHP.Text = game.PlayerHitPoint.ToString();

            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShown = 0;

            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    pictureBoxBat.Location = enemy.Location;
                    labelBatHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghost)
                {
                    pictureBoxGhost.Location = enemy.Location;
                    labelGhostHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    pictureBoxGhoul.Location = enemy.Location;
                    labelGhoulHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShown++;
                    }
                }
            }

            if (showBat == false)
            {
                pictureBoxBat.Visible = false;
                labelBatHP.Visible = false;
            }
            else
            {
                pictureBoxBat.Visible = true;
                labelBatHP.Visible = true;
            }
            if (showGhost == false)
            {
                pictureBoxGhost.Visible = false;
                labelGhostHP.Visible = false;
            }
            else
            {
                pictureBoxGhost.Visible = true;
                labelGhostHP.Visible = true;
            }
            if (showGhoul == false)
            {
                pictureBoxGhoul.Visible = false;
                labelGhoulHP.Visible = false;
            }
            else
            {
                pictureBoxGhoul.Visible = true;
                labelGhoulHP.Visible = true;
            }

            pictureBoxSword.Visible = false;
            pictureBoxBow.Visible = false;
            pictureBoxMace.Visible = false;
            pictureBoxBluePotion.Visible = false;
            pictureBoxRedPotion.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = pictureBoxSword;
                    break;
                case "Bow":
                    weaponControl = pictureBoxBow;
                    break;
                case "Mace":
                    weaponControl = pictureBoxMace;
                    break;
                case "Blue Potion":
                    weaponControl = pictureBoxBluePotion;
                    break;
                case "Red Potion":
                    weaponControl = pictureBoxRedPotion;
                    break;
            }

            weaponControl.Visible = true;

            if (game.CheckPlayerInventory("Sword"))
            {
                pictureItemSword.Visible = true;
            }
            else
            {
                pictureItemSword.Visible = false;
            }
            if (game.CheckPlayerInventory("Bow"))
            {
                pictureItemBow.Visible = true;
            }
            else
            {
                pictureItemBow.Visible = false;
            }
            if (game.CheckPlayerInventory("Mace"))
            {
                pictureItemMace.Visible = true;
            }
            else
            {
                pictureItemMace.Visible = false;
            }
            if (game.CheckPlayerInventory("Blue Potion") && !game.Player.IsUsed("Blue Potion"))
            {
                pictureItemBP.Visible = true;
            }
            else
            {
                pictureItemBP.Visible = false;
            }
            if (game.CheckPlayerInventory("Red Potion") && !game.Player.IsUsed("Red Potion"))
            {
                pictureItemRP.Visible = true;
            }
            else
            {
                pictureItemRP.Visible = false;
            }

            weaponControl.Location = game.WeaponInRoom.Location;

            if(game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }

            if(game.PlayerHitPoint <= 0)
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

        private void buttonMoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Up, random);
            UpdateCharacters();
        }

        private void buttonMoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Left, random);
            UpdateCharacters();
        }

        private void buttonMoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Right, random);
            UpdateCharacters();
        }

        private void buttonMoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Mover.Direction.Down, random);
            UpdateCharacters();
        }

        private void buttonAttackUp_Click(object sender, EventArgs e)
        {
            game.Attack(Mover.Direction.Up, random);
            UpdateCharacters();
        }

        private void buttonAttackLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Mover.Direction.Left, random);
            UpdateCharacters();
        }

        private void buttonAttackRight_Click(object sender, EventArgs e)
        {
            game.Attack(Mover.Direction.Right, random);
            UpdateCharacters();
        }

        private void buttonAttackDown_Click(object sender, EventArgs e)
        {
            game.Attack(Mover.Direction.Down, random);
            UpdateCharacters();
        }

        private void pictureItemSword_Click(object sender, EventArgs e)
        {
            if(game.CheckPlayerInventory("Sword"))
            {
                game.Equip("Sword");
                buttonAttackUp.Text = "Up";
            }

            buttonAttackDown.Enabled = true;
            buttonAttackLeft.Enabled = true;
            buttonAttackRight.Enabled = true;

            pictureItemSword.BorderStyle = BorderStyle.Fixed3D;
            pictureItemBow.BorderStyle = BorderStyle.None;
            pictureItemMace.BorderStyle = BorderStyle.None;
            pictureItemBP.BorderStyle = BorderStyle.None;
            pictureItemRP.BorderStyle = BorderStyle.None;

        }

        private void pictureItemBow_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Bow"))
            {
                game.Equip("Bow");
                buttonAttackUp.Text = "Up";
            }

            buttonAttackDown.Enabled = true;
            buttonAttackLeft.Enabled = true;
            buttonAttackRight.Enabled = true;

            pictureItemSword.BorderStyle = BorderStyle.None;
            pictureItemBow.BorderStyle = BorderStyle.Fixed3D;
            pictureItemMace.BorderStyle = BorderStyle.None;
            pictureItemBP.BorderStyle = BorderStyle.None;
            pictureItemRP.BorderStyle = BorderStyle.None;
        }

        private void pictureItemMace_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Mace"))
            {
                game.Equip("Mace");
                buttonAttackUp.Text = "Up";
            }

            buttonAttackDown.Enabled = true;
            buttonAttackLeft.Enabled = true;
            buttonAttackRight.Enabled = true;

            pictureItemSword.BorderStyle = BorderStyle.None;
            pictureItemBow.BorderStyle = BorderStyle.None;
            pictureItemMace.BorderStyle = BorderStyle.Fixed3D;
            pictureItemBP.BorderStyle = BorderStyle.None;
            pictureItemRP.BorderStyle = BorderStyle.None;
        }

        private void pictureItemBP_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                game.Equip("Blue Potion");
                buttonAttackUp.Text = "Drink";
            }

            buttonAttackDown.Enabled = false;
            buttonAttackLeft.Enabled = false;
            buttonAttackRight.Enabled = false;

            pictureItemSword.BorderStyle = BorderStyle.None;
            pictureItemBow.BorderStyle = BorderStyle.None;
            pictureItemMace.BorderStyle = BorderStyle.None;
            pictureItemBP.BorderStyle = BorderStyle.Fixed3D;
            pictureItemRP.BorderStyle = BorderStyle.None;
        }

        private void pictureItemRP_Click(object sender, EventArgs e)
        {
            if (game.CheckPlayerInventory("Red Potion"))
            {
                game.Equip("Red Potion");
                buttonAttackUp.Text = "Drink";
            }

            buttonAttackDown.Enabled = false;
            buttonAttackLeft.Enabled = false;
            buttonAttackRight.Enabled = false;

            pictureItemSword.BorderStyle = BorderStyle.None;
            pictureItemBow.BorderStyle = BorderStyle.None;
            pictureItemMace.BorderStyle = BorderStyle.None;
            pictureItemBP.BorderStyle = BorderStyle.None;
            pictureItemRP.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.NumPad8)
            {
                buttonMoveUp_Click(sender, e);
            }
            if (e.KeyCode == Keys.NumPad4)
            {
                buttonMoveLeft_Click(sender, e);
            }
            if (e.KeyCode == Keys.NumPad6)
            {
                buttonMoveRight_Click(sender, e);
            }
            if (e.KeyCode == Keys.NumPad5)
            {
                buttonMoveDown_Click(sender, e);
            }
            if (e.KeyCode == Keys.W)
            {
                buttonAttackUp_Click(sender, e);
            }
            if (e.KeyCode == Keys.A)
            {
                buttonAttackLeft_Click(sender, e);
            }
            if (e.KeyCode == Keys.D)
            {
                buttonAttackRight_Click(sender, e);
            }
            if (e.KeyCode == Keys.S)
            {
                buttonAttackDown_Click(sender, e);
            }
            if (e.KeyCode == Keys.D1)
            {
                if (pictureItemSword.Visible == true)
                    pictureItemSword_Click(sender, e);
            }
            if (e.KeyCode == Keys.D2)
            {
                if (pictureItemBow.Visible == true)
                    pictureItemBow_Click(sender, e);
            }
            if (e.KeyCode == Keys.D3)
            {
                if (pictureItemMace.Visible == true)
                    pictureItemMace_Click(sender, e);
            }
            if (e.KeyCode == Keys.D4)
            {
                if(pictureItemBP.Visible == true)
                pictureItemBP_Click(sender, e);
            }
            if (e.KeyCode == Keys.D5)
            {
                if (pictureItemRP.Visible == true)
                    pictureItemRP_Click(sender, e);
            }
        }
    }
}
