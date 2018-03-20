using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private int hitPoint;
        public int HitPoint { get { return hitPoint; } }
        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> name = new List<string>();
                foreach (Weapon weapon in inventory)
                {
                    name.Add(weapon.Name);
                }
                return name;
            }
        }

        public Player(Game game, Point location) 
            : base(game, location)
        {
            hitPoint = 10;
        }
        public void Damaged(int maxDamage , Random random)
        {
            hitPoint -= random.Next(1, maxDamage);
        }
        public void IncreaseHealth(int health , Random random)
        {
            hitPoint += random.Next(1, health);
        }
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if(weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                    MessageBox.Show(equippedWeapon.ToString());
                }
            }
        }

        public void AttackEnemies(MoveDirection direction, Random random)
        {

            if (equippedWeapon!=null)
            {
                equippedWeapon.Attack(direction, random);

                if (equippedWeapon is IDrinkable)
                {
                    inventory.Remove(equippedWeapon);
                }
            }
        }    
        public void Move(MoveDirection direction)
        {
            base.location = Move(direction, game.Boundaries);

            //웨폰인룸 픽업이 false일때
            if (!game.WeaponInRoom.PickedUp)
            {
                Point weaponLocation   = game.WeaponInRoom.Location;
                //근처에 무기가 있는지 확인하고 가능하다면 무기를 줍는다.
                if (NearBy(weaponLocation,5))
                {
                    game.WeaponInRoom.PickUpWeapon();

                    inventory.Add(game.WeaponInRoom);
                    
                }
            }
        }
    }
}
