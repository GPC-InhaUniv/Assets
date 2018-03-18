using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticeQuest
{
   
    public partial class Form1 : Form
    {
        private Game game;
        private Point location;
        private Random random = new Random();

        
        

        public Form1()
        {
            InitializeComponent();

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void InventorySword_Click(object sender, EventArgs e)
        {
            Sword sword = new Sword(game,location);
            if (game.CheckPlayerInventory(sword.Name))
                game.Equip(sword.Name);
            InventorySword.BorderStyle = BorderStyle.FixedSingle;
            InventoryMace.BorderStyle = BorderStyle.None;
            InventoryBow.BorderStyle = BorderStyle.None;
            InventoryRedPotion.BorderStyle = BorderStyle.None;
            InventoryBluePotion.BorderStyle = BorderStyle.None;
        }

        private void InventoryBow_Click(object sender, EventArgs e)
        {
            Bow bow = new Bow(game, location);
            if (game.CheckPlayerInventory(bow.Name))
                game.Equip(bow.Name);
            InventoryBow.BorderStyle = BorderStyle.FixedSingle;
            InventoryMace.BorderStyle = BorderStyle.None;
            InventorySword.BorderStyle = BorderStyle.None;
            InventoryRedPotion.BorderStyle = BorderStyle.None;
            InventoryBluePotion.BorderStyle = BorderStyle.None;
        }

        private void InventoryMace_Click(object sender, EventArgs e)
        {
            Mace mace = new Mace(game, location);
            if (game.CheckPlayerInventory(mace.Name))
                game.Equip(mace.Name);
            InventoryMace.BorderStyle = BorderStyle.FixedSingle;
            InventorySword.BorderStyle = BorderStyle.None;
            InventoryBow.BorderStyle = BorderStyle.None;
            InventoryRedPotion.BorderStyle = BorderStyle.None;
            InventoryBluePotion.BorderStyle = BorderStyle.None;
        }

        public void UpdateCharacters()
        {
            RoomPlayer.Location = game.PlayerLocation;
            labPlayerHp.Text = game.PlayerHitPoints.ToString();

            
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            int enemiesShowm = 0;

            RoomBat.Visible = false;
            RoomGhost.Visible = false;
            RoomGhoul.Visible = false;

            foreach (Enemy enemy in game.Enemies)
            {
                RoomBat.Visible = true;
                if (enemy is Bat)
                {
                    RoomBat.Location = enemy.Location;
                    labBatHp.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showBat = true;
                        enemiesShowm++;
                    }
                }
                if (showBat == false)
                {
                    showBat = false;
                    RoomBat.Visible = showBat;
                    labBatHp.Text = "0";
                }
            }


            foreach (Enemy enemy in game.Enemies)
            {
                RoomGhost.Visible = true;
                if (enemy is Ghost)
                {
                    RoomGhost.Location = enemy.Location;
                    labGhostHp.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhost = true;
                        enemiesShowm++;
                    }
                }
                if (showGhost == false)
                {
                    showGhost = false;
                    RoomGhost.Visible = showGhost;
                    labGhostHp.Text = "0";
                }
            }


            foreach (Enemy enemy in game.Enemies)
            {
                RoomGhoul.Visible = true;
                if (enemy is Ghoul)
                {
                    RoomGhoul.Location = enemy.Location;
                    labGhoulHp.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        showGhoul = true;
                        enemiesShowm++;
                    }
                }
                if (showGhoul == false)
                {
                    showGhoul = false;
                    RoomGhoul.Visible = showGhoul;
                    labGhoulHp.Text = "0";
                }
            }



            RoomSword.Visible = false;
            RoomBow.Visible = false;
            RoomRedPotion.Visible = false;
            RoomBluePotion.Visible = false;
            RoomMace.Visible = false;

            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = RoomSword; break;
                case "Bow":
                    weaponControl = RoomBow; break;
                case "Mace":
                    weaponControl = RoomMace; break;
                case "Red Potin":
                    weaponControl = RoomRedPotion; break;
                case "Blue Potion":
                    weaponControl = RoomBluePotion; break;
                default:
                    break;
            }
             weaponControl.Visible = true;

            InventoryBluePotion.Visible = false;
            InventoryBow.Visible = false;
            InventoryMace.Visible = false;
            InventorySword.Visible = false;
            InventoryRedPotion.Visible = false;


            if (game.CheckPlayerInventory("Sword"))
            {
                InventorySword.Visible = true;
            }
            if (game.CheckPlayerInventory("Bow"))
            {
                InventoryBow.Visible = true;
            }
            if (game.CheckPlayerInventory("Mace"))
            {
                InventoryMace.Visible = true;
            }
            if (game.CheckPlayerInventory("Red Potion"))
            {
                InventoryRedPotion.Visible = true;
            }
            if (game.CheckPlayerInventory("Blue Potion"))
            {
                InventoryBluePotion.Visible = true;
            }



            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
            {
                weaponControl.Visible = true;
            }
            if(game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("당신의 캐릭터는 죽었습니다.");
                Application.Exit();
            }
            if(enemiesShowm < 1)
            {
                MessageBox.Show("당신은 이 레벨에 있는 몬스터들을 다 물리쳤다.");
                game.NewLevel(random);
                UpdateCharacters();
            }
        }



        private void InventoryBluePotion_Click(object sender, EventArgs e)
        {
            BluePotion bluePotion = new BluePotion(game, location);
            InventoryBluePotion.BorderStyle = BorderStyle.FixedSingle;
            bluePotion.Attack(Direction.NONE, random);
        }
        private void InventoryRedPotion_Click(object sender, EventArgs e)
        {
            RedPotion redPotion = new RedPotion(game, location);
            InventoryRedPotion.BorderStyle = BorderStyle.FixedSingle;
            redPotion.Attack(Direction.NONE, random);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(random);
            UpdateCharacters();
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Up, random);
            UpdateCharacters();

        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Down, random);
            UpdateCharacters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Left, random);
            UpdateCharacters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            game.Move(Direction.Right, random);
            UpdateCharacters();
        }

        private void AtkUp_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            if (game.CheckPlayerInventory("Red Potion") || game.CheckPlayerInventory("Blue Potion"))
                AtkUp.Text = "Drink";
            UpdateCharacters();
        }

        private void AtkDown_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            if (game.CheckPlayerInventory("Red Potion") || game.CheckPlayerInventory("Blue Potion"))
                AtkUp.Text = "Drink";
            UpdateCharacters();
        }

        private void AtkLeft_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            if (game.CheckPlayerInventory("Red Potion") || game.CheckPlayerInventory("Blue Potion"))
                AtkUp.Text = "Drink";
            UpdateCharacters();
        }

        private void AtkRight_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            if (game.CheckPlayerInventory("Red Potion") || game.CheckPlayerInventory("Blue Potion"))
                AtkUp.Text = "Drink";
 
            UpdateCharacters();
        }
    }
}
