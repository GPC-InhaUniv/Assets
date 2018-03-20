using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class BluePotion : Weapon, IUseable
    {
        public BluePotion(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "파란물약"; } }
        private bool used = false;
        public bool Used { get { return used; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(5);
            used = true;
        }
    }
}
