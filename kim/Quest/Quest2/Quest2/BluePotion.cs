using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Quest2
{
    class BluePotion : Weapon, IUsable
    {
        public BluePotion(Game game, Point location) : base(game, location)
        {
        }
        private bool usedItem = false;
        public override WeaponName Name { get { return WeaponName.BluePotion; } }
        public bool Used { get { return usedItem; } }
        public override void Attack(Direction direction, Random random)
        {
            usedItem = true;
        }
    }
}
