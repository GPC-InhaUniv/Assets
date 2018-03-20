using System;
using System.Collections.Generic;
using System.Drawing;

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

        public void EquipWeapon(Weapon weapon)
        {
            foreach (Weapon weapons in inventory)
                if (weapons.GetType() == weapon.GetType())
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

                        if (NearbyObject(game.Enemies[i].Location, 50,direction))
                        {
                            game.Enemies[i].DamagedByPlayer(5, random);
                            checkAttack = true;
                        }
                    }
                    else if (equippedWeapon is Sword)
                    {

                        if (NearbyObject(game.Enemies[i].Location, 60, direction))
                        {
                            game.Enemies[i].DamagedByPlayer(5, random);
                            checkAttack = true;
                        }
                    }
                    else if (equippedWeapon is Mace)
                    {

                        if (NearbyObject(game.Enemies[i].Location, 60, direction))
                        {
                            game.Enemies[i].DamagedByPlayer(10, random);
                            checkAttack = true;
                        }
                    }

                    else if (equippedWeapon is Bow)
                    {

                        if (NearbyObject(game.Enemies[i].Location, 200, direction))
                        {
                            game.Enemies[i].DamagedByPlayer(2, random);
                            checkAttack = true;

                        }
                    }
                    else if (equippedWeapon is BluePotion)
                    {
                        IPositionAble blueportion=(BluePotion)equippedWeapon;
                        blueportion.Used(random);
                        inventory.Remove(equippedWeapon);
                        equippedWeapon.UsePostion = true;
                        equippedWeapon = null;
                    }
                    else if (equippedWeapon is RedPotion)
                    {
                        IPositionAble blueportion = (RedPotion)equippedWeapon;
                        blueportion.Used(random);
                        inventory.Remove(equippedWeapon);
                        equippedWeapon.UsePostion = true;
                        equippedWeapon = null;
                    }


                }

            }

            return checkAttack;
        }

        public void ResetPlayer()
        {
            
            hitPoints = 10;
            base.location = new Point(game.Boundaries.Left + 10, game.Boundaries.Top + 70);
        }

        public void ResetPlayerPosition()
        {
            base.location= new Point(game.Boundaries.Left + 10, game.Boundaries.Top + 70);
        }
       
    }
}
