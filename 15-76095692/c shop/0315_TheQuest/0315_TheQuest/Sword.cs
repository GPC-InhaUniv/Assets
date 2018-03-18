using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace _0315_TheQuest
{
    public class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }
        public override string Name { get { return "BFSword"; } }

        public override void Attack(Direction direction, Random random)
        {
            throw new NotImplementedException();
        }
    }
}