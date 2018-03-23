using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class RedPotion : Weapon, IUseable
    {
        public RedPotion(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "빨간물약"; } }
        private bool used = false;
        public bool Used { get { return used; } }

        public override void Attack(Direction direction, Random random)
        {
            game.IncreasePlayerHealth(10);
            used = true;
        }
    }
}
