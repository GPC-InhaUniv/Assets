using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace QuestGameCreate.Model
{
    class Player : Util.Mover
    {
        private Weapon equipWeapon;
        private int hp;
        public int HP { get { return hp; } }

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

        public void Move(Direction direction)
        {
            base.location = Move(direction, game.Boundaries);
            if(!game.weaponInRoom.PickedUp)
            {
                // 근처에 무기가 있으면 줍습니다.
            }
        }

        public void Attack(Direction direction,Random random)
        {

        }

        public Player(Controller.Game game, Point location)
            : base(game,location) // Mover에 선언된 변수
        {
            hp = 10;
        }

        public void PlayerDamege(int MaxDamege,Random random)
        {
            hp -= random.Next(1, MaxDamege); // 플레이어가 대미지를 입으면 랜덤으로 hp 감소 (나중에 능력치 적용할 생각중)
        }

        public void HealingPotion(int MaxHealing,Random random)
        {
            hp += random.Next(1, MaxHealing); // 회복포션 사용시 플레이어 hp를 랜덤으로 회복 (나중에 세분화해서 고정시킬 것)
        }

        public void Equip(string weaponName) // 무기 장비
        {
            foreach (Weapon weapon in inventory) // 인벤토리 읽어오기
                if (weapon.Name == weaponName) // 무기 리스트에 선택한 무기와 똑같은 이름을 사용하는 무기가 있는지 비교
                    equipWeapon = weapon; // 똑같은 이름을 사용하는 무기가 있을시 착용
        }
    }
}
