using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace AdventureGame
{
    class Player : Mover
        
    {
        private Weapon equippedWeapon;
        
        //캡슐화
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        //Weapon 클래스를 인스턴스 : 참조변수 inventory
        private List<Weapon> inventory = new List<Weapon>();

        
        public List<string> Weapons
        {
            get
            {
                List<string> names = new List<string>(); //플레이어가 얻은 아이템을 저장
                foreach (Weapon weapon in inventory)
                    names.Add(weapon.Name); 
                return names;
            }
        }




        //플레이어의 생성자 : 무버의 생성자가 베이스이다.
        public Player(Game game, Point location)
          : base(game, location)
        {
            hitPoints = 10;
        }

        public void Hit (int MaxDamage, Random random)
        {
            hitPoints -= random.Next(1, MaxDamage);

        }

        public void IncreaseHealth(int potionHealth, Random random)
        {
            hitPoints += random.Next(1, potionHealth);
        }

        //무기장착 메소드
        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            //if (!game.WeaponInRoom.PickedUp) 
            //{


                //근처에(한칸이내) 무기가 있는지 확인하고 가능하다면 그 무기를 플레이어의 인벤토리에 추가한다.
                //물품 목록에 다른 무기가 없었다면 그 무기를 장착한다.


                //}
        }

        public void Attack(Direction direction, Random random)
        {
            return;
        }





    }
}
