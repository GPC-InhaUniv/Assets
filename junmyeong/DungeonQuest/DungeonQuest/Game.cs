using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace DungeonQuest
{
    public enum Direction
    {
        위쪽,
        왼쪽,
        오른쪽,
        아래쪽,
    }

    class Game
    {
        private Player player;
        private Random random =  new Random();
        private Point randomLocation;
        public String PlayerText;
        public Point PlayerLocation{get{ return player.Location; } }
        public int PlayerHpPoint { get { return player.PlayerHpPoint; } }
        private List<Minion> minionList = new List<Minion>();
        public List<Minion> MinionList { get { return minionList; } }
        public Weapon WeaponInRoom;
        private Rectangle boundaries;
        public Rectangle Boundaries { get { return boundaries; } }
        private int level = 0;
        public int Level { get { return level; } }
        public List<String> PlayerWeapons { get { return player.Weapons; } }

        public Game(Rectangle boundaries,Point playerStartLotation)
        {
            this.boundaries = boundaries;
            player = new Player(this, playerStartLotation);
        }

        public List<Minion> StageSet()
        {
            level++;
            switch(level)
            {
                case 1:
                    minionList.Add(new MeleeMinion(RandomLocation(),this));
                    WeaponInRoom = new Sword(this, RandomLocation());
                    return minionList;
                case 2:
                    minionList.Add(new CasterMinion(RandomLocation(), this));
                    WeaponInRoom = new BluePotion(this, RandomLocation());
                    return minionList;
                case 3:
                    minionList.Add(new SiegeMinion(RandomLocation(), this));
                    WeaponInRoom = new Bow(this, RandomLocation());
                    return minionList;
                case 4:
                    minionList.Add(new MeleeMinion(RandomLocation(), this));
                    minionList.Add(new CasterMinion(RandomLocation(), this));
                    if(!CheckPlayerInventory("최후의속삭임"))
                    {
                        WeaponInRoom = new Bow(this, RandomLocation());
                    }else if(!CheckPlayerInventory("파란물약"))
                        WeaponInRoom = new BluePotion(this, RandomLocation());
                    return minionList;
                case 5:
                    minionList.Add(new MeleeMinion(RandomLocation(), this));
                    minionList.Add(new SiegeMinion(RandomLocation(), this));
                    WeaponInRoom = new RedPotion(this, RandomLocation());
                    return minionList;
                case 6:
                    minionList.Add(new CasterMinion(RandomLocation(), this));
                    minionList.Add(new SiegeMinion(RandomLocation(), this));
                    WeaponInRoom = new Mace(this, RandomLocation());
                    return minionList;
                case 7:
                    minionList.Add(new MeleeMinion(RandomLocation(), this));
                    minionList.Add(new CasterMinion(RandomLocation(), this));
                    minionList.Add(new SiegeMinion(RandomLocation(), this));
                    if (!CheckPlayerInventory("야만의몽둥이"))
                    {
                        WeaponInRoom = new Mace(this, RandomLocation());
                    }
                    else if (!CheckPlayerInventory("빨간물약"))
                        WeaponInRoom = new RedPotion(this, RandomLocation());
                    return minionList;
                default:
                    return minionList;
            }
        }
        public Point RandomLocation()
        {
            randomLocation.X = random.Next(boundaries.Left, boundaries.Right);
            randomLocation.Y = random.Next(boundaries.Top, boundaries.Bottom);
            return randomLocation;
        }

        public void Move(Direction direction)
        {
            player.Move(direction, boundaries);
            PlayerText = player.ToString();
            for (int i = 0; i < minionList.Count; i++)
            {
                if (minionList[i].MinionHpPoint <= 0)
                {
                    minionList.Remove(minionList[i]);
                }
                else
                {
                    minionList[i].Move(random);
                }
            }
        }

        public Point PlayerStartLocation(Point startLocation)
        {
            return player.StartLocation(startLocation);
        }

        public void MinionAttack(int maxDamage, Random random)
        {
            player.PlayerHit(maxDamage, random);
        }

        public void Equip(String weaponName)
        {
            player.Equip(weaponName);
        }

        public bool CheckPlayerInventory(String weaponName)
        {
            return player.Weapons.Contains(weaponName);
        }
        
        public void IncreasePlayerHealth(int health)
        {
            player.IncreaseHealth(health);
        }

        public void Attack(Direction direction)
        {
            player.Attack(direction, random);
            for (int i = 0; i < minionList.Count; i++)
            {
                if (minionList[i].MinionHpPoint <= 0)
                {
                    minionList.Remove(minionList[i]);
                }
                else
                {
                    minionList[i].Move(random);
                }
            }
        }

    }
}
