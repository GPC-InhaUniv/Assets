using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeQuest
{
    abstract class Weapon : Mover
    {

        protected Game game;
        private bool pickedUp;
        public bool PickedUp { get { return pickedUp; } }

        private Point location;
        public Point Location { get { return location; } }


        public Weapon(Game game, Point location)
            :base(game,location)
        {
            this.game = game;
            this.location = location;
            pickedUp = false;
        }

        public void PickUpWeapon() { pickedUp = true; }

        public abstract void Attack(Direction direction, Random random);

        public abstract string Name { get; }

        protected bool DamageEnemy(Direction direction, int radius, int damege, Random random)
        {
            Point target = game.PlayerLocation;
            for (int distance = 0; distance < radius; distance++)
            {
                foreach(Enemy enemy in game.Enemies)
                {
                    if (Nearby(enemy.Location, target, radius))
                    {
                        enemy.Hit(damege, random);
                        return true;
                    }
                }
                target = Move(direction, target, game.Boundaries);
            }
            return false;
        }

        private bool Nearby(Point location, Point target, int radius)
        {
            return true;

        }

        private Point Move(Direction direction, Point target, Rectangle boundaries)
        {
            throw new NotImplementedException();
        }
    }
}
