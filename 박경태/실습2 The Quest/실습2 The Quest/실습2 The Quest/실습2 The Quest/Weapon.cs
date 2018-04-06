using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace 실습2_The_Quest
{
    abstract class Weapon : Mover
    {
        private bool pickup;
        public bool PickUp
        {
            get { return pickup; }
        }

        private int damage;
        public int Damage
        {
            get { return damage; }
        }

        private int range;
        public int Range
        {
            get { return range; }
        }

        private string name;
        public string Name
        {
            get { return name; }
        }
        
        public Weapon(Point point, Game game, int damage, int range) : base(point, game)
        {
            this.damage = damage;
            this.range = range;
        }
        public abstract void Attack(Direction direction, Monster monsters);

        public bool PickUpWeapon()
        {
            if (game.PlayerLocation.X > base.Lcation.X)
                return true;
            else if(base.Lcation.X < game.PlayerLocation.X)
                return true;
            else if (game.PlayerLocation.Y > base.Lcation.Y)
                return true;
            else if (base.Lcation.Y < game.PlayerLocation.Y)
                return true;
            else
                return false;
        }
        

    }
}
