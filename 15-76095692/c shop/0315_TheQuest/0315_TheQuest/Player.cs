using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace _0315_TheQuest
{
    public class Player : Mover
    {
        private Weapon equippedWeapon;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name);
                return names;
            }
        }
        public Player(Game game, Point location) : base(game, location)
        {
            hitPoints = 10;
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                //근처에 무기가 있는지 확인하고 가능하면 그 무기를 줍습니다.

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
        public void Hit(int maxDamage,Random random)
        {

        }
        public void IncreaseHealth(int health, Random random)
        {

        }
        public void Attack(Direction direction, Random random)
        {

        }
    }
}
