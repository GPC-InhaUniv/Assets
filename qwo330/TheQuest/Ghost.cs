using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    /* 
     * hp 8
     * 데미지 3
     * 1/3 확률로 플레이어쪽 or 제자리
    */
    class Ghost : Enemy 
    {
        public Ghost(Game game, Point location)
            : base(game, location, 8) { }

        public override string Name { get { return "Ghost"; } }

        public override bool Move(Random randomDirection)
        {
            if (!Dead)
            {
                Direction dir;
                if (randomDirection.Next(3) == 0) dir = FindPlayerDirection(game.PlayerLocation);
                else dir = (Direction)10; // 없는 값

                base.location = Move(dir, game.Boundaries);
                if (NearPlayer())
                {
                    game.HitPlayer(3, randomDirection); // randomDirection이 아니라 hitDamage 결정
                    return true;
                }
            }
            return false;
        }
    }
}
