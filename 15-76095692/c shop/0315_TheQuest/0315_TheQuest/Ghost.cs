using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _0315_TheQuest
{
    class Ghost : Enemy
    {
        public Ghost(Game game, Point location) : base(game, location, 8) { }
        public override void Move(Random random)//1/3의 확률로 플레이어를 향해 움직이고 2/3확률로 제자리에 머무름
        {
            Direction direction = FindPlayerDirection(game.PlayerLocation);
            if (random.Next(1, 4) == 1)
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
