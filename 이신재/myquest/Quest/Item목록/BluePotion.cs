using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class BluePotion : Item
    {
        public BluePotion(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "BluePotion"; } }

        public override void Attack(enumDirection direction, Random random)
        {

        }
    }
}
