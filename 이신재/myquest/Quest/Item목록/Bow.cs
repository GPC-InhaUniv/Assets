using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Quest
{
    class Bow : Item
    {
        public Bow(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "Bow"; } }

        public override void Attack(enumDirection direction, Random random)
        {

        }
    }
}
