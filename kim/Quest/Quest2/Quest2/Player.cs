using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Quest2
{
    class Player : Mover, IHitable
    {


        public Player(Game game, Point location) : base(game, location)
        {
            hitPoints = 10;
        }
        //전투-------------------------------
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }
        public void Attack(Direction direction, Random random)
        {
            inventory.Add(game.WeaponInRoom);
            
            if(game.WeaponInRoom is Sword)
            {
                game.WeaponInRoom.Attack(direction,random);
            }
        }
        //장비-------------------------------
        private Weapon equippedWeapon;
        public List<Weapon> inventory = new List<Weapon>();
        

        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    names.Add(weapon.Name);
                }
                return names;
            }
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


        // 이동-------------------------------
        public void Move(Direction direction)
        {

            location = Move(direction, game.Boundaries);

        }
    }
}
