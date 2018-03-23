using System;
using System.Collections.Generic;
using System.Drawing;


namespace Quest2
{
    class Game
    {
        private Player Player;
        public List<Enemy> Enemies;
        public Weapon WeaponInRoom;
        public Point PlayerLocation { get { return Player.Location; } }
        public int PlayerHitPoints { get { return Player.HitPoints; } }
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }
        public Game(Rectangle boundaries)
        {
            this.boundaries = boundaries;
            Player = new Player(this, new Point(boundaries.Left + 10, boundaries.Top + 10)); // 플레이어 생성위치
            Enemies = new List<Enemy>();
        }
        public void Move(Direction direction, Random random)
        {
            Player.Move(direction);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
                enemy.Die();
            }
        }
        // --------- Level -------------
        private int level = 0;
        public int Level { get { return level; } }
        public void NewLevel(Random random)
        {
            level++;
            bool CheckedHaveWeapon = false;
            switch (level)
            {
                case 1:
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new Sword(this, GetRandomLocation(random));
                    break;
                case 2:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    break;
                case 3:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 4:
                    Enemies.Clear();
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    foreach (WeaponName haveItem in PlayerWeapons)
                    {
                        if (haveItem.Equals(WeaponName.Bow))
                            CheckedHaveWeapon = true;
                    }
                    if (CheckedHaveWeapon == true)
                    {
                        WeaponInRoom = new BluePotion(this, GetRandomLocation(random));
                    }
                    else
                        WeaponInRoom = new Bow(this, GetRandomLocation(random));
                    break;
                case 5:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                case 6:
                    Enemies.Clear();
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 7:
                    Enemies.Clear();
                    Enemies.Add(new Bat(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghoul(this, GetRandomLocation(random)));
                    Enemies.Add(new Ghost(this, GetRandomLocation(random)));
                    foreach (WeaponName haveItem in PlayerWeapons)
                    {
                        if (haveItem.Equals(WeaponName.Mace))
                            CheckedHaveWeapon = true;
                    }
                    if (CheckedHaveWeapon == true)
                    {
                        WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    }
                    else
                        WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    break;
                case 8:
                    Enemies.Clear();
                    Enemies.Add(new SkeletonMage(this, GetRandomLocation(random)));
                    WeaponInRoom = new Mace(this, GetRandomLocation(random));
                    WeaponInRoom = new RedPotion(this, GetRandomLocation(random));
                    break;
                default:
                    break;
            }
        }
        //---------------랜덤 스폰---------------
        private Point GetRandomLocation(Random random)
        {
            return new Point(boundaries.Left + random.Next(boundaries.Right / 10 - boundaries.Left / 10) * 10, boundaries.Top + random.Next(boundaries.Bottom / 10 - boundaries.Top / 10) * 10);
        }
        // -------------- 전투 --------------
        public void GiveDamageToPlayer(int maxDamage, Random random)
        {
            Player.Hit(maxDamage, random);
        }
        public void Attack(Direction direction, Random random)
        {
            Player.Attack(direction, random);
            foreach (Enemy enemy in Enemies)
            {
                enemy.Move(random);
                enemy.Die();
            }
        }
        //--------------- 장비-----------
        public List<WeaponName> PlayerWeapons { get { return Player.Weapons; } }
        public bool CheckPlayerInventory(WeaponName weaponName)
        {
            return Player.Weapons.Contains(weaponName);
        }
        public void Equip(WeaponName weaponName)
        {
            Player.Equip(weaponName);
        }
    }
}
