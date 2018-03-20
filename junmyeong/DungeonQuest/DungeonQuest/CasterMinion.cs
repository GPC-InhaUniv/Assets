using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class CasterMinion : Minion
    {
        public CasterMinion(Point location,Game game) : base(location,game, 8)
        {
            name = "CasterMinion";
            movement = 10;
        }

        public override void Move(Random random)
        {
            int condition = random.Next(0, 3);
            if (condition == 0)
            {
                targetPlayerMove(random);
            } else
            {
                way = MinionActive.제자리;                                                  //아무 움직임 없을때.
                if (NearBy(game.PlayerLocation, 30) == true)
                {
                    game.MinionAttack(4, random);
                    way = MinionActive.공격;
                }
            }
        }
    }
}
