using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{


    abstract class Weapon : Mover
    {
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        public abstract string Name { get; }

        public Weapon(Game game, Point location)
            : base(game, location) { pickedUp = false; }

        public void PickUpWeapon() { pickedUp = true; }

        public abstract void Attack(Direction dir, Random random);

        public abstract DrawInfo SendAttackRange(Direction dir);

        public bool Nearby(Direction dir, Point targetLocation, Point playerLocation, int attackRange)
        {
            int size = 30; // Abs값
            switch (dir)
            {
                case Direction.extendedUp:
                case Direction.Up:
                    if (
                        (playerLocation.Y - targetLocation.Y) < attackRange
                        && 0 < (playerLocation.Y - targetLocation.Y)
                        && Math.Abs(playerLocation.X - targetLocation.X) < size
                        )
                        return true;
                    break;
                case Direction.extendedRight:
                case Direction.Right:
                    if ((playerLocation.X - targetLocation.X) > -attackRange
                        && 0 > (playerLocation.X - targetLocation.X)
                        && Math.Abs(playerLocation.Y - targetLocation.Y) < size
                        )
                        return true;
                    break;
                case Direction.Down:
                    if ((playerLocation.Y - targetLocation.Y) > -attackRange
                        && 0 > (playerLocation.Y - targetLocation.Y)
                        && Math.Abs(playerLocation.X - targetLocation.X) < size
                        )
                        return true;
                    break;
                case Direction.extendedLeft:
                case Direction.Left:
                    if ((playerLocation.X - targetLocation.X) < attackRange
                        && 0 < (playerLocation.X - targetLocation.X)
                        && Math.Abs(playerLocation.Y - targetLocation.Y) < size
                        )
                        return true;
                        break;
            }
            return false;
        }

        protected bool DamageEnemy(Direction dir, int attackRange, int damage, Random random)
        {
            Point WeaponLocation = game.PlayerLocation;//??

            for(int distance = 0; distance < attackRange; distance++)
            {
                foreach (Enemy enemy in game.Enemies)
                {
                    if (Nearby(dir, enemy.Location, WeaponLocation, attackRange) && !enemy.Dead)
                    {
                        enemy.Hit(damage, random);
                        return true;
                    }
                }
                //WeaponLocation = Move(dir, game.Boundaries);  ??
            }
            return false;
        }
    }
}
