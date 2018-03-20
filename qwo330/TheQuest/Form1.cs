using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace TheQuest
{
    public partial class Form1 : Form
    {
        Game game;
        Random randomDirection;
        PictureBox previous;
        int enemiesShown;

        public Form1()
        {
            InitializeComponent();

            randomDirection = new Random();
           
            game = new Game(new Rectangle(78, 57, 420, 155));
            game.NewLevel(randomDirection, StageLevel);

            UpdateGame();
        }

        public void UpdateGame()
        {
            UpdateCharacters();
            UpdateWeapons();
            UpdateSystem();
            DoubleBuffered = true;
            
        }

        public void UpdateCharacters() // player와 enemy
        {
            /* player update */
            Player.Location = game.PlayerLocation;
            playerHitPoint.Text = game.PlayerHitPoints.ToString();
            bool showBat = false;
            bool showGhost = false;
            bool showGhoul = false;
            enemiesShown = 0;

            /* enemy update */
            batHitPoints.Text = "";
            ghostHitPoints.Text = "";
            ghoulHitPoints.Text = "";

            foreach (Enemy enemy in game.Enemies)
            {
                switch (enemy.Name)
                {
                    case "Bat":
                        Bat.Location = enemy.Location;
                        batHitPoints.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showBat = true;
                            enemiesShown++;
                        }
                        break;
                    case "Ghost":
                        Ghost.Location = enemy.Location;
                        ghostHitPoints.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showGhost = true;
                            enemiesShown++;
                        }
                        break;
                    case "Ghoul":
                        Ghoul.Location = enemy.Location;
                        ghoulHitPoints.Text = enemy.HitPoints.ToString();
                        if (enemy.HitPoints > 0)
                        {
                            showGhoul = true;
                            enemiesShown++;
                        }
                        break;
                    default: break;
                }
            }
            // 조건문 ? 참 : 거짓
            Bat.Visible = showBat ? true : false;
            Ghost.Visible = showGhost ? true : false;
            Ghoul.Visible = showGhoul ? true : false;
        }
        public void UpdateSystem()
        {
            /* system update */
            if (game.PlayerHitPoints <= 0)
            {
                MessageBox.Show("You Died");
                Application.Exit();
            }
            if (enemiesShown < 1)
            {
                MessageBox.Show("You have defeated the enemies on this level!");
                game.NewLevel(randomDirection, StageLevel); // randomObjectLoation

                // 업데이트 해주지 않으면 pictureBox가 그려지지 않음
                UpdateCharacters();
                UpdateWeapons();
            }
        }

        public void UpdateWeapons() // weapon
        {
            /* weapon update */
            Sword.Visible = false;
            Bow.Visible = false;
            Mace.Visible = false;
            Potion_Blue.Visible = false;
            Potion_Red.Visible = false;

            Control weaponCtrl = null;
            switch (game.WeaponInRoom.Name)
            {
                case "Sword":
                    weaponCtrl = Sword; break;
                case "Bow":
                    weaponCtrl = Bow; break;
                case "Mace":
                    weaponCtrl = Mace; break;
                case "BluePotion":
                    weaponCtrl = Potion_Blue; break;
                case "RedPotion":
                    weaponCtrl = Potion_Red; break;
                default: break;
            }
            weaponCtrl.Visible = true;
            /* inventory update */
            InvenSword.Visible = false;
            InvenBluePotion.Visible = false;
            InvenBow.Visible = false;
            InvenRedPotion.Visible = false;
            InvenMace.Visible = false;
            Inven6.Visible = false;
            Inven7.Visible = false;

            InvenSword.Visible = game.CheckPlayerInventory("Sword") ? true : false;
            InvenBluePotion.Visible = game.CheckPlayerInventory("BluePotion") ? true : false;
            InvenBow.Visible = game.CheckPlayerInventory("Bow") ? true : false;
            InvenRedPotion.Visible = game.CheckPlayerInventory("RedPotion") ? true : false;
            InvenMace.Visible = game.CheckPlayerInventory("Mace") ? true : false;
            Inven6.Visible = game.CheckPlayerInventory("inven6") ? true : false;
            Inven7.Visible = game.CheckPlayerInventory("inven7") ? true : false;
            /* */
            weaponCtrl.Location = game.WeaponInRoom.Location;

            if (game.WeaponInRoom.PickedUp) weaponCtrl.Visible = false;
            else weaponCtrl.Visible = true;
        }

        public void EffectThread()
        {
            Thread effect = new Thread(new ThreadStart(HitEffect));
            effect.Start();
        }

        public void HitEffect() // 반투명 빨강 이펙트
        {
            Form bg = this;
            bg.BackgroundImage = Properties.Resources.hitEffect;
            System.Threading.Thread.Sleep(150);
            bg.BackgroundImage = Properties.Resources.dungeon600x400;
        }

        // 키보드 입력 처리
        private void InputKeyboard(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                if (previous != null) previous.BorderStyle = BorderStyle.None;

                game.Equip("Sword");
                InvenSword.BorderStyle = BorderStyle.FixedSingle;

                previous = InvenSword;
            }

            if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                if (previous != null) previous.BorderStyle = BorderStyle.None;

                game.Equip("BluePotion");
                InvenBluePotion.BorderStyle = BorderStyle.FixedSingle;

                previous = InvenBluePotion;
            }

            if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                if (previous != null) previous.BorderStyle = BorderStyle.None;

                game.Equip("Bow");
                InvenBow.BorderStyle = BorderStyle.FixedSingle;

                previous = InvenBow;
            }

            if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                if (previous != null) previous.BorderStyle = BorderStyle.None;

                game.Equip("RedPotion");
                InvenRedPotion.BorderStyle = BorderStyle.FixedSingle;

                previous = InvenRedPotion;
            }

            if (e.KeyCode == Keys.D5)
            {
                if (previous != null) previous.BorderStyle = BorderStyle.None;

                game.Equip("Mace");
                InvenMace.BorderStyle = BorderStyle.FixedSingle;

                previous = InvenMace;
            }

            if (e.Control && e.KeyCode == Keys.W)
            {
                if (game.Attack(Direction.Up, randomDirection, this)) EffectThread();
                UpdateGame();
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                if (game.Attack(Direction.Left, randomDirection, this)) EffectThread();
                UpdateGame();
            }
            else if (e.Control && e.KeyCode == Keys.S)
            {
                if (game.Attack(Direction.Down, randomDirection, this)) EffectThread();
                UpdateGame();
            }
            else if (e.Control && e.KeyCode == Keys.D)
            {
                if (game.Attack(Direction.Right, randomDirection, this)) EffectThread();
                UpdateGame();
            }
            else if(e.KeyCode == Keys.W)
            {
                if (game.Move(Direction.Up, randomDirection)) EffectThread();
                UpdateGame();
            }
            else if (e.KeyCode == Keys.A)
            {
                if (game.Move(Direction.Left, randomDirection)) EffectThread();
                UpdateGame();
            }
            else if (e.KeyCode == Keys.S)
            {
                if (game.Move(Direction.Down, randomDirection)) EffectThread();
                UpdateGame();
            }
            else if (e.KeyCode == Keys.D)
            {
                if (game.Move(Direction.Right, randomDirection)) EffectThread();
                UpdateGame();
            }
        }
    }
}