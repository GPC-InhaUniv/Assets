using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class Player : Mover
    {
        private Weapon equippedWeapon;
        int playerHpPoint;
        public int PlayerHpPoint { get { return playerHpPoint; } }
        String way;
        private List<Weapon> inventory = new List<Weapon>();
        public List<String> Weapons
        {
            get
            {
                List<String> names = new List<String>();
                for(int i = 0; i < inventory.Count; i++)
                    names.Add(inventory[i].Name);
                return names;
            }
        }

        public Player( Game game, Point location) : base (game, location)
        {
            playerHpPoint = 10;
        }

        public override void Move(Direction direction, Rectangle boundaries)
        {
            way = direction.ToString();
            movement = 10;
            base.Move(direction, boundaries);
            if (!game.WeaponInRoom.PickedUp)
            {
                bool WeaponCheck = NearBy(game.WeaponInRoom.Location, 20);
                if(WeaponCheck == true)
                {
                    inventory.Add(game.WeaponInRoom);
                    game.WeaponInRoom.PickUpWeapon();
                }
            }
        }

        public Point StartLocation(Point startLocation)
        {
            location = startLocation;
            return location;
        }

        public void PlayerHit(int maxDamage, Random random)
        {
            playerHpPoint -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health)
        {
            playerHpPoint += health;
            inventory.Remove(equippedWeapon);
            equippedWeapon = null;
            
        }

        public void Equip(String weaponName)
        {
            for(int i = 0; i < inventory.Count; i++)
            {
                if (inventory[i].Name == weaponName)
                    equippedWeapon = inventory[i];
                
            }
        }
        
        public void Attack(Direction direction, Random random)
        {
            if (equippedWeapon != null)
            {
                switch (equippedWeapon.Name)
                {
                    case "도란검":
                        equippedWeapon.Attack(direction, random);
                        break;
                    case "최후의속삭임":
                        equippedWeapon.Attack(direction, random);
                        break;
                    case "야만의몽둥이":
                        equippedWeapon.Attack(direction, random);
                        break;
                    case "파란물약":
                        equippedWeapon.Attack(direction, random);
                        break;
                    default:
                        equippedWeapon.Attack(direction, random);
                        break;
                }
            }
        }

        public override string ToString()
        {
            return "Player가 "+way+"으로 "+movement+"만큼 이동하였다.";
        }

        
        

    }
}
