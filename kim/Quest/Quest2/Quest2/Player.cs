using System;
using System.Collections.Generic;
using System.Drawing;
namespace Quest2
{
    class Player : Mover, IHitable
    {
        public Player(Game game, Point location) : base(game, location)
        {
            hitPoints = 20;
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
            if(equippedWeapon is RedPotion)
            {
                RedPotion item = equippedWeapon as RedPotion;
                if(item.Used == false)
                {
                    IncreaseHealth(10, random);
                    item.Attack(direction, random);
                    inventory.Remove(item);
                    Weapons.Remove(item.Name);
                }
                
            }
            else if (equippedWeapon is BluePotion)
            {
                BluePotion item = equippedWeapon as BluePotion;
                if (item.Used == false)
                {
                    IncreaseHealth(10, random);
                    item.Attack(direction, random);
                    inventory.Remove(item);
                    Weapons.Remove(item.Name);
                }

            }

            else if(equippedWeapon !=null)
                equippedWeapon.Attack(direction, random);

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

            //장비 줍기
            if(!game.WeaponInRoom.PickedUp)
            {
                if(Nearby(game.WeaponInRoom.Location, 30))
                {
                    if (inventory.Contains(game.WeaponInRoom) == false)
                    {
                        Console.WriteLine(inventory.Contains(game.WeaponInRoom));
                        inventory.Add(game.WeaponInRoom);
                        game.WeaponInRoom.PickUpWeapon();
                    }
                   
                }
            }

            

        }
        // 회복

        public void IncreaseHealth(int health,Random random)
        {
            hitPoints += random.Next(1, health);
        }
        
        
    }
}
