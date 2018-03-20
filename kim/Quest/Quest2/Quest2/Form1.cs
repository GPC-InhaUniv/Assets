using System;
using System.Drawing;
using System.Windows.Forms;

namespace Quest2
{
    public enum Direction
    {
        Up = 0,
        Down = 2,
        Left = 3,
        Right = 1,
        Stop = 4,

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
            game.Move(Direction.Up, random);
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
            random = new Random();
            game.NewLevel(random);
            UpdateCharacter();         

        }

        public void UpdateCharacter()
        {
            Player_Pic.Location = game.PlayerLocation;
            PlayerHP.Text = game.PlayerHitPoints.ToString();
            ImageInvisble();
            EnemyCheck();
            InventoryCheck();
            PickUpItem();
            BackGround.Refresh();
           
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("게임 오버!");
                Application.Exit();
            }
        }

        private void ImageInvisble()
        {
            //Enemy
            Bat_Pic.Visible = false;
            Ghost_Pic.Visible = false;
            Ghoul_Pic.Visible = false;
            Skeleton_Pic.Visible = false;

            //DropItem
            Sword_Drop_Pic.Visible = false;
            Mace_Drop_Pic.Visible = false;
            Bow_Drop_Pic.Visible = false;

            BluePotion_Drop_Pic.Visible = false;
            RedPotion_Drop_Pic.Visible = false;

            //Inventory
            Sword_Inven_Pic.Visible = false;
            Mace_Inven_Pic.Visible = false;
            Bow_Inven_Pic.Visible = false;

            RedPotion_Inven_Pic.Visible = false;
            BluePotion_Inven_Pic.Visible = false;
        }

        private void EnemyCheck()
        {
            int enemiesShown = 0;
            foreach (Enemy enemy in game.Enemies)
            {
                if (enemy is Bat)
                {
                    Bat_Pic.Location = enemy.Location;
                    BatHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Bat_Pic.Visible = true;
                        enemiesShown++;
                    }

                }
                if (enemy is Ghost)
                {
                    Ghost_Pic.Location = enemy.Location;
                    GhostHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Ghost_Pic.Visible = true;
                        enemiesShown++;
                    }
                }
                if (enemy is Ghoul)
                {
                    Ghoul_Pic.Location = enemy.Location;
                    GhoulHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Ghoul_Pic.Visible = true;
                        enemiesShown++;
                    }
                }
                if (enemy is SkeletonMage)
                {
                    Skeleton_Pic.Location = enemy.Location;
                    BossHP.Text = enemy.HitPoints.ToString();
                    if (enemy.HitPoints > 0)
                    {
                        Skeleton_Pic.Visible = true;
                        enemiesShown++;
                    }
                }

            }
            if (enemiesShown == 0)
            {
                game.NewLevel(random);
                UpdateCharacter();
            }
        }

        private void InventoryCheck()
        {
            foreach (string weapon in game.PlayerWeapons)
            {
                if (weapon.Equals("Sword"))
                {
                    Sword_Inven_Pic.Visible = true;

                }
                if (weapon.Equals("Bow"))
                {
                    Bow_Inven_Pic.Visible = true;
                }

                if (weapon.Equals("Mace"))
                {
                    Mace_Inven_Pic.Visible = true;
                }

                if (weapon.Equals("RedPotion"))
                {
                    RedPotion_Inven_Pic.Visible = true;
                }
                if (weapon.Equals("BluePotion"))
                {
                    BluePotion_Inven_Pic.Visible = true;
                }
            }

        }

        private void PickUpItem()
        {
            Control weaponControl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = Sword_Drop_Pic;
                    break;
                case "Bow":
                    weaponControl = Bow_Drop_Pic;
                    break;
                case "Mace":
                    weaponControl = Mace_Drop_Pic;
                    break;
                case "RedPotion":
                    weaponControl = RedPotion_Drop_Pic;
                    break;
                case "BluePotion":
                    weaponControl = BluePotion_Drop_Pic;
                    break;

            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickedUp)
            {
                weaponControl.Visible = false;
            }
            else
                weaponControl.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Up, random);
            UpdateCharacter();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Left, random);
            UpdateCharacter();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Right, random);
            UpdateCharacter();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.Down, random);
            UpdateCharacter();
        }

        private void Sword_Inven_Pic_Click(object sender, EventArgs e)
        {
            game.Equip("Sword");
            imageBorderStyle();
            Sword_Inven_Pic.BorderStyle = BorderStyle.Fixed3D;

        }

        private void Inven_RedPotion_Pic_Click(object sender, EventArgs e)
        {
            game.Equip("RedPotion");
            imageBorderStyle();
            RedPotion_Inven_Pic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Mace_Inven_Pic_Click(object sender, EventArgs e)
        {
            game.Equip("Mace");
            imageBorderStyle();
            Mace_Inven_Pic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void Bow_Inven_Pic_Click(object sender, EventArgs e)
        {
            game.Equip("Bow");
            imageBorderStyle();
            Bow_Inven_Pic.BorderStyle = BorderStyle.Fixed3D;

        }

        private void BluePotion_Inven_Pic_Click(object sender, EventArgs e)
        {
            game.Equip("BluePotion");
            imageBorderStyle();
            BluePotion_Inven_Pic.BorderStyle = BorderStyle.Fixed3D;
        }

        private void imageBorderStyle()
        {
            Sword_Inven_Pic.BorderStyle = BorderStyle.None;
            Bow_Inven_Pic.BorderStyle = BorderStyle.None;
            Mace_Inven_Pic.BorderStyle = BorderStyle.None;
            RedPotion_Inven_Pic.BorderStyle = BorderStyle.None;
            BluePotion_Inven_Pic.BorderStyle = BorderStyle.None;
        }
    }
}
