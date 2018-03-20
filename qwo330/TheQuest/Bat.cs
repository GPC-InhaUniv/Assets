using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    /*  
    * hp 6
    * 데미지 2
    * 50% 확률로 플레이어쪽 or 랜덤이동
    */
    class Bat : Enemy
    {
        public Bat(Game game, Point location) 
            :base(game, location, 6) { }

        public override string Name { get { return "Bat"; } }

        public override bool Move(Random randomDirection)
        {
            if (!Dead)
            {
                Direction dir;
                if (randomDirection.Next(2) == 0) dir = FindPlayerDirection(game.PlayerLocation);
                else dir = (Direction)randomDirection.Next(4);

                base.location = Move(dir, game.Boundaries);
                if (NearPlayer())
                {
                    game.HitPlayer(2, randomDirection); // randomDirection이 아니라 hitDamage 결정
                    return true;
                }
            }
            return false;
        }
    }
}
