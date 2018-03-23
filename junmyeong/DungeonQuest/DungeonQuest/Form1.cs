using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DungeonQuest
{
    public partial class Form1 : Form
    {
        Game game;
        Rectangle boundaries;
        List<Minion> minionList;
        Point playerStartLocation;
        public Form1()
        {
            InitializeComponent();
            playerStartLocation = playerPictureBox.Location;
            boundaries = new Rectangle(116, 83, 640, 250);
            game = new Game(boundaries, playerPictureBox.Location);
            minionList = game.StageSet();
            newMapSet();
        }
        
        private void newMapSet()
        {
            playerHpLabel.Text = game.PlayerHpPoint.ToString();
            for (int i = 0; i < minionList.Count; i++)
            {
                if (minionList[i].Name == "MeleeMinion")
                {
                    meleeMinionPictureBox.Visible = true;
                    meleeMinionLabel.Visible = true;
                    meleeMinionHpLabel.Visible = true;
                    meleeMinionHpLabel.Text = minionList[i].MinionHpPoint.ToString();
                    meleeMinionPictureBox.Location = minionList[i].Location;
                }
                else if (minionList[i].Name == "CasterMinion")
                {
                    casterMinionPictureBox.Visible = true;
                    casterMinionLabel.Visible = true;
                    casterMinionHpLabel.Visible = true;
                    casterMinionHpLabel.Text = minionList[i].MinionHpPoint.ToString();
                    casterMinionPictureBox.Location = minionList[i].Location;
                }
                else
                {
                    siegeMinionPictureBox.Visible = true;
                    siegeMinionLabel.Visible = true;
                    siegeMinionHpLabel.Visible = true;
                    siegeMinionHpLabel.Text = minionList[i].MinionHpPoint.ToString();
                    siegeMinionPictureBox.Location = minionList[i].Location;
                }
            }
            WeaponPictureBox();
        }

        private void moveUpButton_Click(object sender, EventArgs e)
        {
            progressTextBox.Text = "";
            game.Move(Direction.위쪽);
            UpdateGame();
        }

        private void moveLeftButton_Click(object sender, EventArgs e)
        {
            progressTextBox.Text = "";
            game.Move(Direction.왼쪽);
            UpdateGame();
        }

        private void moveRightButton_Click(object sender, EventArgs e)
        {
            progressTextBox.Text = "";
            game.Move(Direction.오른쪽);
            UpdateGame();
        }

        private void moveDownButton_Click(object sender, EventArgs e)
        {
            progressTextBox.Text = "";
            game.Move(Direction.아래쪽);
            UpdateGame();
        }

        private int LocationUpdate()
        {
            int minionNumber = 0;
            playerPictureBox.Location = game.PlayerLocation;
            progressTextBox.Text += game.PlayerText + Environment.NewLine;
            for (int i = 0; i < minionList.Count; i++)
            {
                if (minionList[i].Name == "MeleeMinion")
                {
                    meleeMinionPictureBox.Visible = true;
                    meleeMinionLabel.Visible = true;
                    meleeMinionHpLabel.Visible = true;
                    meleeMinionHpLabel.Text = minionList[i].MinionHpPoint.ToString();
                    progressTextBox.Text += minionList[i].ToString() + Environment.NewLine;
                    meleeMinionPictureBox.Location = minionList[i].Location;
                    minionNumber++;
                }
                else if (minionList[i].Name == "CasterMinion")
                {
                    casterMinionPictureBox.Visible = true;
                    casterMinionLabel.Visible = true;
                    casterMinionHpLabel.Visible = true;
                    casterMinionHpLabel.Text = minionList[i].MinionHpPoint.ToString();
                    progressTextBox.Text += minionList[i].ToString() + Environment.NewLine;
                    casterMinionPictureBox.Location = minionList[i].Location;
                    minionNumber++;
                }
                else
                {
                    siegeMinionPictureBox.Visible = true;
                    siegeMinionLabel.Visible = true;
                    siegeMinionHpLabel.Visible = true;
                    siegeMinionHpLabel.Text = minionList[i].MinionHpPoint.ToString();
                    progressTextBox.Text += minionList[i].ToString() + Environment.NewLine;
                    siegeMinionPictureBox.Location = minionList[i].Location;
                    minionNumber++;
                }
            }
            return minionNumber;
        }

        private void UpdateGame()
        {
            int minionNumber;
            if (game.PlayerHpPoint <= 0)
            {
                MessageBox.Show("당신은 죽었습니다.");
                Application.Exit();
            }
            playerHpLabel.Text = game.PlayerHpPoint.ToString();
            minionPictureBoxFalse();
            WeaponPictureBox();
            minionNumber = LocationUpdate();
            if (minionNumber == 0)
            {
                MessageBox.Show("클리어하였습니다.! \n새로운 스테이지로 이동합니다.");
                minionList = game.StageSet();
                playerPictureBox.Location = game.PlayerStartLocation(playerStartLocation);
                newMapSet();
            }
        }

        private void minionPictureBoxFalse()
        {
            meleeMinionPictureBox.Visible = false;
            casterMinionPictureBox.Visible = false;
            siegeMinionPictureBox.Visible = false;
            meleeMinionLabel.Visible = false;
            meleeMinionHpLabel.Visible = false;
            casterMinionLabel.Visible = false;
            casterMinionHpLabel.Visible = false;
            siegeMinionLabel.Visible = false;
            siegeMinionHpLabel.Visible = false;
        }
        
        private void WeaponPictureBox()
        {
            swordPictureBox.Visible = false;
            boxPictureBox.Visible = false;
            macePictureBox.Visible = false;
            redPotionPictureBox.Visible = false;
            bluePotionPictureBox.Visible = false;
            Control weaponControl = null;
            switch(game.WeaponInRoom.Name)
            {
                case "도란검":
                    weaponControl = swordPictureBox;
                    break;
                case "최후의속삭임":
                    weaponControl = boxPictureBox;
                    break;
                case "야만의몽둥이":
                    weaponControl = macePictureBox;
                    break;
                case "빨간물약":
                    weaponControl = redPotionPictureBox;
                    break;
                default:
                    weaponControl = bluePotionPictureBox;
                    break;
            }
            if (game.WeaponInRoom.PickedUp )
            {
                inSwordPictureBox.Visible = game.CheckPlayerInventory("도란검");
                inBowPictureBox.Visible = game.CheckPlayerInventory("최후의속삭임");
                inMacePictureBox.Visible = game.CheckPlayerInventory("야만의몽둥이");
                inBluePotionPictureBox.Visible = game.CheckPlayerInventory("파란물약");
                inRedPotionPictureBox.Visible = game.CheckPlayerInventory("빨간물약");
            }else
            {
                weaponControl.Visible = true;
                weaponControl.Location = game.WeaponInRoom.Location;
            }

        }

        private void inSwordPictureBox_Click(object sender, EventArgs e)
        {
            inSwordPictureBox.BorderStyle = BorderStyle.FixedSingle;
            inBowPictureBox.BorderStyle = BorderStyle.None;
            inMacePictureBox.BorderStyle = BorderStyle.None;
            inRedPotionPictureBox.BorderStyle = BorderStyle.None;
            inBluePotionPictureBox.BorderStyle = BorderStyle.None;
            game.Equip("도란검");
        }

        private void inBowPictureBox_Click(object sender, EventArgs e)
        {
            inSwordPictureBox.BorderStyle = BorderStyle.None;
            inBowPictureBox.BorderStyle = BorderStyle.FixedSingle;
            inMacePictureBox.BorderStyle = BorderStyle.None;
            inRedPotionPictureBox.BorderStyle = BorderStyle.None;
            inBluePotionPictureBox.BorderStyle = BorderStyle.None;
            game.Equip("최후의속삭임");
        }

        private void inMacePictureBox_Click(object sender, EventArgs e)
        {
            inSwordPictureBox.BorderStyle = BorderStyle.None;
            inBowPictureBox.BorderStyle = BorderStyle.None;
            inMacePictureBox.BorderStyle = BorderStyle.FixedSingle;
            inRedPotionPictureBox.BorderStyle = BorderStyle.None;
            inBluePotionPictureBox.BorderStyle = BorderStyle.None;
            game.Equip("야만의몽둥이");
        }

        private void inRedPotionPictureBox_Click(object sender, EventArgs e)
        {
            inSwordPictureBox.BorderStyle = BorderStyle.None;
            inBowPictureBox.BorderStyle = BorderStyle.None;
            inMacePictureBox.BorderStyle = BorderStyle.None;
            inRedPotionPictureBox.BorderStyle = BorderStyle.FixedSingle;
            inBluePotionPictureBox.BorderStyle = BorderStyle.None;
            game.Equip("빨간물약");
        }

        private void inBluePotionPictureBox_Click(object sender, EventArgs e)
        {
            inSwordPictureBox.BorderStyle = BorderStyle.None;
            inBowPictureBox.BorderStyle = BorderStyle.None;
            inMacePictureBox.BorderStyle = BorderStyle.None;
            inRedPotionPictureBox.BorderStyle = BorderStyle.None;
            inBluePotionPictureBox.BorderStyle = BorderStyle.FixedSingle;
            game.Equip("파란물약");
        }

        private void attackUpButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.위쪽);
            potionUsed();
            UpdateGame();
        }

        private void attackLeftButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.왼쪽);
            potionUsed();
            UpdateGame();
        }

        private void attackRightButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.오른쪽);
            potionUsed();
            UpdateGame();
        }

        private void attackDownButton_Click(object sender, EventArgs e)
        {
            game.Attack(Direction.아래쪽);
            potionUsed();
            UpdateGame();
        }

        private void potionUsed()
        {
            if (!game.CheckPlayerInventory("파란물약"))
                inBluePotionPictureBox.Visible = false;
            else if (!game.CheckPlayerInventory("빨간물약"))
                inRedPotionPictureBox.Visible = false;
        }
    }

    
}
