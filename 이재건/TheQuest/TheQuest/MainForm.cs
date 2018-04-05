using System;
using System.Drawing;
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
            this.SetStyle(ControlStyles.DoubleBuffer, true);
            this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            gameManager = new Game(gameRectSize);
            gameManager.NextStage(random);
            gameManager.HitImage = PopImage;



        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            SetImages();
            UpdateCharaters();
        }

        private void UpdateLabels()
        {
            PlayerHpLabel.Text = gameManager.PlayerHitPoints.ToString();

            for (int i = 0; i < gameManager.Enemies.Count; i++)
            {
                if (gameManager.Enemies[i] is Bat)
                {
                    BatHpLabel.Text = gameManager.Enemies[i].Hitpoints.ToString();

                    BatImage1.Location = gameManager.Enemies[i].Location;

                    if (gameManager.Enemies[i].Dead)
                        BatImage1.Visible = false;
                }

                else if (gameManager.Enemies[i] is Ghost)
                {
                    GhostHpLabel.Text = gameManager.Enemies[i].Hitpoints.ToString();

                    GhostImage1.Location = gameManager.Enemies[i].Location;

                    if (gameManager.Enemies[i].Dead)
                        GhostImage1.Visible = false;
                }

                else if (gameManager.Enemies[i] is Ghoul)
                {
                    GhoulHpLabel.Text = gameManager.Enemies[i].Hitpoints.ToString();

                    GhoulImage1.Location = gameManager.Enemies[i].Location;

                    if (gameManager.Enemies[i].Dead)
                        GhoulImage1.Visible = false;
                }


            }
        }

        private void UpdateLocation()
        {
            playerImage.Location = gameManager.PlayerLocation;

            if (gameManager.WeaponInRoom != null)
            {
                if (!(gameManager.WeaponInRoom.PickedUp))
                {
                    if (gameManager.WeaponInRoom.NearbyObject(gameManager.PlayerLocation, 30))  //can pickup distance 30;
                    {
                        gameManager.WeaponInRoom.WeaponPickup(gameManager.WeaponInRoom);

                        if (gameManager.WeaponInRoom is Mace)
                        {
                            WeaponImage3.Location = gameManager.WeaponInRoom.Location;
                            gameManager.AddWeaponToInventory(gameManager.WeaponInRoom);

                        }

                        else if (gameManager.WeaponInRoom is Sword)
                        {
                            WeaponImage1.Location = gameManager.WeaponInRoom.Location;
                            gameManager.AddWeaponToInventory(gameManager.WeaponInRoom);

                        }

                        else if (gameManager.WeaponInRoom is Bow)
                        {
                            WeaponImage2.Location = gameManager.WeaponInRoom.Location;
                            gameManager.AddWeaponToInventory(gameManager.WeaponInRoom);

                        }

                    }
                }
            }

            for (int i = 0; i < gameManager.portion.Length; i++)
            {
                if (gameManager.portion[i] != null)
                {
                    if (!(gameManager.portion[i].PickedUp))
                    {
                        if (gameManager.portion[i].NearbyObject(gameManager.PlayerLocation, 30))  //can pickup distance 30;
                        {
                            gameManager.portion[i].WeaponPickup(gameManager.portion[i]);

                            if (gameManager.portion[i] is BluePotion)
                            {
                                PostionImage1.Location = gameManager.portion[i].Location;
                                gameManager.AddWeaponToInventory(gameManager.portion[i]);
                            }

                            else if (gameManager.portion[i] is RedPotion)
                            {
                                PostionImage2.Location = gameManager.portion[i].Location;
                                gameManager.AddWeaponToInventory(gameManager.portion[i]);
                            }

                        }
                    }

                    else if (gameManager.portion[i].UsePostion)
                    {
                        if (i == 0)
                            PostionImage1.Visible = false;
                        else if (i == 1)
                            PostionImage2.Visible = false;

                    }

                }
            }
        }

        private void UpdateCharaters()
        {
            bool checkClear = false;

            UpdateLabels();
            UpdateLocation();

            if (gameManager.GameOver())
            {
                gameManager.ReTryGame(random);

                PopImage.Visible = false;
                SetImages();
                UpdateCharaters();
            }

            for (int i = 0; i < gameManager.Enemies.Count; i++)
            {
                if (gameManager.Enemies[i].Hitpoints <= 0)
                    checkClear = true;
                else
                {
                    checkClear = false;
                    break;
                }
            }

            if (checkClear)
            {
                gameManager.NextStage(random);
                if (gameManager.Level >= 4)
                {
                    MessageBox.Show("던전 클리어!!");
                    this.Close();
                }
                else
                {
                    SetImages();
                    UpdateCharaters();
                }

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
                if (gameManager.WeaponInRoom is Sword)
                {
                    WeaponImage1.Location = gameManager.WeaponInRoom.Location;
                    WeaponImage1.Image = gameManager.WeaponImageList[0];
                    WeaponImage1.Visible = true;
                }
                else if (gameManager.WeaponInRoom is Bow)
                {
                    WeaponImage2.Location = gameManager.WeaponInRoom.Location;
                    WeaponImage2.Image = gameManager.WeaponImageList[1];
                    WeaponImage2.Visible = true;
                }
                else if (gameManager.WeaponInRoom is Mace)
                {
                    WeaponImage3.Location = gameManager.WeaponInRoom.Location;
                    WeaponImage3.Image = gameManager.WeaponImageList[2];
                    WeaponImage3.Visible = true;
                }
            }

            for (int i = 0; i < gameManager.portion.Length; i++)
            {
                if (gameManager.portion[i] != null)
                {
                    if (gameManager.portion[i] is BluePotion)
                    {
                        PostionImage1.Location = gameManager.portion[i].Location;
                        PostionImage1.Image = gameManager.WeaponImageList[3];
                        PostionImage1.Visible = true;
                    }
                    else if (gameManager.portion[i] is RedPotion)
                    {
                        PostionImage2.Location = gameManager.portion[i].Location;
                        PostionImage2.Image = gameManager.WeaponImageList[4];
                        PostionImage2.Visible = true;
                    }

                }
            }
            CheckUnVisible();

        }

        private void CheckUnVisible()
        {

            if (gameManager.Level == 2)
            {
                if (!(gameManager.CheckPlayerInventory(WeaponList.Sword.ToString())))
                {
                    WeaponImage1.Visible = false;

                }
                if (!(gameManager.CheckPlayerInventory(PortionList.bluePortion.ToString())))
                {
                    PostionImage1.Visible = false;
                }
            }

            if (gameManager.Level == 3)
            {
                if (!(gameManager.CheckPlayerInventory(WeaponList.Bow.ToString())))
                {
                    WeaponImage2.Visible = false;

                }
                if (!(gameManager.CheckPlayerInventory(PortionList.redPortion.ToString())))
                {
                    PostionImage2.Visible = false;
                }
            }
            PopImage.Visible = false;

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
            if (gameManager.CheckPlayerInventory(WeaponList.Sword.ToString()))
            {
                WeaponImage1.BorderStyle = BorderStyle.FixedSingle;

                PostionImage1.BorderStyle = BorderStyle.None;
                WeaponImage2.BorderStyle = BorderStyle.None;
                WeaponImage3.BorderStyle = BorderStyle.None;

                gameManager.EquipWeapon(new Sword(gameManager, new Point(0, 0)));
                playerImage.Image = gameManager.PlayerImageList[0];

            }
        }

        private void WeaponImage2_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory(WeaponList.Bow.ToString()))
            {
                WeaponImage2.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage3.BorderStyle = BorderStyle.None;
                PostionImage1.BorderStyle = BorderStyle.None;
                WeaponImage1.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon(new Bow(gameManager, new Point(0, 0)));
                playerImage.Image = gameManager.PlayerImageList[1];
            }
        }

        private void BatImage1_Click(object sender, EventArgs e)
        {


        }

        private void PostionImage1_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory(PortionList.bluePortion.ToString()))
            {
                PostionImage1.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage2.BorderStyle = BorderStyle.None;
                WeaponImage1.BorderStyle = BorderStyle.None;
                WeaponImage3.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon(new BluePotion(gameManager, new Point(0, 0)));
                playerImage.Image = gameManager.PlayerImageList[3];
            }
        }

        private void WeaponImage3_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory(WeaponList.Mace.ToString()))
            {
                WeaponImage3.BorderStyle = BorderStyle.FixedSingle;

                PostionImage1.BorderStyle = BorderStyle.None;
                WeaponImage1.BorderStyle = BorderStyle.None;
                WeaponImage2.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon(new Mace(gameManager, new Point(0, 0)));
                playerImage.Image = gameManager.PlayerImageList[2];
            }
        }

        private void PostionImage2_Click(object sender, EventArgs e)
        {
            if (gameManager.CheckPlayerInventory(PortionList.redPortion.ToString()))
            {
                PostionImage2.BorderStyle = BorderStyle.FixedSingle;

                WeaponImage2.BorderStyle = BorderStyle.None;
                WeaponImage1.BorderStyle = BorderStyle.None;
                WeaponImage3.BorderStyle = BorderStyle.None;
                PostionImage1.BorderStyle = BorderStyle.None;
                gameManager.EquipWeapon(new RedPotion(gameManager, new Point(0, 0)));
                playerImage.Image = gameManager.PlayerImageList[3];
            }
        }
    }
}
