using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventureGame
{
    class Player : GameObject, IHittable
    {
        private Item equippedItem;
        private int hitPoints;
        public int HitPoints { get { return hitPoints; } }

        private List<Item> inventory = new List<Item>();
        private Point point;

        public List<string> Items
        {
            get
            {
                List<string> names = new List<string>();
                foreach (Item item in inventory)
                    names.Add(item.Name);

                return names;
            }
        }               

        public Player(GameView gameView, Point location) : base(gameView, location)
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

        public void EquipItem(string itemName)
        {
            foreach (Item item in inventory)
            {
                if (item.Name == itemName)
                    equippedItem = item;
            }
        }

        public void Move(Direction direction)
        {
            base.location = Move(direction, gameView.Boundaries);
            if (!gameView.ItemInRoom.PickedUp)
            {
                if (Nearby(gameView.ItemInRoom.Location, 1))
                {
                    gameView.ItemInRoom.PickUpItem();
                    inventory.Add(gameView.ItemInRoom);
                }                   

            }
        }

        public void Use(Direction direction, Random random)
        {
            if (equippedItem != null)
            {
                equippedItem.Use(direction, random);
            }            
        }

    }
}
