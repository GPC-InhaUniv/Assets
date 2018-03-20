using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0315_TheQuest
{
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location) : base(game, location, 10) { }
        public override void Move(Random random)//히트 포인트가 1이상 남아있을때만 이동해서 공격함. 2/3확률로 플렝이어를향해 이동 1/3확률로 가만히 있음
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if (random.Next(1, 4) != 1)
            {
                location = Move(direction, game.Boundaries);
            }
            if (NearPlayer())
            {
                game.HitPlayer(4, random);
            }
        }
    }
}
