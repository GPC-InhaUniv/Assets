using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Potion_Red: Weapon, IDrinkable
    {
        // hp 10 회복
        public Potion_Red(Game game, Point location)
            : base(game, location) { }

        public override string Name { get { return "RedPotion"; } }
        public override void Attack(Direction dir, Random random, Form1 form)
        {
            game.IncreasePlayerHealth(10, random);
        }

        public override void showAttackRange(Direction dir, Form1 form) { }
        public bool Used{ get{ return true; }}
    }
}
