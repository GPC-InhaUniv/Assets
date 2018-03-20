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
    class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;

        private Player player;
        public Random random = new Random();
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHP { get { return player.HP; } }
        public List<string> PlayerWeapon { get { return player.PlayerWeapon; } }
        public int moveInterval = 10;

        public int Stage = 0;

        private Rectangle boundaries;
        public Rectangle Boundaries
        {
            get { return boundaries; }
        }

        private Form1 frm;

        public Game(Form1 form, Rectangle rectangle)
        {
            frm = form;
            boundaries = rectangle;

            Enemies = new List<Enemy>();
            
            //플레이어 구현
            PictureBox pimage = frm.createbox(new Point(450, 150), "player");
            player = new Player(this, pimage.Location, pimage);

            //스테이지 세팅
            NewLevel(Stage);
        }

        //스테이지 구현
        public void NewLevel(int lv)
        {
            switch (lv)
            {
                case 0:
                    //Enemies.Clear();
                    PictureBox box1 = frm.createbox(new Point(78+random.Next(80),52+random.Next(100)), "bat");
                    Bat bat1 = new Bat(box1, this, 10, 5, "박쥐1");
                    Enemies.Add(bat1);
                    WeaponInRoom = new Sword(this, new Point(PlayerLocation.X - 50 + random.Next(50), PlayerLocation.Y - 50 + random.Next(50)), random);
                    break;

                case 1:
                    Enemies.Clear();
                    PictureBox box2 = frm.createbox(new Point(78 + random.Next(332), 52 + random.Next(93)), "bat");
                    PictureBox box3 = frm.createbox(new Point(78 + random.Next(332), 52 + random.Next(93)), "bat");
                    PictureBox box4 = frm.createbox(new Point(78 + random.Next(332), 52 + random.Next(93)), "bat");
                    Bat bat4 = new Bat(box4, this, 10, 5, "박쥐1");
                    Bat bat2 = new Bat(box2, this, 10, 5, "박쥐2");
                    Bat bat3 = new Bat(box3, this, 10, 5, "박쥐3");
                    Enemies.Add(bat4);
                    Enemies.Add(bat2);
                    Enemies.Add(bat3);
                    break;
            }
        }

        public bool CheckPlayerInventory(string weaponName)
        {
            return player.PlayerWeapon.Contains(weaponName);
        }

        public void Equip(string weaponName)
        {
            player.Equip(weaponName);
        }

        //플레이어가 이동하면 적도 한번 씩 이동
        public void Move(Direction direction)
        {
            player.Move(direction, moveInterval);
            foreach (Enemy enemy in Enemies)
            {
                if (!enemy.Dead)
                {
                    enemy.Move();
                }
                else
                {
                    enemy.enemyimage.Visible = false;
                }
            }
        }

        public void HitPlayer(int max, Random random)
        {
            if (!player.HitPlayer(max, random))
            {
                MessageBox.Show("당신은 죽었습니다!");
                Application.Exit();
            }
        }

    }
}
