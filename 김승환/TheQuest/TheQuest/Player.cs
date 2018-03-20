using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheQuest
{
    public class Player : Mover
    {
        private Weapon equippedWeapon;
        public Weapon EquippedWeapon
        {
            get => equippedWeapon;
        }

        private int hitPoints;
        public int HitPoints
        {
            get => hitPoints;
        }

        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> weaponNames = new List<string>();
                foreach(Weapon weapon in inventory)
                {
                    weaponNames.Add(weapon.Name);
                }
                return weaponNames;
            }
        }

        public bool isUsedBP = false;
        public bool isUsedRP = false;

        public Player(Game game, Point location) : base(game, location)
        {
            hitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
            {
                if(weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public void Move(Direction direction)
        {
            location = Move(direction, game.Boundaries);
            if(!game.WeaponInRoom.PickedUp)
            {
                if(game.WeaponInRoom.Nearby(location, 10))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon == null)
            {
                return;
            }
            else
            {
                if(equippedWeapon is IPotion)
                {
                    IPotion myPotion = equippedWeapon as IPotion;
                    if(myPotion.Used == false)
                    {
                        equippedWeapon.Attack(direction, random);
                    }
                }
                else
                {
                    equippedWeapon.Attack(direction, random);
                }
            }
        }
    }
}
