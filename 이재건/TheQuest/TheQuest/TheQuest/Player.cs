using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace TheQuest
{
    class Player:Mover
    {
        private Weapon equippedWeapon;
        public Weapon EquippedWeapon
        {
            get
            {
                return equippedWeapon;
            }
        }

        private int hitPoints;
        public int Hitpoints { get { return hitPoints; } }

        private List<Weapon> inventory = new List<Weapon>();
        public List<string> Weapons
        {
            get
            {
                List<string> weaponname = new List<string>();
                foreach (Weapon weapons in inventory)
                {
                    weaponname.Add(weapons.Name);
                }
                return weaponname;
            }
        }

        public Player(Game game, Point location) : base(game, location)
        {
            hitPoints = 10;  //set hp
        }

        public void DamagedByEnemy(int maxdamage,Random random)
        {

            hitPoints -= random.Next(1, maxdamage);
         
                

        }
        public void SaveWeaponToInventory(Weapon weapon)
        {
            inventory.Add(weapon);
        }

        public void UsePotion(int health,Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void EquipWeapon(string weaponName)
        {
            foreach (Weapon weapons in inventory)
                if (weapons.Name == weaponName)
                    equippedWeapon = weapons;
        }

        public void MovePlayer(Direction direction)
        {
            base.location = MoveObject(direction, game.Boundaries);
          
        }

        public bool AttackMonster(Direction direction, Random random)
        {
            bool checkAttack = false;
            
            for (int i = 0; i < game.Enemies.Count; i++)
            {
                if (game.Enemies[i].Dead == false)
                {
                    if (equippedWeapon == null)
                    {

                        if (NearbyObject(game.Enemies[i].Location, 50))
                        {
                            game.Enemies[i].DamagedByPlayer(5, random);
                            checkAttack = true;
                        }
                    }
                    else if (equippedWeapon.Name == "sword")
                    {

                        if (NearbyObject(game.Enemies[i].Location, 60))
                        {
                            game.Enemies[i].DamagedByPlayer(5, random);
                            checkAttack = true;
                        }
                    }
                    else if (equippedWeapon.Name == "mace")
                    {

                        if (NearbyObject(game.Enemies[i].Location, 60))
                        {
                            game.Enemies[i].DamagedByPlayer(10, random);
                            checkAttack = true;
                        }
                    }

                    else if (equippedWeapon.Name == "bow")
                    {

                        if (NearbyObject(game.Enemies[i].Location, 200))
                        {
                            game.Enemies[i].DamagedByPlayer(2, random);
                            checkAttack = true;

                        }
                    }
                    else if (equippedWeapon.Name == "bluePortion")
                    {
                        hitPoints += 5;
                    }
                }
              
            }

            return checkAttack;
        }

        public void ResetPlayer()
        {
            
            hitPoints = 10;
            location = new Point(game.Boundaries.Left + 10, game.Boundaries.Top + 70);
        }

    }
}
