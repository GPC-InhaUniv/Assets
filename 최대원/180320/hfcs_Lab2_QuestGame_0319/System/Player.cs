using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfcs_Lab2_QuestGame
{
    class Player : Mover
    {
        private int hp;
        private Weapon equippedWeapon;
        private List<Weapon> inventory = new List<Weapon>();

        public int HP { get { return hp; } }
        public List<string> PlayerWeapon
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

        public PictureBox imageLocation;
        public Point Location
        {
            get { return imageLocation.Location; }
            set { imageLocation.Location = value; }
        }

        public Player(Game game, Point Location, PictureBox Imagebox) :base(game, Imagebox)
        {
            hp = 30;
            imageLocation = Imagebox;
        }

        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                equippedWeapon.Attack(direction, random);
            }
        }

        public void Equip(string weaponName)
        {
            foreach (Weapon weapon in inventory)
            {
                if(weapon.Name == weaponName)
                {
                    equippedWeapon = weapon;
                }
            }
        }

        public bool HitPlayer(int max, Random random)
        {
            hp -= random.Next(1, max);
            if (hp > 0)
            {
                return true;
            }
            else return false;
        }

        public new void Move(Direction direction, int distance)
        {
            Location = base.Move(direction, distance);
            if (!game.WeaponInRoom.PickUp)
            {
                if (NearBy(game.WeaponInRoom.Location, 10))
                {
                    game.WeaponInRoom.PickUpWeapon();
                    inventory.Add(game.WeaponInRoom);
                }
            }
            Attack(direction, game.random);
        }
    }
}
