using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    // hp 5 회복
    class Potion_Blue : Weapon, IDrinkable
    {
        public Potion_Blue(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "BluePotion"; } }
        public override void Attack(Direction dir, Random random)
        {
            game.IncreasePlayerHealth(5, random);
        }

        public override DrawInfo SendAttackRange(Direction dir) { return new DrawInfo(); }
        public bool Used { get { return true; } }
    }
}
