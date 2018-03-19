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
        public override void Attack(Direction dir, Random random, Form1 form)
        {
            game.IncreasePlayerHealth(5, random);
        }

        public override void showAttackRange(Direction dir, Form1 form) { }

        public bool Used { get { return true; } }
    }
}
