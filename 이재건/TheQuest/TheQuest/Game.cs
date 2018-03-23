using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{

    class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;
        public Weapon[] portion=new Weapon[3];
       
        public List<Image> EnemyImageList = new List<Image>();
        public List<Image> WeaponImageList = new List<Image>();
        public List<Image> PlayerImageList = new List<Image>();

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.Hitpoints; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }
        public Weapon playerEuqipped { get { return player.EquippedWeapon; } }
        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        private PictureBox hitImage;
        public PictureBox HitImage
        {
            get
            {
                return hitImage;
            }
            set
            {
                hitImage = value;
            }
        }

        public Game(Rectangle rectangle)
        {
            this.boundaries = rectangle;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
            if (LoadImageIntoList() == false)
                return;

            hitImage = new PictureBox();
            hitImage.Image = Image.FromFile(@"image\pop.png");
           
        }

        public void AddWeaponToInventory(Weapon weapon)
        {
            player.SaveWeaponToInventory(weapon);
        }

        public void MoveObject(Direction direction, Random random)
        {
            if (hitImage.Visible)
                hitImage.Visible = false;

            player.MovePlayer(direction);

            if (Enemies != null && Enemies.Count > 0)
                foreach (Enemy enemy in Enemies)
                    enemy.Move(random);
        }

        public void EquipWeapon(Weapon weapon)
        {
            player.EquipWeapon(weapon);
        }
        
      


        public bool CheckPlayerInventory(string weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }
        

        public void DamageToplayer(int maxdamage, Random random)
        {
            if (player.Hitpoints >= 0)
            {
          
                hitImage.Location = new Point(PlayerLocation.X-10,PlayerLocation.Y+10);
                hitImage.Visible = true;
                player.DamagedByEnemy(maxdamage, random);
            }
        }


        public void UsePotion(int health, Random random)
        {
            player.UsePotion(health, random);

            if (Enemies.Count > 0 && Enemies != null)
                foreach (Enemy enemy in Enemies)
                    enemy.Move(random);

        }

        public void Attack(Direction direction, Random random)
        {
            if (player.AttackMonster(direction, random))
            {
                if (Enemies.Count > 0 && Enemies != null)
                    foreach (Enemy enemy in Enemies)
                        enemy.Move(random);
            }
        }

        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10,
                boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }

        public void NextStage(Random random)
        {
            level++;
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    //Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    //add weapons;
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    portion[0] = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    portion[1] = new RedPotion(this, GetRandomLocation(random));          
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));  
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    portion[0] = new BluePotion(this, GetRandomLocation(random));
                    break;
            }
            player.ResetPlayerPosition();
        }

        public void ResetStage(Random random)
        {
            
            switch (level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                   
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                  //  WeaponInRoom = new Weapon(this, GetRandomLocation(random), "bow");
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                //    WeaponInRoom = new Weapon(this, GetRandomLocation(random), "mace");
                    break;
            }
        }

        private bool LoadImageIntoList()
        {
            EnemyImageList.Add(Image.FromFile(@"image\bat.png"));  //0 is bat
            EnemyImageList.Add(Image.FromFile(@"image\ghost.png"));  //1 is ghost
            EnemyImageList.Add(Image.FromFile(@"image\ghoul.png"));     //2 is ghoul

            WeaponImageList.Add(Image.FromFile(@"image\sword.png"));  //0 is sword
            WeaponImageList.Add(Image.FromFile(@"image\bow.png"));  //1 is bow
            WeaponImageList.Add(Image.FromFile(@"image\mace.png")); //2 is mace
            WeaponImageList.Add(Image.FromFile(@"image\potion_blue.png"));
            WeaponImageList.Add(Image.FromFile(@"image\potion_red.png"));

            PlayerImageList.Add(Image.FromFile(@"image\playerSword.png"));
            PlayerImageList.Add(Image.FromFile(@"image\playerBow.png"));
            PlayerImageList.Add(Image.FromFile(@"image\playerMace.png"));
            PlayerImageList.Add(Image.FromFile(@"image\player.png"));
            for (int i = 0; i < 3; i++)
            {
                if (EnemyImageList[i] == null||WeaponImageList[i]==null||PlayerImageList[i]==null)
                    return false;
            }

            return true;

        }

        public bool GameOver()
        {
            if (player.Hitpoints <= 0)
            {
                if (MessageBox.Show("You die...\nReTry???", "!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    return true;
                }
                else return false;
            }
            else return false;
            
        }

        public void ReTryGame(Random random)
        {
            player.ResetPlayer();
            ResetStage(random);
        }
    }
}
