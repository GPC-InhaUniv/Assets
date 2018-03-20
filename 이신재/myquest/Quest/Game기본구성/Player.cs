using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Player : Mover
    {
        private Item equippedItem;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }
       
        private List<Item> inventory = new List<Item>();
        public List<string> Items
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Item item in inventory)
                { names.Add(item.Name); }
                return names;
            }
             
        }
        
        

        public Player(Game game, Point location):base(game, location)
        {
            hitPoints = 10;
        }

        public void Hit(int maxDamage, Random random)
        {
            hitPoints -= random.Next(1, maxDamage);
        }

        public void IncreaseHealth(int health, Random random)
        {
            hitPoints += random.Next(1, health);
        }

        public void Equip(string itemName)
        {
            foreach(Item item in inventory)
             if(item.Name == itemName)
                    if (item.Name == itemName)
                    {
                        equippedItem = item;
                    }

        }
        public void Move(enumDirection direction)
        {
            base.location = Move(direction, game.Boundaries);
           //근처에 무기가 있는지 확인하고 줍기
        }


        public void Attack(enumDirection direction, Random random)
        {
            if (equippedItem != null)
            {
                equippedItem.Attack(direction, random);
            }
        }
    }
}
