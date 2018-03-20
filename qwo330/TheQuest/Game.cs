using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    //public enum WeaponName
    //{
    //    Sword,
    //    BluePotion,
    //    Bow,
    //    RedPotion,
    //    Mace
    //}

    public enum Direction
    {
        extendedLeft, // sword용
        Up,
        Right,
        Down,
        Left,
        extendedUp, // sword용
        extendedRight // mace용
    }

    struct DrawInfo
    {
        private Direction dir;
        public Direction Dir { get { return dir; } }

        private string name;
        public string Name { get { return name; } }

        private int attackRange;
        public int AttackRange { get { return attackRange; } }

        public DrawInfo(Direction dir, string name, int attackRange)
        {
            this.dir = dir;
            this.name = name;
            this.attackRange = attackRange;
        }
    }

    class Game
    {
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom; // ?????

        private Player player;
        public Point PlayerLocation { get { return player.Location; } }
        public int PlayerHitPoints { get { return player.HitPoints; } }
        public Weapon PlayerEquipedWeapon { get { return player.MyWeapon; } }
        public List<string> PlayerWeapons { get { return player.Weapons; } }

        private int level = 0;
        public int Level { get { return level; } }

        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }

        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 70));
        }

        public bool Move(Direction dir, Random randomDirection)
        {  
            player.Move(dir);
            bool hitEffect = false;
            foreach (Enemy enemy in Enemies)
            {
                if(enemy.Move(randomDirection)) hitEffect = true; 
            }
            return hitEffect;
        }

        public bool Attack(Direction dir, Random randomDirection)
        {
            player.Attack(dir,randomDirection);
            bool hitEffect = false;
            foreach (Enemy enemy in Enemies)
            {
                if (enemy.Move(randomDirection)) hitEffect = true;
            }
            return hitEffect;
        }

        public void Equip(string weaponName)
        {
            if (CheckPlayerInventory(weaponName))
            {
                player.Equip(weaponName);
            }
        }

        public bool CheckPlayerInventory(string itemName)
        {
            return player.Weapons.Contains(itemName);
        }

        public void HitPlayer(int maxDamage, Random random)
        {
            player.Hit(maxDamage, random);
        }

        public void IncreasePlayerHealth(int health, Random random)
        {
            player.IncreaseHealth(health, random);
        }

        public Point GetRandomLocation(Random random) /*   value/10 안함    */
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right - boundaries.Left), 
                boundaries.Top + random.Next(boundaries.Bottom - boundaries.Top));
        }
        
        public int NewLevel(Random random) // randomLocation
        {
            level++;
            switch(level)
            {
                case 1:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));

                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));

                    WeaponInRoom = new Potion_Blue(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));

                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));

                    if(CheckPlayerInventory("Bow")) WeaponInRoom = new Potion_Blue(this, GetRandomLocation(random));
                    else WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));

                    WeaponInRoom = new Potion_Red(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));

                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies = new List<Enemy>();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));

                    if (CheckPlayerInventory("Mace")) WeaponInRoom = new Potion_Red(this, GetRandomLocation(random));
                    else WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 8:
                    MessageBox.Show("Clear!!!");
                    Application.Exit();
                    break;
            }
            return level;
        }
    }
}
