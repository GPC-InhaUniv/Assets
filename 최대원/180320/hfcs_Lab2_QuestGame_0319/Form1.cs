using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfcs_Lab2_QuestGame
{
    public partial class Form1 : Form
    {
        Game game;
        public Form1()
        {
            InitializeComponent();
            game = new Game(this, new Rectangle(78,52,410,145));
            InstallSlot();
            UpdateBoard();
        }

        public class DoubleBufferPicture : PictureBox
        {
            public DoubleBufferPicture()
            {
                DoubleBuffered = true;
                SetStyle(ControlStyles.UserPaint |
                    ControlStyles.AllPaintingInWmPaint |
                    ControlStyles.ResizeRedraw |
                    ControlStyles.ContainerControl |
                    ControlStyles.OptimizedDoubleBuffer |
                    ControlStyles.SupportsTransparentBackColor
                    , true);
                UpdateStyles();
            }
        }

        public void InstallSlot()
        {
            Slot1.Image = null;
            Slot1.Visible = false;
            Slot2.Image = null;
            Slot2.Visible = false;
            Slot3.Image = null;
            Slot3.Visible = false;
            Slot4.Image = null;
            Slot4.Visible = false;
            Slot5.Image = null;
            Slot5.Visible = false;
            Slot6.Image = null;
            Slot6.Visible = false;
            Slot7.Image = null;
            Slot7.Visible = false;
        }


        public DoubleBufferPicture createbox(Point point, string image)
        {
            DoubleBufferPicture pictureBox = new DoubleBufferPicture()
            {
                Location = point,
                Size = new Size(45, 45),
                SizeMode = PictureBoxSizeMode.StretchImage,
                BorderStyle = BorderStyle.None,
                BackColor = Color.Transparent,
            };
            switch (image)
            {
                case "bat":
                    Bitmap bitmap = new Bitmap(Properties.Resources.bat);
                    //bitmap.MakeTransparent(Color.Transparent);
                    pictureBox.Image = Properties.Resources.bat;
                    break;
                case "player":
                    pictureBox.Image = Properties.Resources.player;
                    break;
                case "sword":
                    pictureBox.Image = Properties.Resources.sword;
                    break;
                case "bow":
                    pictureBox.Image = Properties.Resources.bow;
                    break;
                case "mace":
                    pictureBox.Image = Properties.Resources.mace;
                    break;
                case "ghost":
                    pictureBox.Image = Properties.Resources.ghost;
                    break;
                case "ghoul":
                    pictureBox.Image = Properties.Resources.ghoul;
                    break;
            }
            Controls.Add(pictureBox);
            pictureBox.SendToBack();
            return pictureBox;
        }

        public void UpdateBoard()
        {
            label2.Text = "";
            if(game.PlayerHP > 0) { label2.Text += "플레이어 체력 : " + game.PlayerHP + Environment.NewLine; }
            for(int i = 0; i < game.Enemies.Count; i++)
            {
                if (game.Enemies[i].Hp > 0) {
                    label2.Text += game.Enemies[i].enemyName + "의 체력 : " + game.Enemies[i].Hp + Environment.NewLine;
                }
                else game.Enemies.RemoveAt(i);
            }

            sword.Visible = false;
            bow.Visible = false;
            mace.Visible = false;
            redPotion.Visible = false;

            Control weaponControl = null;

            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponControl = sword;
                    break;
                case "Bow":
                    weaponControl = bow;
                    break;
                case "Mace":
                    weaponControl = mace;
                    break;
                case "RedPotion":
                    weaponControl = redPotion;
                    break;
            }

            weaponControl.Location = game.WeaponInRoom.Location;
            if (game.WeaponInRoom.PickUp)
            {
                weaponControl.Visible = false;
                SoltCheckItem(game.WeaponInRoom.Name);
            }
            else weaponControl.Visible = true;

            if (game.Enemies.Count <= 0)
            {
                MessageBox.Show("적을 모두 물리쳤습니다!");
                game.Stage++;
                game.NewLevel(game.Stage);
            }

            if (game.Enemies.Count >= 0) {
                foreach (Enemy enemy in game.Enemies)
                {
                    if(game.Enemies.Contains(enemy))
                    enemy.enemyimage.Location = enemy.Location;
                }
            }
                
        }

        //슬롯 체크
        public void SoltCheckItem(string name)
        {
            switch (name)
            {
                case "Sword":
                    Slot1.Image = Properties.Resources.sword;
                    Slot1.Visible = true;
                    break;
                case "Bow":
                    Slot2.Image = Properties.Resources.bow;
                    Slot2.Visible = true;
                    break;
                case "Mace":
                    Slot3.Image = Properties.Resources.mace;
                    Slot3.Visible = true;
                    break;
                case "RedPotion":
                    Slot4.Image = Properties.Resources.potion_red;
                    Slot4.Visible = true;
                    break;
            }
        }


        //키입력으로 이동
        private void MoveKeyDown(object sender, KeyEventArgs e)
        {
            //MessageBox.Show(e.KeyCode.ToString());
            if (game.PlayerHP > 0)
            {
                switch (e.KeyCode)
                {
                    case Keys.Up:
                        game.Move(Direction.Up);
                        UpdateBoard();
                        break;
                    case Keys.Down:
                        game.Move(Direction.Down);
                        UpdateBoard();
                        break;
                    case Keys.Left:
                        game.Move(Direction.Left);
                        UpdateBoard();
                        break;
                    case Keys.Right:
                        game.Move(Direction.Right);
                        UpdateBoard();
                        break;
                }
            }
        }

        private void SelectItem(PictureBox pictureBox, string item)
        {
            //sword
            if (game.CheckPlayerInventory(item))
            {
                game.Equip(item);
                UnSelectItem();
                pictureBox.BorderStyle = BorderStyle.FixedSingle;
            }
        }

        private void UnSelectItem()
        {
            Slot1.BorderStyle = BorderStyle.None;
            Slot2.BorderStyle = BorderStyle.None;
            Slot3.BorderStyle = BorderStyle.None;
            Slot4.BorderStyle = BorderStyle.None;
            Slot5.BorderStyle = BorderStyle.None;
            Slot6.BorderStyle = BorderStyle.None;
            Slot7.BorderStyle = BorderStyle.None;
        }

        private void Slot1_Click(object sender, EventArgs e)
        {
            SelectItem(Slot1, "Sword");
        }
    }
}
