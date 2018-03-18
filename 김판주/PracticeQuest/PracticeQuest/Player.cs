using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace PracticeQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        private int hitPoints;
        public int HitPoints { get{ return hitPoints; } }

        protected new Game game;
        protected new Point location;

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

        public Player(Game game, Point location)
            :base(game, location)
        {
            hitPoints = 10;
            this.game = game;
            this.location = location; //오른쪽은 클래스내 필드 변수 = 왼쪽은 생성자 매개변수
        }

        public void Hit(int maxDamge, Random random)
        {
            hitPoints -= random.Next(1, maxDamge);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string weaponName) //무기를 장착하는 메소드로 인벤토리에서 아이템을 클릭하면 호출
        {
            foreach(Weapon weapon in inventory)
            {
                if (weapon.Name == weaponName)
                    equippedWeapon = weapon; //장착된 무기를 반환함
            }
        }

        public  void Move(Direction direction)
        {
            Sword InvenSword = new Sword(game, location);
            Bow InvenBow = new Bow(game, location);
            Mace InvenMace = new Mace(game, location);
            RedPotion InvenRed = new RedPotion(game, location);
            BluePotion InvenBlue = new BluePotion (game, location);

            PictureBox picture = new PictureBox();

            base.location = Move(direction, game.Boundaries);
            if (!game.WeaponInRoom.PickedUp) // 근처에 무기가 있는지 확인하고 가능하다면 그 무기를 줍습니다.
            {
                if (Nearby(game.WeaponInRoom.Location, 3))
                {
                    game.WeaponInRoom.PickUpWeapon();

                    inventory.Add(game.WeaponInRoom);
                }         
            }
        }

        public void Attack(Direction direction, Random random)
        {
            //무기 장착되어 있지 않으면 이 메소드를 실행했을 때 컨테인?
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(Direction.NONE, random);
            }
            else
            {
                return;
            }
            //장착된 무기가 있다면 attack메소드를 호출해야 합니다. 
            
            //아무일도 일어나지 않습니다. 

        }
    }
}
