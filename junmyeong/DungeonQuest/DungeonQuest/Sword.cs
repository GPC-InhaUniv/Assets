using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class Sword : Weapon
    {
        public Sword(Game game, Point location) : base(game, location) { }

        public override string Name { get { return "도란검"; } }

        public override void Attack(Direction direction, Random random)
        {
            for(int i = 0; i < game.MinionList.Count; i ++)
            if (Math.Abs(game.PlayerLocation.X - game.MinionList[i].Location.X) < 40 && Math.Abs(game.PlayerLocation.Y - game.MinionList[i].Location.Y) < 40)
                {
                    game.MinionList[i].MinionHit(4, random);
                }
        }
    }
}
