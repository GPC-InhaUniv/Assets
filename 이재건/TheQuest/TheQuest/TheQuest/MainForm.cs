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

    public partial class MainForm : Form
    {
        Rectangle gameRectSize = new Rectangle(78, 57, 420, 155);
        private Random random = new Random();
        private Game gameManager;



        public MainForm()
        {
            InitializeComponent();
            gameManager = new Game(gameRectSize);
            gameManager.NextStage(random);
            gameManager.HitImage = PopImage;



        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            SetImages();
            UpdateCharaters();
        }

        private void UpdateCharaters()
        {
            bool checkClear = false;

            playerImage.Location = gameManager.PlayerLocation;

            PlayerHpLabel.Text = gameManager.PlayerHitPoints.ToString();

            for (int i = 0; i < gameManager.Enemies.Count; i++)
            {
                if (gameManager.Enemies[i].GetType() == typeof(Bat))
                {
                    BatHpLabel.Text = gameManager.Enemies[i].Hitpoints.ToString();
                    BatImage1.Location = gameManager.Enemies[i].Location;

                    if (gameManager.Enemies[i].Dead)
                        BatImage1.Visible = false;
                }
                else if (gameManager.Enemies[i].GetType() == typeof(Ghost))
                {
                    GhostHpLabel.Text = gameManager.Enemies[i].Hitpoints.ToString();
                    GhostImage1.Location = gameManager.Enemies[i].Location;
                    if (gameManager.Enemies[i].Dead)
                       GhostImage1.Visible = false;
                }
                else if (gameManager.Enemies[i].GetType() == typeof(Ghoul))
                {
                    GhoulHpLabel.Text = gameManager.Enemies[i].Hitpoints.ToString();
                    GhoulImage1.Location = gameManager.Enemies[i].Location;
                    if (gameManager.Enemies[i].Dead)
                        GhoulImage1.Visible = false;
                }
                
            
                
                
            }

            if (!(gameManager.WeaponInRoom.PickedUp))
            {
                if (gameManager.WeaponInRoom.NearbyObject(gameManager.PlayerLocation, 30))  //can pickup distance 30;
                {
                    gameManager.WeaponInRoom.WeaponPickup(gameManager.WeaponInRoom.Name);


                    if (gameManager.WeaponInRoom.Name == "mace")
                    {
                        WeaponImage3.Location = gameManager.WeaponInRoom.Location;
                        gameManager.AddWeaponToInventory(gameManager.WeaponInRoom);

                    }
                    else if (gameManager.WeaponInRoom.Name == "sword")
                    {
                        WeaponImage1.Location = gameManager.WeaponInRoom.Location;
                        gameManager.AddWeaponToInventory(gameManager.WeaponInRoom);

                    }
                    else if (gameManager.WeaponInRoom.Name == "bow")
                    {
                        WeaponImage2.Location = gameManager.WeaponInRoom.Location;
                        gameManager.AddWeaponToInventory(gameManager.WeaponInRoom);

                    }
                
                }
            }

            if (!(gameManager.portion.PickedUp))
            {
                if (gameManager.portion.NearbyObject(gameManager.PlayerLocation, 30))  //can pickup distance 30;
                {
                    gameManager.portion.WeaponPickup(gameManager.portion.Name);

                    if (gameManager.portion.Name == "bluePortion")
                    {
                        PostionImage1.Location = gameManager.portion.Location;
                        gameManager.AddWeaponToInventory(gameManager.portion);
                    }
                }
            }


                if (gameManager.GameOver())
            {
                gameManager.ReTryGame(random);
             
                PopImage.Visible = false;
                SetImages();
                UpdateCharaters();
            }

          
            for(int i=0;i<gameManager.Enemies.Count;i++)
            {
                if (gameManager.Enemies[i].Hitpoints <= 0)
                    checkClear = true;
                else
                {
                    checkClear = false;
                    break;
                }
            }

            if(checkClear)
            {
                gameManager.NextStage(random);
                SetImages();
                UpdateCharaters();

            }

          
        }

        private void MoveUp_Click(object sender, EventArgs e)
        {
            gameManager.MoveObject(Direction.Up, random);
            UpdateCharaters();
        }

        private void MoveRight_Click(object sender, EventArgs e)
        {
            gameManager.MoveObject(Direction.Right, random);
            UpdateCharaters();
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            gameManager.MoveObject(Direction.Left, random);
            UpdateCharaters();
        }

        private void MoveDown_Click(object sender, EventArgs e)
        {
            gameManager.MoveObject(Direction.Down, random);
            UpdateCharaters();
        }

        private void PlayerHpTextBox_TextChanged(object sender, EventArgs e)
        {
            //do not use
        }

        private void SetImages()
        {
            if (playerImage.Image == null)
                playerImage.Load(@"image\player.png");

            if (PopImage.Image == null)
                gameManager.HitImage.Load(@"image\pop.png");

            for (int i = 0; i < gameManager.Enemies.Count; i++)
            {
                if (gameManager.Enemies[i].GetType() == typeof(Bat))
                {
                    BatImage1.Image = gameManager.EnemyImageList[0];
                    BatImage1.Visible = true;
                }
                else if (gameManager.Enemies[i].GetType() == typeof(Ghost))
                {
                    GhostImage1.Image = gameManager.EnemyImageList[1];
                    GhostImage1.Visible = true;
                }
                else if (gameManager.Enemies[i].GetType() == typeof(Ghoul))
                {
                    GhoulImage1.Image = gameManager.EnemyImageList[2];
                    GhoulImage1.Visible = true;
                }


            }


            if (gameManager.WeaponInRoom != null)
            {
                if (gameManager.WeaponInRoom.Name == "sword")
                {
                    WeaponImage1.Location = gameManager.WeaponInRoom.Location;
                    WeaponImage1.Image = gameManager.WeaponImageList[0];
                    WeaponImage1.Visible = true;
                }
                else if (gameManager.WeaponInRoom.Name == "bow")
                {
                    WeaponImage2.Location = gameManager.WeaponInRoom.Location;
                    WeaponImage2.Image = gameManager.WeaponImageList[1];
                    WeaponImage2.Visible = true;
                }
                else if (gameManager.WeaponInRoom.Name == "mace")
                {
                    WeaponImage3.Location = gameManager.WeaponInRoom.Location;
                    WeaponImage3.Image = gameManager.WeaponImageList[2];
                    WeaponImage3.Visible = true;
                }
             

            }


            if (gameManager.portion != null)
            {
                if (gameManager.portion.Name == "bluePortion")
                {
                    PostionImage1.Location = gameManager.portion.Location;
                    PostionImage1.Image = gameManager.WeaponImageList[3];
                    PostionImage1.Visible = true;
                }

            }
            }

        private void AttackUp_Click(object sender, EventArgs e)
        {
            gameManager.Attack(Direction.Up, random);
            UpdateCharaters();
        }

        private void AttackLeft_Click(object sender, EventArgs e)
        {
            gameManager.Attack(Direction.Left, random);
            UpdateCharaters();
        }

        private void AttackRight_Click(object sender, EventArgs e)
        {
            gameManager.Attack(Direction.Right, random);
            UpdateCharaters();
        }

        private void AttackDown_Click(object sender, EventArgs e)
        {
            gameManager.Attack(Direction.Down, random);
            UpdateCharaters();
        }



        private void WeaponImage1_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory("sword"))
            {
                WeaponImage1.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage2.BorderStyle = BorderStyle.None;
                WeaponImage3.BorderStyle = BorderStyle.None;

                gameManager.EquipWeapon("sword");
                playerImage.Image = gameManager.PlayerImageList[0];

            }
        }

        private void WeaponImage2_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory("bow"))
            {
                WeaponImage2.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage3.BorderStyle = BorderStyle.None;

                WeaponImage1.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon("bow");
                playerImage.Image = gameManager.PlayerImageList[1];
            }
        }

        private void BatImage1_Click(object sender, EventArgs e)
        {
            

        }

        private void PostionImage1_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory("bluePortion"))
                {
                PostionImage1.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage1.BorderStyle = BorderStyle.None;
                WeaponImage3.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon("bluePortion");
                playerImage.Image = gameManager.PlayerImageList[2];
            }
        }

        private void WeaponImage3_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory("mace"))
            {
                WeaponImage3.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage1.BorderStyle = BorderStyle.None;
                WeaponImage3.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon("mace");
                playerImage.Image = gameManager.PlayerImageList[2];
            }
        }
    }
}
