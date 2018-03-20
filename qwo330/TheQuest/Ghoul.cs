using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    /* 
    * hp 10
    * 데미지 4
    * 2/3 확률로 플레이어쪽 or 제자리
    */
    class Ghoul : Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location, 10) { }

        public override string Name { get { return "Ghoul"; } }

        public override bool Move(Random randomDirection)
        {
            if (!Dead)
            {
                Direction dir;
                if (randomDirection.Next(3) != 0) dir = FindPlayerDirection(game.PlayerLocation);
                else dir = (Direction)10; // 없는 값

                base.location = Move(dir, game.Boundaries);
                if (NearPlayer())
                {
                    game.HitPlayer(4, randomDirection); // randomDirection이 아니라 hitDamage 결정
                    return true;
                }
            }
            return false;
        }
    }
}
