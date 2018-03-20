using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheQuest
{
    class Ghoul : Enemy
    {
        private int attackDamage = 4;
        public Ghoul(Game game, Point location) : base(game, location, 10)
        {

        }

      
        public override void Move(Random random)
        {
            if (base.NearPlayer())
            {
                AttackPlayer(attackDamage,random);
            }
            else
            {
                if (!(random.Next(1, 4) == 1))  //66% 확률로 플레이어에게 이동
                {
                    Direction direction = FindPlayerDirection(game.PlayerLocation);
                    base.location = MoveObject(direction, game.Boundaries);
                }
                else
                {
                    Direction direction = (Direction)random.Next(1, 5);
                    base.location = MoveObject(direction, game.Boundaries);
                }
            }
        }
    }
}
