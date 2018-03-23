using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace TheQuest
{
    class Player : Mover
    {
        private int hitPoints;
        public int HitPoints
        {
            get { return hitPoints; }
            set { this.hitPoints = value; }
        }

        private Weapon myWeapon;
        public Weapon MyWeapon { get { return myWeapon; } }
        private List<Weapon> inventory = new List<Weapon>();

        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();

                foreach(Weapon weapon in inventory)
                    names.Add(weapon.Name);

                return names;
            }
        }

        public Player(Game game, Point location)
            : base(game, location) { hitPoints = 100; }

        public void Hit(int maxDamage, Random random)
        { hitPoints -= random.Next(1, maxDamage); }

        public void IncreaseHealth(int health, Random random)
        { hitPoints += random.Next(1, health); }

        public void Equip(string weaponName)
        {
            foreach(Weapon weapon in inventory)
                if (weapon.Name == weaponName)  myWeapon = weapon;
        }

        public void Move(Direction dir)
        {
            base.location = Move(dir, game.Boundaries);
            // 아이템 획득
            if (!game.WeaponInRoom.PickedUp)
            {
                // see if weapon is nearby, psossibly pick it ip
                if (Nearby(game.WeaponInRoom.Location, 15))
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public void Attack(Direction dir, Random random)
        {
            if (myWeapon == null) return;
            myWeapon.Attack(dir, random);

            if (myWeapon is IDrinkable)
            {
                inventory.Remove(myWeapon);
                if (!game.CheckPlayerInventory(myWeapon.Name)) myWeapon = null;
                else Equip(myWeapon.Name); // 다시 포션 장비
            }
        }
    }
}
