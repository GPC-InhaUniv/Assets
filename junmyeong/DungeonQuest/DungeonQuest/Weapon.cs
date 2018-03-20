using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    abstract class Weapon : Mover
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }
        
        public Weapon(Game game, Point location) : base(game,location)
        {
            pickedUp = false;
        }

        public void PickUpWeapon() { pickedUp = true; }
        
        public abstract String Name { get; }

        public abstract void Attack(Direction direction, Random random);

        
    }
}
