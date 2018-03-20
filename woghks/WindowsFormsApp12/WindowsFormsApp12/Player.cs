using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApp12
{
     class Player : Mover
    {
        //private Weapon equippedWeapon;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }


        //private List<Weapon> inventory = new List<Weapon>();
        //public List<string> Weapons
        //{
        //    get
        //    {
        //        List<string> names = new List<string>();
        //        foreach (Weapon weapon in inventory)
        //            names.Add(weapon.Name);
        //        return names;
        //    }
        //}

        public Player(Game game, Point location)  //플레이어의 공격 데미지
            : base(game, location)
        {
            hitPoints = 10;
        }

        public void Hit (int maxDamage, Random random)  //공격당함 데미지
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        //public void Equip(string weaponName) //장비 장착
        //{
        //    foreach (Weapon weapon in inventory)
        //    {
        //        if (weapon.Name == weaponName)
        //            equippedWeapon = weapon;
        //    }
        //}
        //public void Move(Direction direction)
        //{
        //    base.location = Move(direction, game.Boundaries); //플레이어의 Move메소드
        //    if (!game.WeaponInRoom.PickedUp)
        //    {
                
        //    }
            
        //}

       

        public void Attack (Direction direction , Random random)  //공격 메소드
        {
            
        }

    }


}


