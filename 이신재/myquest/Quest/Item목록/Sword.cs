using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Sword : Item
    {
        public Sword(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Sword"; } }

        public override void Attack(enumDirection direction, Random random)
        {

        }

    }
}
