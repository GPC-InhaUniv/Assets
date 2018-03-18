using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    abstract class Item : Mover
    {
        protected Game game;
        public abstract string Name { get; }

        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }
        private Point location;
        public Point Location { get { return location; } }
       
        public Item(Game game, Point location) : base(game, location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon() { pickedUp = true; }

        public abstract void Attack(enumDirection direction, Random random);

        protected bool DamageMonster(enumDirection direction, int radius, int damage, Random random)
        {
            Point target = game.PlayerLocation;
            for(int distance = 0; distance<radius;distance++)
            {
               
            }
            return false;
        }
        

        

        


    }
    
}
