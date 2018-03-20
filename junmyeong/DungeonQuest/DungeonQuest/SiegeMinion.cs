using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonQuest
{
    class SiegeMinion : Minion
    {
        
        public SiegeMinion(Point location,Game game) : base(location,game,10)
        {
            name = "SiegeMinion";
            movement = 10;
        }

        public override void Move(Random random)
        {
            int condition = random.Next(0, 3);
            if (condition == 0 || condition == 1)
            {
                targetPlayerMove(random);
            }
            else
            {
                way = MinionActive.제자리;                                                  //아무 움직임 없을때.
                if (NearBy(game.PlayerLocation, 30) == true)
                {
                    game.MinionAttack(5, random);
                    way = MinionActive.공격;
                }
            }

        }
    }
}
