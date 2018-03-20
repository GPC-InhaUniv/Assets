using System;
using System.Drawing;

namespace Quest2
{
    abstract class Weapon : Mover
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }
        protected int radius;
        public int Radius { get { return radius; } }
        protected int maxDamage;
        public Weapon(Game game, Point location) : base(game, location)
        {
            pickedUp = false;
        }

        public abstract string Name { get; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, Random random)
        {
          
            Point target = game.PlayerLocation;
            foreach(Enemy enemy in game.Enemies)
            {
                if (enemy.Death == false)
                {
                    if (Nearby(enemy.Location, direction, radius))
                    {

                        enemy.Hit(maxDamage, random);
                        return true;
                    }
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
