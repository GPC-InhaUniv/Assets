using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hfcs_Lab2_QuestGame
{
     abstract class Weapon : Mover
    {
        private bool pickUp;
        public bool PickUp { get { return pickUp; } }
        public abstract string Name { get; }

        private Point location;
        public Point Location
        {
            get { return location; }
        }

        public Weapon(Game game, Point Location) :base(game)
        {
            this.game = game;
            location = Location;
            pickUp = false;
        }

        public void PickUpWeapon() { pickUp = true; }

        public abstract void Attack(Direction direction, Random random);

        protected bool DamageEnemy(Direction direction, int radius, int damage, Random random)
        {
            Point playerPos = game.PlayerLocation;
            for (int i = 0; i < game.Enemies.Count; i++)
            {
                    if (NearBy(game.Enemies[i].enemyimage.Location, playerPos, radius) == true)
                    {
                    game.Enemies[i].Hit(damage, random);
                    return true;
                    }
            }
            return false;
        }

        public bool NearBy(Point enemyPos, Point playerPos,int distance)
        {
            if (Math.Abs(playerPos.X - enemyPos.X) < distance && Math.Abs(playerPos.Y - enemyPos.Y) < distance)
            {
                return true;
            }
            else return false;
        }




    }
}
