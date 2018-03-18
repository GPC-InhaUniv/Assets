using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest2
{
    abstract class Weapon : Mover
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }
        protected int radius;
        public int Radius { get { return radius; } }

        public Weapon(Game game, Point location) : base(game, location)
        {
            pickedUp = false;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
          
            Point target = game.PlayerLocation;
            foreach(Enemy enemy in game.Enemies)
            {
               
                if(Nearby(enemy.Location,direction,radius))
                {
                    
                    enemy.Hit(damage, random);
                    return true;
                }
                
            }

            return false;
        }
       
        public void PickUpWeapon()
        {
            pickedUp = true;
        }

    }
}
